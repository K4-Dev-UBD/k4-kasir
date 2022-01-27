using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using k4_kasir.orderService;
using k4_kasir.databaseService;

namespace k4_kasir {
  public partial class PaymentSession : Form {
    private static int uangPembayaran = 0;
    ConfirmPayment mainForm = null;
    MainPage mainPage = null;
    public PaymentSession(ConfirmPayment connectForm1, MainPage connectForm2) {
      InitializeComponent();
      mainForm = connectForm1;
      mainPage = connectForm2;
    }

    private void btnBatal_click(object sender, EventArgs e) {
      Close();
    }

    private void btnBayar_Click(object sender, EventArgs e) {
      OrderService orderService = new OrderService();
      QueueService queueService = new QueueService();
      BarangService barangService = new BarangService();

      uangPembayaran = Convert.ToInt32(msTxtMasukkanUang.Text);
      if (uangPembayaran < orderService.getTotalPriceOfOrders())
        lblNotif.Text = $"Uang anda kurang - {(orderService.getTotalPriceOfOrders() - uangPembayaran).ToString("#,###")}";
      else {
        MessageBox.Show($"Terima kasih telah melakukan pembayaran, Kembalian {(uangPembayaran - orderService.getTotalPriceOfOrders()).ToString("#,###")}");

        var getOrderListMakanan = orderService.getOrderListMakanan();
        var getOrderListMinuman = orderService.getOrderListMinuman();

        foreach (var makanan in getOrderListMakanan) {
          barangService.editStokBarangById(makanan.Value.id, (Convert.ToInt32(barangService.getBarangById(makanan.Value.id)["Stok"]) - makanan.Value.getJumlahBeli()));
        }

        foreach (var minuman in getOrderListMinuman) {
          barangService.editStokBarangById(minuman.Value.id, (Convert.ToInt32(barangService.getBarangById(minuman.Value.id)["Stok"]) - minuman.Value.getJumlahBeli()));
        }

        queueService.addMakanan(getOrderListMakanan);
        queueService.addMinuman(getOrderListMinuman);
        queueService.add();

        Close();
        mainForm.Close();
        mainPage.refreshAntrianTab();
        mainPage.refreshMainPageTab();
        orderService.clearAll();
        mainPage.refreshOrderCountLabel();
      }
    }

    private void msTxtMasukkanUang_textChanged(object sender, EventArgs e) {
      OrderService orderService = new OrderService();

      uangPembayaran = Convert.ToInt32(msTxtMasukkanUang.Text);
      if (uangPembayaran < orderService.getTotalPriceOfOrders())
        lblNotif.Text = $"Uang anda kurang - {(orderService.getTotalPriceOfOrders() - uangPembayaran).ToString("#,###")}";
      else
        lblNotif.Hide();
    }
  }
}
