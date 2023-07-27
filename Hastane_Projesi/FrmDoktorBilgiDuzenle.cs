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
using System.Windows.Forms;

namespace Hastane_Projesi
{
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            TcMsktxt.Text = TC;
            SqlCommand komut = new SqlCommand("select * from Tbl_Doktor where doktorTc=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p3", TcMsktxt.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                adTxt.Text = dr[1].ToString();
                soyadTxt.Text = dr[2].ToString();
                bransCmb.Text = dr[3].ToString();
                sifreTxt.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktor set doktorAd=@p1,doktorSoyad=@p2,doktorBrans=@p3,doktorSifre=@p4 where doktorTc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",adTxt.Text);
            komut.Parameters.AddWithValue("@p2", soyadTxt.Text);
            komut.Parameters.AddWithValue("@p3", bransCmb.Text);
            komut.Parameters.AddWithValue("@p4", sifreTxt.Text);
            komut.Parameters.AddWithValue("@p5", TcMsktxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler güncellendi.","Güncelleme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
