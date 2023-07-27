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
using System.Data.SqlClient;

namespace Hastane_Projesi
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Doktor", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //Branşları cmbBoxa aktarma
            SqlCommand komut=new SqlCommand("select bransAd from tbl_brans",bgl.baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                bransCmb.Items.Add(dataReader[0]);
            }
            bgl.baglanti().Close();
            
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktor (doktorAd,doktorSoyad,doktorBrans,doktorTc,doktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", adTxt.Text);
            komut.Parameters.AddWithValue("@p2", soyadTxt.Text);
            komut.Parameters.AddWithValue("@p3", bransCmb.Text);
            komut.Parameters.AddWithValue("@p4", tcMsk.Text);
            komut.Parameters.AddWithValue("@p5", sifreTxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor eklendi.", "Doktor Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            adTxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyadTxt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            bransCmb.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tcMsk.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            sifreTxt.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Doktor where doktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tcMsk.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktor set doktorAd=@p1,doktorSoyad=@p2,doktorBrans=@p3,doktorSifre=@p5 where doktorTc=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", adTxt.Text);
            komut.Parameters.AddWithValue("@p2", soyadTxt.Text);
            komut.Parameters.AddWithValue("@p3", bransCmb.Text);
            komut.Parameters.AddWithValue("@p4", tcMsk.Text);
            komut.Parameters.AddWithValue("@p5", sifreTxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
