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
    public partial class Form3 : Form
    {
        Form1 f1;


        public Form3()
        {
            InitializeComponent();
            
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            string MySQLConnectionString = //database info
            MySqlConnection conn = new MySqlConnection(MySQLConnectionString);
            /////
            string checkif = ("UPDATE musteri SET cariadi=@cariadi,vno=@vno,vergidairesi=@vergidairesi,adres=@adres,telefon=@telefon,sehir=@sehir WHERE id=" + int.Parse(textBox_id2.Text));
            MySqlCommand command  = new MySqlCommand(checkif, conn);
            command.Parameters.AddWithValue("@cariadi", textBox_cariadi2.Text );
            command.Parameters.AddWithValue("@vno",textBox_vno2.Text );
            command.Parameters.AddWithValue("@vergidairesi",textBox_vergidairesi2.Text );
            command.Parameters.AddWithValue("@adres", textBox_adres2.Text);
            command.Parameters.AddWithValue("@telefon", textBox_telefon2.Text);
            command.Parameters.AddWithValue("@sehir", textBox_sehir2.Text );

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            form1.bring_items();
            this.Close();


        }
    }
}
