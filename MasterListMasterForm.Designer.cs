namespace SRS.DeskApp
{
    partial class MasterListMasterForm
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
            this.tbID = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tbRegion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.tbSuperVisor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tbAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tbContractNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbContactNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbPartnerId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbPartnerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbSubDistrict = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbDistrict = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbLandArea = new SRS.DeskApp.NumericTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Lines = new string[] {
        "0"};
            this.tbID.Location = new System.Drawing.Point(329, 74);
            this.tbID.MaxLength = 32767;
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbID.SelectedText = "";
            this.tbID.Size = new System.Drawing.Size(37, 23);
            this.tbID.TabIndex = 46;
            this.tbID.Text = "0";
            this.tbID.UseSelectable = true;
            this.tbID.Visible = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(329, 512);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 36);
            this.metroButton1.TabIndex = 45;
            this.metroButton1.Text = "Tambahkan";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tbRegion
            // 
            this.tbRegion.Lines = new string[0];
            this.tbRegion.Location = new System.Drawing.Point(123, 473);
            this.tbRegion.MaxLength = 32767;
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.PasswordChar = '\0';
            this.tbRegion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRegion.SelectedText = "";
            this.tbRegion.Size = new System.Drawing.Size(200, 23);
            this.tbRegion.TabIndex = 44;
            this.tbRegion.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(12, 473);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(50, 19);
            this.metroLabel11.TabIndex = 43;
            this.metroLabel11.Text = "Region";
            // 
            // tbSuperVisor
            // 
            this.tbSuperVisor.Lines = new string[0];
            this.tbSuperVisor.Location = new System.Drawing.Point(123, 437);
            this.tbSuperVisor.MaxLength = 32767;
            this.tbSuperVisor.Name = "tbSuperVisor";
            this.tbSuperVisor.PasswordChar = '\0';
            this.tbSuperVisor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSuperVisor.SelectedText = "";
            this.tbSuperVisor.Size = new System.Drawing.Size(200, 23);
            this.tbSuperVisor.TabIndex = 42;
            this.tbSuperVisor.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(12, 437);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(70, 19);
            this.metroLabel10.TabIndex = 41;
            this.metroLabel10.Text = "Supervisor";
            // 
            // tbAddress
            // 
            this.tbAddress.Lines = new string[0];
            this.tbAddress.Location = new System.Drawing.Point(123, 345);
            this.tbAddress.MaxLength = 32767;
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '\0';
            this.tbAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAddress.SelectedText = "";
            this.tbAddress.Size = new System.Drawing.Size(294, 81);
            this.tbAddress.TabIndex = 40;
            this.tbAddress.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(12, 345);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(56, 19);
            this.metroLabel9.TabIndex = 39;
            this.metroLabel9.Text = "Address";
            // 
            // tbContractNo
            // 
            this.tbContractNo.Lines = new string[0];
            this.tbContractNo.Location = new System.Drawing.Point(123, 311);
            this.tbContractNo.MaxLength = 32767;
            this.tbContractNo.Name = "tbContractNo";
            this.tbContractNo.PasswordChar = '\0';
            this.tbContractNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbContractNo.SelectedText = "";
            this.tbContractNo.Size = new System.Drawing.Size(200, 23);
            this.tbContractNo.TabIndex = 38;
            this.tbContractNo.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(12, 311);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 37;
            this.metroLabel8.Text = "Contract No";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(12, 279);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = "Land Area (Ha)";
            // 
            // tbContactNo
            // 
            this.tbContactNo.Lines = new string[0];
            this.tbContactNo.Location = new System.Drawing.Point(123, 243);
            this.tbContactNo.MaxLength = 32767;
            this.tbContactNo.Name = "tbContactNo";
            this.tbContactNo.PasswordChar = '\0';
            this.tbContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbContactNo.SelectedText = "";
            this.tbContactNo.Size = new System.Drawing.Size(200, 23);
            this.tbContactNo.TabIndex = 34;
            this.tbContactNo.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 243);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.TabIndex = 33;
            this.metroLabel6.Text = "Contact No";
            // 
            // tbPartnerId
            // 
            this.tbPartnerId.Lines = new string[0];
            this.tbPartnerId.Location = new System.Drawing.Point(123, 208);
            this.tbPartnerId.MaxLength = 32767;
            this.tbPartnerId.Name = "tbPartnerId";
            this.tbPartnerId.PasswordChar = '\0';
            this.tbPartnerId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPartnerId.SelectedText = "";
            this.tbPartnerId.Size = new System.Drawing.Size(200, 23);
            this.tbPartnerId.TabIndex = 32;
            this.tbPartnerId.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 208);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Partner ID";
            // 
            // tbPartnerName
            // 
            this.tbPartnerName.Lines = new string[0];
            this.tbPartnerName.Location = new System.Drawing.Point(123, 175);
            this.tbPartnerName.MaxLength = 32767;
            this.tbPartnerName.Name = "tbPartnerName";
            this.tbPartnerName.PasswordChar = '\0';
            this.tbPartnerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPartnerName.SelectedText = "";
            this.tbPartnerName.Size = new System.Drawing.Size(200, 23);
            this.tbPartnerName.TabIndex = 30;
            this.tbPartnerName.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Partner Name";
            // 
            // tbSubDistrict
            // 
            this.tbSubDistrict.Lines = new string[0];
            this.tbSubDistrict.Location = new System.Drawing.Point(123, 141);
            this.tbSubDistrict.MaxLength = 32767;
            this.tbSubDistrict.Name = "tbSubDistrict";
            this.tbSubDistrict.PasswordChar = '\0';
            this.tbSubDistrict.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSubDistrict.SelectedText = "";
            this.tbSubDistrict.Size = new System.Drawing.Size(200, 23);
            this.tbSubDistrict.TabIndex = 28;
            this.tbSubDistrict.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 141);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "Sub District";
            // 
            // tbDistrict
            // 
            this.tbDistrict.Lines = new string[0];
            this.tbDistrict.Location = new System.Drawing.Point(123, 108);
            this.tbDistrict.MaxLength = 32767;
            this.tbDistrict.Name = "tbDistrict";
            this.tbDistrict.PasswordChar = '\0';
            this.tbDistrict.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDistrict.SelectedText = "";
            this.tbDistrict.Size = new System.Drawing.Size(200, 23);
            this.tbDistrict.TabIndex = 26;
            this.tbDistrict.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "District";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(123, 68);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 24;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Contract Date ";
            // 
            // ep1
            // 
            this.ep1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep1.ContainerControl = this;
            // 
            // tbLandArea
            // 
            this.tbLandArea.AllowSpace = false;
            this.tbLandArea.BackColor = System.Drawing.SystemColors.Control;
            this.tbLandArea.Location = new System.Drawing.Point(123, 279);
            this.tbLandArea.MaxLength = 10;
            this.tbLandArea.Name = "tbLandArea";
            this.tbLandArea.Size = new System.Drawing.Size(81, 20);
            this.tbLandArea.TabIndex = 36;
            this.tbLandArea.Text = "0";
            this.tbLandArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 47;
            // 
            // MasterListMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 559);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tbRegion);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.tbSuperVisor);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.tbContractNo);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.tbLandArea);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tbContactNo);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.tbPartnerId);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tbPartnerName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tbSubDistrict);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbDistrict);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterListMasterForm";
            this.Text = "Master Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.MasterListMasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox tbRegion;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox tbSuperVisor;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox tbAddress;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox tbContractNo;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private NumericTextBox tbLandArea;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbContactNo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tbPartnerId;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbPartnerName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbSubDistrict;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbDistrict;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbID;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.TextBox textBox1;
    }
}