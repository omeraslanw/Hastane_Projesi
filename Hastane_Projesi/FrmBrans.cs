using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Projesi
{
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Brans (bransAd) values(@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", bransTxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            idTxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bransTxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Brans where bransıd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", idTxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_Brans set bransAd=@p2 where bransId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", idTxt.Text);
            komut.Parameters.AddWithValue("@p2", bransTxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
