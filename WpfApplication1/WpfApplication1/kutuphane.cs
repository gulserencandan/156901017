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

        public kutuphane(string ipadresi, string portno, string kullaniciadi, string sifre, string veritabaniadi)
        {
            baglantistr = "Server=" + ipadresi + ";Port=" + portno + ";Database=" + veritabaniadi + ";Uid=" + kullaniciadi + ";Pwd=" + sifre + ";";
        }
        string baglantistr;
        public string hata = "";


        public void Kaydet(string kitapAdi, string yazarAdi, string yayinAdi, string kitapTuru, string baskiSayisi, string stokSayisi)
        {
            MySqlConnection baglanti = new MySqlConnection(baglantistr);
            try
            {
                baglanti.Open();
            }
            catch (MySqlException e)
            {
                hata = e.Message;
                return;
            }

            MySqlCommand komut = new MySqlCommand ("INSERT INTO kutuphane (kitapAdi, yazarAdi, yayinAdi, kitapTuru, baskiSayisi, stokSayisi) Values ('" + kitapAdi + "','" 
                +yazarAdi+ "','" +yayinAdi + "','" + kitapTuru + "','" + baskiSayisi + "','" + stokSayisi + "')", baglanti);

            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            baglanti.Dispose();
        }
        public void VeriSil(int id)
        {
            MySqlConnection baglanti;
            baglanti = new MySqlConnection(baglantistr);
            try
            {
                baglanti.Open();
            }
            catch (MySqlException e)
            {
                hata = e.Message;
                return;
            }
            MySqlCommand komut = new MySqlCommand("DELETE FROM deneme WHERE id=" + id.ToString(), baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            komut.Dispose();
        
        }

        public DataView tumverilerioku(string tabloadi)
        {
            MySqlConnection baglanti;
            baglanti = new MySqlConnection(baglantistr);
            try
            {
                baglanti.Open();
            }
            catch (MySqlException e)
            {
                hata = e.Message;
                return new DataView();
            }
            MySqlCommand komut = new MySqlCommand("SELECT * FROM  kutuphane" , baglanti);
            MySqlDataAdapter adabtor = new MySqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adabtor.Fill(tablo);
            baglanti.Close();
            return tablo.AsDataView();
        }




    }
}
