
namespace AracKiralama
{
    partial class frmAracListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracListele));
            this.txtSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtGuncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbxSegment = new System.Windows.Forms.ComboBox();
            this.cmbxMarka = new System.Windows.Forms.ComboBox();
            this.cmbxYakıt = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtKiraUcreti = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSil
            // 
            this.txtSil.BackColor = System.Drawing.Color.Coral;
            this.txtSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSil.ImageKey = "1814090_delete_garbage_trash_icon.png";
            this.txtSil.ImageList = this.ımageList1;
            this.txtSil.Location = new System.Drawing.Point(133, 339);
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(87, 32);
            this.txtSil.TabIndex = 33;
            this.txtSil.Text = "Sil";
            this.txtSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtSil.UseVisualStyleBackColor = false;
            this.txtSil.Click += new System.EventHandler(this.txtSil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "3688460_pencil_text_update_write_draw_icon.png");
            this.ımageList1.Images.SetKeyName(1, "1814090_delete_garbage_trash_icon.png");
            this.ımageList1.Images.SetKeyName(2, "1894664_cancel_close_cross_delete_exit_icon.png");
            this.ımageList1.Images.SetKeyName(3, "808604_files_inbox_reply_return_icon.png");
            // 
            // txtGuncelle
            // 
            this.txtGuncelle.BackColor = System.Drawing.Color.Cyan;
            this.txtGuncelle.ForeColor = System.Drawing.Color.Black;
            this.txtGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtGuncelle.ImageKey = "3688460_pencil_text_update_write_draw_icon.png";
            this.txtGuncelle.ImageList = this.ımageList1;
            this.txtGuncelle.Location = new System.Drawing.Point(35, 339);
            this.txtGuncelle.Name = "txtGuncelle";
            this.txtGuncelle.Size = new System.Drawing.Size(87, 32);
            this.txtGuncelle.TabIndex = 31;
            this.txtGuncelle.Text = "Güncelle";
            this.txtGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtGuncelle.UseVisualStyleBackColor = false;
            this.txtGuncelle.Click += new System.EventHandler(this.txtGuncelle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "1894664_cancel_close_cross_delete_exit_icon.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(237, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "İptal";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(716, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Plaka ARA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(790, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1373, 389);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmbxSegment
            // 
            this.cmbxSegment.FormattingEnabled = true;
            this.cmbxSegment.Items.AddRange(new object[] {
            "Şehir Otomobilleri (A)",
            "Küçük Otomobiller (B)",
            "Kompakt Otomobiller ( C )",
            "Orta Sınıf Otomobiller (D)",
            "Orta Üst Sınıf Otomobiller ( E )",
            "Lüks Sınıf Otomobiller (F)",
            "SUV Segmentleri",
            "MPV Otomobiller (M)",
            "Spor Otomobiller (S)"});
            this.cmbxSegment.Location = new System.Drawing.Point(149, 137);
            this.cmbxSegment.Name = "cmbxSegment";
            this.cmbxSegment.Size = new System.Drawing.Size(154, 21);
            this.cmbxSegment.TabIndex = 53;
            // 
            // cmbxMarka
            // 
            this.cmbxMarka.FormattingEnabled = true;
            this.cmbxMarka.Items.AddRange(new object[] {
            "Alfa Romeo",
            "Alfa Romeo",
            "Aston Martin",
            "Aston Martin",
            "Audi",
            "Audi",
            "Bentley",
            "Bentley",
            "BMW",
            "BMW",
            "Bugatti",
            "Bugatti",
            "Buick",
            "Buick",
            "Cadillac",
            "Cadillac",
            "Chery",
            "Chery",
            "Chevrolet",
            "Chevrolet",
            "Chrysler",
            "Chrysler",
            "Citroen",
            "Citroen",
            "Dacia",
            "Dacia",
            "Daewoo",
            "Daewoo",
            "Daihatsu",
            "Daihatsu",
            "Dodge",
            "Dodge",
            "Ferrari",
            "Ferrari",
            "Fiat",
            "Fiat",
            "Ford",
            "Ford",
            "Geely",
            "Geely",
            "Honda",
            "Honda",
            "Hyundai",
            "Hyundai",
            "Infiniti",
            "Infiniti",
            "Isuzu",
            "Isuzu",
            "Iveco",
            "Iveco",
            "Jaguar",
            "Jaguar",
            "Jeep",
            "Jeep",
            "Kia",
            "Kia",
            "Lada",
            "Lada",
            "Lamborghini",
            "Lamborghini",
            "Lancia",
            "Lancia",
            "Land-rover",
            "Land-rover",
            "Lexus",
            "Lexus",
            "Lincoln",
            "Lincoln",
            "Lotus",
            "Lotus",
            "Maserati",
            "Maserati",
            "Mazda",
            "Mazda",
            "McLaren",
            "McLaren",
            "Mercedes-Benz",
            "Mercedes-Benz",
            "Mini",
            "Mini",
            "Mitsubishi",
            "Mitsubishi",
            "Nissan",
            "Nissan",
            "Opel",
            "Opel",
            "Peugeot",
            "Peugeot",
            "Porsche",
            "Porsche",
            "Proton",
            "Proton",
            "Renault",
            "Renault",
            "Rolls Royce",
            "Rolls Royce",
            "Rover",
            "Rover",
            "Saab",
            "Saab",
            "Seat",
            "Seat",
            "Skoda",
            "Skoda",
            "Smart",
            "Smart",
            "Ssangyong",
            "Ssangyong",
            "Subaru",
            "Subaru",
            "Suzuki",
            "Suzuki",
            "Tata",
            "Tata",
            "Tofaş",
            "Tofaş",
            "Toyota",
            "Toyota",
            "Volkswagen",
            "Volkswagen",
            "Volvo",
            "Volvo"});
            this.cmbxMarka.Location = new System.Drawing.Point(149, 84);
            this.cmbxMarka.Name = "cmbxMarka";
            this.cmbxMarka.Size = new System.Drawing.Size(154, 21);
            this.cmbxMarka.TabIndex = 52;
            // 
            // cmbxYakıt
            // 
            this.cmbxYakıt.FormattingEnabled = true;
            this.cmbxYakıt.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+Lpg",
            "Hibrid",
            "Electric"});
            this.cmbxYakıt.Location = new System.Drawing.Point(149, 242);
            this.cmbxYakıt.Name = "cmbxYakıt";
            this.cmbxYakıt.Size = new System.Drawing.Size(154, 21);
            this.cmbxYakıt.TabIndex = 51;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "808604_files_inbox_reply_return_icon.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(339, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 24);
            this.button3.TabIndex = 49;
            this.button3.Text = "Resim Ekle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Kira Ücreti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Yakıt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Km";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Renk";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Seri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Model(YIL)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Segment";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "Marka";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 48;
            this.label16.Text = "Plaka";
            // 
            // txtKiraUcreti
            // 
            this.txtKiraUcreti.Location = new System.Drawing.Point(150, 270);
            this.txtKiraUcreti.Name = "txtKiraUcreti";
            this.txtKiraUcreti.Size = new System.Drawing.Size(154, 20);
            this.txtKiraUcreti.TabIndex = 36;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(149, 216);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(154, 20);
            this.txtKm.TabIndex = 35;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(149, 190);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(154, 20);
            this.txtRenk.TabIndex = 34;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(149, 111);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(154, 20);
            this.txtSeri.TabIndex = 37;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(149, 164);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(154, 20);
            this.txtModel.TabIndex = 38;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(149, 59);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(154, 20);
            this.txtPlaka.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(339, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(147, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(154, 20);
            this.txtID.TabIndex = 39;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(11, 34);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 48;
            this.ID.Text = "ID";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Durum";
            // 
            // cbxDurum
            // 
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "Dolu",
            "Boş"});
            this.cbxDurum.Location = new System.Drawing.Point(150, 303);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(153, 21);
            this.cbxDurum.TabIndex = 54;
            // 
            // frmAracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::AracKiralama.Properties.Resources.Fırat;
            this.ClientSize = new System.Drawing.Size(1401, 854);
            this.Controls.Add(this.cbxDurum);
            this.Controls.Add(this.cmbxSegment);
            this.Controls.Add(this.cmbxMarka);
            this.Controls.Add(this.cmbxYakıt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtKiraUcreti);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtSeri);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtSil);
            this.Controls.Add(this.txtGuncelle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmAracListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAracListele";
            this.Load += new System.EventHandler(this.frmAracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtSil;
        private System.Windows.Forms.Button txtGuncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbxSegment;
        private System.Windows.Forms.ComboBox cmbxMarka;
        private System.Windows.Forms.ComboBox cmbxYakıt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtKiraUcreti;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDurum;
    }
}