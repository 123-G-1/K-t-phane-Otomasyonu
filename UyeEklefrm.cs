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

namespace Kütüphane_Otomasyonu
{
    public partial class UyeEklefrm : Form
    {
        public UyeEklefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti= new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\KULLANICI\\Downloads\\Kütüphane Otomasyonu.mdf\";Integrated Security=True;Connect Timeout=30");
        private object textTc;
        private object txtCinsiyet;

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UyeEklefrm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into uye(tc,adsoyad,yaş,cinsiyet,telefon,adres,email,okumakitapsayisi)values(@tc,@adsoyad,@yaş,@cinsiyet,@telefon,@adres,@email,@okumakitapsayisi)", baglanti);
            cmd.Parameters.AddWithValue("@tc", txtTc.Text);
            cmd.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@yaş", txtYaş.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@okunankitapsayisi", txtOkunanKitapSayısı.Text);
            cmd.Parameters.AddWithValue("@okumakitapsayisi", txtOkunanKitapSayısı.Text);
            baglanti.Close();
            MessageBox.Show("Üye Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name != "txtOkunanKitapSayısı") // Exclude the read books count field from clearing
                    {
                        item.Text = "";
                    }
                }
            }
           
        }

    
        

        
    }
}
