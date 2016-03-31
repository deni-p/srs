namespace SRS.DeskApp
{
    partial class RegistrasiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrasiForm));
            this.bgMonitorStatusKartu = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerSearchTTA = new System.ComponentModel.BackgroundWorker();
            this.tbRayon = new MetroFramework.Controls.MetroTextBox();
            this.GridList = new MetroFramework.Controls.MetroGrid();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.lblStatusWrite = new MetroFramework.Controls.MetroLabel();
            this.lblProgress = new MetroFramework.Controls.MetroLabel();
            this.tbLuasPanen = new MetroFramework.Controls.MetroTextBox();
            this.chkGandengan = new MetroFramework.Controls.MetroCheckBox();
            this.MChkValidasi = new MetroFramework.Controls.MetroCheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbNumCard = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tbTglRegister = new MetroFramework.Controls.MetroTextBox();
            this.btnTab = new MetroFramework.Controls.MetroButton();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.tbTglTTA = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbKodeMitra2 = new MetroFramework.Controls.MetroTextBox();
            this.tbKodeMitra = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btReset = new MetroFramework.Controls.MetroButton();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.tbJabatan2 = new MetroFramework.Controls.MetroTextBox();
            this.tbpenanggungjawabRegion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.tbJabatan = new MetroFramework.Controls.MetroTextBox();
            this.tbDibuatOleh = new MetroFramework.Controls.MetroTextBox();
            this.tbKab = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.tbKec = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.tbDesa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tbVarietas = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tbNoTruck = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tbNamaDriver = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbAlamatPetani1 = new MetroFramework.Controls.MetroTextBox();
            this.tbNamaPetani2 = new MetroFramework.Controls.MetroTextBox();
            this.tbNamaPetani1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbNoTiketTTA = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbNamaKUD = new MetroFramework.Controls.MetroTextBox();
            this.btSimpan = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bgMonitorStatusKartu
            // 
            this.bgMonitorStatusKartu.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgMonitorStatusKartu_DoWork);
            this.bgMonitorStatusKartu.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgMonitorStatusKartu_RunWorkerCompleted);
            // 
            // bgWorkerSearchTTA
            // 
            this.bgWorkerSearchTTA.WorkerReportsProgress = true;
            this.bgWorkerSearchTTA.WorkerSupportsCancellation = true;
            this.bgWorkerSearchTTA.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerSearchTTA_DoWork);
            this.bgWorkerSearchTTA.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerSearchTTA_ProgressChanged);
            this.bgWorkerSearchTTA.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerSearchTTA_RunWorkerCompleted);
            // 
            // tbRayon
            // 
            this.tbRayon.Lines = new string[0];
            this.tbRayon.Location = new System.Drawing.Point(277, 310);
            this.tbRayon.MaxLength = 32767;
            this.tbRayon.Name = "tbRayon";
            this.tbRayon.PasswordChar = '\0';
            this.tbRayon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRayon.SelectedText = "";
            this.tbRayon.Size = new System.Drawing.Size(98, 23);
            this.tbRayon.TabIndex = 154;
            this.tbRayon.UseCustomBackColor = true;
            this.tbRayon.UseSelectable = true;
            this.tbRayon.UseStyleColors = true;
            // 
            // GridList
            // 
            this.GridList.AllowUserToResizeRows = false;
            this.GridList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridList.ColumnHeadersHeight = 20;
            this.GridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridList.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridList.EnableHeadersVisualStyles = false;
            this.GridList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridList.Location = new System.Drawing.Point(381, 248);
            this.GridList.Name = "GridList";
            this.GridList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridList.RowHeadersWidth = 4;
            this.GridList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GridList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GridList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridList.RowTemplate.DividerHeight = 1;
            this.GridList.RowTemplate.Height = 20;
            this.GridList.RowTemplate.ReadOnly = true;
            this.GridList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.GridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridList.Size = new System.Drawing.Size(330, 120);
            this.GridList.Style = MetroFramework.MetroColorStyle.Teal;
            this.GridList.TabIndex = 153;
            this.GridList.UseCustomBackColor = true;
            this.GridList.UseCustomForeColor = true;
            this.GridList.UseStyleColors = true;
            this.GridList.Visible = false;
            this.GridList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridList_CellContentClick);
            this.GridList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridList_CellDoubleClick);
            this.GridList.Leave += new System.EventHandler(this.GridList_Leave);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton2.BackgroundImage")));
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton2.Location = new System.Drawing.Point(381, 217);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(23, 23);
            this.metroButton2.TabIndex = 152;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // lblStatusWrite
            // 
            this.lblStatusWrite.Location = new System.Drawing.Point(514, 401);
            this.lblStatusWrite.Name = "lblStatusWrite";
            this.lblStatusWrite.Size = new System.Drawing.Size(197, 45);
            this.lblStatusWrite.TabIndex = 151;
            this.lblStatusWrite.Text = "Silahkan Ditunggu, Sedang Menulis Data Ke Kartu..";
            this.lblStatusWrite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatusWrite.Visible = false;
            this.lblStatusWrite.WrapToLine = true;
            this.lblStatusWrite.Click += new System.EventHandler(this.lblStatusWrite_Click_1);
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(175, 28);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(530, 19);
            this.lblProgress.TabIndex = 150;
            this.lblProgress.Text = "Wait... Progresss";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblProgress.Visible = false;
            this.lblProgress.Click += new System.EventHandler(this.lblProgress_Click_1);
            // 
            // tbLuasPanen
            // 
            this.tbLuasPanen.BackColor = System.Drawing.Color.White;
            this.tbLuasPanen.Lines = new string[] {
        "0.00"};
            this.tbLuasPanen.Location = new System.Drawing.Point(174, 310);
            this.tbLuasPanen.MaxLength = 32767;
            this.tbLuasPanen.Name = "tbLuasPanen";
            this.tbLuasPanen.PasswordChar = '\0';
            this.tbLuasPanen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLuasPanen.SelectedText = "";
            this.tbLuasPanen.Size = new System.Drawing.Size(61, 23);
            this.tbLuasPanen.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLuasPanen.TabIndex = 15;
            this.tbLuasPanen.Text = "0.00";
            this.tbLuasPanen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbLuasPanen.UseCustomBackColor = true;
            this.tbLuasPanen.UseSelectable = true;
            this.tbLuasPanen.UseStyleColors = true;
            this.tbLuasPanen.Click += new System.EventHandler(this.tbLuasPanen_Click);
            this.tbLuasPanen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLuasPanen_KeyDown);
            this.tbLuasPanen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLuasPanen_KeyPress);
            // 
            // chkGandengan
            // 
            this.chkGandengan.AutoSize = true;
            this.chkGandengan.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkGandengan.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkGandengan.Location = new System.Drawing.Point(174, 126);
            this.chkGandengan.Name = "chkGandengan";
            this.chkGandengan.Size = new System.Drawing.Size(85, 19);
            this.chkGandengan.TabIndex = 5;
            this.chkGandengan.Text = "Gandeng";
            this.chkGandengan.UseSelectable = true;
            this.chkGandengan.CheckedChanged += new System.EventHandler(this.chkGandengan_CheckedChanged);
            this.chkGandengan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkGandengan_KeyDown);
            // 
            // MChkValidasi
            // 
            this.MChkValidasi.AutoSize = true;
            this.MChkValidasi.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.MChkValidasi.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.MChkValidasi.Location = new System.Drawing.Point(418, 284);
            this.MChkValidasi.Name = "MChkValidasi";
            this.MChkValidasi.Size = new System.Drawing.Size(303, 19);
            this.MChkValidasi.TabIndex = 14;
            this.MChkValidasi.Text = "Nama Petani Sesuai Dengan Nama di TTA";
            this.MChkValidasi.UseSelectable = true;
            this.MChkValidasi.CheckedChanged += new System.EventHandler(this.MChkValidasi_CheckedChanged);
            this.MChkValidasi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MChkValidasi_KeyDown);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(511, 63);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 23);
            this.progressBar1.TabIndex = 148;
            this.progressBar1.Visible = false;
            // 
            // tbNumCard
            // 
            this.tbNumCard.Lines = new string[0];
            this.tbNumCard.Location = new System.Drawing.Point(511, 357);
            this.tbNumCard.MaxLength = 32767;
            this.tbNumCard.Name = "tbNumCard";
            this.tbNumCard.PasswordChar = '\0';
            this.tbNumCard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNumCard.SelectedText = "";
            this.tbNumCard.Size = new System.Drawing.Size(200, 23);
            this.tbNumCard.TabIndex = 146;
            this.tbNumCard.UseSelectable = true;
            this.tbNumCard.Visible = false;
            this.tbNumCard.Click += new System.EventHandler(this.tbNumCard_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(418, 159);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(86, 19);
            this.metroLabel8.TabIndex = 145;
            this.metroLabel8.Text = "Tgl Registrasi";
            // 
            // tbTglRegister
            // 
            this.tbTglRegister.Lines = new string[] {
        " "};
            this.tbTglRegister.Location = new System.Drawing.Point(511, 157);
            this.tbTglRegister.MaxLength = 32767;
            this.tbTglRegister.Name = "tbTglRegister";
            this.tbTglRegister.PasswordChar = '\0';
            this.tbTglRegister.ReadOnly = true;
            this.tbTglRegister.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTglRegister.SelectedText = "";
            this.tbTglRegister.Size = new System.Drawing.Size(200, 23);
            this.tbTglRegister.TabIndex = 8;
            this.tbTglRegister.Text = " ";
            this.tbTglRegister.UseSelectable = true;
            this.tbTglRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTglRegister_KeyDown);
            // 
            // btnTab
            // 
            this.btnTab.Enabled = false;
            this.btnTab.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTab.Location = new System.Drawing.Point(511, 524);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(200, 41);
            this.btnTab.TabIndex = 27;
            this.btnTab.Text = "TAP (Simpan Data Ke Kartu)";
            this.btnTab.UseSelectable = true;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(418, 130);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(83, 19);
            this.metroLabel22.TabIndex = 141;
            this.metroLabel22.Text = "Tanggal TTA";
            // 
            // tbTglTTA
            // 
            this.tbTglTTA.Lines = new string[] {
        " "};
            this.tbTglTTA.Location = new System.Drawing.Point(511, 126);
            this.tbTglTTA.MaxLength = 32767;
            this.tbTglTTA.Name = "tbTglTTA";
            this.tbTglTTA.PasswordChar = '\0';
            this.tbTglTTA.ReadOnly = true;
            this.tbTglTTA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTglTTA.SelectedText = "";
            this.tbTglTTA.Size = new System.Drawing.Size(200, 23);
            this.tbTglTTA.TabIndex = 6;
            this.tbTglTTA.Text = " ";
            this.tbTglTTA.UseSelectable = true;
            this.tbTglTTA.Click += new System.EventHandler(this.tbTglTTA_Click);
            this.tbTglTTA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTglTTA_KeyDown);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(418, 219);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(85, 19);
            this.metroLabel6.TabIndex = 139;
            this.metroLabel6.Text = "Kode Mitra 2";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(418, 190);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 19);
            this.metroLabel5.TabIndex = 138;
            this.metroLabel5.Text = "Kode Mitra";
            // 
            // tbKodeMitra2
            // 
            this.tbKodeMitra2.Lines = new string[0];
            this.tbKodeMitra2.Location = new System.Drawing.Point(511, 217);
            this.tbKodeMitra2.MaxLength = 32767;
            this.tbKodeMitra2.Name = "tbKodeMitra2";
            this.tbKodeMitra2.PasswordChar = '\0';
            this.tbKodeMitra2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKodeMitra2.SelectedText = "";
            this.tbKodeMitra2.Size = new System.Drawing.Size(200, 23);
            this.tbKodeMitra2.TabIndex = 12;
            this.tbKodeMitra2.UseCustomBackColor = true;
            this.tbKodeMitra2.UseSelectable = true;
            this.tbKodeMitra2.UseStyleColors = true;
            this.tbKodeMitra2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKodeMitra2_KeyDown);
            // 
            // tbKodeMitra
            // 
            this.tbKodeMitra.Lines = new string[0];
            this.tbKodeMitra.Location = new System.Drawing.Point(511, 188);
            this.tbKodeMitra.MaxLength = 32767;
            this.tbKodeMitra.Name = "tbKodeMitra";
            this.tbKodeMitra.PasswordChar = '\0';
            this.tbKodeMitra.ReadOnly = true;
            this.tbKodeMitra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKodeMitra.SelectedText = "";
            this.tbKodeMitra.Size = new System.Drawing.Size(200, 23);
            this.tbKodeMitra.TabIndex = 10;
            this.tbKodeMitra.UseSelectable = true;
            this.tbKodeMitra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKodeMitra_KeyDown);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(381, 64);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(23, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btReset
            // 
            this.btReset.Enabled = false;
            this.btReset.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btReset.Location = new System.Drawing.Point(286, 524);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(88, 41);
            this.btReset.TabIndex = 26;
            this.btReset.Text = "Reset";
            this.btReset.UseSelectable = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(401, 488);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(54, 19);
            this.metroLabel20.TabIndex = 133;
            this.metroLabel20.Text = "Jabatan";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(28, 493);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(160, 19);
            this.metroLabel21.TabIndex = 132;
            this.metroLabel21.Text = "Penangung Jawab Region";
            // 
            // tbJabatan2
            // 
            this.tbJabatan2.Lines = new string[0];
            this.tbJabatan2.Location = new System.Drawing.Point(511, 484);
            this.tbJabatan2.MaxLength = 32767;
            this.tbJabatan2.Name = "tbJabatan2";
            this.tbJabatan2.PasswordChar = '\0';
            this.tbJabatan2.ReadOnly = true;
            this.tbJabatan2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbJabatan2.SelectedText = "";
            this.tbJabatan2.Size = new System.Drawing.Size(200, 23);
            this.tbJabatan2.TabIndex = 24;
            this.tbJabatan2.UseSelectable = true;
            this.tbJabatan2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbJabatan2_KeyDown);
            // 
            // tbpenanggungjawabRegion
            // 
            this.tbpenanggungjawabRegion.Lines = new string[0];
            this.tbpenanggungjawabRegion.Location = new System.Drawing.Point(193, 489);
            this.tbpenanggungjawabRegion.MaxLength = 32767;
            this.tbpenanggungjawabRegion.Name = "tbpenanggungjawabRegion";
            this.tbpenanggungjawabRegion.PasswordChar = '\0';
            this.tbpenanggungjawabRegion.ReadOnly = true;
            this.tbpenanggungjawabRegion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbpenanggungjawabRegion.SelectedText = "";
            this.tbpenanggungjawabRegion.Size = new System.Drawing.Size(182, 23);
            this.tbpenanggungjawabRegion.TabIndex = 23;
            this.tbpenanggungjawabRegion.UseSelectable = true;
            this.tbpenanggungjawabRegion.Click += new System.EventHandler(this.tbpenanggungjawabRegion_Click);
            this.tbpenanggungjawabRegion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbpenanggungjawabRegion_KeyDown);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(401, 459);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(54, 19);
            this.metroLabel19.TabIndex = 129;
            this.metroLabel19.Text = "Jabatan";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(28, 464);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(79, 19);
            this.metroLabel18.TabIndex = 128;
            this.metroLabel18.Text = "Dibuat Oleh";
            // 
            // tbJabatan
            // 
            this.tbJabatan.Lines = new string[0];
            this.tbJabatan.Location = new System.Drawing.Point(511, 455);
            this.tbJabatan.MaxLength = 32767;
            this.tbJabatan.Name = "tbJabatan";
            this.tbJabatan.PasswordChar = '\0';
            this.tbJabatan.ReadOnly = true;
            this.tbJabatan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbJabatan.SelectedText = "";
            this.tbJabatan.Size = new System.Drawing.Size(200, 23);
            this.tbJabatan.TabIndex = 22;
            this.tbJabatan.UseSelectable = true;
            this.tbJabatan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbJabatan_KeyDown);
            // 
            // tbDibuatOleh
            // 
            this.tbDibuatOleh.Lines = new string[] {
        " "};
            this.tbDibuatOleh.Location = new System.Drawing.Point(193, 460);
            this.tbDibuatOleh.MaxLength = 32767;
            this.tbDibuatOleh.Name = "tbDibuatOleh";
            this.tbDibuatOleh.PasswordChar = '\0';
            this.tbDibuatOleh.ReadOnly = true;
            this.tbDibuatOleh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDibuatOleh.SelectedText = "";
            this.tbDibuatOleh.Size = new System.Drawing.Size(182, 23);
            this.tbDibuatOleh.TabIndex = 21;
            this.tbDibuatOleh.Text = " ";
            this.tbDibuatOleh.UseSelectable = true;
            this.tbDibuatOleh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDibuatOleh_KeyDown);
            // 
            // tbKab
            // 
            this.tbKab.Lines = new string[] {
        " "};
            this.tbKab.Location = new System.Drawing.Point(218, 430);
            this.tbKab.MaxLength = 32767;
            this.tbKab.Name = "tbKab";
            this.tbKab.PasswordChar = '\0';
            this.tbKab.ReadOnly = true;
            this.tbKab.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKab.SelectedText = "";
            this.tbKab.Size = new System.Drawing.Size(157, 23);
            this.tbKab.TabIndex = 20;
            this.tbKab.Text = " ";
            this.tbKab.UseSelectable = true;
            this.tbKab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKab_KeyDown);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(175, 434);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(34, 19);
            this.metroLabel17.TabIndex = 124;
            this.metroLabel17.Text = "Kab.";
            // 
            // tbKec
            // 
            this.tbKec.Lines = new string[] {
        " "};
            this.tbKec.Location = new System.Drawing.Point(218, 401);
            this.tbKec.MaxLength = 32767;
            this.tbKec.Name = "tbKec";
            this.tbKec.PasswordChar = '\0';
            this.tbKec.ReadOnly = true;
            this.tbKec.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKec.SelectedText = "";
            this.tbKec.Size = new System.Drawing.Size(157, 23);
            this.tbKec.TabIndex = 18;
            this.tbKec.Text = " ";
            this.tbKec.UseSelectable = true;
            this.tbKec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKec_KeyDown);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(175, 405);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(32, 19);
            this.metroLabel16.TabIndex = 122;
            this.metroLabel16.Text = "Kec.";
            // 
            // tbDesa
            // 
            this.tbDesa.Lines = new string[] {
        " "};
            this.tbDesa.Location = new System.Drawing.Point(218, 372);
            this.tbDesa.MaxLength = 32767;
            this.tbDesa.Name = "tbDesa";
            this.tbDesa.PasswordChar = '\0';
            this.tbDesa.ReadOnly = true;
            this.tbDesa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDesa.SelectedText = "";
            this.tbDesa.Size = new System.Drawing.Size(157, 23);
            this.tbDesa.TabIndex = 17;
            this.tbDesa.Text = " ";
            this.tbDesa.UseSelectable = true;
            this.tbDesa.Click += new System.EventHandler(this.tbDesa_Click);
            this.tbDesa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDesa_KeyDown);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(175, 376);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(23, 19);
            this.metroLabel15.TabIndex = 120;
            this.metroLabel15.Text = "Ds";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(28, 377);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(84, 19);
            this.metroLabel14.TabIndex = 119;
            this.metroLabel14.Text = "Lokasi Kebun";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(28, 344);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(88, 19);
            this.metroLabel13.TabIndex = 118;
            this.metroLabel13.Text = "Varietas Tebu";
            // 
            // tbVarietas
            // 
            this.tbVarietas.Lines = new string[] {
        " "};
            this.tbVarietas.Location = new System.Drawing.Point(175, 340);
            this.tbVarietas.MaxLength = 32767;
            this.tbVarietas.Name = "tbVarietas";
            this.tbVarietas.PasswordChar = '\0';
            this.tbVarietas.ReadOnly = true;
            this.tbVarietas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbVarietas.SelectedText = "";
            this.tbVarietas.Size = new System.Drawing.Size(200, 23);
            this.tbVarietas.TabIndex = 16;
            this.tbVarietas.Text = " ";
            this.tbVarietas.UseSelectable = true;
            this.tbVarietas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbVarietas_KeyDown);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(246, 312);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(25, 19);
            this.metroLabel12.TabIndex = 116;
            this.metroLabel12.Text = "Ha";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(28, 313);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(124, 19);
            this.metroLabel11.TabIndex = 114;
            this.metroLabel11.Text = "Estimasi Luas Panen";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(28, 97);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(96, 19);
            this.metroLabel10.TabIndex = 113;
            this.metroLabel10.Text = "No. Kendaraan";
            // 
            // tbNoTruck
            // 
            this.tbNoTruck.BackColor = System.Drawing.Color.White;
            this.tbNoTruck.Lines = new string[] {
        " "};
            this.tbNoTruck.Location = new System.Drawing.Point(175, 93);
            this.tbNoTruck.MaxLength = 32767;
            this.tbNoTruck.Name = "tbNoTruck";
            this.tbNoTruck.PasswordChar = '\0';
            this.tbNoTruck.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoTruck.SelectedText = "";
            this.tbNoTruck.Size = new System.Drawing.Size(200, 23);
            this.tbNoTruck.TabIndex = 3;
            this.tbNoTruck.Text = " ";
            this.tbNoTruck.UseCustomBackColor = true;
            this.tbNoTruck.UseSelectable = true;
            this.tbNoTruck.UseStyleColors = true;
            this.tbNoTruck.Click += new System.EventHandler(this.tbNoTruck_Click);
            this.tbNoTruck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNoTruck_KeyDown);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(418, 97);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(84, 19);
            this.metroLabel9.TabIndex = 111;
            this.metroLabel9.Text = "Nama Driver";
            // 
            // tbNamaDriver
            // 
            this.tbNamaDriver.Lines = new string[] {
        " "};
            this.tbNamaDriver.Location = new System.Drawing.Point(511, 93);
            this.tbNamaDriver.MaxLength = 32767;
            this.tbNamaDriver.Name = "tbNamaDriver";
            this.tbNamaDriver.PasswordChar = '\0';
            this.tbNamaDriver.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNamaDriver.SelectedText = "";
            this.tbNamaDriver.Size = new System.Drawing.Size(200, 23);
            this.tbNamaDriver.TabIndex = 4;
            this.tbNamaDriver.Text = " ";
            this.tbNamaDriver.UseCustomBackColor = true;
            this.tbNamaDriver.UseSelectable = true;
            this.tbNamaDriver.UseStyleColors = true;
            this.tbNamaDriver.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNamaDriver_KeyDown);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(26, 265);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(128, 19);
            this.metroLabel7.TabIndex = 108;
            this.metroLabel7.Text = "Alamat KTP Petani 1";
            // 
            // tbAlamatPetani1
            // 
            this.tbAlamatPetani1.Lines = new string[0];
            this.tbAlamatPetani1.Location = new System.Drawing.Point(175, 248);
            this.tbAlamatPetani1.MaxLength = 32767;
            this.tbAlamatPetani1.Multiline = true;
            this.tbAlamatPetani1.Name = "tbAlamatPetani1";
            this.tbAlamatPetani1.PasswordChar = '\0';
            this.tbAlamatPetani1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAlamatPetani1.SelectedText = "";
            this.tbAlamatPetani1.Size = new System.Drawing.Size(200, 55);
            this.tbAlamatPetani1.TabIndex = 13;
            this.tbAlamatPetani1.UseSelectable = true;
            this.tbAlamatPetani1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAlamatPetani1_KeyDown);
            // 
            // tbNamaPetani2
            // 
            this.tbNamaPetani2.Lines = new string[0];
            this.tbNamaPetani2.Location = new System.Drawing.Point(175, 217);
            this.tbNamaPetani2.MaxLength = 32767;
            this.tbNamaPetani2.Name = "tbNamaPetani2";
            this.tbNamaPetani2.PasswordChar = '\0';
            this.tbNamaPetani2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNamaPetani2.SelectedText = "";
            this.tbNamaPetani2.Size = new System.Drawing.Size(200, 23);
            this.tbNamaPetani2.TabIndex = 11;
            this.tbNamaPetani2.UseCustomBackColor = true;
            this.tbNamaPetani2.UseSelectable = true;
            this.tbNamaPetani2.UseStyleColors = true;
            this.tbNamaPetani2.TextChanged += new System.EventHandler(this.tbNamaPetani2_TextChanged);
            this.tbNamaPetani2.Click += new System.EventHandler(this.tbNamaPetani2_Click);
            this.tbNamaPetani2.Enter += new System.EventHandler(this.tbNamaPetani2_Enter);
            this.tbNamaPetani2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNamaPetani2_KeyDown);
            this.tbNamaPetani2.Leave += new System.EventHandler(this.tbNamaPetani2_Leave);
            // 
            // tbNamaPetani1
            // 
            this.tbNamaPetani1.Lines = new string[0];
            this.tbNamaPetani1.Location = new System.Drawing.Point(175, 188);
            this.tbNamaPetani1.MaxLength = 32767;
            this.tbNamaPetani1.Name = "tbNamaPetani1";
            this.tbNamaPetani1.PasswordChar = '\0';
            this.tbNamaPetani1.ReadOnly = true;
            this.tbNamaPetani1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNamaPetani1.SelectedText = "";
            this.tbNamaPetani1.Size = new System.Drawing.Size(200, 23);
            this.tbNamaPetani1.TabIndex = 9;
            this.tbNamaPetani1.UseSelectable = true;
            this.tbNamaPetani1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNamaPetani1_KeyDown);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 219);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(96, 19);
            this.metroLabel4.TabIndex = 99;
            this.metroLabel4.Text = "Nama Petani 2";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 98;
            this.metroLabel3.Text = "Nama Petani 1";
            // 
            // tbNoTiketTTA
            // 
            this.tbNoTiketTTA.BackColor = System.Drawing.Color.White;
            this.tbNoTiketTTA.Lines = new string[0];
            this.tbNoTiketTTA.Location = new System.Drawing.Point(175, 64);
            this.tbNoTiketTTA.MaxLength = 32767;
            this.tbNoTiketTTA.Name = "tbNoTiketTTA";
            this.tbNoTiketTTA.PasswordChar = '\0';
            this.tbNoTiketTTA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoTiketTTA.SelectedText = "";
            this.tbNoTiketTTA.Size = new System.Drawing.Size(200, 23);
            this.tbNoTiketTTA.TabIndex = 1;
            this.tbNoTiketTTA.UseSelectable = true;
            this.tbNoTiketTTA.UseStyleColors = true;
            this.tbNoTiketTTA.Click += new System.EventHandler(this.tbNoTiketTTA_Click_1);
            this.tbNoTiketTTA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNoTiketTTA_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 96;
            this.metroLabel1.Text = "No. Tiket TTA";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 159);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 19);
            this.metroLabel2.TabIndex = 95;
            this.metroLabel2.Text = "Nama KUD / KPTR";
            // 
            // tbNamaKUD
            // 
            this.tbNamaKUD.BackColor = System.Drawing.Color.White;
            this.tbNamaKUD.Lines = new string[0];
            this.tbNamaKUD.Location = new System.Drawing.Point(174, 157);
            this.tbNamaKUD.MaxLength = 32767;
            this.tbNamaKUD.Name = "tbNamaKUD";
            this.tbNamaKUD.PasswordChar = '\0';
            this.tbNamaKUD.ReadOnly = true;
            this.tbNamaKUD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNamaKUD.SelectedText = "";
            this.tbNamaKUD.Size = new System.Drawing.Size(200, 23);
            this.tbNamaKUD.TabIndex = 7;
            this.tbNamaKUD.UseSelectable = true;
            this.tbNamaKUD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNamaKUD_KeyDown);
            // 
            // btSimpan
            // 
            this.btSimpan.Enabled = false;
            this.btSimpan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSimpan.Location = new System.Drawing.Point(193, 524);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(88, 41);
            this.btSimpan.TabIndex = 25;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseSelectable = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistrasiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 583);
            this.Controls.Add(this.tbRayon);
            this.Controls.Add(this.GridList);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.lblStatusWrite);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.tbLuasPanen);
            this.Controls.Add(this.chkGandengan);
            this.Controls.Add(this.MChkValidasi);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tbNumCard);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.tbTglRegister);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.metroLabel22);
            this.Controls.Add(this.tbTglTTA);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tbKodeMitra2);
            this.Controls.Add(this.tbKodeMitra);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.tbJabatan2);
            this.Controls.Add(this.tbpenanggungjawabRegion);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.tbJabatan);
            this.Controls.Add(this.tbDibuatOleh);
            this.Controls.Add(this.tbKab);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.tbKec);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.tbDesa);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.tbVarietas);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.tbNoTruck);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.tbNamaDriver);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tbAlamatPetani1);
            this.Controls.Add(this.tbNamaPetani2);
            this.Controls.Add(this.tbNamaPetani1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbNoTiketTTA);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tbNamaKUD);
            this.Controls.Add(this.btSimpan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrasiForm";
            this.Resizable = false;
            this.Text = "Registrasi";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.RegistrasiForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegistrasiForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroTextBox tbJabatan2;
        private MetroFramework.Controls.MetroTextBox tbpenanggungjawabRegion;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox tbJabatan;
        private MetroFramework.Controls.MetroTextBox tbDibuatOleh;
        private MetroFramework.Controls.MetroTextBox tbKab;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox tbKec;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox tbDesa;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox tbVarietas;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox tbNoTruck;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox tbNamaDriver;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbAlamatPetani1;
        private MetroFramework.Controls.MetroTextBox tbNamaPetani2;
        private MetroFramework.Controls.MetroTextBox tbNamaPetani1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbNoTiketTTA;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbNamaKUD;
        private MetroFramework.Controls.MetroButton btSimpan;
        private MetroFramework.Controls.MetroButton btReset;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbKodeMitra2;
        private MetroFramework.Controls.MetroTextBox tbKodeMitra;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroTextBox tbTglTTA;
        private MetroFramework.Controls.MetroButton btnTab;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox tbTglRegister;
        private MetroFramework.Controls.MetroTextBox tbNumCard;
        private System.ComponentModel.BackgroundWorker bgMonitorStatusKartu;
        private System.ComponentModel.BackgroundWorker bgWorkerSearchTTA;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroFramework.Controls.MetroCheckBox MChkValidasi;
        private MetroFramework.Controls.MetroCheckBox chkGandengan;
        private MetroFramework.Controls.MetroTextBox tbLuasPanen;
        private MetroFramework.Controls.MetroLabel lblProgress;
        private MetroFramework.Controls.MetroLabel lblStatusWrite;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroGrid GridList;
        private MetroFramework.Controls.MetroTextBox tbRayon;
    }
}