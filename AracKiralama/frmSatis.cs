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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        Arac_Kiralama arac = new Arac_Kiralama();

        private void frmSatis_Load(object sender, EventArgs e)
        {
            
            string sorgu2 = "select * from Satis";
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adapter2,sorgu2);
            arac.SatisHesapla(label1);
        }
    }
}
