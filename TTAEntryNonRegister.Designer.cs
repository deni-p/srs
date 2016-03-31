namespace SRS.DeskApp
{
    partial class TTAEntryNonRegister
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tbAlamatKTP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel33 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel32 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel31 = new MetroFramework.Controls.MetroLabel();
            this.tbNamaMitra = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tbKodeMitra = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbKelurahan = new MetroFramework.Controls.MetroComboBox();
            this.cbKecamatan = new MetroFramework.Controls.MetroComboBox();
            this.cbKabupaten = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(135, 346);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 36);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Simpan";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tbAlamatKTP
            // 
            this.tbAlamatKTP.Lines = new string[0];
            this.tbAlamatKTP.Location = new System.Drawing.Point(135, 248);
            this.tbAlamatKTP.MaxLength = 32767;
            this.tbAlamatKTP.Multiline = true;
            this.tbAlamatKTP.Name = "tbAlamatKTP";
            this.tbAlamatKTP.PasswordChar = '\0';
            this.tbAlamatKTP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAlamatKTP.SelectedText = "";
            this.tbAlamatKTP.Size = new System.Drawing.Size(254, 81);
            this.tbAlamatKTP.TabIndex = 6;
            this.tbAlamatKTP.UseCustomBackColor = true;
            this.tbAlamatKTP.UseSelectable = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(25, 248);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(77, 19);
            this.metroLabel17.TabIndex = 72;
            this.metroLabel17.Text = "Alamat KTP";
            // 
            // metroLabel33
            // 
            this.metroLabel33.AutoSize = true;
            this.metroLabel33.Location = new System.Drawing.Point(25, 145);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(71, 19);
            this.metroLabel33.TabIndex = 70;
            this.metroLabel33.Text = "Kabupaten";
            // 
            // metroLabel32
            // 
            this.metroLabel32.AutoSize = true;
            this.metroLabel32.Location = new System.Drawing.Point(23, 178);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(73, 19);
            this.metroLabel32.TabIndex = 68;
            this.metroLabel32.Text = "Kecamatan";
            // 
            // metroLabel31
            // 
            this.metroLabel31.AutoSize = true;
            this.metroLabel31.Location = new System.Drawing.Point(23, 213);
            this.metroLabel31.Name = "metroLabel31";
            this.metroLabel31.Size = new System.Drawing.Size(66, 19);
            this.metroLabel31.TabIndex = 66;
            this.metroLabel31.Text = "Kelurahan";
            // 
            // tbNamaMitra
            // 
            this.tbNamaMitra.Lines = new string[0];
            this.tbNamaMitra.Location = new System.Drawing.Point(135, 114);
            this.tbNamaMitra.MaxLength = 32767;
            this.tbNamaMitra.Name = "tbNamaMitra";
            this.tbNamaMitra.PasswordChar = '\0';
            this.tbNamaMitra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNamaMitra.SelectedText = "";
            this.tbNamaMitra.Size = new System.Drawing.Size(200, 23);
            this.tbNamaMitra.TabIndex = 2;
            this.tbNamaMitra.UseCustomBackColor = true;
            this.tbNamaMitra.UseSelectable = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(25, 116);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(80, 19);
            this.metroLabel13.TabIndex = 29;
            this.metroLabel13.Text = "Nama Mitra";
            // 
            // tbKodeMitra
            // 
            this.tbKodeMitra.Lines = new string[0];
            this.tbKodeMitra.Location = new System.Drawing.Point(135, 85);
            this.tbKodeMitra.MaxLength = 32767;
            this.tbKodeMitra.Name = "tbKodeMitra";
            this.tbKodeMitra.PasswordChar = '\0';
            this.tbKodeMitra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKodeMitra.SelectedText = "";
            this.tbKodeMitra.Size = new System.Drawing.Size(200, 23);
            this.tbKodeMitra.TabIndex = 1;
            this.tbKodeMitra.UseCustomBackColor = true;
            this.tbKodeMitra.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(25, 87);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(74, 19);
            this.metroLabel12.TabIndex = 27;
            this.metroLabel12.Text = "Kode Mitra";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbKelurahan
            // 
            this.cbKelurahan.FormattingEnabled = true;
            this.cbKelurahan.ItemHeight = 23;
            this.cbKelurahan.Location = new System.Drawing.Point(135, 213);
            this.cbKelurahan.Name = "cbKelurahan";
            this.cbKelurahan.Size = new System.Drawing.Size(200, 29);
            this.cbKelurahan.TabIndex = 97;
            this.cbKelurahan.UseSelectable = true;
            // 
            // cbKecamatan
            // 
            this.cbKecamatan.FormattingEnabled = true;
            this.cbKecamatan.ItemHeight = 23;
            this.cbKecamatan.Location = new System.Drawing.Point(135, 178);
            this.cbKecamatan.Name = "cbKecamatan";
            this.cbKecamatan.Size = new System.Drawing.Size(200, 29);
            this.cbKecamatan.TabIndex = 96;
            this.cbKecamatan.UseSelectable = true;
            this.cbKecamatan.SelectedIndexChanged += new System.EventHandler(this.cbKecamatan_SelectedIndexChanged);
            // 
            // cbKabupaten
            // 
            this.cbKabupaten.FormattingEnabled = true;
            this.cbKabupaten.ItemHeight = 23;
            this.cbKabupaten.Location = new System.Drawing.Point(135, 143);
            this.cbKabupaten.Name = "cbKabupaten";
            this.cbKabupaten.Size = new System.Drawing.Size(200, 29);
            this.cbKabupaten.TabIndex = 95;
            this.cbKabupaten.UseSelectable = true;
            this.cbKabupaten.SelectedIndexChanged += new System.EventHandler(this.cbKabupaten_SelectedIndexChanged);
            // 
            // TTAEntryNonRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 396);
            this.Controls.Add(this.cbKelurahan);
            this.Controls.Add(this.cbKecamatan);
            this.Controls.Add(this.cbKabupaten);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tbAlamatKTP);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroLabel33);
            this.Controls.Add(this.metroLabel32);
            this.Controls.Add(this.metroLabel31);
            this.Controls.Add(this.tbNamaMitra);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.tbKodeMitra);
            this.Controls.Add(this.metroLabel12);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TTAEntryNonRegister";
            this.Text = "Entry Petani Non Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.TTAEntryNonRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbNamaMitra;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox tbKodeMitra;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel33;
        private MetroFramework.Controls.MetroLabel metroLabel32;
        private MetroFramework.Controls.MetroLabel metroLabel31;
        private MetroFramework.Controls.MetroTextBox tbAlamatKTP;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroComboBox cbKelurahan;
        private MetroFramework.Controls.MetroComboBox cbKecamatan;
        private MetroFramework.Controls.MetroComboBox cbKabupaten;
    }
}