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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = TCno;
            //Ad Soyad
            SqlCommand komut = new SqlCommand("Select sekreterAdSoyad from Tbl_Sekreter where sekreterTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                lblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();
            //Branşları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select bransAd from Tbl_Brans", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            //Doktorları datagride aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktorAd+''+doktorSoyad) as 'Doktorlar',doktorBrans from Tbl_Doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            //Branşı cmboxa aktarma
            SqlCommand komut2 = new SqlCommand("select bransAd from Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                bransCmb.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Randevular (randevuTarih,randevuSaat,randevuBrans,randevuDoktor)values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tarihMskb.Text);
            komut.Parameters.AddWithValue("@p2", saatMskb.Text);
            komut.Parameters.AddWithValue("@p3", bransCmb.Text);
            komut.Parameters.AddWithValue("@p4", doktorCmb.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz kaydedildi.", "Randevu Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bransCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktorCmb.Items.Clear();
            SqlCommand komut = new SqlCommand("select doktorAd,doktorSoyad from Tbl_Doktor where doktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", bransCmb.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                doktorCmb.Items.Add(dr[0] + "" + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", duyuruRchTxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu", "Duyuru", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr=new FrmDoktorPaneli();
            fr.Show();
            
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBrans frm=new FrmBrans();
            frm.Show();
        }

        private void btnRandevuListesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr= new FrmRandevuListesi();
            fr.Show();
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr=new FrmDuyurular();
            fr.Show();
        }
    }
}
