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
            this.btSimpan = new MetroFramework.Controls.MetroButton();
            this.btnSimpan = new MetroFramework.Controls.MetroButton();
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
            this.Tanggal});
            this.GridList.Location = new System.Drawing.Point(23, 116);
            this.GridList.Name = "GridList";
            this.GridList.Size = new System.Drawing.Size(735, 288);
            this.GridList.TabIndex = 1;
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
            this.btnSimpan.Location = new System.Drawing.Point(692, 74);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(66, 36);
            this.btnSimpan.TabIndex = 178;
            this.btnSimpan.Text = "Submit";
            this.btnSimpan.UseSelectable = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // TransGr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 427);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.GridList);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TransGr";
            this.Text = "GRPO";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.TransByrCicilan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridList;
        private MetroFramework.Controls.MetroButton btSimpan;
        private MetroFramework.Controls.MetroButton btnSimpan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkBxSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxKP;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxBerat;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxPembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
    }
}