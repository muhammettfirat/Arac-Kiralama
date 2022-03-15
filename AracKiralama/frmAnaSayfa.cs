using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMüsteriEkle frmMüsteriEkle = new frmMüsteriEkle();
            frmMüsteriEkle.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMüsteriListele listele = new frmMüsteriListele();
            listele.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAracKayıt frmAracKayıt = new frmAracKayıt();
            frmAracKayıt.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAracListele frmAracListele = new frmAracListele();
            frmAracListele.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSözlesme frmSözlesme = new frmSözlesme();
            frmSözlesme.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSatis frmSatis = new frmSatis();
            frmSatis.ShowDialog(this);
        }
    }
}
