using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_kasir.databaseService {
  class BarangService {
    IdGenerator idGenerator = new IdGenerator();
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\k4_kasir.mdf;Integrated Security=True");

    public void addBarang(string nama, double harga, int stok, string gambar, string kategori) {
      string createdAt = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss");

      SqlCommand cmd = new SqlCommand("INSERT INTO Barang VALUES (@Id, @Nama, @Harga, @Stok, @Gambar, @Kategori, @Created_At, @Edited_At)");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Id", idGenerator.generate());
      cmd.Parameters.AddWithValue("@Nama", nama);
      cmd.Parameters.AddWithValue("@Harga", harga);
      cmd.Parameters.AddWithValue("@Stok", stok);
      cmd.Parameters.AddWithValue("@Gambar", gambar);
      cmd.Parameters.AddWithValue("@Kategori", kategori);
      cmd.Parameters.AddWithValue("@Created_At", createdAt);
      cmd.Parameters.AddWithValue("@Edited_At", createdAt);

      con.Open();
      cmd.ExecuteNonQuery();
      con.Close();
    }

    public Dictionary<string, string> getBarangByTitle(string namaBarang) {
      var dataBarang = new Dictionary<string, string>();
       
      SqlCommand cmd = new SqlCommand("SELECT * FROM Barang WHERE Nama = @Nama");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Nama", namaBarang);

      con.Open();

      using (SqlDataReader reader = cmd.ExecuteReader()) {
        while (reader.Read()) {
          dataBarang.Add("Id", reader["Id"].ToString());
          dataBarang.Add("Nama", reader["Nama"].ToString());
          dataBarang.Add("Harga", reader["Harga"].ToString());
          dataBarang.Add("Stok", reader["Stok"].ToString());
          dataBarang.Add("Gambar", reader["Gambar"].ToString());
          dataBarang.Add("Kategori", reader["Kategori"].ToString());
        }
      }

      cmd.ExecuteNonQuery();
      con.Close();

      return dataBarang;
    }

    public Dictionary<string, string> getBarangById(string id) {
      var dataBarang = new Dictionary<string, string>();

      SqlCommand cmd = new SqlCommand("SELECT * FROM Barang WHERE Id = @Id");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Id", id);

      con.Open();

      using (SqlDataReader reader = cmd.ExecuteReader()) {
        while (reader.Read()) {
          dataBarang.Add("Id", reader["Id"].ToString());
          dataBarang.Add("Nama", reader["Nama"].ToString());
          dataBarang.Add("Harga", reader["Harga"].ToString());
          dataBarang.Add("Stok", reader["Stok"].ToString());
          dataBarang.Add("Gambar", reader["Gambar"].ToString());
          dataBarang.Add("Kategori", reader["Kategori"].ToString());
        }
      }

      cmd.ExecuteNonQuery();
      con.Close();

      return dataBarang;
    }

    public Dictionary<int, string> getNamaBarangByKategori(string kategori) {
      var dataBarang = new Dictionary<int, string>();

      SqlCommand cmd = new SqlCommand("SELECT * FROM Barang WHERE Kategori = @Kategori");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Kategori", kategori);

      con.Open();
      int count = 0;
      using (SqlDataReader reader = cmd.ExecuteReader()) {
        while (reader.Read()) {
          dataBarang.Add(count, reader["Nama"].ToString());
          count++;
        }
      }

      cmd.ExecuteNonQuery();
      con.Close();

      return dataBarang;
    }

    public void editBarangByNama(string nama, string[] dataForEdited) {
      string editedAt = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss");

      SqlCommand cmd = new SqlCommand("UPDATE Barang SET Harga = @Harga, Stok = @Stok, Gambar = @Gambar, Kategori = @Kategori, Edited_At = @Edited_At WHERE Nama = @Nama");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Nama", nama);
      cmd.Parameters.AddWithValue("@Harga", Convert.ToInt32(dataForEdited[0]));
      cmd.Parameters.AddWithValue("@Stok", Convert.ToInt32(dataForEdited[1]));
      cmd.Parameters.AddWithValue("@Kategori", dataForEdited[2]);
      cmd.Parameters.AddWithValue("@Gambar", dataForEdited[3]);
      cmd.Parameters.AddWithValue("@Edited_At", editedAt);

      con.Open();
      cmd.ExecuteNonQuery();
      con.Close();
    }

    public void editStokBarangById(string id, int stok) {
      string editedAt = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss");

      SqlCommand cmd = new SqlCommand("UPDATE Barang SET Stok = @Stok WHERE Id = @Id");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Id", id);
      cmd.Parameters.AddWithValue("@Stok", stok);

      con.Open();
      cmd.ExecuteNonQuery();
      con.Close();
    }

    public void deleteBarangByNama(string nama) {
      SqlCommand cmd = new SqlCommand("DELETE FROM Barang WHERE Nama = @Nama");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Nama", nama);

      con.Open();
      cmd.ExecuteNonQuery();
      con.Close();
    }
  }
}
