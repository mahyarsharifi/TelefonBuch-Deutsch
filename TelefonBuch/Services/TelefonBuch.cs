using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonBuch
{
    class TelefonBuch : ITelefonBuchRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=TelefonBuch_DB;Integrated Security=true";
        public bool Delete(int kontaktId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete From Kontakt where KontaktID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", kontaktId);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insert(string name, string familie, string handynummer, string email, int age, string anschrift)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert Into Kontakt (Name,Familie,HandyNummer,Email,Age,Anschrift) values (@Name,@Familie,@HandyNummer,@Email,@Age,@Anschrift)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Familie", familie);
                command.Parameters.AddWithValue("@HandyNummer", handynummer);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Anschrift", anschrift);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public DataTable Search(string parameter)
        {
            string query = "Select * From Kontakt where Name like @parameter or Familie like @parameter";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable SelectAll()
        {
            string query = "Select * From Kontakt";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable SelectRow(int kontaktId)
        {
            string query = "Select * From Kontakt where kontaktID=" + kontaktId;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        public bool Update(int kontaktId, string name, string familie, string handynummer, string email, int age, string anschrift)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update Kontakt Set Name=@Name,Familie=@Familie,HandyNummer=@HandyNummer,Email=@Email,Age=@Age,Anschrift=@Anschrift where KontaktID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", kontaktId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Familie", familie);
                command.Parameters.AddWithValue("@HandyNummer", handynummer);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Anschrift", anschrift);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
