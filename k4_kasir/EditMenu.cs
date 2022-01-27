using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using k4_kasir.databaseService;

namespace k4_kasir {
  public partial class EditMenu : Form {
    private string namaGambar;
    private string namaBarang;
    MainPage mainPage = null;
    public EditMenu(string namaBarang, MainPage connectForm) {
      InitializeComponent();
      this.namaBarang = namaBarang;
      mainPage = connectForm;

      try {
        BarangService barangService = new BarangService();
        string destDir = Path.Combine(@"images\barang\");
        var getDataBarang = barangService.getBarangByTitle(namaBarang);

        txtNama.Text = getDataBarang["Nama"];
        txtHarga.Text = getDataBarang["Harga"];
        txtStok.Text = getDataBarang["Stok"];
        cbKategori.Text = getDataBarang["Kategori"];

        destDir += getDataBarang["Gambar"];
        gambarBarang.ImageLocation = destDir;
        namaGambar = getDataBarang["Gambar"];
      } catch (Exception error) {
        MessageBox.Show($"Gagal menampilkan data {error.Message}");
      }
    }

    private void btnHapus_Click(object sender, EventArgs e) {
      DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapusnya?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

      if (result == DialogResult.OK) {
        try {
          string fileDir = Path.Combine(@"images\barang\");
          BarangService barangService = new BarangService();
          fileDir += barangService.getBarangByTitle(namaBarang)["Gambar"];

          File.Delete(fileDir);
          barangService.deleteBarangByNama(namaBarang);

          MessageBox.Show("Berhasil dihapus");

          mainPage.refreshAddEditTab();
          Close();
        } catch (Exception error) {
          MessageBox.Show($"Gagal dihapus {error.Message}");
        }
      }
    }

    private void btnSimpan_Click(object sender, EventArgs e) {
      try {
        BarangService barangService = new BarangService();
        string kategoriMenu = cbKategori.SelectedItem.ToString();

        string[] dataForEdited = { txtHarga.Text, txtStok.Text, kategoriMenu, namaGambar };
        barangService.editBarangByNama(txtNama.Text, dataForEdited);

        MessageBox.Show("Berhasil Diubah!");
        mainPage.refreshAddEditTab();
        Close();
      } catch (Exception error) {
        try {
          BarangService barangService = new BarangService();
          string kategoriMenu = cbKategori.Text;

          string[] dataForEdited = { txtHarga.Text, txtStok.Text, kategoriMenu, namaGambar };
          barangService.editBarangByNama(txtNama.Text, dataForEdited);

          MessageBox.Show("Berhasil Diubah!");
          mainPage.refreshAddEditTab();
          Close();
        } catch {
          MessageBox.Show($"Gagal diubah {error.Message}");
        }
      }
    }

    private void EditMenu_shown(object sender, EventArgs e) {
      string[] kategMenus = { "Makanan", "Minuman" };

      foreach (string kategoriMenu in kategMenus) {
        cbKategori.Items.Add(kategoriMenu);
      }
    }

    private void btnAturGambar_Click(object sender, EventArgs e) {
      OpenFileDialog open = new OpenFileDialog();
      open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";

      if (open.ShowDialog() == DialogResult.OK) {
        try {
          Random rnd = new Random();
          string num = rnd.Next().ToString();
          string destDir = Path.Combine(@"images\barang\");

          if (!Directory.Exists(destDir))
            Directory.CreateDirectory(destDir);

          var fileName = Path.GetFileName(open.FileName);
          string namaGambarHash = $"{num}-{fileName}";

          destDir += namaGambarHash;
          File.Copy(open.FileName, destDir, true);

          gambarBarang.ImageLocation = destDir;
          namaGambar = namaGambarHash;
        } catch (IOException copyError) {
          Console.WriteLine($"Gagal upload gambar {copyError.Message}");
        }
      }
    }

    private void btnKembali_click(object sender, EventArgs e) {
      Close();
    }
  }
}
