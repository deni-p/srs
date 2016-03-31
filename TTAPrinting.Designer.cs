namespace SRS.DeskApp
{
    partial class TTAPrinting
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtNoScan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtRecNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtJumlahTiket = new MetroFramework.Controls.MetroTextBox();
            this.ChkAll = new MetroFramework.Controls.MetroCheckBox();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(104, 248);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 35);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Keluar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(23, 248);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 35);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Proses";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(24, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 23);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Scan No. TTA";
            // 
            // TxtNoScan
            // 
            this.TxtNoScan.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtNoScan.Lines = new string[] {
        "TA000001"};
            this.TxtNoScan.Location = new System.Drawing.Point(138, 80);
            this.TxtNoScan.MaxLength = 8;
            this.TxtNoScan.Name = "TxtNoScan";
            this.TxtNoScan.PasswordChar = '\0';
            this.TxtNoScan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNoScan.SelectedText = "";
            this.TxtNoScan.Size = new System.Drawing.Size(127, 28);
            this.TxtNoScan.TabIndex = 1;
            this.TxtNoScan.Text = "TA000001";
            this.TxtNoScan.UseCustomBackColor = true;
            this.TxtNoScan.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(24, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 23);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Posisi Record";
            // 
            // TxtRecNo
            // 
            this.TxtRecNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtRecNo.Lines = new string[] {
        "4"};
            this.TxtRecNo.Location = new System.Drawing.Point(138, 114);
            this.TxtRecNo.MaxLength = 32767;
            this.TxtRecNo.Name = "TxtRecNo";
            this.TxtRecNo.PasswordChar = '\0';
            this.TxtRecNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRecNo.SelectedText = "";
            this.TxtRecNo.Size = new System.Drawing.Size(127, 28);
            this.TxtRecNo.TabIndex = 3;
            this.TxtRecNo.Text = "4";
            this.TxtRecNo.UseCustomBackColor = true;
            this.TxtRecNo.UseSelectable = true;
            this.TxtRecNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRecNo_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(24, 151);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 23);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Jumlah Tiket";
            // 
            // TxtJumlahTiket
            // 
            this.TxtJumlahTiket.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtJumlahTiket.Lines = new string[] {
        "4"};
            this.TxtJumlahTiket.Location = new System.Drawing.Point(138, 148);
            this.TxtJumlahTiket.MaxLength = 32767;
            this.TxtJumlahTiket.Name = "TxtJumlahTiket";
            this.TxtJumlahTiket.PasswordChar = '\0';
            this.TxtJumlahTiket.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtJumlahTiket.SelectedText = "";
            this.TxtJumlahTiket.Size = new System.Drawing.Size(127, 28);
            this.TxtJumlahTiket.TabIndex = 5;
            this.TxtJumlahTiket.Text = "4";
            this.TxtJumlahTiket.UseCustomBackColor = true;
            this.TxtJumlahTiket.UseSelectable = true;
            this.TxtJumlahTiket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtJumlahTiket_KeyPress);
            // 
            // ChkAll
            // 
            this.ChkAll.AutoSize = true;
            this.ChkAll.Location = new System.Drawing.Point(138, 183);
            this.ChkAll.Name = "ChkAll";
            this.ChkAll.Size = new System.Drawing.Size(88, 15);
            this.ChkAll.TabIndex = 8;
            this.ChkAll.Text = "Semua Tiket";
            this.ChkAll.UseSelectable = true;
            this.ChkAll.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(24, 209);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(266, 28);
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar.TabIndex = 9;
            this.pBar.Visible = false;
            // 
            // TTAPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(311, 296);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.ChkAll);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.TxtJumlahTiket);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TxtRecNo);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtNoScan);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TTAPrinting";
            this.Resizable = false;
            this.Text = "Generate Nomor TTA";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.TTAPrinting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtNoScan;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtRecNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtJumlahTiket;
        private MetroFramework.Controls.MetroCheckBox ChkAll;
        private System.Windows.Forms.ProgressBar pBar;
    }
}