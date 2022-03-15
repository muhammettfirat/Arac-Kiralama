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
    public partial class frmMüsteriListele : Form
    {
        Arac_Kiralama AracKiralama = new Arac_Kiralama();
        public frmMüsteriListele()
        {
            InitializeComponent();
        }

        private void frmMüsteriListele_Load(object sender, EventArgs e)
        {
            YenidenLstele();
        }

        private void YenidenLstele()
        {
            string cümle = "select * from Müsteri";
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            dataGridView1.DataSource = AracKiralama.listele(adapter2, cümle);
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select * from Müsteri where Tc like '%"+textBox1.Text+"%' ";
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            dataGridView1.DataSource = AracKiralama.listele(adapter2, cümle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGuncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update Müsteri set Tc=@tc,AdSoyad=@adSoyad,Telefon=@telefon,Adres=@adres,Email=@email where ID=@id  ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@id", txtID.Text);
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@email", txtemail.Text);
            AracKiralama.ekle_sil_guncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenidenLstele();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
         
            txtAdSoyad.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttelefon.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text=dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtemail.Text=dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void txtSil_Click(object sender, EventArgs e)
        {
            string cümle = "delete from Müsteri  where ID=@id  ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@id", txtID.Text);
            AracKiralama.ekle_sil_guncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenidenLstele();
        }
    }
}
