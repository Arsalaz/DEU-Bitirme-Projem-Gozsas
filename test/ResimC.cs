using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test
{
    public partial class ResimC : Form
    {
        string connectionString = "Server=tcp:projesdb.database.windows.net,1433;Initial Catalog=Bruckner;Persist Security Info=False;User ID=dbadmin;Password=98569856Mert;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public ResimC()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            yukle();
        }

        private void yukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, ograd, ogrsoyad, ogrdurum FROM ogr_table";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 &&
                dataGridView1.SelectedRows[0].Cells["ID"].Value != DBNull.Value)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                LoadImages(selectedId);
            }
        }


        private void LoadImages(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT saggoz, solgoz FROM ogr_table WHERE ID=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["saggoz"] != DBNull.Value)
                    {
                        byte[] rightEyeBytes = (byte[])reader["saggoz"];
                        pictureBox1.Image = ByteArrayToImage(rightEyeBytes);
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }

                    if (reader["solgoz"] != DBNull.Value)
                    {
                        byte[] leftEyeBytes = (byte[])reader["solgoz"];
                        pictureBox2.Image = ByteArrayToImage(leftEyeBytes);
                    }
                    else
                    {
                        pictureBox2.Image = null;
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                }
            }
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                returnImage = Image.FromStream(ms);
            }
            return returnImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yukle();
        }
    }
}
