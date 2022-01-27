using k4_kasir.databaseService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace k4_kasir {
  public partial class AddMenu : Form {
    string namaGambar;
    MainPage mainPage = null;
    public AddMenu(MainPage connectForm) {
      InitializeComponent();
      mainPage = connectForm;
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
          Console.WriteLine(copyError.Message);
        }
      }
    }

    private void btnSimpan_Click(object sender, EventArgs e) {
      try {
        BarangService barangService = new BarangService();
        barangService.addBarang(txtNama.Text, Convert.ToInt32(txtHarga.Text), Convert.ToInt32(txtStok.Text), namaGambar, cbKategori.SelectedItem.ToString());

        MessageBox.Show("Berhasil menambahkan barang");
        mainPage.refreshAddEditTab();
        Close();
      } catch (Exception error) {
        MessageBox.Show($"Gagal menambahkan barang {error.Message}");
      }
    }

    private void AddMenu_Show(object sender, EventArgs e) {
      string[] kategMenus = { "Makanan", "Minuman" };

      foreach (string kategoriMenu in kategMenus) {
        cbKategori.Items.Add(kategoriMenu);
      }
    }

    private void btnKembali_click(object sender, EventArgs e) {
      if (namaGambar != null) {
        try {
          string fileDir = Path.Combine(@"images\barang\");
          BarangService barangService = new BarangService();
          fileDir += namaGambar;

          File.Delete(fileDir);
        } catch (Exception error) {
          MessageBox.Show($"Gagal dihapus {error.Message}");
        }
      }

      Close();
    }
  }
}
