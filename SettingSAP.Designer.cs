namespace SRS.DeskApp
{
    partial class SettingSAP
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.btSimpan = new MetroFramework.Controls.MetroButton();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(17, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 213);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.tbDb);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.tbPassword);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.tbUser);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.tbHost);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(582, 187);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Setting";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Database";
            // 
            // tbDb
            // 
            this.tbDb.Location = new System.Drawing.Point(136, 115);
            this.tbDb.Name = "tbDb";
            this.tbDb.Size = new System.Drawing.Size(142, 20);
            this.tbDb.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(136, 89);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(160, 20);
            this.tbPassword.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "User Name";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(136, 63);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(160, 20);
            this.tbUser.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Host - IP Address";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(136, 37);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(142, 20);
            this.tbHost.TabIndex = 12;
            this.tbHost.TextChanged += new System.EventHandler(this.IPAddressGate1_TextChanged);
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(412, 274);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(191, 36);
            this.btSimpan.TabIndex = 178;
            this.btSimpan.Text = "Submit";
            this.btSimpan.UseSelectable = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // SettingSAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 347);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "SettingSAP";
            this.Text = "Setting Server SAP";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private MetroFramework.Controls.MetroButton btSimpan;
    }
}