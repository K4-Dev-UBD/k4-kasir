using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_kasir.databaseService {
  class OrderQueue : Queue {
    public string idBarang { get; set; }
    public int jumlahBeli { get; set; }
    public string namaBarang { get; set; }
    public string gambarBarang { get; set; }
    public int hargaBarang { get; set; }
    public int stokBarang { get; set; }
    public string kategoriBarang { get; set; }
    public string optionalChoice { get; set; }
  }
}
