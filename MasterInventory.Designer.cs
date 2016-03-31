namespace SRS.DeskApp
{
    partial class MasterInventory
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
            this.tbKeterangan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.tbNama = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tbKodeBarang = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKeterangan
            // 
            this.tbKeterangan.Lines = new string[0];
            this.tbKeterangan.Location = new System.Drawing.Point(132, 143);
            this.tbKeterangan.MaxLength = 32767;
            this.tbKeterangan.Multiline = true;
            this.tbKeterangan.Name = "tbKeterangan";
            this.tbKeterangan.PasswordChar = '\0';
            this.tbKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKeterangan.SelectedText = "";
            this.tbKeterangan.Size = new System.Drawing.Size(340, 81);
            this.tbKeterangan.TabIndex = 39;
            this.tbKeterangan.UseSelectable = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(21, 143);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(75, 19);
            this.metroLabel14.TabIndex = 42;
            this.metroLabel14.Text = "Keterangan";
            // 
            // tbNama
            // 
            this.tbNama.Lines = new string[0];
            this.tbNama.Location = new System.Drawing.Point(132, 113);
            this.tbNama.MaxLength = 32767;
            this.tbNama.Name = "tbNama";
            this.tbNama.PasswordChar = '\0';
            this.tbNama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNama.SelectedText = "";
            this.tbNama.Size = new System.Drawing.Size(200, 23);
            this.tbNama.TabIndex = 35;
            this.tbNama.UseSelectable = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(22, 113);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(49, 19);
            this.metroLabel13.TabIndex = 41;
            this.metroLabel13.Text = "Nama ";
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.Lines = new string[0];
            this.tbKodeBarang.Location = new System.Drawing.Point(132, 84);
            this.tbKodeBarang.MaxLength = 32767;
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.PasswordChar = '\0';
            this.tbKodeBarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKodeBarang.SelectedText = "";
            this.tbKodeBarang.Size = new System.Drawing.Size(200, 23);
            this.tbKodeBarang.Style = MetroFramework.MetroColorStyle.White;
            this.tbKodeBarang.TabIndex = 34;
            this.tbKodeBarang.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(22, 84);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(85, 19);
            this.metroLabel12.TabIndex = 40;
            this.metroLabel12.Text = "Kode Barang";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(185, 240);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(124, 36);
            this.metroButton1.TabIndex = 45;
            this.metroButton1.Text = "Tambahkan";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MasterInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 295);
            this.Controls.Add(this.tbKeterangan);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.tbKodeBarang);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroButton1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBox = false;
            this.Name = "MasterInventory";
            this.Text = "Master Inventory";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.MasterInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbKeterangan;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox tbNama;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox tbKodeBarang;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}