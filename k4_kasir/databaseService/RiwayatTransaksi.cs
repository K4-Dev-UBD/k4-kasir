using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_kasir.databaseService {
  class RiwayatTransaksi {
    public string id { get; set; }
    public string idAntrian { get; set; }
    public int total { get; set; }
    public string waktuBeli { get; set; }
    public string nomorAntrian { get; set; }
    public int statusPesanan { get; set; }
  }
}
