using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_kasir.databaseService {
  class RiwayatPesananService {
    IdGenerator idGenerator = new IdGenerator();
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\k4_kasir.mdf;Integrated Security=True");

    public string add(string idAntrian, int total, string waktuBeli, int nomorAntrian, int statusPesanan) {
      SqlCommand cmd = new SqlCommand("INSERT INTO RiwayatTransaksi VALUES (@Id, @Id_Antrian, @Waktu_Beli, @Nomor_Antrian, @Status_Pesanan, @Total)");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      string id = idGenerator.generate();

      cmd.Parameters.AddWithValue("@Id", id);
      cmd.Parameters.AddWithValue("@Id_Antrian", idAntrian);
      cmd.Parameters.AddWithValue("@Waktu_Beli", waktuBeli);
      cmd.Parameters.AddWithValue("@Nomor_Antrian", nomorAntrian);
      cmd.Parameters.AddWithValue("@Status_Pesanan", statusPesanan);
      cmd.Parameters.AddWithValue("@Total", total);

      con.Open();
      cmd.ExecuteNonQuery();
      con.Close();

      return id;
    }

    public Dictionary<int, RiwayatTransaksi> getAll() {
      var dataBarang = new Dictionary<int, RiwayatTransaksi>();

      SqlCommand cmd = new SqlCommand("SELECT * FROM RiwayatTransaksi");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      con.Open();
      int count = 0;

      using (SqlDataReader reader = cmd.ExecuteReader()) {
        while (reader.Read()) {
          RiwayatTransaksi riwayatTransaksi = new RiwayatTransaksi();
          riwayatTransaksi.id = reader["Id"].ToString();
          riwayatTransaksi.idAntrian = reader["Id_Antrian"].ToString();
          riwayatTransaksi.waktuBeli = reader["Waktu_Beli"].ToString();
          riwayatTransaksi.nomorAntrian = reader["Nomor_Antrian"].ToString();
          riwayatTransaksi.statusPesanan = Convert.ToInt32(reader["Status_Pesanan"]);
          riwayatTransaksi.total = Convert.ToInt32(reader["Total"]);

          dataBarang.Add(count, riwayatTransaksi);
          count++;
        }
      }

      cmd.ExecuteNonQuery();
      con.Close();

      return dataBarang;
    }
  }
}
