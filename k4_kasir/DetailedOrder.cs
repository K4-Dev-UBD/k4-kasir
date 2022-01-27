using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using k4_kasir.databaseService;

namespace k4_kasir {
  public partial class DetailedOrder : Form {
    string idAntrian;
    MainPage mainPage = null;
    public DetailedOrder(string idAntrian, MainPage mainPage) {
      InitializeComponent();
      this.idAntrian = idAntrian;
      this.mainPage = mainPage;
    }

    private void btnKembali_click(object sender, EventArgs e) {
      Close();
    }

    private void btnSelesai_Click(object sender, EventArgs e) {
      AntrianService antrianService = new AntrianService();
      RiwayatPesananService riwayatPesananService = new RiwayatPesananService();
      AntrianPesananBarangService antrianPesananBarangService = new AntrianPesananBarangService();

      int totalBiayaTransaksi = 0;

      foreach (var antrianPesanan in antrianPesananBarangService.getAllBarangByIdAntrian(idAntrian)) {
        totalBiayaTransaksi += (antrianPesanan.Value.jumlahBeli * antrianPesanan.Value.hargaBarang);
      }

      antrianService.editStatusById(idAntrian, 1);
      var dataAntrian = antrianService.getAntrianById(idAntrian);

      riwayatPesananService.add(dataAntrian["Id"], totalBiayaTransaksi, dataAntrian["Created_At"], Convert.ToInt32(dataAntrian["Nomor"]), Convert.ToInt32(dataAntrian["Status"]));

      mainPage.refreshAntrianTab();
      Close();
    }

    private void btnBatal_Click(object sender, EventArgs e) {
      DialogResult result = MessageBox.Show("Apakah anda yakin ingin membatalkan pesanan?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

      if (result == DialogResult.OK) {
        AntrianService antrianService = new AntrianService();
        AntrianPesananBarangService antrianPesananBarangService = new AntrianPesananBarangService();
        RiwayatPesananService riwayatPesananService = new RiwayatPesananService();
        BarangService barangService = new BarangService();

        int totalBiayaTransaksi = 0;

        foreach (var antrianPesanan in antrianPesananBarangService.getAllBarangByIdAntrian(idAntrian)) {
          totalBiayaTransaksi += (antrianPesanan.Value.jumlahBeli * antrianPesanan.Value.hargaBarang);
        }

        antrianService.editStatusById(idAntrian, 2);

        var dataAntrian = antrianService.getAntrianById(idAntrian);
        riwayatPesananService.add(dataAntrian["Id"], totalBiayaTransaksi, dataAntrian["Created_At"], Convert.ToInt32(dataAntrian["Nomor"]), Convert.ToInt32(dataAntrian["Status"]));

        foreach (var antrianPesanan in antrianPesananBarangService.getAllBarangByIdAntrian(idAntrian)) {
          barangService.editStokBarangById(antrianPesanan.Value.idBarang, Convert.ToInt32(barangService.getBarangById(antrianPesanan.Value.idBarang)["Stok"]) + antrianPesanan.Value.jumlahBeli);
        }

        mainPage.refreshAntrianTab();

        Close();
      }
    }

    private void detailedOrder_shown(object sender, EventArgs e) {
      listViewPesanan.Items.Clear();
      AntrianPesananBarangService antrianPesananBarangService = new AntrianPesananBarangService();

      foreach (var antrianPesanan in antrianPesananBarangService.getAllBarangByIdAntrian(idAntrian)) {
        var listView = listViewPesanan.Items.Add(antrianPesanan.Value.jumlahBeli.ToString());
        listView.SubItems.Add($"{antrianPesanan.Value.namaBarang}; {antrianPesanan.Value.optionalChoice}");
        listView.SubItems.Add(antrianPesanan.Value.kategoriBarang);
      }
    }
  }
}
