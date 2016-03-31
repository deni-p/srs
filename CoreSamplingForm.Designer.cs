namespace SRS.DeskApp
{
    partial class CoreSamplingForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bwMonitorCoreSampling = new System.ComponentModel.BackgroundWorker();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.b2barstatus = new System.Windows.Forms.PictureBox();
            this.b2manual = new MetroFramework.Controls.MetroButton();
            this.t2barcode = new MetroFramework.Controls.MetroTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.t2brix = new MetroFramework.Controls.MetroTextBox();
            this.t2pol = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lb2tta = new System.Windows.Forms.Label();
            this.bt2status = new MetroFramework.Controls.MetroButton();
            this.lbid2 = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.t2plat = new MetroFramework.Controls.MetroTextBox();
            this.t2sopir = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.b1barstatus = new System.Windows.Forms.PictureBox();
            this.b1manual = new MetroFramework.Controls.MetroButton();
            this.t1barcode = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblStatus1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.t1brix = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.t1pol = new MetroFramework.Controls.MetroTextBox();
            this.lb1tta = new System.Windows.Forms.Label();
            this.bt1status = new MetroFramework.Controls.MetroButton();
            this.lbid1 = new System.Windows.Forms.Label();
            this.t1plat = new MetroFramework.Controls.MetroTextBox();
            this.t1sopir = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b2barstatus)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b1barstatus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bwMonitorCoreSampling
            // 
            this.bwMonitorCoreSampling.WorkerReportsProgress = true;
            this.bwMonitorCoreSampling.WorkerSupportsCancellation = true;
            this.bwMonitorCoreSampling.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMonitorCoreSampling_DoWork);
            this.bwMonitorCoreSampling.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwMonitorCoreSampling_ProgressChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.groupBox3);
            this.metroPanel1.Controls.Add(this.groupBox4);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(667, 542);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel13);
            this.groupBox3.Controls.Add(this.b2barstatus);
            this.groupBox3.Controls.Add(this.b2manual);
            this.groupBox3.Controls.Add(this.t2barcode);
            this.groupBox3.Location = new System.Drawing.Point(352, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 180);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(15, 16);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(115, 25);
            this.metroLabel13.TabIndex = 41;
            this.metroLabel13.Text = "BARCODE ID";
            // 
            // b2barstatus
            // 
            this.b2barstatus.Location = new System.Drawing.Point(219, 119);
            this.b2barstatus.Name = "b2barstatus";
            this.b2barstatus.Size = new System.Drawing.Size(62, 43);
            this.b2barstatus.TabIndex = 23;
            this.b2barstatus.TabStop = false;
            // 
            // b2manual
            // 
            this.b2manual.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b2manual.Location = new System.Drawing.Point(15, 119);
            this.b2manual.Name = "b2manual";
            this.b2manual.Size = new System.Drawing.Size(178, 43);
            this.b2manual.TabIndex = 14;
            this.b2manual.Text = "MANUAL";
            this.b2manual.UseSelectable = true;
            this.b2manual.Click += new System.EventHandler(this.b2manual_Click);
            // 
            // t2barcode
            // 
            this.t2barcode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t2barcode.Lines = new string[0];
            this.t2barcode.Location = new System.Drawing.Point(15, 44);
            this.t2barcode.MaxLength = 32767;
            this.t2barcode.Name = "t2barcode";
            this.t2barcode.PasswordChar = '\0';
            this.t2barcode.ReadOnly = true;
            this.t2barcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t2barcode.SelectedText = "";
            this.t2barcode.Size = new System.Drawing.Size(266, 35);
            this.t2barcode.TabIndex = 13;
            this.t2barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t2barcode.UseSelectable = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroLabel9);
            this.groupBox4.Controls.Add(this.metroLabel8);
            this.groupBox4.Controls.Add(this.metroLabel7);
            this.groupBox4.Controls.Add(this.t2brix);
            this.groupBox4.Controls.Add(this.t2pol);
            this.groupBox4.Controls.Add(this.metroLabel4);
            this.groupBox4.Controls.Add(this.metroLabel3);
            this.groupBox4.Controls.Add(this.lb2tta);
            this.groupBox4.Controls.Add(this.bt2status);
            this.groupBox4.Controls.Add(this.lbid2);
            this.groupBox4.Controls.Add(this.metroLabel2);
            this.groupBox4.Controls.Add(this.t2plat);
            this.groupBox4.Controls.Add(this.t2sopir);
            this.groupBox4.Location = new System.Drawing.Point(352, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 301);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(15, 253);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(74, 25);
            this.metroLabel9.TabIndex = 37;
            this.metroLabel9.Text = "STATUS";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(15, 194);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(49, 25);
            this.metroLabel8.TabIndex = 36;
            this.metroLabel8.Text = "BRIX";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(15, 153);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(44, 25);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = "POL";
            // 
            // t2brix
            // 
            this.t2brix.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t2brix.Lines = new string[0];
            this.t2brix.Location = new System.Drawing.Point(119, 189);
            this.t2brix.MaxLength = 32767;
            this.t2brix.Name = "t2brix";
            this.t2brix.PasswordChar = '\0';
            this.t2brix.ReadOnly = true;
            this.t2brix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t2brix.SelectedText = "";
            this.t2brix.Size = new System.Drawing.Size(162, 35);
            this.t2brix.TabIndex = 11;
            this.t2brix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t2brix.UseSelectable = true;
            // 
            // t2pol
            // 
            this.t2pol.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t2pol.Lines = new string[0];
            this.t2pol.Location = new System.Drawing.Point(119, 148);
            this.t2pol.MaxLength = 32767;
            this.t2pol.Name = "t2pol";
            this.t2pol.PasswordChar = '\0';
            this.t2pol.ReadOnly = true;
            this.t2pol.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t2pol.SelectedText = "";
            this.t2pol.Size = new System.Drawing.Size(162, 35);
            this.t2pol.TabIndex = 10;
            this.t2pol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t2pol.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(15, 103);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 25);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "DRIVER";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(15, 62);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 25);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "NO.MOBIL";
            // 
            // lb2tta
            // 
            this.lb2tta.AutoSize = true;
            this.lb2tta.Location = new System.Drawing.Point(158, 265);
            this.lb2tta.Name = "lb2tta";
            this.lb2tta.Size = new System.Drawing.Size(35, 13);
            this.lb2tta.TabIndex = 30;
            this.lb2tta.Text = "label7";
            this.lb2tta.Visible = false;
            // 
            // bt2status
            // 
            this.bt2status.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bt2status.Location = new System.Drawing.Point(219, 246);
            this.bt2status.Name = "bt2status";
            this.bt2status.Size = new System.Drawing.Size(62, 38);
            this.bt2status.TabIndex = 12;
            this.bt2status.UseSelectable = true;
            this.bt2status.Click += new System.EventHandler(this.bt2status_Click);
            // 
            // lbid2
            // 
            this.lbid2.AutoSize = true;
            this.lbid2.Location = new System.Drawing.Point(104, 265);
            this.lbid2.Name = "lbid2";
            this.lbid2.Size = new System.Drawing.Size(35, 13);
            this.lbid2.TabIndex = 14;
            this.lbid2.Text = "label7";
            this.lbid2.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(0, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(298, 30);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "House 2";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // t2plat
            // 
            this.t2plat.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t2plat.Lines = new string[0];
            this.t2plat.Location = new System.Drawing.Point(119, 57);
            this.t2plat.MaxLength = 32767;
            this.t2plat.Name = "t2plat";
            this.t2plat.PasswordChar = '\0';
            this.t2plat.ReadOnly = true;
            this.t2plat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t2plat.SelectedText = "";
            this.t2plat.Size = new System.Drawing.Size(162, 35);
            this.t2plat.TabIndex = 8;
            this.t2plat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t2plat.UseSelectable = true;
            // 
            // t2sopir
            // 
            this.t2sopir.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t2sopir.Lines = new string[0];
            this.t2sopir.Location = new System.Drawing.Point(119, 98);
            this.t2sopir.MaxLength = 32767;
            this.t2sopir.Name = "t2sopir";
            this.t2sopir.PasswordChar = '\0';
            this.t2sopir.ReadOnly = true;
            this.t2sopir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t2sopir.SelectedText = "";
            this.t2sopir.Size = new System.Drawing.Size(162, 35);
            this.t2sopir.TabIndex = 9;
            this.t2sopir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t2sopir.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.b1barstatus);
            this.groupBox2.Controls.Add(this.b1manual);
            this.groupBox2.Controls.Add(this.t1barcode);
            this.groupBox2.Location = new System.Drawing.Point(23, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 180);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(11, 16);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(115, 25);
            this.metroLabel12.TabIndex = 40;
            this.metroLabel12.Text = "BARCODE ID";
            // 
            // b1barstatus
            // 
            this.b1barstatus.Location = new System.Drawing.Point(216, 119);
            this.b1barstatus.Name = "b1barstatus";
            this.b1barstatus.Size = new System.Drawing.Size(62, 43);
            this.b1barstatus.TabIndex = 24;
            this.b1barstatus.TabStop = false;
            // 
            // b1manual
            // 
            this.b1manual.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b1manual.Location = new System.Drawing.Point(16, 119);
            this.b1manual.Name = "b1manual";
            this.b1manual.Size = new System.Drawing.Size(184, 43);
            this.b1manual.TabIndex = 7;
            this.b1manual.Text = "MANUAL";
            this.b1manual.UseSelectable = true;
            this.b1manual.Click += new System.EventHandler(this.b1manual_Click);
            // 
            // t1barcode
            // 
            this.t1barcode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t1barcode.Lines = new string[0];
            this.t1barcode.Location = new System.Drawing.Point(16, 44);
            this.t1barcode.MaxLength = 32767;
            this.t1barcode.Name = "t1barcode";
            this.t1barcode.PasswordChar = '\0';
            this.t1barcode.ReadOnly = true;
            this.t1barcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t1barcode.SelectedText = "";
            this.t1barcode.Size = new System.Drawing.Size(262, 35);
            this.t1barcode.TabIndex = 6;
            this.t1barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1barcode.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.lblStatus1);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.t1brix);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.t1pol);
            this.groupBox1.Controls.Add(this.lb1tta);
            this.groupBox1.Controls.Add(this.bt1status);
            this.groupBox1.Controls.Add(this.lbid1);
            this.groupBox1.Controls.Add(this.t1plat);
            this.groupBox1.Controls.Add(this.t1sopir);
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 301);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(0, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(298, 30);
            this.metroLabel1.TabIndex = 40;
            this.metroLabel1.Text = "House 1";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStatus1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStatus1.Location = new System.Drawing.Point(11, 253);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(74, 25);
            this.lblStatus1.TabIndex = 39;
            this.lblStatus1.Text = "STATUS";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(11, 194);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(49, 25);
            this.metroLabel10.TabIndex = 38;
            this.metroLabel10.Text = "BRIX";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(11, 153);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(44, 25);
            this.metroLabel11.TabIndex = 37;
            this.metroLabel11.Text = "POL";
            // 
            // t1brix
            // 
            this.t1brix.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t1brix.Lines = new string[0];
            this.t1brix.Location = new System.Drawing.Point(116, 189);
            this.t1brix.MaxLength = 32767;
            this.t1brix.Name = "t1brix";
            this.t1brix.PasswordChar = '\0';
            this.t1brix.ReadOnly = true;
            this.t1brix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t1brix.SelectedText = "";
            this.t1brix.Size = new System.Drawing.Size(162, 35);
            this.t1brix.TabIndex = 4;
            this.t1brix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1brix.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(11, 103);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 25);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "DRIVER";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(11, 62);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(96, 25);
            this.metroLabel6.TabIndex = 33;
            this.metroLabel6.Text = "NO.MOBIL";
            // 
            // t1pol
            // 
            this.t1pol.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t1pol.Lines = new string[0];
            this.t1pol.Location = new System.Drawing.Point(116, 148);
            this.t1pol.MaxLength = 32767;
            this.t1pol.Name = "t1pol";
            this.t1pol.PasswordChar = '\0';
            this.t1pol.ReadOnly = true;
            this.t1pol.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t1pol.SelectedText = "";
            this.t1pol.Size = new System.Drawing.Size(162, 35);
            this.t1pol.TabIndex = 3;
            this.t1pol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1pol.UseSelectable = true;
            // 
            // lb1tta
            // 
            this.lb1tta.AutoSize = true;
            this.lb1tta.Location = new System.Drawing.Point(142, 265);
            this.lb1tta.Name = "lb1tta";
            this.lb1tta.Size = new System.Drawing.Size(35, 13);
            this.lb1tta.TabIndex = 29;
            this.lb1tta.Text = "label7";
            this.lb1tta.Visible = false;
            // 
            // bt1status
            // 
            this.bt1status.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bt1status.Location = new System.Drawing.Point(216, 246);
            this.bt1status.Name = "bt1status";
            this.bt1status.Size = new System.Drawing.Size(62, 38);
            this.bt1status.TabIndex = 5;
            this.bt1status.UseSelectable = true;
            this.bt1status.Click += new System.EventHandler(this.bt1status_Click);
            // 
            // lbid1
            // 
            this.lbid1.AutoSize = true;
            this.lbid1.Location = new System.Drawing.Point(101, 265);
            this.lbid1.Name = "lbid1";
            this.lbid1.Size = new System.Drawing.Size(35, 13);
            this.lbid1.TabIndex = 13;
            this.lbid1.Text = "label7";
            this.lbid1.Visible = false;
            // 
            // t1plat
            // 
            this.t1plat.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t1plat.Lines = new string[0];
            this.t1plat.Location = new System.Drawing.Point(116, 57);
            this.t1plat.MaxLength = 32767;
            this.t1plat.Name = "t1plat";
            this.t1plat.PasswordChar = '\0';
            this.t1plat.ReadOnly = true;
            this.t1plat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t1plat.SelectedText = "";
            this.t1plat.Size = new System.Drawing.Size(162, 35);
            this.t1plat.TabIndex = 1;
            this.t1plat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1plat.UseSelectable = true;
            // 
            // t1sopir
            // 
            this.t1sopir.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t1sopir.Lines = new string[0];
            this.t1sopir.Location = new System.Drawing.Point(116, 98);
            this.t1sopir.MaxLength = 32767;
            this.t1sopir.Name = "t1sopir";
            this.t1sopir.PasswordChar = '\0';
            this.t1sopir.ReadOnly = true;
            this.t1sopir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t1sopir.SelectedText = "";
            this.t1sopir.Size = new System.Drawing.Size(162, 35);
            this.t1sopir.TabIndex = 2;
            this.t1sopir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1sopir.UseSelectable = true;
            // 
            // CoreSamplingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(707, 622);
            this.Controls.Add(this.metroPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "CoreSamplingForm";
            this.Resizable = false;
            this.Text = "Core Sampling On Line";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoreSamplingForm_FormClosing);
            this.Load += new System.EventHandler(this.CoreSamplingForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b2barstatus)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b1barstatus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox t1plat;
        private MetroFramework.Controls.MetroTextBox t1sopir;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton b2manual;
        private MetroFramework.Controls.MetroTextBox t2barcode;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox t2plat;
        private MetroFramework.Controls.MetroTextBox t2sopir;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton b1manual;
        private MetroFramework.Controls.MetroTextBox t1barcode;
        private System.Windows.Forms.PictureBox b2barstatus;
        private System.Windows.Forms.PictureBox b1barstatus;
        private System.Windows.Forms.Label lbid2;
        private System.Windows.Forms.Label lbid1;
        private MetroFramework.Controls.MetroButton bt2status;
        private MetroFramework.Controls.MetroButton bt1status;
        private System.Windows.Forms.Label lb2tta;
        private System.Windows.Forms.Label lb1tta;
        private System.ComponentModel.BackgroundWorker bwMonitorCoreSampling;
        private MetroFramework.Controls.MetroTextBox t1pol;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox t2brix;
        private MetroFramework.Controls.MetroTextBox t2pol;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel lblStatus1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox t1brix;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}