namespace SenkronKafe
{
    partial class SiparisDetayForm
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
            this.dgvSiparisDetay = new System.Windows.Forms.DataGridView();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudUrunAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnSiparisİptal = new System.Windows.Forms.Button();
            this.btnHesabiKapat = new System.Windows.Forms.Button();
            this.btnAnasayfayaDon = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.btnMasaTasi = new System.Windows.Forms.Button();
            this.cboMasaTasiHedef = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisDetay
            // 
            this.dgvSiparisDetay.AllowUserToAddRows = false;
            this.dgvSiparisDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetay.Location = new System.Drawing.Point(12, 56);
            this.dgvSiparisDetay.Name = "dgvSiparisDetay";
            this.dgvSiparisDetay.RowTemplate.Height = 24;
            this.dgvSiparisDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetay.Size = new System.Drawing.Size(516, 494);
            this.dgvSiparisDetay.TabIndex = 0;
            this.dgvSiparisDetay.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvSiparisDetay_UserDeletedRow);
            // 
            // cboUrun
            // 
            this.cboUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(67, 19);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(157, 28);
            this.cboUrun.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün :";
            // 
            // nudUrunAdet
            // 
            this.nudUrunAdet.Location = new System.Drawing.Point(310, 20);
            this.nudUrunAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUrunAdet.Name = "nudUrunAdet";
            this.nudUrunAdet.Size = new System.Drawing.Size(110, 26);
            this.nudUrunAdet.TabIndex = 3;
            this.nudUrunAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adet :";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(432, 17);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(96, 33);
            this.btnUrunEkle.TabIndex = 5;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // btnSiparisİptal
            // 
            this.btnSiparisİptal.BackColor = System.Drawing.Color.Red;
            this.btnSiparisİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisİptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiparisİptal.Location = new System.Drawing.Point(534, 376);
            this.btnSiparisİptal.Name = "btnSiparisİptal";
            this.btnSiparisİptal.Size = new System.Drawing.Size(226, 83);
            this.btnSiparisİptal.TabIndex = 6;
            this.btnSiparisİptal.Text = "Sipariş İptal";
            this.btnSiparisİptal.UseVisualStyleBackColor = false;
            this.btnSiparisİptal.Click += new System.EventHandler(this.BtnSiparisİptal_Click);
            // 
            // btnHesabiKapat
            // 
            this.btnHesabiKapat.BackColor = System.Drawing.Color.DarkGreen;
            this.btnHesabiKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesabiKapat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHesabiKapat.Location = new System.Drawing.Point(766, 376);
            this.btnHesabiKapat.Name = "btnHesabiKapat";
            this.btnHesabiKapat.Size = new System.Drawing.Size(203, 83);
            this.btnHesabiKapat.TabIndex = 7;
            this.btnHesabiKapat.Text = "Hesabı Kapat";
            this.btnHesabiKapat.UseVisualStyleBackColor = false;
            this.btnHesabiKapat.Click += new System.EventHandler(this.BtnHesabiKapat_Click);
            // 
            // btnAnasayfayaDon
            // 
            this.btnAnasayfayaDon.BackColor = System.Drawing.Color.Teal;
            this.btnAnasayfayaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfayaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnasayfayaDon.Location = new System.Drawing.Point(534, 465);
            this.btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            this.btnAnasayfayaDon.Size = new System.Drawing.Size(435, 85);
            this.btnAnasayfayaDon.TabIndex = 8;
            this.btnAnasayfayaDon.Text = "← Anasayfaya Dön";
            this.btnAnasayfayaDon.UseVisualStyleBackColor = false;
            this.btnAnasayfayaDon.Click += new System.EventHandler(this.BtnAnasayfayaDon_Click);
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.BackColor = System.Drawing.Color.SandyBrown;
            this.lblMasaNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMasaNo.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 77F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.Color.MistyRose;
            this.lblMasaNo.Location = new System.Drawing.Point(622, 17);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(236, 216);
            this.lblMasaNo.TabIndex = 9;
            this.lblMasaNo.Text = "01";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(555, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ödeme Tutarı:";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.BackColor = System.Drawing.Color.LightBlue;
            this.lblOdemeTutari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTutari.ForeColor = System.Drawing.Color.Black;
            this.lblOdemeTutari.Location = new System.Drawing.Point(692, 284);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(160, 46);
            this.lblOdemeTutari.TabIndex = 11;
            this.lblOdemeTutari.Text = "00,00 ₺";
            // 
            // btnMasaTasi
            // 
            this.btnMasaTasi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMasaTasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaTasi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMasaTasi.Location = new System.Drawing.Point(876, 25);
            this.btnMasaTasi.Name = "btnMasaTasi";
            this.btnMasaTasi.Size = new System.Drawing.Size(85, 72);
            this.btnMasaTasi.TabIndex = 12;
            this.btnMasaTasi.Text = "↔";
            this.btnMasaTasi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMasaTasi.UseVisualStyleBackColor = false;
            this.btnMasaTasi.Click += new System.EventHandler(this.BtnMasaTasi_Click);
            // 
            // cboMasaTasiHedef
            // 
            this.cboMasaTasiHedef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasaTasiHedef.FormattingEnabled = true;
            this.cboMasaTasiHedef.Location = new System.Drawing.Point(967, 34);
            this.cboMasaTasiHedef.Name = "cboMasaTasiHedef";
            this.cboMasaTasiHedef.Size = new System.Drawing.Size(121, 28);
            this.cboMasaTasiHedef.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(877, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Masa Taşı :";
            // 
            // SiparisDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1099, 555);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMasaTasiHedef);
            this.Controls.Add(this.btnMasaTasi);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnAnasayfayaDon);
            this.Controls.Add(this.btnHesabiKapat);
            this.Controls.Add(this.btnSiparisİptal);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudUrunAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.dgvSiparisDetay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SiparisDetayForm";
            this.Text = "SiparisDetayForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisDetay;
        private System.Windows.Forms.ComboBox cboUrun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudUrunAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnSiparisİptal;
        private System.Windows.Forms.Button btnHesabiKapat;
        private System.Windows.Forms.Button btnAnasayfayaDon;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Button btnMasaTasi;
        private System.Windows.Forms.ComboBox cboMasaTasiHedef;
        private System.Windows.Forms.Label label3;
    }
}