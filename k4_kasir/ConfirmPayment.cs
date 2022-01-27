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
  public partial class ConfirmPayment : Form {
    MainPage mainPage = null;
    public ConfirmPayment(MainPage connectForm) {
      InitializeComponent();
      mainPage = connectForm;
    }

    private void btnBatal_click(object sender, EventArgs e) {
      Close();
    }

    private void btnLanjutKePembayaran_click(object sender, EventArgs e) {
      OrderService orderService = new OrderService();
      var getOrderListMakanan = orderService.getOrderListMakanan();
      var getOrderListMinuman = orderService.getOrderListMinuman();

      if (getOrderListMakanan.Count > 0 || getOrderListMinuman.Count > 0) {
        PaymentSession ps = new PaymentSession(this, mainPage);
        ps.Show();
      } else {
        MessageBox.Show("Silahkan memilih menu terlebih dahulu ...");
        btnLanjut.Cursor = Cursors.No;
      }
    }

    private void listViewPesanan_enter(object sender, EventArgs e) {
      OrderService orderService = new OrderService();
      var getOrderListMakanan = orderService.getOrderListMakanan();
      var getOrderListMinuman = orderService.getOrderListMinuman();

      foreach (var order in getOrderListMakanan) {
        string useFried = order.Value.getFried() == true ? "Goreng" : "";
        string useSpicy = order.Value.getSpicy() == true ? "Pedas" : "";
        string useSalty = order.Value.getSalty() == true ? "Asin" : "";

        var orderList = listViewPesanan.Items.Add(order.Value.getJumlahBeli().ToString());
        orderList.SubItems.Add($"{order.Value.nama}; {useSpicy} {useFried} {useSalty}");
        orderList.SubItems.Add(order.Value.getHargaTotal().ToString("#,###"));
      }

      foreach (var order in getOrderListMinuman) {
        string useIce = order.Value.getUseIce() == true ? "es" : "";

        var orderList = listViewPesanan.Items.Add(order.Value.getJumlahBeli().ToString());
        orderList.SubItems.Add($"{order.Value.nama}; {useIce}");
        orderList.SubItems.Add(order.Value.getHargaTotal().ToString("#,###"));
      }

      txtSubtotal.Text = orderService.getSubTotalPriceOfOrders().ToString("#,###");
      txtPotonganHarga.Text = $"- {orderService.getPromo().ToString("#,###")}";
      txtTotalHarga.Text = orderService.getTotalPriceOfOrders().ToString("#,###");
    }
  }
}
