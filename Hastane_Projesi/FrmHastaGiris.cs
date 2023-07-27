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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();

        private void uyeOlLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Hasta where hastaTc=@p1 and hastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TcMsktxt.Text);
            komut.Parameters.AddWithValue("@p2",sifreTxt.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay frm = new FrmHastaDetay();
                frm.tc=TcMsktxt.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış şifre ya da TC numarası girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
    }
}
