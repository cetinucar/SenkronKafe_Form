namespace SenkronKafe
{
    partial class GecmisSiparislerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvGecmisSiparisler = new System.Windows.Forms.DataGridView();
            this.dgvSiparisDetaylari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geçmiş Siparişler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sipariş Detayları";
            // 
            // dgvGecmisSiparisler
            // 
            this.dgvGecmisSiparisler.AllowUserToAddRows = false;
            this.dgvGecmisSiparisler.AllowUserToDeleteRows = false;
            this.dgvGecmisSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGecmisSiparisler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGecmisSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecmisSiparisler.Location = new System.Drawing.Point(16, 32);
            this.dgvGecmisSiparisler.Name = "dgvGecmisSiparisler";
            this.dgvGecmisSiparisler.ReadOnly = true;
            this.dgvGecmisSiparisler.RowTemplate.Height = 24;
            this.dgvGecmisSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGecmisSiparisler.Size = new System.Drawing.Size(972, 271);
            this.dgvGecmisSiparisler.TabIndex = 2;
            this.dgvGecmisSiparisler.SelectionChanged += new System.EventHandler(this.DgvGecmisSiparisler_SelectionChanged);
            // 
            // dgvSiparisDetaylari
            // 
            this.dgvSiparisDetaylari.AllowUserToAddRows = false;
            this.dgvSiparisDetaylari.AllowUserToDeleteRows = false;
            this.dgvSiparisDetaylari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetaylari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylari.Location = new System.Drawing.Point(16, 335);
            this.dgvSiparisDetaylari.Name = "dgvSiparisDetaylari";
            this.dgvSiparisDetaylari.ReadOnly = true;
            this.dgvSiparisDetaylari.RowTemplate.Height = 24;
            this.dgvSiparisDetaylari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetaylari.Size = new System.Drawing.Size(972, 265);
            this.dgvSiparisDetaylari.TabIndex = 3;
            // 
            // GecmisSiparislerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1000, 612);
            this.Controls.Add(this.dgvSiparisDetaylari);
            this.Controls.Add(this.dgvGecmisSiparisler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GecmisSiparislerForm";
            this.Text = "GecmisSiparislerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvGecmisSiparisler;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylari;
    }
}