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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select * from Tbl_Doktor where  doktorTc=@p1 and doktorSifre=@p2  ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TcMsktxt.Text);
            komut.Parameters.AddWithValue("@p2", sifreTxt.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if(dr.Read()) 
            {
                FrmDoktorDetay frm=new FrmDoktorDetay();
                frm.TcNo=TcMsktxt.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğiniz şifre veya TC no hatalı.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
    }
}
