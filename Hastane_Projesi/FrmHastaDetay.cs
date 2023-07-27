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
using System.Data.Common;

namespace Hastane_Projesi
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            //Ad Soyad çekme
            lblTc.Text = tc;
            SqlCommand komut = new SqlCommand("select hastaAd,hastaSoyad from Tbl_Hasta where hastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where hastaTc=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //datagridviewde bağlantı açıp kapamaya gerek yok

            //Branşları çekme
            SqlCommand komut2 = new SqlCommand("Select bransAd from tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                bransCmb.Items.Add(dr2[0]);
            }
        }

        private void bransCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktorCmb.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select doktorAd,doktorSoyad from Tbl_Doktor where doktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", bransCmb.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                doktorCmb.Items.Add(dr3[0] + "" + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void doktorCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where randevuBrans='" + bransCmb.Text + "'"+"and randevuDoktor='"+doktorCmb.Text+"'and randevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void bilgiDuzenleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = lblTc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            idTxt.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular set randevuDurum=1,hastaTc=@p1,hastaSikayet=@p2 where randevuId=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTc.Text);
            komut.Parameters.AddWithValue("@p2",sikayetRchTxt.Text);
            komut.Parameters.AddWithValue("@p3",idTxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz kaydedildi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
