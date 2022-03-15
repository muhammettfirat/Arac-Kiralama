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
    public partial class frmAracListele : Form
    {
        Arac_Kiralama AracKiralama2 = new Arac_Kiralama();
        public frmAracListele()
        {
            InitializeComponent();
        }
        private void YenidenLstele()
        {
            string cümle = "select * from Arac";
            SqlDataAdapter adapter3 = new SqlDataAdapter();
            dataGridView1.DataSource = AracKiralama2.listele(adapter3, cümle);
        }
        private void frmAracListele_Load(object sender, EventArgs e)
        {
            YenidenLstele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select * from Arac where Plaka like '%" + textBox1.Text + "%' ";
            SqlDataAdapter adapter3 = new SqlDataAdapter();
            dataGridView1.DataSource = AracKiralama2.listele(adapter3, cümle);
        }

        private void txtSil_Click(object sender, EventArgs e)
        {
            string cümle = "delete from Arac  where ID=@id  ";
            SqlCommand komut4 = new SqlCommand();
            komut4.Parameters.AddWithValue("@id", txtID.Text);
            AracKiralama2.ekle_sil_guncelle(komut4, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenidenLstele();
        }

        private void txtGuncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update Arac set(Plaka=@plaka,Marka=@marka,Seri=@seri,Segment=@segment,Model=@model,Renk=@renk,Km=@km,Yakit=@yakit,KiraUcreti=@kiraUcreti,Durum=@durum,Resim=@resim where ID=@id ";
            SqlCommand komut4 = new SqlCommand();
            komut4.Parameters.AddWithValue("@id", txtID.Text);
            komut4.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut4.Parameters.AddWithValue("@marka", cmbxMarka.Text);
            komut4.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut4.Parameters.AddWithValue("@segment", cmbxSegment.Text);
            komut4.Parameters.AddWithValue("@model", txtModel.Text);
            komut4.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut4.Parameters.AddWithValue("@km", txtKm.Text);
            komut4.Parameters.AddWithValue("@yakit", cmbxYakıt.Text);
            komut4.Parameters.AddWithValue("@kiraUcreti", txtKiraUcreti.Text);
            komut4.Parameters.AddWithValue("@durum", cbxDurum.Text);
            komut4.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            AracKiralama2.ekle_sil_guncelle(komut4, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenidenLstele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            cmbxMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSeri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbxSegment.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtKm.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

           cmbxYakıt.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtKiraUcreti.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cbxDurum.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            pictureBox1.ImageLocation= dataGridView1.CurrentRow.Cells[11].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
