namespace SenkronKafe
{
    partial class UrunlerForm
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
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.urunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(93, 41);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(116, 26);
            this.txtUrunAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Ad:";
            // 
            // nudBirimFiyat
            // 
            this.nudBirimFiyat.DecimalPlaces = 2;
            this.nudBirimFiyat.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nudBirimFiyat.Location = new System.Drawing.Point(342, 42);
            this.nudBirimFiyat.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudBirimFiyat.Name = "nudBirimFiyat";
            this.nudBirimFiyat.Size = new System.Drawing.Size(120, 26);
            this.nudBirimFiyat.TabIndex = 3;
            this.nudBirimFiyat.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birim Fiyat (₺):";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(468, 42);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(101, 28);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAd,
            this.urunFiyat});
            this.dgvUrunler.Location = new System.Drawing.Point(16, 86);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(553, 425);
            this.dgvUrunler.TabIndex = 6;
            // 
            // urunAd
            // 
            this.urunAd.DataPropertyName = "UrunAd";
            this.urunAd.HeaderText = "Ürün Adı";
            this.urunAd.Name = "urunAd";
            // 
            // urunFiyat
            // 
            this.urunFiyat.DataPropertyName = "BirimFiyat";
            this.urunFiyat.HeaderText = "Birim Fiyatı";
            this.urunFiyat.Name = "urunFiyat";
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(597, 545);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudBirimFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UrunlerForm";
            this.Text = "UrunlerForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudBirimFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyat;
        private System.Windows.Forms.DataGridView dgvUrunler;
    }
}