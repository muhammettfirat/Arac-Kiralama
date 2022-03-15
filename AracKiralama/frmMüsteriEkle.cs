using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class frmMüsteriEkle : Form
    {
        Arac_Kiralama arac_Kiralama = new Arac_Kiralama();
        public frmMüsteriEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cümle = "insert into Müsteri(Tc,AdSoyad,Telefon,Adres,Email) values (@tc,@adSoyad,@telefon,@adres,@email)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@email", txtemail.Text);
            arac_Kiralama.ekle_sil_guncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                
            
        }

        private void frmMüsteriEkle_Load(object sender, EventArgs e)
        {
           
        }
    }
}
