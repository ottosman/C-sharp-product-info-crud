using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }
        public void namekeeper()
        {
      

        }
        private void button_new_add_Click(object sender, EventArgs e)
        {
            try
            {
                string MySQLConnectionString = //database info
                MySqlConnection conn = new MySqlConnection(MySQLConnectionString);
                conn.Open();
                string checkif = "INSERT INTO musteri (cariadi,vno,vergidairesi,adres,telefon,sehir) VALUES (@cariadi,@vno,@vergidairesi,@adres,@telefon,@sehir)";
                MySqlCommand command = new MySqlCommand(checkif, conn);
                command.Parameters.AddWithValue("@cariadi", textBox_cariadi.Text);
                command.Parameters.AddWithValue("@vno", textBox_vno.Text);
                command.Parameters.AddWithValue("@vergidairesi", textBox_vergidairesi.Text);
                command.Parameters.AddWithValue("@adres", textBox_adres.Text);
                command.Parameters.AddWithValue("@telefon", textBox_telefon.Text);
                command.Parameters.AddWithValue("@sehir", textBox_sehir.Text);
                command.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             
               
            }


            
        }

        
    }
}
