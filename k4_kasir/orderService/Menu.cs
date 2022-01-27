using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_kasir.orderService {
  public abstract class Menu {
    public string nama { get; }
    public int harga { get; }
    public string id { get; }
    private int jumlahBeli = 0;

    public Menu(string nama, int harga, string id) {
      this.nama = nama;
      this.harga = harga;
      this.id = id;
    }

    public int getHargaTotal() {
      return jumlahBeli * harga;
    }

    public int getJumlahBeli() {
      return jumlahBeli;
    }

    public void setJumlahBeli(int jumlahBeli) {
      this.jumlahBeli = jumlahBeli;
    }
  }
}
