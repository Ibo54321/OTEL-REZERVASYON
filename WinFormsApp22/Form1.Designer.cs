namespace WinFormsApp22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox3 = new GroupBox();
            txtGun = new TextBox();
            txtAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rdSuit = new RadioButton();
            rdCiftKisi = new RadioButton();
            rdTekKisi = new RadioButton();
            txtOdaFiyati = new TextBox();
            groupBox1 = new GroupBox();
            chkRehber = new CheckBox();
            chkHavalamani = new CheckBox();
            chkYatak = new CheckBox();
            txtHizmetUcreti = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnHesapla = new Button();
            listBox1 = new ListBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtGun);
            groupBox3.Controls.Add(txtAd);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(32, 50);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(351, 159);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pezervasyon Bilgileri";
            // 
            // txtGun
            // 
            txtGun.Location = new Point(111, 107);
            txtGun.Name = "txtGun";
            txtGun.Size = new Size(125, 27);
            txtGun.TabIndex = 11;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(111, 48);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 110);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 9;
            label2.Text = "Gün Sayısı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 51);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 8;
            label1.Text = "Ad Soyad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdSuit);
            groupBox2.Controls.Add(rdCiftKisi);
            groupBox2.Controls.Add(rdTekKisi);
            groupBox2.Location = new Point(559, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(173, 178);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Oda seçimi";
            // 
            // rdSuit
            // 
            rdSuit.AutoSize = true;
            rdSuit.Location = new Point(24, 138);
            rdSuit.Name = "rdSuit";
            rdSuit.Size = new Size(55, 24);
            rdSuit.TabIndex = 2;
            rdSuit.TabStop = true;
            rdSuit.Text = "Suit";
            rdSuit.UseVisualStyleBackColor = true;
            // 
            // rdCiftKisi
            // 
            rdCiftKisi.AutoSize = true;
            rdCiftKisi.Location = new Point(22, 94);
            rdCiftKisi.Name = "rdCiftKisi";
            rdCiftKisi.Size = new Size(93, 24);
            rdCiftKisi.TabIndex = 1;
            rdCiftKisi.TabStop = true;
            rdCiftKisi.Text = "Çift kişilik";
            rdCiftKisi.UseVisualStyleBackColor = true;
            rdCiftKisi.CheckedChanged += rdCiftKisi_CheckedChanged;
            // 
            // rdTekKisi
            // 
            rdTekKisi.AutoSize = true;
            rdTekKisi.Location = new Point(22, 45);
            rdTekKisi.Name = "rdTekKisi";
            rdTekKisi.Size = new Size(94, 24);
            rdTekKisi.TabIndex = 0;
            rdTekKisi.TabStop = true;
            rdTekKisi.Text = "Tek Kişilik";
            rdTekKisi.UseVisualStyleBackColor = true;
            rdTekKisi.CheckedChanged += rdTekKisi_CheckedChanged;
            // 
            // txtOdaFiyati
            // 
            txtOdaFiyati.Location = new Point(607, 245);
            txtOdaFiyati.Name = "txtOdaFiyati";
            txtOdaFiyati.Size = new Size(125, 27);
            txtOdaFiyati.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkRehber);
            groupBox1.Controls.Add(chkHavalamani);
            groupBox1.Controls.Add(chkYatak);
            groupBox1.Location = new Point(26, 271);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 79);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ek Hizmetler";
            // 
            // chkRehber
            // 
            chkRehber.AutoSize = true;
            chkRehber.Location = new Point(297, 27);
            chkRehber.Name = "chkRehber";
            chkRehber.Size = new Size(78, 24);
            chkRehber.TabIndex = 15;
            chkRehber.Text = "Rehber";
            chkRehber.UseVisualStyleBackColor = true;
            chkRehber.CheckedChanged += chkRehber_CheckedChanged;
            // 
            // chkHavalamani
            // 
            chkHavalamani.AutoSize = true;
            chkHavalamani.Location = new Point(125, 27);
            chkHavalamani.Name = "chkHavalamani";
            chkHavalamani.Size = new Size(166, 24);
            chkHavalamani.TabIndex = 14;
            chkHavalamani.Text = "Havalimani Transferi";
            chkHavalamani.UseVisualStyleBackColor = true;
            chkHavalamani.CheckedChanged += chkHavalamani_CheckedChanged;
            // 
            // chkYatak
            // 
            chkYatak.AutoSize = true;
            chkYatak.Location = new Point(6, 26);
            chkYatak.Name = "chkYatak";
            chkYatak.Size = new Size(85, 24);
            chkYatak.TabIndex = 13;
            chkYatak.Text = "Ek Yatak";
            chkYatak.UseVisualStyleBackColor = true;
            chkYatak.CheckedChanged += chkYatak_CheckedChanged;
            // 
            // txtHizmetUcreti
            // 
            txtHizmetUcreti.Location = new Point(631, 302);
            txtHizmetUcreti.Name = "txtHizmetUcreti";
            txtHizmetUcreti.Size = new Size(82, 27);
            txtHizmetUcreti.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(503, 309);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 16;
            label4.Text = "Ek Hizmet Ücreti:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 245);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 15;
            label3.Text = "Oda Fiyati:";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(618, 374);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(135, 29);
            btnHesapla.TabIndex = 13;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalExtent = 1000;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(26, 421);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(797, 104);
            listBox1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 568);
            Controls.Add(listBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(txtOdaFiyati);
            Controls.Add(groupBox1);
            Controls.Add(txtHizmetUcreti);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnHesapla);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox txtGun;
        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rdSuit;
        private RadioButton rdCiftKisi;
        private RadioButton rdTekKisi;
        private TextBox txtOdaFiyati;
        private GroupBox groupBox1;
        private CheckBox chkRehber;
        private CheckBox chkHavalamani;
        private CheckBox chkYatak;
        private TextBox txtHizmetUcreti;
        private Label label4;
        private Label label3;
        private Button btnHesapla;
        private ListBox listBox1;
    }
}
