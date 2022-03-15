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
 
    public partial class frmAracKayıt : Form
    {
        Arac_Kiralama Kiralama = new Arac_Kiralama();
        public frmAracKayıt()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void txtYakıt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            string cümle = "insert into Arac(Plaka,Marka,Seri,Segment,Model,Renk,Km,Yakit,KiraUcreti,Durum,Resim) values (@plaka,@marka,@seri,@segment,@model,@renk,@km,@yakit,@kiraUcreti,@durum,@resim)";
            SqlCommand komut3 = new SqlCommand();
            komut3.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut3.Parameters.AddWithValue("@marka", cmbxMarka.Text);
            komut3.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut3.Parameters.AddWithValue("@segment", cmbxSegment.Text);
            komut3.Parameters.AddWithValue("@model", txtModel.Text);
            komut3.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut3.Parameters.AddWithValue("@km", txtKm.Text);
            komut3.Parameters.AddWithValue("@yakit", cmbxYakıt.Text);
            komut3.Parameters.AddWithValue("@kiraUcreti", txtKiraUcreti.Text);
            komut3.Parameters.AddWithValue("@durum", cbxDurum.Text);
            komut3.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            Kiralama.ekle_sil_guncelle(komut3, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

        }

        private void frmAracKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
