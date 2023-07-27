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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();
        public string TcNo;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text=TcNo;
            //doktor ad soyad
            SqlCommand komut = new SqlCommand("select doktorAd,doktorSoyad from Tbl_Doktor where doktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TcNo);
            SqlDataReader dr = komut.ExecuteReader(); 
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
            //doktor randevu listesi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where randevudoktor='" + lblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frm=new FrmDoktorBilgiDuzenle();
            frm.TC=lblTc.Text;
            frm.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm=new FrmDuyurular();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            sikayetRchTxt.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
