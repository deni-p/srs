namespace SRS.DeskApp
{
    partial class frmPotongan
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
            this.btn6 = new MetroFramework.Controls.MetroButton();
            this.btn5P = new MetroFramework.Controls.MetroButton();
            this.btn3 = new MetroFramework.Controls.MetroButton();
            this.btn2 = new MetroFramework.Controls.MetroButton();
            this.btn2P = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btn5 = new MetroFramework.Controls.MetroButton();
            this.txtPotongan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(159, 235);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(115, 36);
            this.btn6.TabIndex = 95;
            this.btn6.Tag = "30";
            this.btn6.Text = "30%";
            this.btn6.UseSelectable = true;
            this.btn6.Click += new System.EventHandler(this.btn2P_Click);
            // 
            // btn5P
            // 
            this.btn5P.Location = new System.Drawing.Point(159, 143);
            this.btn5P.Name = "btn5P";
            this.btn5P.Size = new System.Drawing.Size(115, 36);
            this.btn5P.TabIndex = 93;
            this.btn5P.Tag = "5";
            this.btn5P.Text = "5%";
            this.btn5P.UseSelectable = true;
            this.btn5P.Click += new System.EventHandler(this.btn2P_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(38, 236);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(115, 36);
            this.btn3.TabIndex = 92;
            this.btn3.Tag = "20";
            this.btn3.Text = "20%";
            this.btn3.UseSelectable = true;
            this.btn3.Click += new System.EventHandler(this.btn2P_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(38, 189);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(115, 36);
            this.btn2.TabIndex = 91;
            this.btn2.Tag = "10";
            this.btn2.Text = "10%";
            this.btn2.UseSelectable = true;
            this.btn2.Click += new System.EventHandler(this.btn2P_Click);
            // 
            // btn2P
            // 
            this.btn2P.Location = new System.Drawing.Point(38, 143);
            this.btn2P.Name = "btn2P";
            this.btn2P.Size = new System.Drawing.Size(115, 36);
            this.btn2P.TabIndex = 90;
            this.btn2P.Tag = "2";
            this.btn2P.Text = "2%";
            this.btn2P.UseSelectable = true;
            this.btn2P.Click += new System.EventHandler(this.btn2P_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(-267, 74);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 19);
            this.metroLabel5.TabIndex = 89;
            this.metroLabel5.Text = "LINE";
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(159, 189);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(115, 36);
            this.btn5.TabIndex = 94;
            this.btn5.Tag = "15";
            this.btn5.Text = "15%";
            this.btn5.UseSelectable = true;
            this.btn5.Click += new System.EventHandler(this.btn2P_Click);
            // 
            // txtPotongan
            // 
            this.txtPotongan.Lines = new string[0];
            this.txtPotongan.Location = new System.Drawing.Point(104, 91);
            this.txtPotongan.MaxLength = 32767;
            this.txtPotongan.Name = "txtPotongan";
            this.txtPotongan.PasswordChar = '\0';
            this.txtPotongan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPotongan.SelectedText = "";
            this.txtPotongan.Size = new System.Drawing.Size(119, 23);
            this.txtPotongan.TabIndex = 96;
            this.txtPotongan.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(229, 95);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(20, 19);
            this.metroLabel4.TabIndex = 97;
            this.metroLabel4.Text = "%";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(108, 294);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 36);
            this.metroButton1.TabIndex = 98;
            this.metroButton1.Tag = "20";
            this.metroButton1.Text = "OK";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // frmPotongan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(325, 353);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtPotongan);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn5P);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn2P);
            this.Controls.Add(this.metroLabel5);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmPotongan";
            this.Text = "Potongan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn6;
        private MetroFramework.Controls.MetroButton btn5P;
        private MetroFramework.Controls.MetroButton btn3;
        private MetroFramework.Controls.MetroButton btn2;
        private MetroFramework.Controls.MetroButton btn2P;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btn5;
        public MetroFramework.Controls.MetroTextBox txtPotongan;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
