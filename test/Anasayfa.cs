using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test
{
    public partial class Anasayfa : Form
    {
        string connectionString = "Server=tcp:projesdb.database.windows.net,1433;Initial Catalog=Bruckner;Persist Security Info=False;User ID=dbadmin;Password=98569856Mert;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public Anasayfa()
        {
            InitializeComponent();
        }
        private void elleVeriGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elle manuel = new elle();
            manuel.Show();
        }

        private void brucknerTestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testb test = new Testb();
            test.Show();
        }
        private void okulKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okul okulk = new okul();
            okulk.Show();
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ograd, ogrsoyad, ogrno, ogrsinif, okulad " +
                                   "FROM ogr_table INNER JOIN okul_table ON ogr_table.okulid = okul_table.okulno";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatasý: " + ex.Message);
            }
        }

        private void resimKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResimC resimC = new ResimC();
            resimC.Show();
        }

        private void yardýmVeKullanýmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yardim yardim = new yardim();
            yardim.Show();
        }

        private void yazdýrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yazdir yazdir = new Yazdir();
            yazdir.Show();
        }
    }
}
