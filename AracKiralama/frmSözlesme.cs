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
    public partial class frmSözlesme : Form
    {
        public frmSözlesme()
        {
            InitializeComponent();
        }
        Arac_Kiralama arac = new Arac_Kiralama();
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSözlesme_Load(object sender, EventArgs e)
        {
            BosAraclar();
            Yenile();
        }

        private void BosAraclar()
        {
            string sorgu2 = "select * from Arac where Durum='Boş'";
            arac.Müsait_Araclar(cbxAraclar, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select * from Sozlesme";
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            dgwSozlesmeListe.DataSource = arac.listele(adapter2, sorgu3);
        }

       
        private void cbxAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sorgu2 = "select * from Arac where Plaka like '" + cbxAraclar.SelectedItem + "'";
            arac.Combodan_Gelen(cbxAraclar,txtMarka, cbxSegment, txtSeri,txtYıl,txtRenk, sorgu2);

        }

        private void cbxKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sorgu2 = "select * from Arac where Plaka like '" + cbxAraclar.SelectedItem + "'";
            arac.Ucret_Hesapla(cbxKiraSekli,txtKiraUcreti, sorgu2);

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           TimeSpan gun = DateTime.Parse(dtpDonus.Text) - DateTime.Parse(dtpCıkıs.Text);
            int gun2 = gun.Days;
           txtGun.Text = gun2.ToString();
            txtTutar.Text = (gun2 * decimal.Parse(txtKiraUcreti.Text)).ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            dtpCıkıs.Text = DateTime.Now.ToShortDateString();
            dtpDonus.Text = DateTime.Now.ToShortDateString();
            cbxKiraSekli.Text = "";
            txtKiraUcreti.Text = "";
            txtGun.Text = "";
            txtTutar.Text = "";
        }

        private void btnSozEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into Sozlesme(Tc,AdSoyad,Telefon,EhliyetNo,EhliyetTarih,EhliyetYer,Plaka,Marka,Segment,Seri,Yıl,Renk,KiraSekli,KiraUcreti,Gun,Tutar,CıkısTarihi,DonusTarihi) values(@tc,@adSoyad,@telefon,@ehliyetNo,@ehliyetTarihi,@ehliyetYer,@plaka,@marka,@segment,@seri,@yıl,@renk,@kiraSekli,@kiraUcreti,@gun,@tutar,@cıkısTarihi,@donusTarihi)";
            SqlCommand komut6 = new SqlCommand();
     
            komut6.Parameters.AddWithValue("@tc", txtTc.Text);
            komut6.Parameters.AddWithValue("@adSoyad", txtAdSoyadi.Text);
            komut6.Parameters.AddWithValue("@telefon", txtTel.Text);
            komut6.Parameters.AddWithValue("@ehliyetNo", txtENo.Text);
            komut6.Parameters.AddWithValue("@ehliyetTarihi", txtETarihi.Text);
            komut6.Parameters.AddWithValue("@ehliyetYer", txtEverildigiYer.Text);
            komut6.Parameters.AddWithValue("@plaka", cbxAraclar.Text);
            komut6.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut6.Parameters.AddWithValue("@segment", cbxSegment.Text);
            komut6.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut6.Parameters.AddWithValue("@yıl", txtYıl.Text);
            komut6.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut6.Parameters.AddWithValue("@kiraSekli", cbxKiraSekli.Text);
            komut6.Parameters.AddWithValue("@kiraUcreti", decimal.Parse(txtKiraUcreti.Text));
            komut6.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            komut6.Parameters.AddWithValue("@tutar", decimal.Parse(txtTutar.Text));
            komut6.Parameters.AddWithValue("@cıkısTarihi", dtpCıkıs.Text);
            komut6.Parameters.AddWithValue("@donusTarihi", dtpDonus.Text);
            arac.ekle_sil_guncelle(komut6, sorgu2);
            string sorgu3 = "update Arac set  Durum='Dolu' where Plaka='" + cbxAraclar.Text + "'";
            SqlCommand komut7 = new SqlCommand();
            arac.ekle_sil_guncelle(komut7, sorgu3);
            cbxAraclar.Items.Clear();
            BosAraclar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            cbxAraclar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Eklendi");
        }

        private void btnSozGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu4 = "update Sozlesme set Tc=@tc,AdSoyad=@adSoyad,Telefon=@telefon,EhliyetNo=@ehliyetNo,EhliyetTarih=@ehliyetTarihi,EhliyetYer=@ehliyetYer,Plaka=@plaka,Marka=@marka,Segment=@segment, Seri=@seri, Yıl=@yıl ,Renk=@renk, KiraSekli=@kiraSekli, KiraUcreti=@kiraUcreti, Gun=@gun, Tutar=@tutar, CıkısTarihi=@cıkısTarihi, DonusTarihi=@donusTarihi where Plaka=@plaka";
                                                                                                                                                                                                              
            SqlCommand komut8 = new SqlCommand();
         
            komut8.Parameters.AddWithValue("@tc", txtTc.Text);
            komut8.Parameters.AddWithValue("@adSoyad", txtAdSoyadi.Text);
            komut8.Parameters.AddWithValue("@telefon", txtTel.Text);
            komut8.Parameters.AddWithValue("@ehliyetNo", txtENo.Text);
            komut8.Parameters.AddWithValue("@ehliyetTarihi", txtETarihi.Text);
            komut8.Parameters.AddWithValue("@ehliyetYer", txtEverildigiYer.Text);
            komut8.Parameters.AddWithValue("@plaka", cbxAraclar.Text);
            komut8.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut8.Parameters.AddWithValue("@segment", cbxSegment.Text);
            komut8.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut8.Parameters.AddWithValue("@yıl", txtYıl.Text);
            komut8.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut8.Parameters.AddWithValue("@kiraSekli", cbxKiraSekli.Text);
            komut8.Parameters.AddWithValue("@kiraUcreti", decimal.Parse(txtKiraUcreti.Text));
            komut8.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            komut8.Parameters.AddWithValue("@tutar", decimal.Parse(txtTutar.Text));
            komut8.Parameters.AddWithValue("@cıkısTarihi", dtpCıkıs.Text);
            komut8.Parameters.AddWithValue("@donusTarihi", dtpDonus.Text);
            arac.ekle_sil_guncelle(komut8,sorgu4);

            cbxAraclar.Items.Clear();
            BosAraclar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Güncellendi");
        }

        private void dgwSozlesmeListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satır = dgwSozlesmeListe.CurrentRow;


        
            txtTc.Text = satır.Cells[1].Value.ToString();
            txtAdSoyadi.Text = satır.Cells[2].Value.ToString();
            txtTel.Text = satır.Cells[3].Value.ToString();
            txtENo.Text = satır.Cells[4].Value.ToString();
            txtETarihi.Text = satır.Cells[5].Value.ToString();
            txtEverildigiYer.Text = satır.Cells[6].Value.ToString();
           cbxAraclar.Text = satır.Cells[7].Value.ToString();

            txtMarka.Text = satır.Cells[8].Value.ToString();
            cbxSegment.Text = satır.Cells[9].Value.ToString();
           txtSeri.Text = satır.Cells[10].Value.ToString();
           txtYıl.Text = satır.Cells[11].Value.ToString();
            txtRenk.Text = satır.Cells[12].Value.ToString();
            cbxKiraSekli.Text = satır.Cells[13].Value.ToString();

          txtKiraUcreti.Text = satır.Cells[14].Value.ToString();
           txtGun.Text = satır.Cells[15].Value.ToString();
            txtTutar.Text = satır.Cells[16].Value.ToString();
            dtpCıkıs.Text = satır.Cells[17].Value.ToString();
           dtpDonus.Text = satır.Cells[18].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu3 = "select * from Müsteri where Tc like '" +textBox1.Text + "'";
            arac.TC_ARA(txtTc, txtAdSoyadi, txtTel, sorgu3);
        }
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select * from Müsteri where Tc like '" + txtTc.Text + "'";
           arac.TC_ARAma(textBox1, txtTc, txtAdSoyadi, txtTel, sorgu2);

        }

        private void dgwSozlesmeListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dgwSozlesmeListe.CurrentRow;
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime donus = DateTime.Parse(satır.Cells["Donustarihi"].Value.ToString());
            decimal ucret=decimal.Parse(satır.Cells["KiraUcreti"].Value.ToString());
            TimeSpan gunfarki = bugun - donus;
            decimal _gunfarki = gunfarki.Days;
            decimal _ucretfarki;
            _ucretfarki = _gunfarki * ucret;
            txtekstra.Text = _ucretfarki.ToString();
        }

        private void btnAracTeslim_Click(object sender, EventArgs e)
        {
            if (txtekstra.Text !="")
            {
                DataGridViewRow satır = dgwSozlesmeListe.CurrentRow;
                DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                decimal ucret = decimal.Parse(satır.Cells["KiraUcreti"].Value.ToString());
                decimal tutar = decimal.Parse(satır.Cells["Tutar"].Value.ToString());
                DateTime cıkıs = DateTime.Parse(satır.Cells["CıkısTarihi"].Value.ToString());
                TimeSpan gun = bugün - cıkıs;
                decimal _gun = gun.Days;
               decimal toplamtutar = _gun * ucret;
                string sorgu1 = "delete from Sözlesme where Plaka='" + satır.Cells["Plaka"].Value.ToString() + "'";
                SqlCommand komut = new SqlCommand();
                arac.ekle_sil_guncelle(komut,sorgu1);

                string sorgu3 = "update Arac set Durum='Boş'where Plaka='" + satır.Cells["Plaka"].Value.ToString() + "'";
                SqlCommand komut1 = new SqlCommand();
                arac.ekle_sil_guncelle(komut1, sorgu3);

                string sorgu2 = "insert into Satis(Tc,AdSoyad,Plaka,Marka,Seri,Segment,Yıl,Renk,Gun,Fiyat,Tutar,Tarihi1,Tarihi2) values(@tc,@adSoyad,@plaka,@marka,@seri,@segment,@yıl,@renk,@kiraSekli,@fiyat,@gun,@tutar,@tarihi1,@tarihi2)";
                SqlCommand komut6 = new SqlCommand();

                komut6.Parameters.AddWithValue("@tc", satır.Cells["Tc"].Value.ToString());
                komut6.Parameters.AddWithValue("@adSoyad", satır.Cells["AdSoyad"].Value.ToString());
             
                komut6.Parameters.AddWithValue("@plaka", satır.Cells["Plaka"].Value.ToString());
                komut6.Parameters.AddWithValue("@marka", satır.Cells["Marka"].Value.ToString());
                komut6.Parameters.AddWithValue("@seri", satır.Cells["Seri"].Value.ToString());
                komut6.Parameters.AddWithValue("@segment", satır.Cells["Segment"].Value.ToString());
               
                komut6.Parameters.AddWithValue("@yıl", satır.Cells["Yıl"].Value.ToString());
                komut6.Parameters.AddWithValue("@renk", satır.Cells["Renk"].Value.ToString());
           
                komut6.Parameters.AddWithValue("@gun", _gun);

                komut6.Parameters.AddWithValue("@fiyat", ucret);
                komut6.Parameters.AddWithValue("@tutar", toplamtutar);
                komut6.Parameters.AddWithValue("@tarihi1", satır.Cells["CıkısTarihi"].Value.ToString());
                komut6.Parameters.AddWithValue("@tarihi2", DateTime.Now.ToShortDateString());
                arac.ekle_sil_guncelle(komut6, sorgu2);
                MessageBox.Show("Arac Teslim Edildi", "Uyarı");

                cbxAraclar.Items.Clear();
                BosAraclar();
                Yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                Temizle();
                txtekstra.Text = "";

            }
            else if (txtekstra.Text == "")
            {
                MessageBox.Show("Lütfen Seçim Yapınız","Uyarı");
            }
        }
    }
}
