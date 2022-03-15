using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    class Arac_Kiralama
    {
        SqlConnection _baglanti = new SqlConnection("Server=DESKTOP-P516HSN;Initial Catalog=Arac_Kiralama;Integrated Security=true;");
        DataTable table;
        public void Baglanti_Kontrol()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
        }
        public DataTable listele(SqlDataAdapter adapter,string sorgu)
        {
            table = new DataTable();
            adapter = new SqlDataAdapter(sorgu, _baglanti);
            adapter.Fill(table);
            _baglanti.Close();
            return table;
        }
        public void ekle_sil_guncelle(SqlCommand komut,string sorgu)
        {
            Baglanti_Kontrol();
            komut.Connection = _baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            _baglanti.Close();


        }
        public void Müsait_Araclar(ComboBox combo,string sorgu)
        {
            Baglanti_Kontrol();
            SqlCommand komut5 = new SqlCommand(sorgu,_baglanti);
            SqlDataReader read = komut5.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["Plaka"].ToString());
            }
            _baglanti.Close(); 
        }
        public void TC_ARA(TextBox tc,TextBox adsoyad,TextBox telefon, string sorgu20)
        {
            Baglanti_Kontrol();
            SqlCommand komut16 = new SqlCommand(sorgu20, _baglanti);
            SqlDataReader read20 = komut16.ExecuteReader();
            while (read20.Read())
            {
                adsoyad.Text = read20["AdSoyad"].ToString();
                telefon.Text= read20["Telefon"].ToString();

            }
            _baglanti.Close();
        }
        public void TC_ARAma(TextBox tcara,TextBox tc, TextBox adsoyad, TextBox telefon, string sorgu15)
        {
            Baglanti_Kontrol();
            SqlCommand komut17 = new SqlCommand(sorgu15, _baglanti);
            SqlDataReader read1 = komut17.ExecuteReader();
            while (read1.Read())
            {
                tc.Text = read1["Tc"].ToString();
                adsoyad.Text = read1["AdSoyad"].ToString();
                telefon.Text = read1["Telefon"].ToString();

            }
            _baglanti.Close();
        }
        public void Combodan_Gelen(ComboBox araclar, TextBox marka,ComboBox segment, TextBox seri, TextBox yıl,TextBox renk,string sorgu)
        {
            Baglanti_Kontrol();
            SqlCommand komut8 = new SqlCommand(sorgu, _baglanti);
            SqlDataReader read = komut8.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["Marka"].ToString();
                segment.Text = read["Segment"].ToString();
                seri.Text = read["Seri"].ToString();
                yıl.Text = read["Model"].ToString();
               
                renk.Text = read["Renk"].ToString();

            }
            _baglanti.Close();
        }
        public void SatisHesapla(Label lbl)
        {
            Baglanti_Kontrol();
           SqlCommand komut = new SqlCommand("select sum(tutar) from Satis ",_baglanti);
            lbl.Text = "toplam tutar=" + komut.ExecuteScalar() + "Tl";

        }
        public void Ucret_Hesapla(ComboBox combokirasekli,TextBox ucret,  string sorgu)
        {
            Baglanti_Kontrol();
            SqlCommand komut5 = new SqlCommand(sorgu, _baglanti);
            SqlDataReader read = komut5.ExecuteReader();
            while (read.Read())
            {
                if (combokirasekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["KiraUcreti"].ToString()) * 1).ToString();
                if (combokirasekli.SelectedIndex == 1) ucret.Text=(int.Parse(read["KiraUcreti"].ToString()) * 0.80).ToString();
                if (combokirasekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["KiraUcreti"].ToString()) * 0.70).ToString();
            }
            _baglanti.Close();
        }
    }
}
