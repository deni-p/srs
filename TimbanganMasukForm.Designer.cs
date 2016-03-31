namespace SRS.DeskApp
{
    partial class TimbanganMasukForm
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
            this.bgWorkerMonitorTimbangan = new System.ComponentModel.BackgroundWorker();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.manualInput6 = new MetroFramework.Controls.MetroButton();
            this.manualInput5 = new MetroFramework.Controls.MetroButton();
            this.manualInput4 = new MetroFramework.Controls.MetroButton();
            this.manualInput3 = new MetroFramework.Controls.MetroButton();
            this.manualInput2 = new MetroFramework.Controls.MetroButton();
            this.manualInput1 = new MetroFramework.Controls.MetroButton();
            this.lblTimer6 = new MetroFramework.Controls.MetroLabel();
            this.lblTimer5 = new MetroFramework.Controls.MetroLabel();
            this.lblTimer4 = new MetroFramework.Controls.MetroLabel();
            this.lblTimer3 = new MetroFramework.Controls.MetroLabel();
            this.lblTimer2 = new MetroFramework.Controls.MetroLabel();
            this.lblTimer1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.b6 = new MetroFramework.Controls.MetroButton();
            this.b5 = new MetroFramework.Controls.MetroButton();
            this.b4 = new MetroFramework.Controls.MetroButton();
            this.b3 = new MetroFramework.Controls.MetroButton();
            this.b2 = new MetroFramework.Controls.MetroButton();
            this.b1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbid6 = new System.Windows.Forms.Label();
            this.t6plat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.t6ukuran = new MetroFramework.Controls.MetroTextBox();
            this.t6sopir = new MetroFramework.Controls.MetroTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbid5 = new System.Windows.Forms.Label();
            this.t5plat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.t5ukuran = new MetroFramework.Controls.MetroTextBox();
            this.t5sopir = new MetroFramework.Controls.MetroTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbid4 = new System.Windows.Forms.Label();
            this.t4plat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.t4ukuran = new MetroFramework.Controls.MetroTextBox();
            this.t4sopir = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbid3 = new System.Windows.Forms.Label();
            this.t3plat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.t3ukuran = new MetroFramework.Controls.MetroTextBox();
            this.t3sopir = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbid2 = new System.Windows.Forms.Label();
            this.t2plat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.t2ukuran = new MetroFramework.Controls.MetroTextBox();
            this.t2sopir = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbid1 = new System.Windows.Forms.Label();
            this.t1plat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.t1ukuran = new MetroFramework.Controls.MetroTextBox();
            this.t1sopir = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel3.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bgWorkerMonitorTimbangan
            // 
            this.bgWorkerMonitorTimbangan.WorkerReportsProgress = true;
            this.bgWorkerMonitorTimbangan.WorkerSupportsCancellation = true;
            this.bgWorkerMonitorTimbangan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerMonitorTimbangan_DoWork);
            this.bgWorkerMonitorTimbangan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerMonitorTimbangan_ProgressChanged);
            this.bgWorkerMonitorTimbangan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerMonitorTimbangan_RunWorkerCompleted);
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.manualInput6);
            this.metroPanel3.Controls.Add(this.manualInput5);
            this.metroPanel3.Controls.Add(this.manualInput4);
            this.metroPanel3.Controls.Add(this.manualInput3);
            this.metroPanel3.Controls.Add(this.manualInput2);
            this.metroPanel3.Controls.Add(this.manualInput1);
            this.metroPanel3.Controls.Add(this.lblTimer6);
            this.metroPanel3.Controls.Add(this.lblTimer5);
            this.metroPanel3.Controls.Add(this.lblTimer4);
            this.metroPanel3.Controls.Add(this.lblTimer3);
            this.metroPanel3.Controls.Add(this.lblTimer2);
            this.metroPanel3.Controls.Add(this.lblTimer1);
            this.metroPanel3.Controls.Add(this.metroButton2);
            this.metroPanel3.Controls.Add(this.metroButton1);
            this.metroPanel3.Controls.Add(this.b6);
            this.metroPanel3.Controls.Add(this.b5);
            this.metroPanel3.Controls.Add(this.b4);
            this.metroPanel3.Controls.Add(this.b3);
            this.metroPanel3.Controls.Add(this.b2);
            this.metroPanel3.Controls.Add(this.b1);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(20, 285);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(921, 216);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            this.metroPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel3_Paint);
            // 
            // manualInput6
            // 
            this.manualInput6.Enabled = false;
            this.manualInput6.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.manualInput6.Location = new System.Drawing.Point(770, 163);
            this.manualInput6.Name = "manualInput6";
            this.manualInput6.Size = new System.Drawing.Size(123, 43);
            this.manualInput6.TabIndex = 36;
            this.manualInput6.Tag = "6";
            this.manualInput6.Text = "Manual";
            this.manualInput6.UseSelectable = true;
            // 
            // manualInput5
            // 
            this.manualInput5.Enabled = false;
            this.manualInput5.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.manualInput5.Location = new System.Drawing.Point(621, 163);
            this.manualInput5.Name = "manualInput5";
            this.manualInput5.Size = new System.Drawing.Size(123, 43);
            this.manualInput5.TabIndex = 35;
            this.manualInput5.Tag = "5";
            this.manualInput5.Text = "Manual";
            this.manualInput5.UseSelectable = true;
            // 
            // manualInput4
            // 
            this.manualInput4.Enabled = false;
            this.manualInput4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.manualInput4.Location = new System.Drawing.Point(472, 163);
            this.manualInput4.Name = "manualInput4";
            this.manualInput4.Size = new System.Drawing.Size(123, 43);
            this.manualInput4.TabIndex = 34;
            this.manualInput4.Tag = "4";
            this.manualInput4.Text = "Manual";
            this.manualInput4.UseSelectable = true;
            // 
            // manualInput3
            // 
            this.manualInput3.Enabled = false;
            this.manualInput3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.manualInput3.Location = new System.Drawing.Point(323, 163);
            this.manualInput3.Name = "manualInput3";
            this.manualInput3.Size = new System.Drawing.Size(123, 43);
            this.manualInput3.TabIndex = 33;
            this.manualInput3.Tag = "3";
            this.manualInput3.Text = "Manual";
            this.manualInput3.UseSelectable = true;
            // 
            // manualInput2
            // 
            this.manualInput2.Enabled = false;
            this.manualInput2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.manualInput2.Location = new System.Drawing.Point(174, 163);
            this.manualInput2.Name = "manualInput2";
            this.manualInput2.Size = new System.Drawing.Size(123, 43);
            this.manualInput2.TabIndex = 32;
            this.manualInput2.Tag = "2";
            this.manualInput2.Text = "Manual";
            this.manualInput2.UseSelectable = true;
            this.manualInput2.Click += new System.EventHandler(this.manualInput2_Click);
            // 
            // manualInput1
            // 
            this.manualInput1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.manualInput1.Location = new System.Drawing.Point(25, 163);
            this.manualInput1.Name = "manualInput1";
            this.manualInput1.Size = new System.Drawing.Size(123, 43);
            this.manualInput1.TabIndex = 31;
            this.manualInput1.Tag = "1";
            this.manualInput1.Text = "Manual";
            this.manualInput1.UseSelectable = true;
            this.manualInput1.Click += new System.EventHandler(this.manualInput1_Click);
            // 
            // lblTimer6
            // 
            this.lblTimer6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTimer6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTimer6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTimer6.Location = new System.Drawing.Point(770, 122);
            this.lblTimer6.Name = "lblTimer6";
            this.lblTimer6.Size = new System.Drawing.Size(123, 30);
            this.lblTimer6.TabIndex = 30;
            this.lblTimer6.Text = "00:00";
            this.lblTimer6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer6.UseCustomForeColor = true;
            this.lblTimer6.UseStyleColors = true;
            // 
            // lblTimer5
            // 
            this.lblTimer5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTimer5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTimer5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTimer5.Location = new System.Drawing.Point(621, 122);
            this.lblTimer5.Name = "lblTimer5";
            this.lblTimer5.Size = new System.Drawing.Size(123, 30);
            this.lblTimer5.TabIndex = 29;
            this.lblTimer5.Text = "00:00";
            this.lblTimer5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer5.UseCustomForeColor = true;
            this.lblTimer5.UseStyleColors = true;
            // 
            // lblTimer4
            // 
            this.lblTimer4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTimer4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTimer4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTimer4.Location = new System.Drawing.Point(472, 122);
            this.lblTimer4.Name = "lblTimer4";
            this.lblTimer4.Size = new System.Drawing.Size(123, 30);
            this.lblTimer4.TabIndex = 28;
            this.lblTimer4.Text = "00:00";
            this.lblTimer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer4.UseCustomForeColor = true;
            this.lblTimer4.UseStyleColors = true;
            // 
            // lblTimer3
            // 
            this.lblTimer3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTimer3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTimer3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTimer3.Location = new System.Drawing.Point(323, 122);
            this.lblTimer3.Name = "lblTimer3";
            this.lblTimer3.Size = new System.Drawing.Size(123, 30);
            this.lblTimer3.TabIndex = 27;
            this.lblTimer3.Text = "00:00";
            this.lblTimer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer3.UseCustomForeColor = true;
            this.lblTimer3.UseStyleColors = true;
            // 
            // lblTimer2
            // 
            this.lblTimer2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTimer2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTimer2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTimer2.Location = new System.Drawing.Point(174, 122);
            this.lblTimer2.Name = "lblTimer2";
            this.lblTimer2.Size = new System.Drawing.Size(123, 30);
            this.lblTimer2.TabIndex = 26;
            this.lblTimer2.Text = "00:00";
            this.lblTimer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer2.UseCustomForeColor = true;
            this.lblTimer2.UseStyleColors = true;
            // 
            // lblTimer1
            // 
            this.lblTimer1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTimer1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTimer1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTimer1.Location = new System.Drawing.Point(25, 122);
            this.lblTimer1.Name = "lblTimer1";
            this.lblTimer1.Size = new System.Drawing.Size(123, 30);
            this.lblTimer1.Style = MetroFramework.MetroColorStyle.Green;
            this.lblTimer1.TabIndex = 25;
            this.lblTimer1.Text = "00:00";
            this.lblTimer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer1.UseCustomForeColor = true;
            this.lblTimer1.UseStyleColors = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(174, 36);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(123, 26);
            this.metroButton2.TabIndex = 24;
            this.metroButton2.Tag = "1";
            this.metroButton2.Text = "Timer Stop";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Visible = false;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 36);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(125, 26);
            this.metroButton1.TabIndex = 23;
            this.metroButton1.Tag = "1";
            this.metroButton1.Text = "Timer Start";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // b6
            // 
            this.b6.Enabled = false;
            this.b6.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b6.Location = new System.Drawing.Point(770, 68);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(123, 43);
            this.b6.TabIndex = 16;
            this.b6.Tag = "6";
            this.b6.Text = "6";
            this.b6.UseSelectable = true;
            this.b6.Click += new System.EventHandler(this.b1_Click);
            // 
            // b5
            // 
            this.b5.Enabled = false;
            this.b5.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b5.Location = new System.Drawing.Point(621, 68);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(123, 43);
            this.b5.TabIndex = 15;
            this.b5.Tag = "5";
            this.b5.Text = "5";
            this.b5.UseSelectable = true;
            this.b5.Click += new System.EventHandler(this.b1_Click);
            // 
            // b4
            // 
            this.b4.Enabled = false;
            this.b4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b4.Location = new System.Drawing.Point(472, 68);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(123, 43);
            this.b4.TabIndex = 14;
            this.b4.Tag = "4";
            this.b4.Text = "4";
            this.b4.UseSelectable = true;
            this.b4.Click += new System.EventHandler(this.b1_Click);
            // 
            // b3
            // 
            this.b3.Enabled = false;
            this.b3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b3.Location = new System.Drawing.Point(323, 68);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(123, 43);
            this.b3.TabIndex = 13;
            this.b3.Tag = "3";
            this.b3.Text = "3";
            this.b3.UseSelectable = true;
            this.b3.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Enabled = false;
            this.b2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b2.Location = new System.Drawing.Point(174, 68);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(123, 43);
            this.b2.TabIndex = 12;
            this.b2.Tag = "2";
            this.b2.Text = "2";
            this.b2.UseSelectable = true;
            this.b2.Click += new System.EventHandler(this.b1_Click);
            // 
            // b1
            // 
            this.b1.Enabled = false;
            this.b1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.b1.Location = new System.Drawing.Point(25, 68);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(123, 43);
            this.b1.TabIndex = 11;
            this.b1.Tag = "1";
            this.b1.Text = "1";
            this.b1.UseSelectable = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.groupBox4);
            this.metroPanel1.Controls.Add(this.groupBox5);
            this.metroPanel1.Controls.Add(this.groupBox6);
            this.metroPanel1.Controls.Add(this.groupBox3);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(921, 225);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbid6);
            this.groupBox4.Controls.Add(this.t6plat);
            this.groupBox4.Controls.Add(this.metroLabel6);
            this.groupBox4.Controls.Add(this.t6ukuran);
            this.groupBox4.Controls.Add(this.t6sopir);
            this.groupBox4.Location = new System.Drawing.Point(762, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 188);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // lbid6
            // 
            this.lbid6.AutoSize = true;
            this.lbid6.Location = new System.Drawing.Point(81, 16);
            this.lbid6.Name = "lbid6";
            this.lbid6.Size = new System.Drawing.Size(35, 13);
            this.lbid6.TabIndex = 13;
            this.lbid6.Text = "label1";
            this.lbid6.Visible = false;
            // 
            // t6plat
            // 
            this.t6plat.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t6plat.Lines = new string[0];
            this.t6plat.Location = new System.Drawing.Point(13, 50);
            this.t6plat.MaxLength = 32767;
            this.t6plat.Name = "t6plat";
            this.t6plat.PasswordChar = '\0';
            this.t6plat.ReadOnly = true;
            this.t6plat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t6plat.SelectedText = "";
            this.t6plat.Size = new System.Drawing.Size(109, 35);
            this.t6plat.TabIndex = 2;
            this.t6plat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t6plat.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(6, 11);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(126, 25);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "6";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t6ukuran
            // 
            this.t6ukuran.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t6ukuran.Lines = new string[0];
            this.t6ukuran.Location = new System.Drawing.Point(13, 96);
            this.t6ukuran.MaxLength = 32767;
            this.t6ukuran.Name = "t6ukuran";
            this.t6ukuran.PasswordChar = '\0';
            this.t6ukuran.ReadOnly = true;
            this.t6ukuran.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t6ukuran.SelectedText = "";
            this.t6ukuran.Size = new System.Drawing.Size(109, 35);
            this.t6ukuran.TabIndex = 3;
            this.t6ukuran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t6ukuran.UseSelectable = true;
            // 
            // t6sopir
            // 
            this.t6sopir.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t6sopir.Lines = new string[0];
            this.t6sopir.Location = new System.Drawing.Point(14, 141);
            this.t6sopir.MaxLength = 32767;
            this.t6sopir.Name = "t6sopir";
            this.t6sopir.PasswordChar = '\0';
            this.t6sopir.ReadOnly = true;
            this.t6sopir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t6sopir.SelectedText = "";
            this.t6sopir.Size = new System.Drawing.Size(109, 35);
            this.t6sopir.TabIndex = 4;
            this.t6sopir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t6sopir.UseSelectable = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbid5);
            this.groupBox5.Controls.Add(this.t5plat);
            this.groupBox5.Controls.Add(this.metroLabel5);
            this.groupBox5.Controls.Add(this.t5ukuran);
            this.groupBox5.Controls.Add(this.t5sopir);
            this.groupBox5.Location = new System.Drawing.Point(613, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 188);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // lbid5
            // 
            this.lbid5.AutoSize = true;
            this.lbid5.Location = new System.Drawing.Point(80, 16);
            this.lbid5.Name = "lbid5";
            this.lbid5.Size = new System.Drawing.Size(35, 13);
            this.lbid5.TabIndex = 12;
            this.lbid5.Text = "label1";
            this.lbid5.Visible = false;
            // 
            // t5plat
            // 
            this.t5plat.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t5plat.Lines = new string[0];
            this.t5plat.Location = new System.Drawing.Point(14, 50);
            this.t5plat.MaxLength = 32767;
            this.t5plat.Name = "t5plat";
            this.t5plat.PasswordChar = '\0';
            this.t5plat.ReadOnly = true;
            this.t5plat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t5plat.SelectedText = "";
            this.t5plat.Size = new System.Drawing.Size(109, 35);
            this.t5plat.TabIndex = 2;
            this.t5plat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t5plat.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(6, 11);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(126, 25);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "5";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t5ukuran
            // 
            this.t5ukuran.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t5ukuran.Lines = new string[0];
            this.t5ukuran.Location = new System.Drawing.Point(14, 96);
            this.t5ukuran.MaxLength = 32767;
            this.t5ukuran.Name = "t5ukuran";
            this.t5ukuran.PasswordChar = '\0';
            this.t5ukuran.ReadOnly = true;
            this.t5ukuran.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t5ukuran.SelectedText = "";
            this.t5ukuran.Size = new System.Drawing.Size(109, 35);
            this.t5ukuran.TabIndex = 3;
            this.t5ukuran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t5ukuran.UseSelectable = true;
            // 
            // t5sopir
            // 
            this.t5sopir.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t5sopir.Lines = new string[0];
            this.t5sopir.Location = new System.Drawing.Point(14, 141);
            this.t5sopir.MaxLength = 32767;
            this.t5sopir.Name = "t5sopir";
            this.t5sopir.PasswordChar = '\0';
            this.t5sopir.ReadOnly = true;
            this.t5sopir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t5sopir.SelectedText = "";
            this.t5sopir.Size = new System.Drawing.Size(109, 35);
            this.t5sopir.TabIndex = 4;
            this.t5sopir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t5sopir.UseSelectable = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbid4);
            this.groupBox6.Controls.Add(this.t4plat);
            this.groupBox6.Controls.Add(this.metroLabel4);
            this.groupBox6.Controls.Add(this.t4ukuran);
            this.groupBox6.Controls.Add(this.t4sopir);
            this.groupBox6.Location = new System.Drawing.Point(464, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(138, 188);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            // 
            // lbid4
            // 
            this.lbid4.AutoSize = true;
            this.lbid4.Location = new System.Drawing.Point(82, 16);
            this.lbid4.Name = "lbid4";
            this.lbid4.Size = new System.Drawing.Size(35, 13);
            this.lbid4.TabIndex = 12;
            this.lbid4.Text = "label1";
            this.lbid4.Visible = false;
            // 
            // t4plat
            // 
            this.t4plat.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t4plat.Lines = new string[0];
            this.t4plat.Location = new System.Drawing.Point(15, 50);
            this.t4plat.MaxLength = 32767;
            this.t4plat.Name = "t4plat";
            this.t4plat.PasswordChar = '\0';
            this.t4plat.ReadOnly = true;
            this.t4plat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t4plat.SelectedText = "";
            this.t4plat.Size = new System.Drawing.Size(109, 35);
            this.t4plat.TabIndex = 2;
            this.t4plat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t4plat.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(6, 11);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(126, 25);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "4";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t4ukuran
            // 
            this.t4ukuran.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t4ukuran.Lines = new string[0];
            this.t4ukuran.Location = new System.Drawing.Point(15, 96);
            this.t4ukuran.MaxLength = 32767;
            this.t4ukuran.Name = "t4ukuran";
            this.t4ukuran.PasswordChar = '\0';
            this.t4ukuran.ReadOnly = true;
            this.t4ukuran.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t4ukuran.SelectedText = "";
            this.t4ukuran.Size = new System.Drawing.Size(109, 35);
            this.t4ukuran.TabIndex = 3;
            this.t4ukuran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t4ukuran.UseSelectable = true;
            // 
            // t4sopir
            // 
            this.t4sopir.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t4sopir.Lines = new string[0];
            this.t4sopir.Location = new System.Drawing.Point(15, 141);
            this.t4sopir.MaxLength = 32767;
            this.t4sopir.Name = "t4sopir";
            this.t4sopir.PasswordChar = '\0';
            this.t4sopir.ReadOnly = true;
            this.t4sopir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t4sopir.SelectedText = "";
            this.t4sopir.Size = new System.Drawing.Size(109, 35);
            this.t4sopir.TabIndex = 4;
            this.t4sopir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t4sopir.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbid3);
            this.groupBox3.Controls.Add(this.t3plat);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.t3ukuran);
            this.groupBox3.Controls.Add(this.t3sopir);
            this.groupBox3.Location = new System.Drawing.Point(315, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 188);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // lbid3
            // 
            this.lbid3.AutoSize = true;
            this.lbid3.Location = new System.Drawing.Point(82, 16);
            this.lbid3.Name = "lbid3";
            this.lbid3.Size = new System.Drawing.Size(35, 13);
            this.lbid3.TabIndex = 8;
            this.lbid3.Text = "label1";
            this.lbid3.Visible = false;
            // 
            // t3plat
            // 
            this.t3plat.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t3plat.Lines = new string[0];
            this.t3plat.Location = new System.Drawing.Point(14, 50);
            this.t3plat.MaxLength = 32767;
            this.t3plat.Name = "t3plat";
            this.t3plat.PasswordChar = '\0';
            this.t3plat.ReadOnly = true;
            this.t3plat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t3plat.SelectedText = "";
            this.t3plat.Size = new System.Drawing.Size(109, 35);
            this.t3plat.TabIndex = 2;
            this.t3plat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t3plat.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(6, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(126, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "3";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t3ukuran
            // 
            this.t3ukuran.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t3ukuran.Lines = new string[0];
            this.t3ukuran.Location = new System.Drawing.Point(14, 96);
            this.t3ukuran.MaxLength = 32767;
            this.t3ukuran.Name = "t3ukuran";
            this.t3ukuran.PasswordChar = '\0';
            this.t3ukuran.ReadOnly = true;
            this.t3ukuran.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t3ukuran.SelectedText = "";
            this.t3ukuran.Size = new System.Drawing.Size(109, 35);
            this.t3ukuran.TabIndex = 3;
            this.t3ukuran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t3ukuran.UseSelectable = true;
            // 
            // t3sopir
            // 
            this.t3sopir.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t3sopir.Lines = new string[0];
            this.t3sopir.Location = new System.Drawing.Point(14, 141);
            this.t3sopir.MaxLength = 32767;
            this.t3sopir.Name = "t3sopir";
            this.t3sopir.PasswordChar = '\0';
            this.t3sopir.ReadOnly = true;
            this.t3sopir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t3sopir.SelectedText = "";
            this.t3sopir.Size = new System.Drawing.Size(109, 35);
            this.t3sopir.TabIndex = 4;
            this.t3sopir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t3sopir.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbid2);
            this.groupBox2.Controls.Add(this.t2plat);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.t2ukuran);
            this.groupBox2.Controls.Add(this.t2sopir);
            this.groupBox2.Location = new System.Drawing.Point(166, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 188);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // lbid2
            // 
            this.lbid2.AutoSize = true;
            this.lbid2.Location = new System.Drawing.Point(80, 16);
            this.lbid2.Name = "lbid2";
            this.lbid2.Size = new System.Drawing.Size(35, 13);
            this.lbid2.TabIndex = 7;
            this.lbid2.Text = "label1";
            this.lbid2.Visible = false;
            // 
            // t2plat
            // 
            this.t2plat.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t2plat.Lines = new string[0];
            this.t2plat.Location = new System.Drawing.Point(14, 50);
            this.t2plat.MaxLength = 32767;
            this.t2plat.Name = "t2plat";
            this.t2plat.PasswordChar = '\0';
            this.t2plat.ReadOnly = true;
            this.t2plat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t2plat.SelectedText = "";
            this.t2plat.Size = new System.Drawing.Size(109, 35);
            this.t2plat.TabIndex = 2;
            this.t2plat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t2plat.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(6, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "2";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t2ukuran
            // 
            this.t2ukuran.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t2ukuran.Lines = new string[0];
            this.t2ukuran.Location = new System.Drawing.Point(14, 96);
            this.t2ukuran.MaxLength = 32767;
            this.t2ukuran.Name = "t2ukuran";
            this.t2ukuran.PasswordChar = '\0';
            this.t2ukuran.ReadOnly = true;
            this.t2ukuran.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t2ukuran.SelectedText = "";
            this.t2ukuran.Size = new System.Drawing.Size(109, 35);
            this.t2ukuran.TabIndex = 3;
            this.t2ukuran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t2ukuran.UseSelectable = true;
            // 
            // t2sopir
            // 
            this.t2sopir.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t2sopir.Lines = new string[0];
            this.t2sopir.Location = new System.Drawing.Point(14, 141);
            this.t2sopir.MaxLength = 32767;
            this.t2sopir.Name = "t2sopir";
            this.t2sopir.PasswordChar = '\0';
            this.t2sopir.ReadOnly = true;
            this.t2sopir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t2sopir.SelectedText = "";
            this.t2sopir.Size = new System.Drawing.Size(109, 35);
            this.t2sopir.TabIndex = 4;
            this.t2sopir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t2sopir.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbid1);
            this.groupBox1.Controls.Add(this.t1plat);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.t1ukuran);
            this.groupBox1.Controls.Add(this.t1sopir);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 188);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lbid1
            // 
            this.lbid1.AutoSize = true;
            this.lbid1.Location = new System.Drawing.Point(77, 16);
            this.lbid1.Name = "lbid1";
            this.lbid1.Size = new System.Drawing.Size(35, 13);
            this.lbid1.TabIndex = 6;
            this.lbid1.Text = "label1";
            this.lbid1.Visible = false;
            // 
            // t1plat
            // 
            this.t1plat.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t1plat.Lines = new string[0];
            this.t1plat.Location = new System.Drawing.Point(14, 50);
            this.t1plat.MaxLength = 32767;
            this.t1plat.Name = "t1plat";
            this.t1plat.PasswordChar = '\0';
            this.t1plat.ReadOnly = true;
            this.t1plat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t1plat.SelectedText = "";
            this.t1plat.Size = new System.Drawing.Size(109, 35);
            this.t1plat.TabIndex = 2;
            this.t1plat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1plat.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(6, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "1";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t1ukuran
            // 
            this.t1ukuran.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t1ukuran.Lines = new string[0];
            this.t1ukuran.Location = new System.Drawing.Point(14, 96);
            this.t1ukuran.MaxLength = 32767;
            this.t1ukuran.Name = "t1ukuran";
            this.t1ukuran.PasswordChar = '\0';
            this.t1ukuran.ReadOnly = true;
            this.t1ukuran.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t1ukuran.SelectedText = "";
            this.t1ukuran.Size = new System.Drawing.Size(109, 35);
            this.t1ukuran.TabIndex = 3;
            this.t1ukuran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1ukuran.UseSelectable = true;
            // 
            // t1sopir
            // 
            this.t1sopir.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.t1sopir.Lines = new string[0];
            this.t1sopir.Location = new System.Drawing.Point(14, 141);
            this.t1sopir.MaxLength = 32767;
            this.t1sopir.Name = "t1sopir";
            this.t1sopir.PasswordChar = '\0';
            this.t1sopir.ReadOnly = true;
            this.t1sopir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.t1sopir.SelectedText = "";
            this.t1sopir.Size = new System.Drawing.Size(109, 35);
            this.t1sopir.TabIndex = 4;
            this.t1sopir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1sopir.UseSelectable = true;
            // 
            // TimbanganMasukForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 521);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimbanganMasukForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Monitoring Timbangan Masuk";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimbanganMasukForm_FormClosing);
            this.Load += new System.EventHandler(this.TimbanganMasukForm_Load);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox t1sopir;
        private MetroFramework.Controls.MetroTextBox t1ukuran;
        private MetroFramework.Controls.MetroTextBox t1plat;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox t2plat;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox t2ukuran;
        private MetroFramework.Controls.MetroTextBox t2sopir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox t6plat;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox t6ukuran;
        private MetroFramework.Controls.MetroTextBox t6sopir;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroTextBox t5plat;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox t5ukuran;
        private MetroFramework.Controls.MetroTextBox t5sopir;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroTextBox t4plat;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox t4ukuran;
        private MetroFramework.Controls.MetroTextBox t4sopir;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox t3plat;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox t3ukuran;
        private MetroFramework.Controls.MetroTextBox t3sopir;
        private MetroFramework.Controls.MetroButton b6;
        private MetroFramework.Controls.MetroButton b5;
        private MetroFramework.Controls.MetroButton b4;
        private MetroFramework.Controls.MetroButton b3;
        private MetroFramework.Controls.MetroButton b2;
        private MetroFramework.Controls.MetroButton b1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbid6;
        private System.Windows.Forms.Label lbid5;
        private System.Windows.Forms.Label lbid4;
        private System.Windows.Forms.Label lbid3;
        private System.Windows.Forms.Label lbid2;
        private System.Windows.Forms.Label lbid1;
        private System.ComponentModel.BackgroundWorker bgWorkerMonitorTimbangan;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel lblTimer1;
        private MetroFramework.Controls.MetroLabel lblTimer6;
        private MetroFramework.Controls.MetroLabel lblTimer5;
        private MetroFramework.Controls.MetroLabel lblTimer4;
        private MetroFramework.Controls.MetroLabel lblTimer3;
        private MetroFramework.Controls.MetroLabel lblTimer2;
        private MetroFramework.Controls.MetroButton manualInput6;
        private MetroFramework.Controls.MetroButton manualInput5;
        private MetroFramework.Controls.MetroButton manualInput4;
        private MetroFramework.Controls.MetroButton manualInput3;
        private MetroFramework.Controls.MetroButton manualInput2;
        private MetroFramework.Controls.MetroButton manualInput1;
    }
}