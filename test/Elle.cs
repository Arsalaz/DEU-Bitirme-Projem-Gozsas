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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test
{
    public partial class elle : Form
    {
        string connectionString = "Server=tcp:projesdb.database.windows.net,1433;Initial Catalog=Bruckner;Persist Security Info=False;User ID=dbadmin;Password=98569856Mert;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public elle()
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBox2.KeyPress += new KeyPressEventHandler(textBox2_KeyPress);
            textBox3.KeyPress += new KeyPressEventHandler(textBox3_KeyPress);
            textBox4.KeyPress += new KeyPressEventHandler(textBox4_KeyPress);
            textBox5.KeyPress += new KeyPressEventHandler(textBox5_KeyPress);

        }

        private void kaydetb_Click(object sender, EventArgs e)
        {
            try
            {
                string ograd = textBox1.Text;
                string ogrsoyad = textBox2.Text;
                int ogrno = Convert.ToInt32(textBox3.Text);
                string ogrsinif = textBox4.Text;
                long okulid = Convert.ToInt64(textBox5.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO ogr_table (okulid, ograd, ogrsoyad, ogrno, ogrsinif) VALUES (@okulid, @ograd, @ogrsoyad, @ogrno, @ogrsinif)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@okulid", okulid);
                        command.Parameters.AddWithValue("@ograd", ograd);
                        command.Parameters.AddWithValue("@ogrsoyad", ogrsoyad);
                        command.Parameters.AddWithValue("@ogrno", ogrno);
                        command.Parameters.AddWithValue("@ogrsinif", ogrsinif);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla eklendi.");
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt ekleme hatası: " + ex.Message);
            }
        }

        private void elle_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * From okul_table";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                 
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] specialCharacters = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', ';', ':', '"', '\'', '\\', '|', ',', '<', '>', '.', '?'};

            if (Array.IndexOf(specialCharacters, e.KeyChar) != -1 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
