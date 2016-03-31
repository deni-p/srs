namespace SRS.DeskApp
{
    partial class TimbanganInManualForm
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
            this.lbLine = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbNoTTA = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbDriver = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btSimpan = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbNoMobil = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbBeratKotor = new SRS.DeskApp.NumericTextBox();
            this.btnSerchTTA = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.btnPlayCam = new MetroFramework.Controls.MetroButton();
            this.btnStopCam = new MetroFramework.Controls.MetroButton();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbLine.Location = new System.Drawing.Point(130, 70);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(0, 0);
            this.lbLine.TabIndex = 49;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 70);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 19);
            this.metroLabel5.TabIndex = 48;
            this.metroLabel5.Text = "LINE";
            // 
            // tbNoTTA
            // 
            this.tbNoTTA.Lines = new string[0];
            this.tbNoTTA.Location = new System.Drawing.Point(130, 107);
            this.tbNoTTA.MaxLength = 32767;
            this.tbNoTTA.Name = "tbNoTTA";
            this.tbNoTTA.PasswordChar = '\0';
            this.tbNoTTA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoTTA.SelectedText = "";
            this.tbNoTTA.Size = new System.Drawing.Size(119, 23);
            this.tbNoTTA.TabIndex = 1;
            this.tbNoTTA.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 111);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 46;
            this.metroLabel4.Text = "No TTA";
            // 
            // tbDriver
            // 
            this.tbDriver.Enabled = false;
            this.tbDriver.Lines = new string[0];
            this.tbDriver.Location = new System.Drawing.Point(130, 165);
            this.tbDriver.MaxLength = 32767;
            this.tbDriver.Name = "tbDriver";
            this.tbDriver.PasswordChar = '\0';
            this.tbDriver.ReadOnly = true;
            this.tbDriver.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDriver.SelectedText = "";
            this.tbDriver.Size = new System.Drawing.Size(213, 23);
            this.tbDriver.TabIndex = 3;
            this.tbDriver.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "Driver";
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(130, 269);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(109, 36);
            this.btSimpan.TabIndex = 5;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseSelectable = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 198);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Berat Kotor";
            // 
            // tbNoMobil
            // 
            this.tbNoMobil.Enabled = false;
            this.tbNoMobil.Lines = new string[0];
            this.tbNoMobil.Location = new System.Drawing.Point(130, 136);
            this.tbNoMobil.MaxLength = 32767;
            this.tbNoMobil.Name = "tbNoMobil";
            this.tbNoMobil.PasswordChar = '\0';
            this.tbNoMobil.ReadOnly = true;
            this.tbNoMobil.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoMobil.SelectedText = "";
            this.tbNoMobil.Size = new System.Drawing.Size(213, 23);
            this.tbNoMobil.TabIndex = 2;
            this.tbNoMobil.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 140);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nomor Mobil ";
            // 
            // tbBeratKotor
            // 
            this.tbBeratKotor.AllowSpace = false;
            this.tbBeratKotor.BackColor = System.Drawing.SystemColors.Control;
            this.tbBeratKotor.Location = new System.Drawing.Point(130, 194);
            this.tbBeratKotor.MaxLength = 10;
            this.tbBeratKotor.Name = "tbBeratKotor";
            this.tbBeratKotor.Size = new System.Drawing.Size(119, 20);
            this.tbBeratKotor.TabIndex = 4;
            this.tbBeratKotor.Text = "0";
            this.tbBeratKotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSerchTTA
            // 
            this.btnSerchTTA.Location = new System.Drawing.Point(255, 107);
            this.btnSerchTTA.Name = "btnSerchTTA";
            this.btnSerchTTA.Size = new System.Drawing.Size(88, 23);
            this.btnSerchTTA.TabIndex = 50;
            this.btnSerchTTA.Text = "Cari";
            this.btnSerchTTA.UseSelectable = true;
            this.btnSerchTTA.Click += new System.EventHandler(this.btnSerchTTA_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(255, 269);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 36);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Bersihkan";
            this.btnClear.UseSelectable = true;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(394, 37);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(372, 229);
            this.videoSourcePlayer1.TabIndex = 52;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // btnPlayCam
            // 
            this.btnPlayCam.Enabled = false;
            this.btnPlayCam.Location = new System.Drawing.Point(487, 399);
            this.btnPlayCam.Name = "btnPlayCam";
            this.btnPlayCam.Size = new System.Drawing.Size(109, 36);
            this.btnPlayCam.TabIndex = 54;
            this.btnPlayCam.Text = "Play";
            this.btnPlayCam.UseSelectable = true;
            this.btnPlayCam.Click += new System.EventHandler(this.btnPlayCam_Click);
            // 
            // btnStopCam
            // 
            this.btnStopCam.Enabled = false;
            this.btnStopCam.Location = new System.Drawing.Point(602, 399);
            this.btnStopCam.Name = "btnStopCam";
            this.btnStopCam.Size = new System.Drawing.Size(109, 36);
            this.btnStopCam.TabIndex = 55;
            this.btnStopCam.Text = "Stop";
            this.btnStopCam.UseSelectable = true;
            this.btnStopCam.Click += new System.EventHandler(this.btnStopCam_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(487, 285);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(279, 20);
            this.txtUrl.TabIndex = 56;
            this.txtUrl.Text = "http://<servername>/axis-cgi/mjpg/video.cgi?resolution=704x288";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(394, 284);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(32, 19);
            this.metroLabel6.TabIndex = 58;
            this.metroLabel6.Text = "URL";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(394, 313);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(68, 19);
            this.metroLabel7.TabIndex = 57;
            this.metroLabel7.Text = "Username";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(394, 344);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(63, 19);
            this.metroLabel8.TabIndex = 59;
            this.metroLabel8.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(487, 318);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(164, 20);
            this.txtUsername.TabIndex = 60;
            this.txtUsername.Text = "admin";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(487, 344);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(164, 20);
            this.txtPassword.TabIndex = 61;
            this.txtPassword.Text = "admin";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(487, 376);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "Security Checked";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TimbanganInManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 523);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnStopCam);
            this.Controls.Add(this.btnPlayCam);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSerchTTA);
            this.Controls.Add(this.tbBeratKotor);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tbNoTTA);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tbDriver);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tbNoMobil);
            this.Controls.Add(this.metroLabel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 281);
            this.Name = "TimbanganInManualForm";
            this.Text = "Timbangan In Manual ";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.TimbanganInManualForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbNoMobil;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btSimpan;
        private MetroFramework.Controls.MetroTextBox tbDriver;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbNoTTA;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lbLine;
        private NumericTextBox tbBeratKotor;
        private MetroFramework.Controls.MetroButton btnSerchTTA;
        private MetroFramework.Controls.MetroButton btnClear;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private MetroFramework.Controls.MetroButton btnPlayCam;
        private MetroFramework.Controls.MetroButton btnStopCam;
        private System.Windows.Forms.TextBox txtUrl;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}