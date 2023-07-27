using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Projesi
{
    internal class sqlbaglantisi //'sqlbaglantisi' sınıfın adı
    {
        public SqlConnection baglanti() //'baglanti 'metodun adı
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BOV3B8B\\SQLEXPRESS;Initial Catalog=HastaProje;Integrated Security=True");
            //'baglan' SqlConnection sınıfından türetilen bağlantı adresini tutan nesnenin adı
            baglan.Open();
            return baglan;
        }
    }
}
