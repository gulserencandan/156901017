using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
namespace WpfApplication1
{
    class kutuphane
    {
        public class ktpBilgi
        {
            public int id { get; set; }
            public string kitapAdi { get; set; }
            public string yazarAdi { get; set; }
            public string yayinEvi { get; set; }
            public string kitapTuru { get; set; }
            public int baskiSayisi { get; set; }
            public int stokSayisi { get; set; }
            public DateTime gelisTarihi { get; set; }
        }

        string baglantistr = "Server=localhost:60;Port=3306;Database=test;Uid=root;Pwd=;Convert Zero Datetime=True;Allow Zero Datetime=True;";
        public void Kaydet(ktpBilgi a)
        {
            MySqlConnection baglanti = new MySqlConnection(baglantistr);
            baglanti.Open();

            MySqlCommand komut = new MySqlCommand("INSERT INTO kutuphane (kitapAdi, yazarAdi, yayinAdi, kitapTuru, baskiSayisi, stokSayisi) Values (" + a.kitapAdi + ","
                + a.yazarAdi + "," + a.yayinEvi + "," + a.kitapTuru + "," + a.baskiSayisi + "," + a.stokSayisi + ")", baglanti);

            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            baglanti.Dispose();
        }

    }
}
