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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();


        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_Sekreter where sekreterTc=@p1 and sekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TcMsktxt.Text);
            komut.Parameters.AddWithValue("@p2", sifreTxt.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay fr = new FrmSekreterDetay();
                fr.TCno=TcMsktxt.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış şifre veya TC no girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
