using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace BazyDanych
{
    class Connection
    {
        public static string MyConnectionString = "Server=localhost;Database=magazyn;port=3306;Uid=root;Pwd=bazydanych;SslMode=none";

        public DataSet LoadData(string query)
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception)
            {
                throw;
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Clone();
            }
        }

        public void InsertListwa(string symbol, string material, string kolor, bool ornament, string okleina, float kosztMb)
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO listwa(symbol,material,kolor,ornament,okleina,kosztMb)VALUES(@symbol,@material,@kolor,@ornament,@okleina,@kosztMb)";
                cmd.Parameters.AddWithValue("@symbol", symbol);
                cmd.Parameters.AddWithValue("@material", material);
                cmd.Parameters.AddWithValue("@kolor", kolor);
                cmd.Parameters.AddWithValue("@ornament", ornament);
                cmd.Parameters.AddWithValue("@okleina", okleina);
                cmd.Parameters.AddWithValue("@kosztMb", kosztMb);
                //cmd.Parameters.AddWithValue("@ornament");
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Clone();
                }

            }
        }
    }
}

