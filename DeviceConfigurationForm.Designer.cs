namespace SRS.DeskApp
{
    partial class DeviceConfigurationForm
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
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tbNamaPerangkat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbAlamatIP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbLokasiPerangkat = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbIdPosisi = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btSimpan = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(43, 147);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(108, 19);
            this.metroLabel10.TabIndex = 115;
            this.metroLabel10.Text = "Nama Perangkat";
            // 
            // tbNamaPerangkat
            // 
            this.tbNamaPerangkat.BackColor = System.Drawing.Color.White;
            this.tbNamaPerangkat.Lines = new string[] {
        " "};
            this.tbNamaPerangkat.Location = new System.Drawing.Point(190, 143);
            this.tbNamaPerangkat.MaxLength = 32767;
            this.tbNamaPerangkat.Name = "tbNamaPerangkat";
            this.tbNamaPerangkat.PasswordChar = '\0';
            this.tbNamaPerangkat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNamaPerangkat.SelectedText = "";
            this.tbNamaPerangkat.Size = new System.Drawing.Size(200, 23);
            this.tbNamaPerangkat.TabIndex = 114;
            this.tbNamaPerangkat.Text = " ";
            this.tbNamaPerangkat.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 189);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 117;
            this.metroLabel1.Text = "Alamat IP";
            // 
            // tbAlamatIP
            // 
            this.tbAlamatIP.BackColor = System.Drawing.Color.White;
            this.tbAlamatIP.Lines = new string[] {
        " "};
            this.tbAlamatIP.Location = new System.Drawing.Point(190, 185);
            this.tbAlamatIP.MaxLength = 32767;
            this.tbAlamatIP.Name = "tbAlamatIP";
            this.tbAlamatIP.PasswordChar = '\0';
            this.tbAlamatIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAlamatIP.SelectedText = "";
            this.tbAlamatIP.Size = new System.Drawing.Size(200, 23);
            this.tbAlamatIP.TabIndex = 116;
            this.tbAlamatIP.Text = " ";
            this.tbAlamatIP.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(43, 304);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 119;
            this.metroLabel2.Text = "Identitas Posisi";
            // 
            // cbLokasiPerangkat
            // 
            this.cbLokasiPerangkat.FormattingEnabled = true;
            this.cbLokasiPerangkat.Items.AddRange(new object[] {
            "PENDAFTARAN",
            "TIMBANGAN IN",
            "CORE SAMPLING",
            "UNLOADING",
            "TIMBANGAN OUT"});
            this.cbLokasiPerangkat.Location = new System.Drawing.Point(190, 223);
            this.cbLokasiPerangkat.Name = "cbLokasiPerangkat";
            this.cbLokasiPerangkat.Size = new System.Drawing.Size(200, 21);
            this.cbLokasiPerangkat.TabIndex = 120;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(43, 225);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 19);
            this.metroLabel3.TabIndex = 121;
            this.metroLabel3.Text = "Lokasi Perangkat";
            // 
            // cbIdPosisi
            // 
            this.cbIdPosisi.FormattingEnabled = true;
            this.cbIdPosisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbIdPosisi.Location = new System.Drawing.Point(190, 304);
            this.cbIdPosisi.Name = "cbIdPosisi";
            this.cbIdPosisi.Size = new System.Drawing.Size(127, 21);
            this.cbIdPosisi.TabIndex = 122;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cbStatus.Location = new System.Drawing.Point(190, 266);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(127, 21);
            this.cbStatus.TabIndex = 124;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(43, 266);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 123;
            this.metroLabel4.Text = "Status";
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(244, 377);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(146, 41);
            this.btSimpan.TabIndex = 125;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseSelectable = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // DeviceConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 480);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbIdPosisi);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbLokasiPerangkat);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbAlamatIP);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.tbNamaPerangkat);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "DeviceConfigurationForm";
            this.Text = "Device Configuration Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.DeviceConfigurationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox tbNamaPerangkat;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbAlamatIP;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cbLokasiPerangkat;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox cbIdPosisi;
        private System.Windows.Forms.ComboBox cbStatus;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btSimpan;
    }
}