namespace SRS.DeskApp
{
    partial class FrmTransGrPo
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
            this.btnSimpan = new MetroFramework.Controls.MetroButton();
            this.rdMandiri = new MetroFramework.Controls.MetroRadioButton();
            this.rdKKPE = new MetroFramework.Controls.MetroRadioButton();
            this.rdOwn = new MetroFramework.Controls.MetroRadioButton();
            this.dtTgl = new MetroFramework.Controls.MetroDateTime();
            this.rdAll = new MetroFramework.Controls.MetroRadioButton();
            this.GrdList = new System.Windows.Forms.DataGridView();
            this.chkBxSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_REK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RENDEMEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BERAT_BERSIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HARGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TANGGAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOC_ENTRY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(750, 91);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(96, 42);
            this.btnSimpan.TabIndex = 181;
            this.btnSimpan.Text = "Submit";
            this.btnSimpan.UseSelectable = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // rdMandiri
            // 
            this.rdMandiri.AutoSize = true;
            this.rdMandiri.Location = new System.Drawing.Point(334, 91);
            this.rdMandiri.Name = "rdMandiri";
            this.rdMandiri.Size = new System.Drawing.Size(64, 15);
            this.rdMandiri.TabIndex = 182;
            this.rdMandiri.Text = "Mandiri";
            this.rdMandiri.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdMandiri.UseSelectable = true;
            this.rdMandiri.Visible = false;
            this.rdMandiri.Click += new System.EventHandler(this.rdMandiri_Click);
            // 
            // rdKKPE
            // 
            this.rdKKPE.AutoSize = true;
            this.rdKKPE.Checked = true;
            this.rdKKPE.Location = new System.Drawing.Point(420, 91);
            this.rdKKPE.Name = "rdKKPE";
            this.rdKKPE.Size = new System.Drawing.Size(50, 15);
            this.rdKKPE.TabIndex = 183;
            this.rdKKPE.TabStop = true;
            this.rdKKPE.Text = "KKPE";
            this.rdKKPE.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdKKPE.UseSelectable = true;
            this.rdKKPE.Visible = false;
            this.rdKKPE.Click += new System.EventHandler(this.rdKKPE_Click);
            // 
            // rdOwn
            // 
            this.rdOwn.AutoSize = true;
            this.rdOwn.Location = new System.Drawing.Point(492, 91);
            this.rdOwn.Name = "rdOwn";
            this.rdOwn.Size = new System.Drawing.Size(48, 15);
            this.rdOwn.TabIndex = 184;
            this.rdOwn.Text = "Own";
            this.rdOwn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdOwn.UseSelectable = true;
            this.rdOwn.Visible = false;
            this.rdOwn.Click += new System.EventHandler(this.rdOwn_Click);
            // 
            // dtTgl
            // 
            this.dtTgl.Location = new System.Drawing.Point(45, 83);
            this.dtTgl.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTgl.Name = "dtTgl";
            this.dtTgl.Size = new System.Drawing.Size(200, 29);
            this.dtTgl.TabIndex = 185;
            this.dtTgl.Visible = false;
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Location = new System.Drawing.Point(275, 91);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(37, 15);
            this.rdAll.TabIndex = 186;
            this.rdAll.Text = "All";
            this.rdAll.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdAll.UseSelectable = true;
            this.rdAll.Visible = false;
            // 
            // GrdList
            // 
            this.GrdList.AllowUserToAddRows = false;
            this.GrdList.AllowUserToDeleteRows = false;
            this.GrdList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkBxSelect,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.NO_REK,
            this.RENDEMEN,
            this.BERAT_BERSIH,
            this.HARGA,
            this.TANGGAL,
            this.DOC_ENTRY});
            this.GrdList.Location = new System.Drawing.Point(45, 139);
            this.GrdList.MultiSelect = false;
            this.GrdList.Name = "GrdList";
            this.GrdList.Size = new System.Drawing.Size(801, 288);
            this.GrdList.TabIndex = 187;
            // 
            // chkBxSelect
            // 
            this.chkBxSelect.DataPropertyName = "IsChecked";
            this.chkBxSelect.Frozen = true;
            this.chkBxSelect.HeaderText = "";
            this.chkBxSelect.Name = "chkBxSelect";
            this.chkBxSelect.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BASE";
            this.dataGridViewTextBoxColumn1.HeaderText = "BASE ENTRY";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KODE";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Kode Mitra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NAMA";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // NO_REK
            // 
            this.NO_REK.DataPropertyName = "NO_REK";
            this.NO_REK.HeaderText = "No Rek";
            this.NO_REK.Name = "NO_REK";
            // 
            // RENDEMEN
            // 
            this.RENDEMEN.DataPropertyName = "RENDEMEN";
            this.RENDEMEN.HeaderText = "Rendemen";
            this.RENDEMEN.Name = "RENDEMEN";
            // 
            // BERAT_BERSIH
            // 
            this.BERAT_BERSIH.DataPropertyName = "BERAT_BERSIH";
            this.BERAT_BERSIH.HeaderText = "Berat Bersih";
            this.BERAT_BERSIH.Name = "BERAT_BERSIH";
            // 
            // HARGA
            // 
            this.HARGA.DataPropertyName = "HARGA";
            this.HARGA.HeaderText = "Harga";
            this.HARGA.Name = "HARGA";
            // 
            // TANGGAL
            // 
            this.TANGGAL.DataPropertyName = "TANGGAL";
            this.TANGGAL.HeaderText = "Tanggal";
            this.TANGGAL.Name = "TANGGAL";
            // 
            // DOC_ENTRY
            // 
            this.DOC_ENTRY.DataPropertyName = "DOC_ENTRY";
            this.DOC_ENTRY.HeaderText = "Doc Entry";
            this.DOC_ENTRY.Name = "DOC_ENTRY";
            this.DOC_ENTRY.Visible = false;
            // 
            // FrmTransGrPo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 473);
            this.Controls.Add(this.GrdList);
            this.Controls.Add(this.rdAll);
            this.Controls.Add(this.dtTgl);
            this.Controls.Add(this.rdOwn);
            this.Controls.Add(this.rdKKPE);
            this.Controls.Add(this.rdMandiri);
            this.Controls.Add(this.btnSimpan);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmTransGrPo";
            this.Text = "Transaksi Penerimaan Tebu";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.FrmTransGrPo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSimpan;
        private MetroFramework.Controls.MetroRadioButton rdMandiri;
        private MetroFramework.Controls.MetroRadioButton rdKKPE;
        private MetroFramework.Controls.MetroRadioButton rdOwn;
        private MetroFramework.Controls.MetroDateTime dtTgl;
        private MetroFramework.Controls.MetroRadioButton rdAll;
        private System.Windows.Forms.DataGridView GrdList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkBxSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_REK;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENDEMEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BERAT_BERSIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HARGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TANGGAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOC_ENTRY;
    }
}