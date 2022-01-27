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
using k4_kasir.orderService;

namespace k4_kasir {
  public partial class DetailedMenu : Form {
    int orderCount = 0;
    private static bool pedas = false, goreng = false, asin = false, es = false;
    MainPage mainPage = null;

    public DetailedMenu(string namaMenu, MainPage mainPage) {
      InitializeComponent();
      this.mainPage = mainPage;

      try {
        BarangService barangService = new BarangService();
        string destDir = Path.Combine(@"images\barang\");
        var getDataBarang = barangService.getBarangByTitle(namaMenu);

        lblNamaMenu.Text = getDataBarang["Nama"];
        lblHarga.Text = getDataBarang["Harga"];
        lblStok.Text = $"stok: {getDataBarang["Stok"]}";

        destDir += getDataBarang["Gambar"];
        gambarBarang.ImageLocation = destDir;

        if (getDataBarang["Kategori"] != "Makanan") {
          cbAsin.Hide();
          cbGoreng.Hide();
          cbPedas.Hide();
        } else {
          cbEs.Hide();
        }
      } catch (Exception error) {
        MessageBox.Show(error.Message);
      }

      msTxtCount.Text = orderCount.ToString();
    }

    private void btnBatal_click(object sender, EventArgs e) {
      Close();
    }

    private void btnMin_Click(object sender, EventArgs e) {
      if (orderCount > 0) {
        orderCount--;
        msTxtCount.Text = orderCount.ToString();
      }
    }

    private void btnPlus_Click(object sender, EventArgs e) {
      BarangService barangService = new BarangService();
      var getDataBarang = barangService.getBarangByTitle(lblNamaMenu.Text);

      if (orderCount < Convert.ToInt32(getDataBarang["Stok"])) {
        orderCount++;
      }
      
      msTxtCount.Text = orderCount.ToString();
    }

    private void btnSimpan_Click(object sender, EventArgs e) {
      BarangService barangService = new BarangService();
      OrderService orderService = new OrderService();
      PromoMenuService promoMenuService = new PromoMenuService();

      bool[] optionalChoiceForMakanan = { pedas, goreng, asin };
      bool[] optionalChoiceForMinuman = { es };

      var getDataBarang = barangService.getBarangByTitle(lblNamaMenu.Text);
      var getPromoBarang = promoMenuService.getPromoByIdBarang(getDataBarang["Id"]);

      if (getDataBarang["Kategori"] == "Makanan" && Convert.ToInt32(msTxtCount.Text) > 0) {
        orderService.addMakanan(getDataBarang["Nama"], Convert.ToInt32(getDataBarang["Harga"]), Convert.ToInt32(msTxtCount.Text), getPromoBarang, optionalChoiceForMakanan, getDataBarang["Id"]);
      } else if (getDataBarang["Kategori"] == "Minuman" && Convert.ToInt32(msTxtCount.Text) > 0) {
        orderService.addMinuman(getDataBarang["Nama"], Convert.ToInt32(getDataBarang["Harga"]), Convert.ToInt32(msTxtCount.Text), getPromoBarang, optionalChoiceForMinuman, getDataBarang["Id"]);
      }

      mainPage.refreshOrderCountLabel();
      Close();
    }

    private void msTxtCount_TextChanged(object sender, EventArgs e) {
      changedMsTxtCount();
    }

    private void changedMsTxtCount() {
      BarangService barangService = new BarangService();
      var getDataBarang = barangService.getBarangByTitle(lblNamaMenu.Text);

      if (orderCount < Convert.ToInt32(getDataBarang["Stok"])) {
        orderCount = Convert.ToInt32(msTxtCount.Text);
      } else {
        orderCount = Convert.ToInt32(getDataBarang["Stok"]);
      }
    }

    private void cbPedas_checkedChanged(object sender, EventArgs e) {
      setFalseOptionalChoice();
      pedas = cbPedas.Checked;
    }

    private void cbGoreng_checkedChanged(object sender, EventArgs e) {
      setFalseOptionalChoice();
      goreng = cbGoreng.Checked;
    }

    private void cbAsin_checkedChanged(object sender, EventArgs e) {
      setFalseOptionalChoice();
      asin = cbAsin.Checked;
    }

    private void cbEs_checkedChanged(object sender, EventArgs e) {
      setFalseOptionalChoice();
      es = cbEs.Checked;
    }

    private void setFalseOptionalChoice() {
      pedas = false;
      goreng = false;
      asin = false;
      es = false;
    }
  }
}
