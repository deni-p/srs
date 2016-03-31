namespace SRS.DeskApp
{
    partial class RegistrasiNewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrasiNewForm));
            this.bgMonitorStatusKartu = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerSearchTTA = new System.ComponentModel.BackgroundWorker();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dtTTA = new MetroFramework.Controls.MetroDateTime();
            this.cbKelurahan = new MetroFramework.Controls.MetroComboBox();
            this.cbKecamatan = new MetroFramework.Controls.MetroComboBox();
            this.cbKabupaten = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.GridList = new MetroFramework.Controls.MetroGrid();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.lblProgress = new MetroFramework.Controls.MetroLabel();
            this.tbLuasPanen = new MetroFramework.Controls.MetroTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.tbTglTTA = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbKodeMitra2 = new MetroFramework.Controls.MetroTextBox();
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
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tbVarietas = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbAlamatPetani1 = new MetroFramework.Controls.MetroTextBox();
            this.tbNamaPetani2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbNoTiketTTA = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btSimpan = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tbNamaDriver = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tbNoTruck = new MetroFramework.Controls.MetroTextBox();
            this.lblStatusWrite = new MetroFramework.Controls.MetroLabel();
            this.btnTab = new MetroFramework.Controls.MetroButton();
            this.chkGandengan = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bgMonitorStatusKartu
            // 
            this.bgMonitorStatusKartu.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgMonitorStatusKartu_DoWork);
            // 
            // bgWorkerSearchTTA
            // 
            this.bgWorkerSearchTTA.WorkerReportsProgress = true;
            this.bgWorkerSearchTTA.WorkerSupportsCancellation = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(29, 151);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(86, 19);
            this.metroLabel8.TabIndex = 160;
            this.metroLabel8.Text = "Tgl Registrasi";
            // 
            // dtTTA
            // 
            this.dtTTA.Location = new System.Drawing.Point(194, 115);
            this.dtTTA.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTTA.Name = "dtTTA";
            this.dtTTA.Size = new System.Drawing.Size(200, 29);
            this.dtTTA.TabIndex = 5;
            // 
            // cbKelurahan
            // 
            this.cbKelurahan.BackColor = System.Drawing.Color.White;
            this.cbKelurahan.FormattingEnabled = true;
            this.cbKelurahan.ItemHeight = 23;
            this.cbKelurahan.Location = new System.Drawing.Point(194, 425);
            this.cbKelurahan.Name = "cbKelurahan";
            this.cbKelurahan.Size = new System.Drawing.Size(200, 29);
            this.cbKelurahan.TabIndex = 16;
            this.cbKelurahan.UseCustomBackColor = true;
            this.cbKelurahan.UseSelectable = true;
            this.cbKelurahan.UseStyleColors = true;
            this.cbKelurahan.SelectedIndexChanged += new System.EventHandler(this.cbKelurahan_SelectedIndexChanged);
            // 
            // cbKecamatan
            // 
            this.cbKecamatan.BackColor = System.Drawing.Color.White;
            this.cbKecamatan.FormattingEnabled = true;
            this.cbKecamatan.ItemHeight = 23;
            this.cbKecamatan.Location = new System.Drawing.Point(194, 390);
            this.cbKecamatan.Name = "cbKecamatan";
            this.cbKecamatan.Size = new System.Drawing.Size(200, 29);
            this.cbKecamatan.TabIndex = 15;
            this.cbKecamatan.UseCustomBackColor = true;
            this.cbKecamatan.UseSelectable = true;
            this.cbKecamatan.UseStyleColors = true;
            this.cbKecamatan.SelectedIndexChanged += new System.EventHandler(this.cbKecamatan_SelectedIndexChanged);
            // 
            // cbKabupaten
            // 
            this.cbKabupaten.BackColor = System.Drawing.Color.White;
            this.cbKabupaten.FormattingEnabled = true;
            this.cbKabupaten.ItemHeight = 23;
            this.cbKabupaten.Location = new System.Drawing.Point(194, 355);
            this.cbKabupaten.Name = "cbKabupaten";
            this.cbKabupaten.Size = new System.Drawing.Size(200, 29);
            this.cbKabupaten.TabIndex = 14;
            this.cbKabupaten.UseCustomBackColor = true;
            this.cbKabupaten.UseSelectable = true;
            this.cbKabupaten.UseStyleColors = true;
            this.cbKabupaten.SelectedIndexChanged += new System.EventHandler(this.cbKabupaten_SelectedIndexChanged);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(137, 360);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(34, 19);
            this.metroLabel17.TabIndex = 159;
            this.metroLabel17.Text = "Kab.";
            this.metroLabel17.Click += new System.EventHandler(this.metroLabel17_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(136, 395);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(32, 19);
            this.metroLabel16.TabIndex = 158;
            this.metroLabel16.Text = "Kec.";
            this.metroLabel16.Click += new System.EventHandler(this.metroLabel16_Click);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(137, 430);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(23, 19);
            this.metroLabel15.TabIndex = 157;
            this.metroLabel15.Text = "Ds";
            this.metroLabel15.Click += new System.EventHandler(this.metroLabel15_Click);
            // 
            // GridList
            // 
            this.GridList.AllowUserToResizeRows = false;
            this.GridList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridList.ColumnHeadersHeight = 20;
            this.GridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridList.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridList.EnableHeadersVisualStyles = false;
            this.GridList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridList.Location = new System.Drawing.Point(261, 200);
            this.GridList.Name = "GridList";
            this.GridList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridList.RowHeadersWidth = 4;
            this.GridList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GridList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GridList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridList.RowTemplate.DividerHeight = 1;
            this.GridList.RowTemplate.Height = 20;
            this.GridList.RowTemplate.ReadOnly = true;
            this.GridList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridList.Size = new System.Drawing.Size(290, 120);
            this.GridList.Style = MetroFramework.MetroColorStyle.Teal;
            this.GridList.TabIndex = 153;
            this.GridList.UseCustomBackColor = true;
            this.GridList.UseCustomForeColor = true;
            this.GridList.UseStyleColors = true;
            this.GridList.Visible = false;
            this.GridList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridList_CellContentClick_1);
            this.GridList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridList_CellDoubleClick);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton2.BackgroundImage")));
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton2.Location = new System.Drawing.Point(400, 178);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(23, 23);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(29, 57);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(154, 19);
            this.lblProgress.TabIndex = 150;
            this.lblProgress.Text = "Wait... Progresss";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProgress.Visible = false;
            this.lblProgress.Click += new System.EventHandler(this.lblProgress_Click_1);
            // 
            // tbLuasPanen
            // 
            this.tbLuasPanen.BackColor = System.Drawing.Color.White;
            this.tbLuasPanen.Lines = new string[] {
        "0.00"};
            this.tbLuasPanen.Location = new System.Drawing.Point(194, 297);
            this.tbLuasPanen.MaxLength = 32767;
            this.tbLuasPanen.Name = "tbLuasPanen";
            this.tbLuasPanen.PasswordChar = '\0';
            this.tbLuasPanen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLuasPanen.SelectedText = "";
            this.tbLuasPanen.Size = new System.Drawing.Size(61, 23);
            this.tbLuasPanen.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLuasPanen.TabIndex = 11;
            this.tbLuasPanen.Text = "0.00";
            this.tbLuasPanen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbLuasPanen.UseCustomBackColor = true;
            this.tbLuasPanen.UseSelectable = true;
            this.tbLuasPanen.UseStyleColors = true;
            this.tbLuasPanen.Click += new System.EventHandler(this.tbLuasPanen_Click);
            this.tbLuasPanen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLuasPanen_KeyDown);
            this.tbLuasPanen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLuasPanen_KeyPress);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(194, 57);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 19);
            this.progressBar1.TabIndex = 148;
            this.progressBar1.Visible = false;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(29, 120);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(83, 19);
            this.metroLabel22.TabIndex = 141;
            this.metroLabel22.Text = "Tanggal TTA";
            // 
            // tbTglTTA
            // 
            this.tbTglTTA.BackColor = System.Drawing.Color.White;
            this.tbTglTTA.Lines = new string[] {
        " "};
            this.tbTglTTA.Location = new System.Drawing.Point(194, 149);
            this.tbTglTTA.MaxLength = 32767;
            this.tbTglTTA.Name = "tbTglTTA";
            this.tbTglTTA.PasswordChar = '\0';
            this.tbTglTTA.ReadOnly = true;
            this.tbTglTTA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTglTTA.SelectedText = "";
            this.tbTglTTA.Size = new System.Drawing.Size(200, 23);
            this.tbTglTTA.TabIndex = 6;
            this.tbTglTTA.Text = " ";
            this.tbTglTTA.UseCustomBackColor = true;
            this.tbTglTTA.UseSelectable = true;
            this.tbTglTTA.UseStyleColors = true;
            this.tbTglTTA.Click += new System.EventHandler(this.tbTglTTA_Click);
            this.tbTglTTA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTglTTA_KeyDown);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(29, 209);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(74, 19);
            this.metroLabel6.TabIndex = 139;
            this.metroLabel6.Text = "Kode Mitra";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // tbKodeMitra2
            // 
            this.tbKodeMitra2.Lines = new string[0];
            this.tbKodeMitra2.Location = new System.Drawing.Point(194, 207);
            this.tbKodeMitra2.MaxLength = 32767;
            this.tbKodeMitra2.Name = "tbKodeMitra2";
            this.tbKodeMitra2.PasswordChar = '\0';
            this.tbKodeMitra2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKodeMitra2.SelectedText = "";
            this.tbKodeMitra2.Size = new System.Drawing.Size(200, 23);
            this.tbKodeMitra2.TabIndex = 9;
            this.tbKodeMitra2.UseCustomBackColor = true;
            this.tbKodeMitra2.UseSelectable = true;
            this.tbKodeMitra2.UseStyleColors = true;
            this.tbKodeMitra2.Click += new System.EventHandler(this.tbKodeMitra2_Click);
            this.tbKodeMitra2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKodeMitra2_KeyDown);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(400, 86);
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
            this.btReset.Location = new System.Drawing.Point(306, 585);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(88, 41);
            this.btReset.TabIndex = 22;
            this.btReset.Text = "Batal";
            this.btReset.UseSelectable = true;
            this.btReset.Visible = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(23, 548);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(54, 19);
            this.metroLabel20.TabIndex = 133;
            this.metroLabel20.Text = "Jabatan";
            this.metroLabel20.Click += new System.EventHandler(this.metroLabel20_Click);
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(23, 519);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(160, 19);
            this.metroLabel21.TabIndex = 132;
            this.metroLabel21.Text = "Penangung Jawab Region";
            this.metroLabel21.Click += new System.EventHandler(this.metroLabel21_Click);
            // 
            // tbJabatan2
            // 
            this.tbJabatan2.BackColor = System.Drawing.Color.White;
            this.tbJabatan2.Lines = new string[0];
            this.tbJabatan2.Location = new System.Drawing.Point(194, 548);
            this.tbJabatan2.MaxLength = 32767;
            this.tbJabatan2.Name = "tbJabatan2";
            this.tbJabatan2.PasswordChar = '\0';
            this.tbJabatan2.ReadOnly = true;
            this.tbJabatan2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbJabatan2.SelectedText = "";
            this.tbJabatan2.Size = new System.Drawing.Size(200, 23);
            this.tbJabatan2.TabIndex = 20;
            this.tbJabatan2.UseCustomBackColor = true;
            this.tbJabatan2.UseSelectable = true;
            this.tbJabatan2.UseStyleColors = true;
            this.tbJabatan2.Click += new System.EventHandler(this.tbJabatan2_Click);
            this.tbJabatan2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbJabatan2_KeyDown);
            // 
            // tbpenanggungjawabRegion
            // 
            this.tbpenanggungjawabRegion.BackColor = System.Drawing.Color.White;
            this.tbpenanggungjawabRegion.Lines = new string[0];
            this.tbpenanggungjawabRegion.Location = new System.Drawing.Point(194, 519);
            this.tbpenanggungjawabRegion.MaxLength = 32767;
            this.tbpenanggungjawabRegion.Name = "tbpenanggungjawabRegion";
            this.tbpenanggungjawabRegion.PasswordChar = '\0';
            this.tbpenanggungjawabRegion.ReadOnly = true;
            this.tbpenanggungjawabRegion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbpenanggungjawabRegion.SelectedText = "";
            this.tbpenanggungjawabRegion.Size = new System.Drawing.Size(200, 23);
            this.tbpenanggungjawabRegion.TabIndex = 19;
            this.tbpenanggungjawabRegion.UseCustomBackColor = true;
            this.tbpenanggungjawabRegion.UseSelectable = true;
            this.tbpenanggungjawabRegion.UseStyleColors = true;
            this.tbpenanggungjawabRegion.Click += new System.EventHandler(this.tbpenanggungjawabRegion_Click);
            this.tbpenanggungjawabRegion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbpenanggungjawabRegion_KeyDown);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(23, 490);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(54, 19);
            this.metroLabel19.TabIndex = 129;
            this.metroLabel19.Text = "Jabatan";
            this.metroLabel19.Click += new System.EventHandler(this.metroLabel19_Click);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(23, 463);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(79, 19);
            this.metroLabel18.TabIndex = 128;
            this.metroLabel18.Text = "Dibuat Oleh";
            this.metroLabel18.Click += new System.EventHandler(this.metroLabel18_Click);
            // 
            // tbJabatan
            // 
            this.tbJabatan.BackColor = System.Drawing.Color.White;
            this.tbJabatan.Lines = new string[0];
            this.tbJabatan.Location = new System.Drawing.Point(194, 490);
            this.tbJabatan.MaxLength = 32767;
            this.tbJabatan.Name = "tbJabatan";
            this.tbJabatan.PasswordChar = '\0';
            this.tbJabatan.ReadOnly = true;
            this.tbJabatan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbJabatan.SelectedText = "";
            this.tbJabatan.Size = new System.Drawing.Size(200, 23);
            this.tbJabatan.TabIndex = 18;
            this.tbJabatan.UseCustomBackColor = true;
            this.tbJabatan.UseSelectable = true;
            this.tbJabatan.UseStyleColors = true;
            this.tbJabatan.Click += new System.EventHandler(this.tbJabatan_Click);
            this.tbJabatan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbJabatan_KeyDown);
            // 
            // tbDibuatOleh
            // 
            this.tbDibuatOleh.BackColor = System.Drawing.Color.White;
            this.tbDibuatOleh.Lines = new string[0];
            this.tbDibuatOleh.Location = new System.Drawing.Point(194, 461);
            this.tbDibuatOleh.MaxLength = 32767;
            this.tbDibuatOleh.Name = "tbDibuatOleh";
            this.tbDibuatOleh.PasswordChar = '\0';
            this.tbDibuatOleh.ReadOnly = true;
            this.tbDibuatOleh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDibuatOleh.SelectedText = "";
            this.tbDibuatOleh.Size = new System.Drawing.Size(200, 23);
            this.tbDibuatOleh.TabIndex = 17;
            this.tbDibuatOleh.UseCustomBackColor = true;
            this.tbDibuatOleh.UseSelectable = true;
            this.tbDibuatOleh.UseStyleColors = true;
            this.tbDibuatOleh.Click += new System.EventHandler(this.tbDibuatOleh_Click);
            this.tbDibuatOleh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDibuatOleh_KeyDown);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(29, 360);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(84, 19);
            this.metroLabel14.TabIndex = 119;
            this.metroLabel14.Text = "Lokasi Kebun";
            this.metroLabel14.Click += new System.EventHandler(this.metroLabel14_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(29, 328);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(88, 19);
            this.metroLabel13.TabIndex = 118;
            this.metroLabel13.Text = "Varietas Tebu";
            this.metroLabel13.Click += new System.EventHandler(this.metroLabel13_Click);
            // 
            // tbVarietas
            // 
            this.tbVarietas.BackColor = System.Drawing.Color.White;
            this.tbVarietas.Lines = new string[] {
        " "};
            this.tbVarietas.Location = new System.Drawing.Point(194, 326);
            this.tbVarietas.MaxLength = 32767;
            this.tbVarietas.Name = "tbVarietas";
            this.tbVarietas.PasswordChar = '\0';
            this.tbVarietas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbVarietas.SelectedText = "";
            this.tbVarietas.Size = new System.Drawing.Size(200, 23);
            this.tbVarietas.TabIndex = 12;
            this.tbVarietas.Text = " ";
            this.tbVarietas.UseCustomBackColor = true;
            this.tbVarietas.UseSelectable = true;
            this.tbVarietas.UseStyleColors = true;
            this.tbVarietas.Click += new System.EventHandler(this.tbVarietas_Click);
            this.tbVarietas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbVarietas_KeyDown);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(266, 299);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(25, 19);
            this.metroLabel12.TabIndex = 116;
            this.metroLabel12.Text = "Ha";
            this.metroLabel12.Click += new System.EventHandler(this.metroLabel12_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(30, 299);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(124, 19);
            this.metroLabel11.TabIndex = 114;
            this.metroLabel11.Text = "Estimasi Luas Panen";
            this.metroLabel11.Click += new System.EventHandler(this.metroLabel11_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(29, 234);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(117, 19);
            this.metroLabel7.TabIndex = 108;
            this.metroLabel7.Text = "Alamat KTP Petani";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // tbAlamatPetani1
            // 
            this.tbAlamatPetani1.Lines = new string[0];
            this.tbAlamatPetani1.Location = new System.Drawing.Point(194, 236);
            this.tbAlamatPetani1.MaxLength = 32767;
            this.tbAlamatPetani1.Multiline = true;
            this.tbAlamatPetani1.Name = "tbAlamatPetani1";
            this.tbAlamatPetani1.PasswordChar = '\0';
            this.tbAlamatPetani1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAlamatPetani1.SelectedText = "";
            this.tbAlamatPetani1.Size = new System.Drawing.Size(200, 55);
            this.tbAlamatPetani1.TabIndex = 10;
            this.tbAlamatPetani1.UseCustomBackColor = true;
            this.tbAlamatPetani1.UseSelectable = true;
            this.tbAlamatPetani1.UseStyleColors = true;
            this.tbAlamatPetani1.Click += new System.EventHandler(this.tbAlamatPetani1_Click);
            this.tbAlamatPetani1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAlamatPetani1_KeyDown);
            // 
            // tbNamaPetani2
            // 
            this.tbNamaPetani2.Lines = new string[0];
            this.tbNamaPetani2.Location = new System.Drawing.Point(194, 178);
            this.tbNamaPetani2.MaxLength = 32767;
            this.tbNamaPetani2.Name = "tbNamaPetani2";
            this.tbNamaPetani2.PasswordChar = '\0';
            this.tbNamaPetani2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNamaPetani2.SelectedText = "";
            this.tbNamaPetani2.Size = new System.Drawing.Size(200, 23);
            this.tbNamaPetani2.TabIndex = 7;
            this.tbNamaPetani2.UseCustomBackColor = true;
            this.tbNamaPetani2.UseSelectable = true;
            this.tbNamaPetani2.UseStyleColors = true;
            this.tbNamaPetani2.TextChanged += new System.EventHandler(this.tbNamaPetani2_TextChanged);
            this.tbNamaPetani2.Click += new System.EventHandler(this.tbNamaPetani2_Click);
            this.tbNamaPetani2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNamaPetani2_KeyDown);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(29, 178);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 19);
            this.metroLabel4.TabIndex = 99;
            this.metroLabel4.Text = "Nama Petani";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // tbNoTiketTTA
            // 
            this.tbNoTiketTTA.BackColor = System.Drawing.Color.White;
            this.tbNoTiketTTA.Lines = new string[0];
            this.tbNoTiketTTA.Location = new System.Drawing.Point(194, 86);
            this.tbNoTiketTTA.MaxLength = 32767;
            this.tbNoTiketTTA.Name = "tbNoTiketTTA";
            this.tbNoTiketTTA.PasswordChar = '\0';
            this.tbNoTiketTTA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoTiketTTA.SelectedText = "";
            this.tbNoTiketTTA.Size = new System.Drawing.Size(200, 23);
            this.tbNoTiketTTA.TabIndex = 1;
            this.tbNoTiketTTA.UseCustomBackColor = true;
            this.tbNoTiketTTA.UseSelectable = true;
            this.tbNoTiketTTA.UseStyleColors = true;
            this.tbNoTiketTTA.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.tbNoTiketTTA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNoTiketTTA_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 96;
            this.metroLabel1.Text = "No. Tiket TTA";
            // 
            // btSimpan
            // 
            this.btSimpan.Enabled = false;
            this.btSimpan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSimpan.Location = new System.Drawing.Point(194, 585);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(88, 41);
            this.btSimpan.TabIndex = 21;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseSelectable = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(455, 88);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(84, 19);
            this.metroLabel9.TabIndex = 162;
            this.metroLabel9.Text = "Nama Driver";
            // 
            // tbNamaDriver
            // 
            this.tbNamaDriver.BackColor = System.Drawing.Color.White;
            this.tbNamaDriver.Lines = new string[] {
        " "};
            this.tbNamaDriver.Location = new System.Drawing.Point(564, 86);
            this.tbNamaDriver.MaxLength = 32767;
            this.tbNamaDriver.Name = "tbNamaDriver";
            this.tbNamaDriver.PasswordChar = '\0';
            this.tbNamaDriver.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNamaDriver.SelectedText = "";
            this.tbNamaDriver.Size = new System.Drawing.Size(128, 23);
            this.tbNamaDriver.TabIndex = 3;
            this.tbNamaDriver.Text = " ";
            this.tbNamaDriver.UseCustomBackColor = true;
            this.tbNamaDriver.UseSelectable = true;
            this.tbNamaDriver.UseStyleColors = true;
            this.tbNamaDriver.Click += new System.EventHandler(this.tbNamaDriver_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(455, 120);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(93, 19);
            this.metroLabel10.TabIndex = 164;
            this.metroLabel10.Text = "No Kendaraan";
            this.metroLabel10.Click += new System.EventHandler(this.metroLabel10_Click);
            // 
            // tbNoTruck
            // 
            this.tbNoTruck.BackColor = System.Drawing.Color.White;
            this.tbNoTruck.Lines = new string[] {
        " "};
            this.tbNoTruck.Location = new System.Drawing.Point(564, 118);
            this.tbNoTruck.MaxLength = 32767;
            this.tbNoTruck.Name = "tbNoTruck";
            this.tbNoTruck.PasswordChar = '\0';
            this.tbNoTruck.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoTruck.SelectedText = "";
            this.tbNoTruck.Size = new System.Drawing.Size(128, 23);
            this.tbNoTruck.TabIndex = 4;
            this.tbNoTruck.Text = " ";
            this.tbNoTruck.UseCustomBackColor = true;
            this.tbNoTruck.UseSelectable = true;
            this.tbNoTruck.UseStyleColors = true;
            this.tbNoTruck.Click += new System.EventHandler(this.tbNoTruck_Click_1);
            // 
            // lblStatusWrite
            // 
            this.lblStatusWrite.Location = new System.Drawing.Point(413, 526);
            this.lblStatusWrite.Name = "lblStatusWrite";
            this.lblStatusWrite.Size = new System.Drawing.Size(197, 45);
            this.lblStatusWrite.TabIndex = 166;
            this.lblStatusWrite.Text = "Silahkan Ditunggu, Sedang Menulis Data Ke Kartu..";
            this.lblStatusWrite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatusWrite.Visible = false;
            this.lblStatusWrite.WrapToLine = true;
            // 
            // btnTab
            // 
            this.btnTab.Enabled = false;
            this.btnTab.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTab.Location = new System.Drawing.Point(413, 585);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(200, 41);
            this.btnTab.TabIndex = 23;
            this.btnTab.Text = "TAP (Simpan Data Ke Kartu)";
            this.btnTab.UseSelectable = true;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // chkGandengan
            // 
            this.chkGandengan.AutoSize = true;
            this.chkGandengan.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkGandengan.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkGandengan.Location = new System.Drawing.Point(564, 151);
            this.chkGandengan.Name = "chkGandengan";
            this.chkGandengan.Size = new System.Drawing.Size(85, 19);
            this.chkGandengan.TabIndex = 167;
            this.chkGandengan.Text = "Gandeng";
            this.chkGandengan.UseSelectable = true;
            // 
            // RegistrasiNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 633);
            this.Controls.Add(this.chkGandengan);
            this.Controls.Add(this.lblStatusWrite);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.tbNoTruck);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.tbNamaDriver);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.dtTTA);
            this.Controls.Add(this.cbKelurahan);
            this.Controls.Add(this.cbKecamatan);
            this.Controls.Add(this.cbKabupaten);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.GridList);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.tbLuasPanen);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.metroLabel22);
            this.Controls.Add(this.tbTglTTA);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.tbKodeMitra2);
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
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.tbVarietas);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tbAlamatPetani1);
            this.Controls.Add(this.tbNamaPetani2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tbNoTiketTTA);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btSimpan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrasiNewForm";
            this.Resizable = false;
            this.Text = "Registrasi Petani Baru";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.RegistrasiNewForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegistrasiNewForm_KeyDown);
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
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox tbVarietas;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbAlamatPetani1;
        private MetroFramework.Controls.MetroTextBox tbNamaPetani2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbNoTiketTTA;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btSimpan;
        private MetroFramework.Controls.MetroButton btReset;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tbKodeMitra2;
        private System.ComponentModel.BackgroundWorker bgMonitorStatusKartu;
        private System.ComponentModel.BackgroundWorker bgWorkerSearchTTA;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroFramework.Controls.MetroTextBox tbLuasPanen;
        private MetroFramework.Controls.MetroLabel lblProgress;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroGrid GridList;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroTextBox tbTglTTA;
        private MetroFramework.Controls.MetroComboBox cbKelurahan;
        private MetroFramework.Controls.MetroComboBox cbKecamatan;
        private MetroFramework.Controls.MetroComboBox cbKabupaten;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroDateTime dtTTA;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox tbNamaDriver;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox tbNoTruck;
        private MetroFramework.Controls.MetroLabel lblStatusWrite;
        private MetroFramework.Controls.MetroButton btnTab;
        private MetroFramework.Controls.MetroCheckBox chkGandengan;
    }
}