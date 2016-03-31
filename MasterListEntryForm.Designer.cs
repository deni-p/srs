namespace SRS.DeskApp
{
    partial class MasterListEntryForm
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
            this.cbkategori = new MetroFramework.Controls.MetroComboBox();
            this.cbKelurahan = new MetroFramework.Controls.MetroComboBox();
            this.cbKecamatan = new MetroFramework.Controls.MetroComboBox();
            this.cbKabupaten = new MetroFramework.Controls.MetroComboBox();
            this.cbJenisMitra = new MetroFramework.Controls.MetroComboBox();
            this.tbEstTCH = new MetroFramework.Controls.MetroTextBox();
            this.tbEstHasil = new MetroFramework.Controls.MetroTextBox();
            this.tbLuas = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tbID = new MetroFramework.Controls.MetroTextBox();
            this.tbRadius = new MetroFramework.Controls.MetroTextBox();
            this.tbRitase = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbTglPanen = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbKUD = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbANRek = new MetroFramework.Controls.MetroTextBox();
            this.tbBank = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbNoRek = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel33 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel32 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel31 = new MetroFramework.Controls.MetroLabel();
            this.tbKoordinatY = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel30 = new MetroFramework.Controls.MetroLabel();
            this.tbKoordinatX = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel28 = new MetroFramework.Controls.MetroLabel();
            this.tbPenanggungjawabRegion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.cbRayon = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.tbTglTanam = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.tbVarietas = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.tbTglKontrak = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.tbNoKontrak = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.tbNoHp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.tbNoKTP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.tbAlamatKTP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.tbNamaKelompok = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.tbKetuaKelompok = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.tbNamaMitra = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tbKodeMitra = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.ItemHeight = 23;
            this.cbkategori.Items.AddRange(new object[] {
            "Barat",
            "Timur",
            "Tengah"});
            this.cbkategori.Location = new System.Drawing.Point(546, 89);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(134, 29);
            this.cbkategori.TabIndex = 12;
            this.cbkategori.UseSelectable = true;
            // 
            // cbKelurahan
            // 
            this.cbKelurahan.FormattingEnabled = true;
            this.cbKelurahan.ItemHeight = 23;
            this.cbKelurahan.Location = new System.Drawing.Point(546, 395);
            this.cbKelurahan.Name = "cbKelurahan";
            this.cbKelurahan.Size = new System.Drawing.Size(134, 29);
            this.cbKelurahan.TabIndex = 94;
            this.cbKelurahan.UseSelectable = true;
            this.cbKelurahan.SelectedIndexChanged += new System.EventHandler(this.cbKelurahan_SelectedIndexChanged);
            // 
            // cbKecamatan
            // 
            this.cbKecamatan.FormattingEnabled = true;
            this.cbKecamatan.ItemHeight = 23;
            this.cbKecamatan.Location = new System.Drawing.Point(546, 360);
            this.cbKecamatan.Name = "cbKecamatan";
            this.cbKecamatan.Size = new System.Drawing.Size(134, 29);
            this.cbKecamatan.TabIndex = 93;
            this.cbKecamatan.UseSelectable = true;
            this.cbKecamatan.SelectedIndexChanged += new System.EventHandler(this.cbKecamatan_SelectedIndexChanged);
            // 
            // cbKabupaten
            // 
            this.cbKabupaten.FormattingEnabled = true;
            this.cbKabupaten.ItemHeight = 23;
            this.cbKabupaten.Location = new System.Drawing.Point(546, 325);
            this.cbKabupaten.Name = "cbKabupaten";
            this.cbKabupaten.Size = new System.Drawing.Size(134, 29);
            this.cbKabupaten.TabIndex = 92;
            this.cbKabupaten.UseSelectable = true;
            this.cbKabupaten.SelectedIndexChanged += new System.EventHandler(this.cbKabupaten_SelectedIndexChanged);
            // 
            // cbJenisMitra
            // 
            this.cbJenisMitra.FormattingEnabled = true;
            this.cbJenisMitra.ItemHeight = 23;
            this.cbJenisMitra.Location = new System.Drawing.Point(134, 186);
            this.cbJenisMitra.Name = "cbJenisMitra";
            this.cbJenisMitra.Size = new System.Drawing.Size(134, 29);
            this.cbJenisMitra.TabIndex = 5;
            this.cbJenisMitra.UseSelectable = true;
            this.cbJenisMitra.SelectedIndexChanged += new System.EventHandler(this.cbJenisMitra_SelectedIndexChanged);
            // 
            // tbEstTCH
            // 
            this.tbEstTCH.Lines = new string[] {
        "0"};
            this.tbEstTCH.Location = new System.Drawing.Point(907, 221);
            this.tbEstTCH.MaxLength = 32767;
            this.tbEstTCH.Name = "tbEstTCH";
            this.tbEstTCH.PasswordChar = '\0';
            this.tbEstTCH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEstTCH.SelectedText = "";
            this.tbEstTCH.Size = new System.Drawing.Size(81, 23);
            this.tbEstTCH.TabIndex = 27;
            this.tbEstTCH.Text = "0";
            this.tbEstTCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbEstTCH.UseSelectable = true;
            this.tbEstTCH.VisibleChanged += new System.EventHandler(this.tbEstTCH_VisibleChanged);
            this.tbEstTCH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEstTCH_KeyPress);
            this.tbEstTCH.Validating += new System.ComponentModel.CancelEventHandler(this.tbEstTCH_Validating);
            // 
            // tbEstHasil
            // 
            this.tbEstHasil.Lines = new string[] {
        "0"};
            this.tbEstHasil.Location = new System.Drawing.Point(907, 250);
            this.tbEstHasil.MaxLength = 32767;
            this.tbEstHasil.Name = "tbEstHasil";
            this.tbEstHasil.PasswordChar = '\0';
            this.tbEstHasil.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEstHasil.SelectedText = "";
            this.tbEstHasil.Size = new System.Drawing.Size(81, 23);
            this.tbEstHasil.TabIndex = 28;
            this.tbEstHasil.Text = "0";
            this.tbEstHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbEstHasil.UseSelectable = true;
            this.tbEstHasil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEstHasil_KeyPress);
            this.tbEstHasil.Validating += new System.ComponentModel.CancelEventHandler(this.tbEstHasil_Validating);
            // 
            // tbLuas
            // 
            this.tbLuas.Lines = new string[] {
        "0"};
            this.tbLuas.Location = new System.Drawing.Point(546, 63);
            this.tbLuas.MaxLength = 32767;
            this.tbLuas.Name = "tbLuas";
            this.tbLuas.PasswordChar = '\0';
            this.tbLuas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLuas.SelectedText = "";
            this.tbLuas.Size = new System.Drawing.Size(134, 23);
            this.tbLuas.TabIndex = 11;
            this.tbLuas.Text = "0";
            this.tbLuas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbLuas.UseSelectable = true;
            this.tbLuas.Click += new System.EventHandler(this.tbLuas_Click_1);
            this.tbLuas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLuas_KeyPress);
            this.tbLuas.Validating += new System.ComponentModel.CancelEventHandler(this.tbLuas_Validating);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(796, 311);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(67, 19);
            this.metroLabel9.TabIndex = 86;
            this.metroLabel9.Text = "Est Radius";
            // 
            // tbID
            // 
            this.tbID.Lines = new string[0];
            this.tbID.Location = new System.Drawing.Point(747, 383);
            this.tbID.MaxLength = 32767;
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbID.SelectedText = "";
            this.tbID.Size = new System.Drawing.Size(134, 23);
            this.tbID.TabIndex = 85;
            this.tbID.TabStop = false;
            this.tbID.UseSelectable = true;
            this.tbID.Visible = false;
            // 
            // tbRadius
            // 
            this.tbRadius.Lines = new string[0];
            this.tbRadius.Location = new System.Drawing.Point(907, 309);
            this.tbRadius.MaxLength = 32767;
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.PasswordChar = '\0';
            this.tbRadius.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRadius.SelectedText = "";
            this.tbRadius.Size = new System.Drawing.Size(81, 23);
            this.tbRadius.TabIndex = 30;
            this.tbRadius.UseSelectable = true;
            this.tbRadius.Validating += new System.ComponentModel.CancelEventHandler(this.tbRadius_Validating);
            // 
            // tbRitase
            // 
            this.tbRitase.Lines = new string[] {
        "0"};
            this.tbRitase.Location = new System.Drawing.Point(907, 279);
            this.tbRitase.MaxLength = 32767;
            this.tbRitase.Name = "tbRitase";
            this.tbRitase.PasswordChar = '\0';
            this.tbRitase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRitase.SelectedText = "";
            this.tbRitase.Size = new System.Drawing.Size(81, 23);
            this.tbRitase.TabIndex = 29;
            this.tbRitase.Text = "0";
            this.tbRitase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRitase.UseSelectable = true;
            this.tbRitase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRitase_KeyPress);
            this.tbRitase.Validating += new System.ComponentModel.CancelEventHandler(this.tbRitase_Validating);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(796, 281);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(63, 19);
            this.metroLabel8.TabIndex = 81;
            this.metroLabel8.Text = "Est Ritase";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(796, 252);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 79;
            this.metroLabel7.Text = "Est Hasil";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(796, 221);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 19);
            this.metroLabel6.TabIndex = 77;
            this.metroLabel6.Text = "Est TCH";
            // 
            // tbTglPanen
            // 
            this.tbTglPanen.Location = new System.Drawing.Point(907, 186);
            this.tbTglPanen.MinimumSize = new System.Drawing.Size(0, 29);
            this.tbTglPanen.Name = "tbTglPanen";
            this.tbTglPanen.Size = new System.Drawing.Size(200, 29);
            this.tbTglPanen.TabIndex = 26;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(796, 186);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.TabIndex = 75;
            this.metroLabel5.Text = "Tgl Panen";
            // 
            // tbKUD
            // 
            this.tbKUD.Lines = new string[0];
            this.tbKUD.Location = new System.Drawing.Point(907, 153);
            this.tbKUD.MaxLength = 32767;
            this.tbKUD.Name = "tbKUD";
            this.tbKUD.PasswordChar = '\0';
            this.tbKUD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKUD.SelectedText = "";
            this.tbKUD.Size = new System.Drawing.Size(200, 23);
            this.tbKUD.TabIndex = 25;
            this.tbKUD.UseSelectable = true;
            this.tbKUD.Validating += new System.ComponentModel.CancelEventHandler(this.tbKUD_Validating);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(796, 154);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 73;
            this.metroLabel4.Text = "KUD/KPTR";
            // 
            // tbANRek
            // 
            this.tbANRek.Lines = new string[0];
            this.tbANRek.Location = new System.Drawing.Point(907, 95);
            this.tbANRek.MaxLength = 32767;
            this.tbANRek.Name = "tbANRek";
            this.tbANRek.PasswordChar = '\0';
            this.tbANRek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbANRek.SelectedText = "";
            this.tbANRek.Size = new System.Drawing.Size(200, 23);
            this.tbANRek.TabIndex = 23;
            this.tbANRek.UseSelectable = true;
            this.tbANRek.Validating += new System.ComponentModel.CancelEventHandler(this.tbANRek_Validating);
            // 
            // tbBank
            // 
            this.tbBank.Lines = new string[0];
            this.tbBank.Location = new System.Drawing.Point(907, 124);
            this.tbBank.MaxLength = 32767;
            this.tbBank.Name = "tbBank";
            this.tbBank.PasswordChar = '\0';
            this.tbBank.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBank.SelectedText = "";
            this.tbBank.Size = new System.Drawing.Size(134, 23);
            this.tbBank.TabIndex = 24;
            this.tbBank.UseSelectable = true;
            this.tbBank.Validating += new System.ComponentModel.CancelEventHandler(this.tbBank_Validating);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(796, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 70;
            this.metroLabel3.Text = "Bank";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(796, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 68;
            this.metroLabel2.Text = "A/N Rek";
            // 
            // tbNoRek
            // 
            this.tbNoRek.Lines = new string[0];
            this.tbNoRek.Location = new System.Drawing.Point(907, 66);
            this.tbNoRek.MaxLength = 32767;
            this.tbNoRek.Name = "tbNoRek";
            this.tbNoRek.PasswordChar = '\0';
            this.tbNoRek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoRek.SelectedText = "";
            this.tbNoRek.Size = new System.Drawing.Size(134, 23);
            this.tbNoRek.TabIndex = 22;
            this.tbNoRek.UseSelectable = true;
            this.tbNoRek.Validating += new System.ComponentModel.CancelEventHandler(this.tbNoRek_Validating);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(796, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 66;
            this.metroLabel1.Text = "No Rek";
            // 
            // metroLabel33
            // 
            this.metroLabel33.AutoSize = true;
            this.metroLabel33.Location = new System.Drawing.Point(424, 325);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(71, 19);
            this.metroLabel33.TabIndex = 64;
            this.metroLabel33.Text = "Kabupaten";
            // 
            // metroLabel32
            // 
            this.metroLabel32.AutoSize = true;
            this.metroLabel32.Location = new System.Drawing.Point(422, 358);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(73, 19);
            this.metroLabel32.TabIndex = 62;
            this.metroLabel32.Text = "Kecamatan";
            // 
            // metroLabel31
            // 
            this.metroLabel31.AutoSize = true;
            this.metroLabel31.Location = new System.Drawing.Point(424, 395);
            this.metroLabel31.Name = "metroLabel31";
            this.metroLabel31.Size = new System.Drawing.Size(66, 19);
            this.metroLabel31.TabIndex = 60;
            this.metroLabel31.Text = "Kelurahan";
            // 
            // tbKoordinatY
            // 
            this.tbKoordinatY.Lines = new string[0];
            this.tbKoordinatY.Location = new System.Drawing.Point(546, 296);
            this.tbKoordinatY.MaxLength = 32767;
            this.tbKoordinatY.Name = "tbKoordinatY";
            this.tbKoordinatY.PasswordChar = '\0';
            this.tbKoordinatY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKoordinatY.SelectedText = "";
            this.tbKoordinatY.Size = new System.Drawing.Size(134, 23);
            this.tbKoordinatY.TabIndex = 18;
            this.tbKoordinatY.UseSelectable = true;
            this.tbKoordinatY.Validating += new System.ComponentModel.CancelEventHandler(this.tbKoordinatY_Validating);
            // 
            // metroLabel30
            // 
            this.metroLabel30.AutoSize = true;
            this.metroLabel30.Location = new System.Drawing.Point(422, 300);
            this.metroLabel30.Name = "metroLabel30";
            this.metroLabel30.Size = new System.Drawing.Size(78, 19);
            this.metroLabel30.TabIndex = 58;
            this.metroLabel30.Text = "Koordinat Y";
            // 
            // tbKoordinatX
            // 
            this.tbKoordinatX.Lines = new string[0];
            this.tbKoordinatX.Location = new System.Drawing.Point(546, 267);
            this.tbKoordinatX.MaxLength = 32767;
            this.tbKoordinatX.Name = "tbKoordinatX";
            this.tbKoordinatX.PasswordChar = '\0';
            this.tbKoordinatX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKoordinatX.SelectedText = "";
            this.tbKoordinatX.Size = new System.Drawing.Size(134, 23);
            this.tbKoordinatX.TabIndex = 17;
            this.tbKoordinatX.UseSelectable = true;
            this.tbKoordinatX.Validating += new System.ComponentModel.CancelEventHandler(this.tbKoordinatX_Validating);
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(422, 271);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(78, 19);
            this.metroLabel29.TabIndex = 56;
            this.metroLabel29.Text = "Koordinat X";
            // 
            // metroLabel28
            // 
            this.metroLabel28.AutoSize = true;
            this.metroLabel28.Location = new System.Drawing.Point(422, 240);
            this.metroLabel28.Name = "metroLabel28";
            this.metroLabel28.Size = new System.Drawing.Size(50, 19);
            this.metroLabel28.TabIndex = 55;
            this.metroLabel28.Text = "Region";
            // 
            // tbPenanggungjawabRegion
            // 
            this.tbPenanggungjawabRegion.Lines = new string[0];
            this.tbPenanggungjawabRegion.Location = new System.Drawing.Point(546, 222);
            this.tbPenanggungjawabRegion.MaxLength = 32767;
            this.tbPenanggungjawabRegion.Name = "tbPenanggungjawabRegion";
            this.tbPenanggungjawabRegion.PasswordChar = '\0';
            this.tbPenanggungjawabRegion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPenanggungjawabRegion.SelectedText = "";
            this.tbPenanggungjawabRegion.Size = new System.Drawing.Size(200, 23);
            this.tbPenanggungjawabRegion.TabIndex = 16;
            this.tbPenanggungjawabRegion.UseSelectable = true;
            this.tbPenanggungjawabRegion.Validating += new System.ComponentModel.CancelEventHandler(this.tbPenanggungjawabRegion_Validating);
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.Location = new System.Drawing.Point(422, 221);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(123, 19);
            this.metroLabel27.TabIndex = 53;
            this.metroLabel27.Text = "Penanggung Jawab";
            // 
            // cbRayon
            // 
            this.cbRayon.FormattingEnabled = true;
            this.cbRayon.ItemHeight = 23;
            this.cbRayon.Items.AddRange(new object[] {
            "Barat",
            "Timur",
            "Tengah"});
            this.cbRayon.Location = new System.Drawing.Point(546, 186);
            this.cbRayon.Name = "cbRayon";
            this.cbRayon.Size = new System.Drawing.Size(134, 29);
            this.cbRayon.TabIndex = 15;
            this.cbRayon.UseSelectable = true;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(422, 186);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(45, 19);
            this.metroLabel26.TabIndex = 51;
            this.metroLabel26.Text = "Rayon";
            // 
            // tbTglTanam
            // 
            this.tbTglTanam.Location = new System.Drawing.Point(546, 151);
            this.tbTglTanam.MinimumSize = new System.Drawing.Size(0, 29);
            this.tbTglTanam.Name = "tbTglTanam";
            this.tbTglTanam.Size = new System.Drawing.Size(200, 29);
            this.tbTglTanam.TabIndex = 14;
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(422, 158);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(71, 19);
            this.metroLabel25.TabIndex = 49;
            this.metroLabel25.Text = "Tgl Tanam";
            // 
            // tbVarietas
            // 
            this.tbVarietas.Lines = new string[0];
            this.tbVarietas.Location = new System.Drawing.Point(546, 122);
            this.tbVarietas.MaxLength = 32767;
            this.tbVarietas.Name = "tbVarietas";
            this.tbVarietas.PasswordChar = '\0';
            this.tbVarietas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbVarietas.SelectedText = "";
            this.tbVarietas.Size = new System.Drawing.Size(200, 23);
            this.tbVarietas.TabIndex = 13;
            this.tbVarietas.UseSelectable = true;
            this.tbVarietas.Validating += new System.ComponentModel.CancelEventHandler(this.tbVarietas_Validating);
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(422, 126);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(55, 19);
            this.metroLabel24.TabIndex = 47;
            this.metroLabel24.Text = "Varietas";
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(422, 97);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(58, 19);
            this.metroLabel23.TabIndex = 45;
            this.metroLabel23.Text = "Kategori";
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(422, 70);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(62, 19);
            this.metroLabel22.TabIndex = 43;
            this.metroLabel22.Text = "Luas (Ha)";
            // 
            // tbTglKontrak
            // 
            this.tbTglKontrak.Location = new System.Drawing.Point(134, 395);
            this.tbTglKontrak.MinimumSize = new System.Drawing.Size(0, 29);
            this.tbTglKontrak.Name = "tbTglKontrak";
            this.tbTglKontrak.Size = new System.Drawing.Size(200, 29);
            this.tbTglKontrak.TabIndex = 10;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(23, 395);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(75, 19);
            this.metroLabel21.TabIndex = 41;
            this.metroLabel21.Text = "Tgl Kontrak";
            // 
            // tbNoKontrak
            // 
            this.tbNoKontrak.Lines = new string[0];
            this.tbNoKontrak.Location = new System.Drawing.Point(134, 366);
            this.tbNoKontrak.MaxLength = 32767;
            this.tbNoKontrak.Name = "tbNoKontrak";
            this.tbNoKontrak.PasswordChar = '\0';
            this.tbNoKontrak.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoKontrak.SelectedText = "";
            this.tbNoKontrak.Size = new System.Drawing.Size(200, 23);
            this.tbNoKontrak.TabIndex = 9;
            this.tbNoKontrak.UseSelectable = true;
            this.tbNoKontrak.Validating += new System.ComponentModel.CancelEventHandler(this.tbNoKontrak_Validating);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(23, 367);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(75, 19);
            this.metroLabel20.TabIndex = 39;
            this.metroLabel20.Text = "No Kontrak";
            // 
            // tbNoHp
            // 
            this.tbNoHp.Lines = new string[0];
            this.tbNoHp.Location = new System.Drawing.Point(134, 337);
            this.tbNoHp.MaxLength = 32767;
            this.tbNoHp.Name = "tbNoHp";
            this.tbNoHp.PasswordChar = '\0';
            this.tbNoHp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoHp.SelectedText = "";
            this.tbNoHp.Size = new System.Drawing.Size(134, 23);
            this.tbNoHp.TabIndex = 8;
            this.tbNoHp.UseSelectable = true;
            this.tbNoHp.Validating += new System.ComponentModel.CancelEventHandler(this.tbNoHp_Validating);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(23, 338);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(48, 19);
            this.metroLabel19.TabIndex = 37;
            this.metroLabel19.Text = "No HP";
            // 
            // tbNoKTP
            // 
            this.tbNoKTP.Lines = new string[0];
            this.tbNoKTP.Location = new System.Drawing.Point(134, 308);
            this.tbNoKTP.MaxLength = 32767;
            this.tbNoKTP.Name = "tbNoKTP";
            this.tbNoKTP.PasswordChar = '\0';
            this.tbNoKTP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNoKTP.SelectedText = "";
            this.tbNoKTP.Size = new System.Drawing.Size(134, 23);
            this.tbNoKTP.TabIndex = 7;
            this.tbNoKTP.UseSelectable = true;
            this.tbNoKTP.Validating += new System.ComponentModel.CancelEventHandler(this.tbNoKTP_Validating);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(23, 309);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(53, 19);
            this.metroLabel18.TabIndex = 35;
            this.metroLabel18.Text = "No KTP";
            // 
            // tbAlamatKTP
            // 
            this.tbAlamatKTP.Lines = new string[0];
            this.tbAlamatKTP.Location = new System.Drawing.Point(134, 221);
            this.tbAlamatKTP.MaxLength = 32767;
            this.tbAlamatKTP.Multiline = true;
            this.tbAlamatKTP.Name = "tbAlamatKTP";
            this.tbAlamatKTP.PasswordChar = '\0';
            this.tbAlamatKTP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAlamatKTP.SelectedText = "";
            this.tbAlamatKTP.Size = new System.Drawing.Size(254, 81);
            this.tbAlamatKTP.TabIndex = 6;
            this.tbAlamatKTP.UseSelectable = true;
            this.tbAlamatKTP.Click += new System.EventHandler(this.tbAlamatKTP_Click);
            this.tbAlamatKTP.Validating += new System.ComponentModel.CancelEventHandler(this.tbAlamatKTP_Validating);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(23, 221);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(77, 19);
            this.metroLabel17.TabIndex = 33;
            this.metroLabel17.Text = "Alamat KTP";
            this.metroLabel17.Click += new System.EventHandler(this.metroLabel17_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(23, 186);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(71, 19);
            this.metroLabel16.TabIndex = 31;
            this.metroLabel16.Text = "Jenis Mitra";
            this.metroLabel16.Click += new System.EventHandler(this.metroLabel16_Click);
            // 
            // tbNamaKelompok
            // 
            this.tbNamaKelompok.Lines = new string[0];
            this.tbNamaKelompok.Location = new System.Drawing.Point(134, 157);
            this.tbNamaKelompok.MaxLength = 32767;
            this.tbNamaKelompok.Name = "tbNamaKelompok";
            this.tbNamaKelompok.PasswordChar = '\0';
            this.tbNamaKelompok.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNamaKelompok.SelectedText = "";
            this.tbNamaKelompok.Size = new System.Drawing.Size(200, 23);
            this.tbNamaKelompok.TabIndex = 4;
            this.tbNamaKelompok.UseSelectable = true;
            this.tbNamaKelompok.Click += new System.EventHandler(this.tbNamaKelompok_Click);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(23, 158);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(108, 19);
            this.metroLabel15.TabIndex = 29;
            this.metroLabel15.Text = "Nama Kelompok";
            this.metroLabel15.Click += new System.EventHandler(this.metroLabel15_Click);
            // 
            // tbKetuaKelompok
            // 
            this.tbKetuaKelompok.Lines = new string[0];
            this.tbKetuaKelompok.Location = new System.Drawing.Point(134, 128);
            this.tbKetuaKelompok.MaxLength = 32767;
            this.tbKetuaKelompok.Name = "tbKetuaKelompok";
            this.tbKetuaKelompok.PasswordChar = '\0';
            this.tbKetuaKelompok.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKetuaKelompok.SelectedText = "";
            this.tbKetuaKelompok.Size = new System.Drawing.Size(200, 23);
            this.tbKetuaKelompok.TabIndex = 3;
            this.tbKetuaKelompok.UseSelectable = true;
            this.tbKetuaKelompok.Click += new System.EventHandler(this.tbKetuaKelompok_Click);
            this.tbKetuaKelompok.Validating += new System.ComponentModel.CancelEventHandler(this.tbKetuaKelompok_Validating);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(23, 129);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(104, 19);
            this.metroLabel14.TabIndex = 27;
            this.metroLabel14.Text = "Ketua Kelompok";
            this.metroLabel14.Click += new System.EventHandler(this.metroLabel14_Click);
            // 
            // tbNamaMitra
            // 
            this.tbNamaMitra.Lines = new string[0];
            this.tbNamaMitra.Location = new System.Drawing.Point(134, 99);
            this.tbNamaMitra.MaxLength = 32767;
            this.tbNamaMitra.Name = "tbNamaMitra";
            this.tbNamaMitra.PasswordChar = '\0';
            this.tbNamaMitra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNamaMitra.SelectedText = "";
            this.tbNamaMitra.Size = new System.Drawing.Size(200, 23);
            this.tbNamaMitra.TabIndex = 2;
            this.tbNamaMitra.UseSelectable = true;
            this.tbNamaMitra.Click += new System.EventHandler(this.tbNamaMitra_Click);
            this.tbNamaMitra.Validating += new System.ComponentModel.CancelEventHandler(this.tbNamaMitra_Validating);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(24, 99);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(80, 19);
            this.metroLabel13.TabIndex = 25;
            this.metroLabel13.Text = "Nama Mitra";
            this.metroLabel13.Click += new System.EventHandler(this.metroLabel13_Click);
            // 
            // tbKodeMitra
            // 
            this.tbKodeMitra.Lines = new string[0];
            this.tbKodeMitra.Location = new System.Drawing.Point(134, 70);
            this.tbKodeMitra.MaxLength = 32767;
            this.tbKodeMitra.Name = "tbKodeMitra";
            this.tbKodeMitra.PasswordChar = '\0';
            this.tbKodeMitra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKodeMitra.SelectedText = "";
            this.tbKodeMitra.Size = new System.Drawing.Size(200, 23);
            this.tbKodeMitra.TabIndex = 1;
            this.tbKodeMitra.UseSelectable = true;
            this.tbKodeMitra.Click += new System.EventHandler(this.tbKodeMitra_Click);
            this.tbKodeMitra.Validating += new System.ComponentModel.CancelEventHandler(this.tbKodeMitra_Validating);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(24, 70);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(74, 19);
            this.metroLabel12.TabIndex = 23;
            this.metroLabel12.Text = "Kode Mitra";
            this.metroLabel12.Click += new System.EventHandler(this.metroLabel12_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1019, 388);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 36);
            this.metroButton1.TabIndex = 31;
            this.metroButton1.Text = "Tambahkan";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MasterListEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 439);
            this.Controls.Add(this.cbkategori);
            this.Controls.Add(this.cbKelurahan);
            this.Controls.Add(this.cbKecamatan);
            this.Controls.Add(this.cbKabupaten);
            this.Controls.Add(this.cbJenisMitra);
            this.Controls.Add(this.tbEstTCH);
            this.Controls.Add(this.tbEstHasil);
            this.Controls.Add(this.tbLuas);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.tbRitase);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.tbTglPanen);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tbKUD);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tbANRek);
            this.Controls.Add(this.tbBank);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tbNoRek);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel33);
            this.Controls.Add(this.metroLabel32);
            this.Controls.Add(this.metroLabel31);
            this.Controls.Add(this.tbKoordinatY);
            this.Controls.Add(this.metroLabel30);
            this.Controls.Add(this.tbKoordinatX);
            this.Controls.Add(this.metroLabel29);
            this.Controls.Add(this.metroLabel28);
            this.Controls.Add(this.tbPenanggungjawabRegion);
            this.Controls.Add(this.metroLabel27);
            this.Controls.Add(this.cbRayon);
            this.Controls.Add(this.metroLabel26);
            this.Controls.Add(this.tbTglTanam);
            this.Controls.Add(this.metroLabel25);
            this.Controls.Add(this.tbVarietas);
            this.Controls.Add(this.metroLabel24);
            this.Controls.Add(this.metroLabel23);
            this.Controls.Add(this.metroLabel22);
            this.Controls.Add(this.tbTglKontrak);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.tbNoKontrak);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.tbNoHp);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.tbNoKTP);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.tbAlamatKTP);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.tbNamaKelompok);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.tbKetuaKelompok);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.tbNamaMitra);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.tbKodeMitra);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroButton1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterListEntryForm";
            this.Text = "Entry Master List";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterListEntryForm_FormClosing);
            this.Load += new System.EventHandler(this.MasterListEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox tbNamaKelompok;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox tbKetuaKelompok;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox tbNamaMitra;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox tbKodeMitra;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox tbAlamatKTP;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox tbNoKontrak;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox tbNoHp;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTextBox tbNoKTP;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroDateTime tbTglKontrak;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroDateTime tbTglTanam;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroTextBox tbVarietas;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroComboBox cbRayon;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroLabel metroLabel28;
        private MetroFramework.Controls.MetroTextBox tbPenanggungjawabRegion;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroLabel metroLabel33;
        private MetroFramework.Controls.MetroLabel metroLabel32;
        private MetroFramework.Controls.MetroLabel metroLabel31;
        private MetroFramework.Controls.MetroTextBox tbKoordinatY;
        private MetroFramework.Controls.MetroLabel metroLabel30;
        private MetroFramework.Controls.MetroTextBox tbKoordinatX;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbNoRek;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbBank;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbANRek;
        private MetroFramework.Controls.MetroDateTime tbTglPanen;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbKUD;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox tbRitase;
        private MetroFramework.Controls.MetroTextBox tbRadius;
        private MetroFramework.Controls.MetroTextBox tbID;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox tbLuas;
        private MetroFramework.Controls.MetroTextBox tbEstTCH;
        private MetroFramework.Controls.MetroTextBox tbEstHasil;
        private MetroFramework.Controls.MetroComboBox cbkategori;
        private MetroFramework.Controls.MetroComboBox cbKelurahan;
        private MetroFramework.Controls.MetroComboBox cbKecamatan;
        private MetroFramework.Controls.MetroComboBox cbKabupaten;
        private MetroFramework.Controls.MetroComboBox cbJenisMitra;
    }
}