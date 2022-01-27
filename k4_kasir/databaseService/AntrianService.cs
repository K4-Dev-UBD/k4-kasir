using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k4_kasir.databaseService;

namespace k4_kasir.databaseService {
  class AntrianService {
    IdGenerator idGenerator = new IdGenerator();
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\k4_kasir.mdf;Integrated Security=True");

    public string addAntrian(int nomor, int status = 0) {
      string createdAt = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss");
      SqlCommand cmd = new SqlCommand("INSERT INTO Antrian VALUES (@Id, @Nomor, @Status, @Created_At)");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      string id = idGenerator.generate();

      cmd.Parameters.AddWithValue("@Id", id);
      cmd.Parameters.AddWithValue("@Nomor", nomor);
      cmd.Parameters.AddWithValue("@Status", status);
      cmd.Parameters.AddWithValue("@Created_At", createdAt);

      con.Open();
      cmd.ExecuteNonQuery();
      con.Close();

      return id;
    }

    public Dictionary<int, Queue> getAllAntrian() {
      var dataAntrian = new Dictionary<int, Queue>();

      SqlCommand cmd = new SqlCommand("SELECT * FROM Antrian");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      con.Open();
      int count = 0;
      using (SqlDataReader reader = cmd.ExecuteReader()) {
        while (reader.Read()) {
          Queue antrian = new Queue();
          antrian.id = reader["Id"].ToString();
          antrian.nomor = Convert.ToInt32(reader["Nomor"]);
          antrian.status = Convert.ToInt32(reader["Status"]);
          antrian.createdAt = reader["Created_At"].ToString();

          dataAntrian.Add(count, antrian);
          count++;
        }
      }

      cmd.ExecuteNonQuery();
      con.Close();

      return dataAntrian;
    }

    public Dictionary<string, string> getAntrianById(string id) {
      var dataAntrian = new Dictionary<string, string>();

      SqlCommand cmd = new SqlCommand("SELECT * FROM Antrian WHERE Id = @Id");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Id", id);

      con.Open();
      using (SqlDataReader reader = cmd.ExecuteReader()) {
        while (reader.Read()) {
          dataAntrian.Add("Id", reader["Id"].ToString());
          dataAntrian.Add("Nomor", reader["Nomor"].ToString());
          dataAntrian.Add("Status", reader["Status"].ToString());
          dataAntrian.Add("Created_At", reader["Created_At"].ToString());
        }
      }

      cmd.ExecuteNonQuery();
      con.Close();

      return dataAntrian;
    }

    public void editStatusById(string id, int status) {
      SqlCommand cmd = new SqlCommand("UPDATE Antrian SET Status = @Status WHERE Id = @Id");
      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Id", id);
      cmd.Parameters.AddWithValue("@Status", status);

      con.Open();
      cmd.ExecuteNonQuery();
      con.Close();
    }

    public void deleteById(string id) {
      SqlCommand cmd = new SqlCommand("DELETE FROM Antrian WHERE Id = @Id_Antrian");

      cmd.CommandType = CommandType.Text;
      cmd.Connection = con;

      cmd.Parameters.AddWithValue("@Id_Antrian", id);
      con.Open();

      cmd.ExecuteNonQuery();
      con.Close();
    }
  }
}
