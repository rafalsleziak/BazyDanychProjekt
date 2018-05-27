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
        
        public DataSet LoadData()
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM klient";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
            }
            catch(Exception)
            {
                throw;
            }

            if(connection.State==ConnectionState.Open)
            {
                connection.Clone();
            }
        }
    }
}
