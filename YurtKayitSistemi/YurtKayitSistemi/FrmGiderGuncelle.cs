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
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
         
        }
        SqlBaglantim bgl = new SqlBaglantim();
        public string elektrik,gida, su, dogalgaz, diger, internet, personel,id;

        private void btnGiderGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p2,Su=@p3,Dogalgaz=@p4,internet=@p5,Gıda=@p6,Personel=@p7,Diger=@p8 where Odemeid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtGiderid.Text);
            komut.Parameters.AddWithValue("@p2", TxtElektrik.Text);
            komut.Parameters.AddWithValue("@p3", TxtSu.Text);
            komut.Parameters.AddWithValue("@p4", TxtDogalgaz.Text);
            komut.Parameters.AddWithValue("@p5", TxtInternet.Text);
            komut.Parameters.AddWithValue("@p6", TxtGida.Text);
            komut.Parameters.AddWithValue("@p7", TxtPersonel.Text);
            komut.Parameters.AddWithValue("@p8", TxtDiger.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi");






        }

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            TxtGiderid.Text = id;
            TxtElektrik.Text = elektrik;
            TxtGida.Text = gida;
            TxtSu.Text = su;
            TxtPersonel.Text = personel;
            TxtInternet.Text = internet;
            TxtDogalgaz.Text = dogalgaz;
            TxtDiger.Text = diger;

        }
    }
}
