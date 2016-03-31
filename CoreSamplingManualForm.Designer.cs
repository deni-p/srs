namespace SRS.DeskApp
{
    partial class CoreSamplingManualForm
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
            this.tbBarcode = new MetroFramework.Controls.MetroTextBox();
            this.lbBar = new MetroFramework.Controls.MetroLabel();
            this.lbBrix = new MetroFramework.Controls.MetroLabel();
            this.lbLine = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbNoTTA = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbDriver = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btSimpan = new MetroFramework.Controls.MetroButton();
            this.lbPOL = new MetroFramework.Controls.MetroLabel();
            this.tbNoMobil = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbBrix = new MetroFramework.Controls.MetroTextBox();
            this.tbPOL = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // tbBarcode
            // 
            this.tbBarcode.Lines = new string[0];
            this.tbBarcode.Location = new System.Drawing.Point(144, 254);
            this.tbBarcode.MaxLength = 32767;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.PasswordChar = '\0';
            this.tbBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBarcode.SelectedText = "";
            this.tbBarcode.Size = new System.Drawing.Size(119, 23);
            this.tbBarcode.TabIndex = 63;
            this.tbBarcode.UseSelectable = true;
            // 
            // lbBar
            // 
            this.lbBar.AutoSize = true;
            this.lbBar.Location = new System.Drawing.Point(23, 256);
            this.lbBar.Name = "lbBar";
            this.lbBar.Size = new System.Drawing.Size(58, 19);
            this.lbBar.TabIndex = 64;
            this.lbBar.Text = "Barcode";
            // 
            // lbBrix
            // 
            this.lbBrix.AutoSize = true;
            this.lbBrix.Location = new System.Drawing.Point(23, 227);
            this.lbBrix.Name = "lbBrix";
            this.lbBrix.Size = new System.Drawing.Size(36, 19);
            this.lbBrix.TabIndex = 62;
            this.lbBrix.Text = "BRIX";
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbLine.Location = new System.Drawing.Point(144, 72);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(0, 0);
            this.lbLine.TabIndex = 60;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 72);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 19);
            this.metroLabel5.TabIndex = 59;
            this.metroLabel5.Text = "LINE";
            // 
            // tbNoTTA
            // 
            this.tbNoTTA.Lines = new string[0];
            this.tbNoTTA.Location = new System.Drawing.Point(144, 109);
            this.tbNoTTA.MaxLength = 32767;
            this.tbNoTTA.Name = "tbNoTTA";
            this.tbNoTTA.PasswordChar = '\0';
            this.tbNoTTA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoTTA.SelectedText = "";
            this.tbNoTTA.Size = new System.Drawing.Size(119, 23);
            this.tbNoTTA.TabIndex = 51;
            this.tbNoTTA.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 111);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 58;
            this.metroLabel4.Text = "No TTA";
            // 
            // tbDriver
            // 
            this.tbDriver.Lines = new string[0];
            this.tbDriver.Location = new System.Drawing.Point(144, 167);
            this.tbDriver.MaxLength = 32767;
            this.tbDriver.Name = "tbDriver";
            this.tbDriver.PasswordChar = '\0';
            this.tbDriver.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDriver.SelectedText = "";
            this.tbDriver.Size = new System.Drawing.Size(119, 23);
            this.tbDriver.TabIndex = 54;
            this.tbDriver.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 57;
            this.metroLabel3.Text = "Driver";
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(150, 299);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(113, 36);
            this.btSimpan.TabIndex = 56;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseSelectable = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // lbPOL
            // 
            this.lbPOL.AutoSize = true;
            this.lbPOL.Location = new System.Drawing.Point(23, 198);
            this.lbPOL.Name = "lbPOL";
            this.lbPOL.Size = new System.Drawing.Size(34, 19);
            this.lbPOL.TabIndex = 52;
            this.lbPOL.Text = "POL";
            // 
            // tbNoMobil
            // 
            this.tbNoMobil.Lines = new string[0];
            this.tbNoMobil.Location = new System.Drawing.Point(144, 138);
            this.tbNoMobil.MaxLength = 32767;
            this.tbNoMobil.Name = "tbNoMobil";
            this.tbNoMobil.PasswordChar = '\0';
            this.tbNoMobil.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoMobil.SelectedText = "";
            this.tbNoMobil.Size = new System.Drawing.Size(119, 23);
            this.tbNoMobil.TabIndex = 53;
            this.tbNoMobil.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 140);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 50;
            this.metroLabel1.Text = "No. Kendaraan";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(29, 299);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 36);
            this.metroButton1.TabIndex = 65;
            this.metroButton1.Text = "Read File";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tbBrix
            // 
            this.tbBrix.Lines = new string[] {
        "0"};
            this.tbBrix.Location = new System.Drawing.Point(144, 225);
            this.tbBrix.MaxLength = 32767;
            this.tbBrix.Name = "tbBrix";
            this.tbBrix.PasswordChar = '\0';
            this.tbBrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBrix.SelectedText = "";
            this.tbBrix.Size = new System.Drawing.Size(119, 23);
            this.tbBrix.TabIndex = 66;
            this.tbBrix.Text = "0";
            this.tbBrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbBrix.UseSelectable = true;
            // 
            // tbPOL
            // 
            this.tbPOL.Lines = new string[] {
        "0"};
            this.tbPOL.Location = new System.Drawing.Point(144, 196);
            this.tbPOL.MaxLength = 32767;
            this.tbPOL.Name = "tbPOL";
            this.tbPOL.PasswordChar = '\0';
            this.tbPOL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPOL.SelectedText = "";
            this.tbPOL.Size = new System.Drawing.Size(119, 23);
            this.tbPOL.TabIndex = 67;
            this.tbPOL.Text = "0";
            this.tbPOL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPOL.UseSelectable = true;
            // 
            // CoreSamplingManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 358);
            this.Controls.Add(this.tbPOL);
            this.Controls.Add(this.tbBrix);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.lbBar);
            this.Controls.Add(this.lbBrix);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tbNoTTA);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tbDriver);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.lbPOL);
            this.Controls.Add(this.tbNoMobil);
            this.Controls.Add(this.metroLabel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(297, 358);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(297, 358);
            this.Name = "CoreSamplingManualForm";
            this.Text = "Core Sampling Manual";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.CoreSamplingManualForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbLine;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbDriver;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btSimpan;
        private MetroFramework.Controls.MetroLabel lbPOL;
        private MetroFramework.Controls.MetroTextBox tbNoMobil;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbBrix;
        private MetroFramework.Controls.MetroTextBox tbBarcode;
        private MetroFramework.Controls.MetroLabel lbBar;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public MetroFramework.Controls.MetroTextBox tbNoTTA;
        private MetroFramework.Controls.MetroTextBox tbBrix;
        private MetroFramework.Controls.MetroTextBox tbPOL;
    }
}