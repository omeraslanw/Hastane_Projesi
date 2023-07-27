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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            TcMsktxt.Text = TCno;
            SqlCommand komut = new SqlCommand("select * from tbl_Hasta where hastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TCno);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                adTxt.Text = dr[1].ToString();
                soyadTxt.Text = dr[2].ToString();
                telefonMskTxt.Text = dr[4].ToString();
                sifreTxt.Text = dr[5].ToString();
                cinsiyetCmbBox.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_Hasta set hastaAd=@p1,hastaSoyad=@p2,hastaSifre=@p3,hastaTelefon=@p4,hastaCinsiyet=@p5 where hastaTc=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", adTxt.Text);
            komut.Parameters.AddWithValue("@p2", soyadTxt.Text);
            komut.Parameters.AddWithValue("@p3", sifreTxt.Text);
            komut.Parameters.AddWithValue("@p4", telefonMskTxt.Text);
            komut.Parameters.AddWithValue("@p5", cinsiyetCmbBox.Text);
            komut.Parameters.AddWithValue("@p6", TcMsktxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
