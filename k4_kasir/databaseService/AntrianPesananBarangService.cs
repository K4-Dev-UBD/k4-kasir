using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_kasir.databaseService {
  class AntrianPesananBarangService {
    IdGenerator idGenerator = new IdGenerator();
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\k4_kasir.mdf;Integrated Security=True");

    public void addAntrianPesanan(string idAntrian, string idBarang, int jumlahPesanan, string optionalChoice) {
      SqlCommand cmd = new SqlCommand("INSERT INTO AntrianPesananBarang VALUES (@Id_Antrian, @Id_Barang, @Jumlah_Pesanan, @Optional_Choice)");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Id_Antrian", idAntrian);
      cmd.Parameters.AddWithValue("@Id_Barang", idBarang);
      cmd.Parameters.AddWithValue("@Jumlah_Pesanan", jumlahPesanan);
      cmd.Parameters.AddWithValue("@Optional_Choice", optionalChoice);

      con.Open();
      cmd.ExecuteNonQuery();
      con.Close();
    }

    public Dictionary<int, OrderQueue> getAllBarangByIdAntrian(string idAntrian) {
      var dataAntrian = new Dictionary<int, OrderQueue>();

      SqlCommand cmd = new SqlCommand("SELECT Barang.*, AntrianPesananBarang.Jumlah_Pesanan, AntrianPesananBarang.Optional_Choice FROM AntrianPesananBarang INNER JOIN Antrian ON Antrian.Id = AntrianPesananBarang.Id_Antrian INNER JOIN Barang ON Barang.Id = AntrianPesananBarang.Id_Barang WHERE AntrianPesananBarang.Id_Antrian = @Id_Antrian");

      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Id_Antrian", idAntrian);

      con.Open();
      int count = 0;

      using (SqlDataReader reader = cmd.ExecuteReader()) {
        while (reader.Read()) {
          OrderQueue antrian = new OrderQueue();
          antrian.idBarang = reader["Id"].ToString();
          antrian.jumlahBeli = Convert.ToInt32(reader["Jumlah_Pesanan"]);
          antrian.hargaBarang = Convert.ToInt32(reader["Harga"]);
          antrian.namaBarang = reader["Nama"].ToString();
          antrian.kategoriBarang = reader["Kategori"].ToString();
          antrian.optionalChoice = reader["Optional_Choice"].ToString();

          dataAntrian.Add(count, antrian);
          count++;
        }
      }

      cmd.ExecuteNonQuery();
      con.Close();

      return dataAntrian;
    }

    public void deleteByIdAntrian(string idAntrian) {
      SqlCommand cmd = new SqlCommand("DELETE FROM AntrianPesananBarang WHERE Id_Antrian = @Id_Antrian");

      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Id_Antrian", idAntrian);
      con.Open();

      cmd.ExecuteNonQuery();
      con.Close();
    }
  }
}
