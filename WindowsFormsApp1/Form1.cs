using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bring_items();
            timer1.Start();
          

        }




        public void bring_items()
        {

            string MySQLConnectionString = //database info
            MySqlConnection conn = new MySqlConnection(MySQLConnectionString);
            conn.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM musteri", conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView_main.DataSource = dataTable;
            conn.Close();




        }





        private void button_add_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            dataGridView_main.Refresh();
        }
        private void dataGridView_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //dataGridView_main.DataSource = e.RowIndex;
            var senderGrid = (DataGridView)sender;
            //if (e.ColumnIndex==0) //DELETE
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string MySQLConnectionString = //database info
                MySqlConnection conn = new MySqlConnection(MySQLConnectionString);
             
                string checkif = "DELETE FROM musteri WHERE id=@id";
                MySqlCommand command = new MySqlCommand(checkif, conn);

                command.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView_main.SelectedRows[0].Cells[1].Value.ToString()));   

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                bring_items();

                





            }

            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            bring_items();
            timer1.Start();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            Form3 form3 = new Form3();

            form3.textBox_id2.Text = dataGridView_main.SelectedRows[0].Cells[1].Value.ToString();

            form3.textBox_cariadi2.Text = dataGridView_main.SelectedRows[0].Cells[2].Value.ToString();
            form3.textBox_vno2.Text = dataGridView_main.SelectedRows[0].Cells[3].Value.ToString();
            form3.textBox_vergidairesi2.Text = dataGridView_main.SelectedRows[0].Cells[4].Value.ToString();
            form3.textBox_adres2.Text = dataGridView_main.SelectedRows[0].Cells[5].Value.ToString();
            form3.textBox_telefon2.Text = dataGridView_main.SelectedRows[0].Cells[6].Value.ToString();
            form3.textBox_sehir2.Text = dataGridView_main.SelectedRows[0].Cells[7].Value.ToString();


            form3.ShowDialog();
        }

        
    }
}
