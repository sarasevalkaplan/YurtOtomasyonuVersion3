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

namespace YurtKayitSistemi
{
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        public string id,ad,soyad,TC,telefon,dogum,bolum;
        public string mail, odano, veliad, velitel, adres;
        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            TxtOgrid.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTC.Text = TC;
            MskOgrTelefon.Text = telefon;
            MskDogum.Text = dogum;
            CmbBolum.Text = bolum;
            TxtMail.Text = mail;
            CmbOdaNo.Text = odano;
            TxtVeliAdSoyad.Text = veliad;
            MskVeliTelefon.Text = velitel;
            RchAdres.Text = adres;


        }
        private void BtnOgrGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p1,OgrSoyad=@p2,OgrTC=@p3,OgrTelefon=@p4,OgrDogum=@p5,OgrBolum=@p6,OgrMail=@p7,OgrOdaNo=@p8,OgrVeliAdSoyad=@p9,OgrVeliTelefon=@p10,OgrVeliAdres=@p11 where Ogrid=@p0",bgl.baglanti());
            komut.Parameters.AddWithValue("@p0",TxtOgrid.Text);
            komut.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskOgrTelefon.Text);
            komut.Parameters.AddWithValue("@p5", MskDogum.Text);
            komut.Parameters.AddWithValue("@p6", CmbBolum.Text);
            komut.Parameters.AddWithValue("@p7", TxtMail.Text);
            komut.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
            komut.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
            komut.Parameters.AddWithValue("@p10", MskVeliTelefon.Text);
            komut.Parameters.AddWithValue("@p11", RchAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi");

        }


    }
}
