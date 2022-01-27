using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_kasir.databaseService {
  class PromoMenuService {
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\k4_kasir.mdf;Integrated Security=True");
    public void addPromoToBarang(string idBarang, int promo = 0) {
      SqlCommand cmd = new SqlCommand("INSERT INTO PromoMenu VALUES (@Id_Barang, @Promo)");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Id_Barang", idBarang);
      cmd.Parameters.AddWithValue("@Promo", promo);

      con.Open();
      cmd.ExecuteNonQuery();
      con.Close();
    }

    public int getPromoByIdBarang(string idBarang) {
      int jumlahPromo = 0;

      try {
        SqlCommand cmd = new SqlCommand("SELECT * FROM PromoMenu WHERE Id_Barang = @Id_Barang");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@Id_Barang", idBarang);

        con.Open();
        using (SqlDataReader reader = cmd.ExecuteReader()) {
          while (reader.Read()) {
            jumlahPromo = Convert.ToInt32(reader["Promo"]);
          }
        }

        cmd.ExecuteNonQuery();
        con.Close();
      } catch {
        jumlahPromo = 0;
      }

      return jumlahPromo;
    }
  }
}
