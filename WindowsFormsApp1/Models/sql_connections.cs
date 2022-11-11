using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;


namespace WindowsFormsApp1.Models
{
    internal class sql_connections
    {
   
        public void baglanti_temelleri()
        {

            string MySQLConnectionString = "datasource=93.89.225.112; port=3306; username=pehozgun_admina; password=Admin5050; database=pehozgun_verita;";
            MySqlConnection conn = new MySqlConnection(MySQLConnectionString);
            conn.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM dbo.market4", conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            
            
            


        }
    }
}
