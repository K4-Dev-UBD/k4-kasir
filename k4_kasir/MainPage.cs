using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using k4_kasir.databaseService;
using k4_kasir.orderService;

namespace k4_kasir {
  public partial class MainPage : Form {
    public MainPage() {
      Thread t = new Thread(new ThreadStart(Loading));
      t.Start();
      InitializeComponent();
      Thread.Sleep(TimeSpan.FromSeconds(2));
      t.Abort();
    }

    void Loading() {
      SplashForm ss = new SplashForm();
      Application.Run(ss);
    }

    private void listMakanan_selected(object sender, EventArgs e) {
      string listName = listMakanan.SelectedItem.ToString();

      DetailedMenu dm = new DetailedMenu(listName, this);
      dm.Show();
    }

    private void listMinuman_selected(object sender, EventArgs e) {
      string listName = listMinuman.SelectedItem.ToString();

      DetailedMenu dm = new DetailedMenu(listName, this);
      dm.Show();
    }

    private void btnKonfirmasi_click(object sender, EventArgs e) {
      ConfirmPayment cp = new ConfirmPayment(this);
      cp.Show();
    }

    private void listEditMakanan_selected(object sender, EventArgs e) {
      string listName = listEditMakanan.SelectedItem.ToString();
      EditMenu em = new EditMenu(listName, this);
      em.Show();
    }

    private void listEditMinuman_selected(object sender, EventArgs e) {
      string listName = listEditMinuman.SelectedItem.ToString();
      EditMenu em = new EditMenu(listName, this);
      em.Show();
    }

    private void trolleyIcon_click(object sender, EventArgs e) {
      ConfirmPayment cp = new ConfirmPayment(this);
      cp.Show();
    }

    private void btnTambahMenu_click(object sender, EventArgs e) {
      AddMenu am = new AddMenu(this);
      am.Show();
    }

    private void mainPage_Shown(object sender, EventArgs e) {
      refreshMainPageTab();
      refreshOrderCountLabel();
    }

    public void refreshMainPageTab() {
      mainTabControl.Focus();
      listMakanan.Items.Clear();
      listMinuman.Items.Clear();

      try {
        BarangService barangService = new BarangService();

        var getListMakanan = barangService.getNamaBarangByKategori("Makanan");
        var getListMinuman = barangService.getNamaBarangByKategori("Minuman");

        foreach (var namaBarang in getListMakanan) {
          listMakanan.Items.Add(namaBarang.Value);
        }

        foreach (var namaBarang in getListMinuman) {
          listMinuman.Items.Add(namaBarang.Value);
        }
      } catch (Exception error) {
        MessageBox.Show(error.Message);
      }
    }

    public void refreshOrderCountLabel() {
      OrderService orderService = new OrderService();
      int orderCount = (orderService.getOrderListMakanan().Count + orderService.getOrderListMinuman().Count);
      
      lblOrderCount.Text = orderCount.ToString();
    }

    private void btnClose_Click(object sender, EventArgs e) {
      DialogResult result = MessageBox.Show("Apakah anda yakin ingin menutup aplikasi?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

      if (result == DialogResult.OK) {
        Close();
      }
    }

    private void btnMinimzed_Click(object sender, EventArgs e) {
      WindowState = FormWindowState.Minimized;
    }

    private void btnSegarkan_Click(object sender, EventArgs e) { 
      refreshMainPageTab();
      refreshOrderCountLabel();
    }

    private void mainTab_Enter(object sender, EventArgs e) {
      refreshOrderCountLabel();
      try {
        BarangService barangService = new BarangService();

        var getListMakanan = barangService.getNamaBarangByKategori("Makanan");
        var getListMinuman = barangService.getNamaBarangByKategori("Minuman");

        listMakanan.Items.Clear();
        listMinuman.Items.Clear();

        foreach (var namaBarang in getListMakanan) {
          listMakanan.Items.Add(namaBarang.Value);
        }

        foreach (var namaBarang in getListMinuman) {
          listMinuman.Items.Add(namaBarang.Value);
        }
      } catch (Exception error) {
        MessageBox.Show(error.Message);
      }
    }

    private void addEditTab_Enter(object sender, EventArgs e) {
      refreshAddEditTab();
    }

    public void refreshAddEditTab() {
      try {
        BarangService barangService = new BarangService();

        var getListMakanan = barangService.getNamaBarangByKategori("Makanan");
        var getListMinuman = barangService.getNamaBarangByKategori("Minuman");

        listEditMakanan.Items.Clear();
        listEditMinuman.Items.Clear();

        foreach (var namaBarang in getListMakanan) {
          listEditMakanan.Items.Add(namaBarang.Value);
        }

        foreach (var namaBarang in getListMinuman) {
          listEditMinuman.Items.Add(namaBarang.Value);
        }
      } catch (Exception error) {
        MessageBox.Show(error.Message);
      }
    }

    private void listViewAntrian_doubleClick(object sender, EventArgs e) {
      DetailedOrder dor = new DetailedOrder(listViewAntrian.SelectedItems[0].Text, this);
      dor.Show();
    }

    private void btnAturUlang_Click(object sender, EventArgs e) {
      OrderService orderService = new OrderService();
      orderService.clearAll();
      refreshOrderCountLabel();
    }

    private void antrianTab_enter(object sender, EventArgs e) {
      refreshAntrianTab();
    }

    public void refreshAntrianTab() {
      listViewAntrian.Items.Clear();
      AntrianService antrianService = new AntrianService();
      AntrianPesananBarangService antrianPesananBarangService = new AntrianPesananBarangService();

      foreach (var antrian in antrianService.getAllAntrian()) {
        if (antrian.Value.status == 0) {
          int jumlahPesanan = antrianPesananBarangService.getAllBarangByIdAntrian(antrian.Value.id).Count;

          var listAntrian = listViewAntrian.Items.Add(antrian.Value.id);
          listAntrian.SubItems.Add(antrian.Value.nomor.ToString());
          listAntrian.SubItems.Add(jumlahPesanan.ToString());
          listAntrian.SubItems.Add(antrian.Value.createdAt);
          listAntrian.SubItems.Add("Proses");
        }
      }
    }

    private void listViewRiwayatTransaksi_enter(object sender, EventArgs e) {
      listViewRiwayatTransaksi.Items.Clear();
      RiwayatPesananService riwayatPesananService = new RiwayatPesananService();

      foreach (var riwayatPesanan in riwayatPesananService.getAll()) {
        var listRiwayatPesanan = listViewRiwayatTransaksi.Items.Add(riwayatPesanan.Value.id);
        listRiwayatPesanan.SubItems.Add(riwayatPesanan.Value.total.ToString("#,###"));
        listRiwayatPesanan.SubItems.Add(riwayatPesanan.Value.waktuBeli);
        listRiwayatPesanan.SubItems.Add(riwayatPesanan.Value.idAntrian);
        listRiwayatPesanan.SubItems.Add(riwayatPesanan.Value.statusPesanan == 1 ? "Berhasil" : "Dibatalkan");
      }
    }
  }
}
