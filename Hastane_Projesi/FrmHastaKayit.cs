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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnKayitYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Hasta (hastaTc,hastaAd,hastaSoyad,hastaTelefon,hastaSifre,hastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TcMsktxt.Text);
            komut.Parameters.AddWithValue("@p2", adTxt.Text);
            komut.Parameters.AddWithValue("@p3", soyadTxt.Text);
            komut.Parameters.AddWithValue("@p4", telefonMskTxt.Text);
            komut.Parameters.AddWithValue("@p5", sifreTxt.Text);
            komut.Parameters.AddWithValue("@p6", cinsiyetCmbBox.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız yapılmıştır.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
