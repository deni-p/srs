namespace SRS.DeskApp
{
    partial class TransGr
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
            this.GridList = new System.Windows.Forms.DataGridView();
            this.chkBxSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBxBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxKP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxBerat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxPembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSimpan = new MetroFramework.Controls.MetroButton();
            this.btnSimpan = new MetroFramework.Controls.MetroButton();
            this.rdNonKKPE = new MetroFramework.Controls.MetroRadioButton();
            this.rdKKPE = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).BeginInit();
            this.SuspendLayout();
            // 
            // GridList
            // 
            this.GridList.AllowUserToAddRows = false;
            this.GridList.AllowUserToDeleteRows = false;
            this.GridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkBxSelect,
            this.txtBxBE,
            this.txtBxKP,
            this.txtBxNM,
            this.txtBxBerat,
            this.txtBxPembayaran,
            this.Tanggal,
            this.invoice,
            this.jenis});
            this.GridList.Location = new System.Drawing.Point(23, 116);
            this.GridList.Name = "GridList";
            this.GridList.Size = new System.Drawing.Size(798, 350);
            this.GridList.TabIndex = 1;
            this.GridList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridList_CellFormatting);
            // 
            // chkBxSelect
            // 
            this.chkBxSelect.DataPropertyName = "IsChecked";
            this.chkBxSelect.HeaderText = "";
            this.chkBxSelect.Name = "chkBxSelect";
            this.chkBxSelect.Width = 50;
            // 
            // txtBxBE
            // 
            this.txtBxBE.DataPropertyName = "BASE";
            this.txtBxBE.HeaderText = "Base Entry";
            this.txtBxBE.Name = "txtBxBE";
            this.txtBxBE.ReadOnly = true;
            // 
            // txtBxKP
            // 
            this.txtBxKP.DataPropertyName = "KODE";
            this.txtBxKP.HeaderText = "Kode Petani";
            this.txtBxKP.Name = "txtBxKP";
            this.txtBxKP.ReadOnly = true;
            // 
            // txtBxNM
            // 
            this.txtBxNM.DataPropertyName = "NAMA";
            this.txtBxNM.HeaderText = "Nama";
            this.txtBxNM.Name = "txtBxNM";
            this.txtBxNM.ReadOnly = true;
            // 
            // txtBxBerat
            // 
            this.txtBxBerat.DataPropertyName = "BERAT";
            this.txtBxBerat.HeaderText = "Berat";
            this.txtBxBerat.Name = "txtBxBerat";
            this.txtBxBerat.ReadOnly = true;
            // 
            // txtBxPembayaran
            // 
            this.txtBxPembayaran.DataPropertyName = "PEMBAYARAN";
            this.txtBxPembayaran.HeaderText = "Pembayaran";
            this.txtBxPembayaran.Name = "txtBxPembayaran";
            this.txtBxPembayaran.ReadOnly = true;
            // 
            // Tanggal
            // 
            this.Tanggal.DataPropertyName = "TANGGAL";
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.Name = "Tanggal";
            // 
            // invoice
            // 
            this.invoice.DataPropertyName = "INVOICE";
            this.invoice.HeaderText = "Invoice";
            this.invoice.Name = "invoice";
            // 
            // jenis
            // 
            this.jenis.DataPropertyName = "JENIS";
            this.jenis.HeaderText = "Jenis Mitra";
            this.jenis.Name = "jenis";
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(0, 0);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 0;
            this.btSimpan.UseSelectable = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(726, 74);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(95, 36);
            this.btnSimpan.TabIndex = 178;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseSelectable = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // rdNonKKPE
            // 
            this.rdNonKKPE.AutoSize = true;
            this.rdNonKKPE.Location = new System.Drawing.Point(95, 77);
            this.rdNonKKPE.Name = "rdNonKKPE";
            this.rdNonKKPE.Size = new System.Drawing.Size(76, 15);
            this.rdNonKKPE.TabIndex = 186;
            this.rdNonKKPE.Text = "Non KKPE";
            this.rdNonKKPE.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdNonKKPE.UseSelectable = true;
            this.rdNonKKPE.Visible = false;
            // 
            // rdKKPE
            // 
            this.rdKKPE.AutoSize = true;
            this.rdKKPE.Checked = true;
            this.rdKKPE.Location = new System.Drawing.Point(23, 77);
            this.rdKKPE.Name = "rdKKPE";
            this.rdKKPE.Size = new System.Drawing.Size(50, 15);
            this.rdKKPE.TabIndex = 185;
            this.rdKKPE.TabStop = true;
            this.rdKKPE.Text = "KKPE";
            this.rdKKPE.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdKKPE.UseSelectable = true;
            this.rdKKPE.Visible = false;
            // 
            // TransGr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 515);
            this.Controls.Add(this.rdNonKKPE);
            this.Controls.Add(this.rdKKPE);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.GridList);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TransGr";
            this.Text = "Transaksi Pembayaran ";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.TransByrCicilan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridList;
        private MetroFramework.Controls.MetroButton btSimpan;
        private MetroFramework.Controls.MetroButton btnSimpan;
        private MetroFramework.Controls.MetroRadioButton rdNonKKPE;
        private MetroFramework.Controls.MetroRadioButton rdKKPE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkBxSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxKP;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxBerat;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxPembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis;
    }
}