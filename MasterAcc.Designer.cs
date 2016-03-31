namespace SRS.DeskApp
{
    partial class MasterAcc
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel33 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel32 = new MetroFramework.Controls.MetroLabel();
            this.tbCash = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tbKodeInventory = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.tbAcReceivable = new MetroFramework.Controls.MetroTextBox();
            this.tbExpenses = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(154, 211);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 36);
            this.metroButton1.TabIndex = 101;
            this.metroButton1.Text = "Simpan";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel33
            // 
            this.metroLabel33.AutoSize = true;
            this.metroLabel33.Location = new System.Drawing.Point(21, 132);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(122, 19);
            this.metroLabel33.TabIndex = 106;
            this.metroLabel33.Text = "Account Receivable";
            // 
            // metroLabel32
            // 
            this.metroLabel32.AutoSize = true;
            this.metroLabel32.Location = new System.Drawing.Point(21, 165);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(61, 19);
            this.metroLabel32.TabIndex = 105;
            this.metroLabel32.Text = "Expenses";
            // 
            // tbCash
            // 
            this.tbCash.Lines = new string[0];
            this.tbCash.Location = new System.Drawing.Point(161, 103);
            this.tbCash.MaxLength = 32767;
            this.tbCash.Name = "tbCash";
            this.tbCash.PasswordChar = '\0';
            this.tbCash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCash.SelectedText = "";
            this.tbCash.Size = new System.Drawing.Size(200, 23);
            this.tbCash.TabIndex = 99;
            this.tbCash.UseCustomBackColor = true;
            this.tbCash.UseSelectable = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(21, 103);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(94, 19);
            this.metroLabel13.TabIndex = 103;
            this.metroLabel13.Text = "Cash On Hand";
            // 
            // tbKodeInventory
            // 
            this.tbKodeInventory.Lines = new string[0];
            this.tbKodeInventory.Location = new System.Drawing.Point(161, 74);
            this.tbKodeInventory.MaxLength = 32767;
            this.tbKodeInventory.Name = "tbKodeInventory";
            this.tbKodeInventory.PasswordChar = '\0';
            this.tbKodeInventory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKodeInventory.SelectedText = "";
            this.tbKodeInventory.Size = new System.Drawing.Size(200, 23);
            this.tbKodeInventory.TabIndex = 98;
            this.tbKodeInventory.UseCustomBackColor = true;
            this.tbKodeInventory.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(21, 74);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(96, 19);
            this.metroLabel12.TabIndex = 102;
            this.metroLabel12.Text = "Kode Inventory";
            // 
            // tbAcReceivable
            // 
            this.tbAcReceivable.Lines = new string[0];
            this.tbAcReceivable.Location = new System.Drawing.Point(161, 132);
            this.tbAcReceivable.MaxLength = 32767;
            this.tbAcReceivable.Name = "tbAcReceivable";
            this.tbAcReceivable.PasswordChar = '\0';
            this.tbAcReceivable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAcReceivable.SelectedText = "";
            this.tbAcReceivable.Size = new System.Drawing.Size(200, 23);
            this.tbAcReceivable.TabIndex = 107;
            this.tbAcReceivable.UseCustomBackColor = true;
            this.tbAcReceivable.UseSelectable = true;
            // 
            // tbExpenses
            // 
            this.tbExpenses.Lines = new string[0];
            this.tbExpenses.Location = new System.Drawing.Point(161, 161);
            this.tbExpenses.MaxLength = 32767;
            this.tbExpenses.Name = "tbExpenses";
            this.tbExpenses.PasswordChar = '\0';
            this.tbExpenses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbExpenses.SelectedText = "";
            this.tbExpenses.Size = new System.Drawing.Size(200, 23);
            this.tbExpenses.TabIndex = 108;
            this.tbExpenses.UseCustomBackColor = true;
            this.tbExpenses.UseSelectable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MasterAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 288);
            this.Controls.Add(this.tbExpenses);
            this.Controls.Add(this.tbAcReceivable);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel33);
            this.Controls.Add(this.metroLabel32);
            this.Controls.Add(this.tbCash);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.tbKodeInventory);
            this.Controls.Add(this.metroLabel12);
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBox = false;
            this.Name = "MasterAcc";
            this.Text = "Master Account";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.MasterAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel33;
        private MetroFramework.Controls.MetroLabel metroLabel32;
        private MetroFramework.Controls.MetroTextBox tbCash;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox tbKodeInventory;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox tbAcReceivable;
        private MetroFramework.Controls.MetroTextBox tbExpenses;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}