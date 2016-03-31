namespace SRS.DeskApp
{
    partial class TimbanganOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimbanganOut));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.report1 = new FastReport.Report();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.print3 = new MetroFramework.Controls.MetroButton();
            this.save3 = new MetroFramework.Controls.MetroButton();
            this.print2 = new MetroFramework.Controls.MetroButton();
            this.save2 = new MetroFramework.Controls.MetroButton();
            this.save1 = new MetroFramework.Controls.MetroButton();
            this.print1 = new MetroFramework.Controls.MetroButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbCarID3 = new MetroFramework.Controls.MetroTextBox();
            this.tbDriver3 = new MetroFramework.Controls.MetroTextBox();
            this.tbNetto3 = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbCarID2 = new MetroFramework.Controls.MetroTextBox();
            this.tbDriver2 = new MetroFramework.Controls.MetroTextBox();
            this.tbNetto2 = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCarID1 = new MetroFramework.Controls.MetroTextBox();
            this.tbDriver1 = new MetroFramework.Controls.MetroTextBox();
            this.tbNetto1 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // report1
            // 
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            // 
            // metroButton1
            // 
            this.metroButton1.Enabled = false;
            this.metroButton1.Location = new System.Drawing.Point(97, 364);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(197, 36);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Tag = "1";
            this.metroButton1.Text = "Design Invoice";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // print3
            // 
            this.print3.Enabled = false;
            this.print3.Location = new System.Drawing.Point(537, 307);
            this.print3.Name = "print3";
            this.print3.Size = new System.Drawing.Size(152, 36);
            this.print3.TabIndex = 15;
            this.print3.Text = "Print";
            this.print3.UseSelectable = true;
            this.print3.Click += new System.EventHandler(this.print1_Click);
            // 
            // save3
            // 
            this.save3.Enabled = false;
            this.save3.Location = new System.Drawing.Point(537, 265);
            this.save3.Name = "save3";
            this.save3.Size = new System.Drawing.Size(152, 36);
            this.save3.TabIndex = 14;
            this.save3.Tag = "3";
            this.save3.Text = "Simpan";
            this.save3.UseSelectable = true;
            this.save3.Click += new System.EventHandler(this.save1_Click);
            // 
            // print2
            // 
            this.print2.Enabled = false;
            this.print2.Location = new System.Drawing.Point(325, 307);
            this.print2.Name = "print2";
            this.print2.Size = new System.Drawing.Size(152, 36);
            this.print2.TabIndex = 13;
            this.print2.Text = "Print";
            this.print2.UseSelectable = true;
            this.print2.Click += new System.EventHandler(this.print1_Click);
            // 
            // save2
            // 
            this.save2.Enabled = false;
            this.save2.Location = new System.Drawing.Point(325, 265);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(152, 36);
            this.save2.TabIndex = 12;
            this.save2.Tag = "2";
            this.save2.Text = "Simpan";
            this.save2.UseSelectable = true;
            this.save2.Click += new System.EventHandler(this.save1_Click);
            // 
            // save1
            // 
            this.save1.Enabled = false;
            this.save1.Location = new System.Drawing.Point(97, 265);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(197, 36);
            this.save1.TabIndex = 11;
            this.save1.Tag = "1";
            this.save1.Text = "Simpan";
            this.save1.UseSelectable = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // print1
            // 
            this.print1.Enabled = false;
            this.print1.Location = new System.Drawing.Point(97, 307);
            this.print1.Name = "print1";
            this.print1.Size = new System.Drawing.Size(197, 36);
            this.print1.TabIndex = 10;
            this.print1.Tag = "1";
            this.print1.Text = "Print";
            this.print1.UseSelectable = true;
            this.print1.Click += new System.EventHandler(this.print1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbCarID3);
            this.panel3.Controls.Add(this.tbDriver3);
            this.panel3.Controls.Add(this.tbNetto3);
            this.panel3.Location = new System.Drawing.Point(512, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 157);
            this.panel3.TabIndex = 2;
            // 
            // tbCarID3
            // 
            this.tbCarID3.Lines = new string[0];
            this.tbCarID3.Location = new System.Drawing.Point(25, 30);
            this.tbCarID3.MaxLength = 32767;
            this.tbCarID3.Name = "tbCarID3";
            this.tbCarID3.PasswordChar = '\0';
            this.tbCarID3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCarID3.SelectedText = "";
            this.tbCarID3.Size = new System.Drawing.Size(152, 23);
            this.tbCarID3.TabIndex = 6;
            this.tbCarID3.UseSelectable = true;
            // 
            // tbDriver3
            // 
            this.tbDriver3.Enabled = false;
            this.tbDriver3.Lines = new string[0];
            this.tbDriver3.Location = new System.Drawing.Point(25, 88);
            this.tbDriver3.MaxLength = 32767;
            this.tbDriver3.Name = "tbDriver3";
            this.tbDriver3.PasswordChar = '\0';
            this.tbDriver3.ReadOnly = true;
            this.tbDriver3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDriver3.SelectedText = "";
            this.tbDriver3.Size = new System.Drawing.Size(152, 23);
            this.tbDriver3.TabIndex = 8;
            this.tbDriver3.UseSelectable = true;
            // 
            // tbNetto3
            // 
            this.tbNetto3.Enabled = false;
            this.tbNetto3.Lines = new string[0];
            this.tbNetto3.Location = new System.Drawing.Point(25, 59);
            this.tbNetto3.MaxLength = 32767;
            this.tbNetto3.Name = "tbNetto3";
            this.tbNetto3.PasswordChar = '\0';
            this.tbNetto3.ReadOnly = true;
            this.tbNetto3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNetto3.SelectedText = "";
            this.tbNetto3.Size = new System.Drawing.Size(152, 23);
            this.tbNetto3.TabIndex = 7;
            this.tbNetto3.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbCarID2);
            this.panel2.Controls.Add(this.tbDriver2);
            this.panel2.Controls.Add(this.tbNetto2);
            this.panel2.Location = new System.Drawing.Point(300, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 157);
            this.panel2.TabIndex = 1;
            // 
            // tbCarID2
            // 
            this.tbCarID2.Lines = new string[0];
            this.tbCarID2.Location = new System.Drawing.Point(25, 30);
            this.tbCarID2.MaxLength = 32767;
            this.tbCarID2.Name = "tbCarID2";
            this.tbCarID2.PasswordChar = '\0';
            this.tbCarID2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCarID2.SelectedText = "";
            this.tbCarID2.Size = new System.Drawing.Size(152, 23);
            this.tbCarID2.TabIndex = 6;
            this.tbCarID2.UseSelectable = true;
            // 
            // tbDriver2
            // 
            this.tbDriver2.Enabled = false;
            this.tbDriver2.Lines = new string[0];
            this.tbDriver2.Location = new System.Drawing.Point(25, 88);
            this.tbDriver2.MaxLength = 32767;
            this.tbDriver2.Name = "tbDriver2";
            this.tbDriver2.PasswordChar = '\0';
            this.tbDriver2.ReadOnly = true;
            this.tbDriver2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDriver2.SelectedText = "";
            this.tbDriver2.Size = new System.Drawing.Size(152, 23);
            this.tbDriver2.TabIndex = 8;
            this.tbDriver2.UseSelectable = true;
            // 
            // tbNetto2
            // 
            this.tbNetto2.Enabled = false;
            this.tbNetto2.Lines = new string[0];
            this.tbNetto2.Location = new System.Drawing.Point(25, 59);
            this.tbNetto2.MaxLength = 32767;
            this.tbNetto2.Name = "tbNetto2";
            this.tbNetto2.PasswordChar = '\0';
            this.tbNetto2.ReadOnly = true;
            this.tbNetto2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNetto2.SelectedText = "";
            this.tbNetto2.Size = new System.Drawing.Size(152, 23);
            this.tbNetto2.TabIndex = 7;
            this.tbNetto2.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbCarID1);
            this.panel1.Controls.Add(this.tbDriver1);
            this.panel1.Controls.Add(this.tbNetto1);
            this.panel1.Location = new System.Drawing.Point(97, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 157);
            this.panel1.TabIndex = 0;
            // 
            // tbCarID1
            // 
            this.tbCarID1.Lines = new string[0];
            this.tbCarID1.Location = new System.Drawing.Point(25, 30);
            this.tbCarID1.MaxLength = 32767;
            this.tbCarID1.Name = "tbCarID1";
            this.tbCarID1.PasswordChar = '\0';
            this.tbCarID1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCarID1.SelectedText = "";
            this.tbCarID1.Size = new System.Drawing.Size(152, 23);
            this.tbCarID1.TabIndex = 6;
            this.tbCarID1.UseSelectable = true;
            // 
            // tbDriver1
            // 
            this.tbDriver1.Enabled = false;
            this.tbDriver1.Lines = new string[0];
            this.tbDriver1.Location = new System.Drawing.Point(25, 88);
            this.tbDriver1.MaxLength = 32767;
            this.tbDriver1.Name = "tbDriver1";
            this.tbDriver1.PasswordChar = '\0';
            this.tbDriver1.ReadOnly = true;
            this.tbDriver1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDriver1.SelectedText = "";
            this.tbDriver1.Size = new System.Drawing.Size(152, 23);
            this.tbDriver1.TabIndex = 8;
            this.tbDriver1.UseSelectable = true;
            // 
            // tbNetto1
            // 
            this.tbNetto1.Enabled = false;
            this.tbNetto1.Lines = new string[0];
            this.tbNetto1.Location = new System.Drawing.Point(25, 59);
            this.tbNetto1.MaxLength = 32767;
            this.tbNetto1.Name = "tbNetto1";
            this.tbNetto1.PasswordChar = '\0';
            this.tbNetto1.ReadOnly = true;
            this.tbNetto1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNetto1.SelectedText = "";
            this.tbNetto1.Size = new System.Drawing.Size(152, 23);
            this.tbNetto1.TabIndex = 7;
            this.tbNetto1.UseSelectable = true;
            // 
            // TimbanganOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(779, 409);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.print3);
            this.Controls.Add(this.save3);
            this.Controls.Add(this.print2);
            this.Controls.Add(this.save2);
            this.Controls.Add(this.save1);
            this.Controls.Add(this.print1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimbanganOut";
            this.Text = "Timbangan Out";
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox tbCarID1;
        private MetroFramework.Controls.MetroTextBox tbDriver1;
        private MetroFramework.Controls.MetroTextBox tbNetto1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox tbCarID2;
        private MetroFramework.Controls.MetroTextBox tbDriver2;
        private MetroFramework.Controls.MetroTextBox tbNetto2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTextBox tbCarID3;
        private MetroFramework.Controls.MetroTextBox tbDriver3;
        private MetroFramework.Controls.MetroTextBox tbNetto3;
        private MetroFramework.Controls.MetroButton print1;
        private MetroFramework.Controls.MetroButton save1;
        private MetroFramework.Controls.MetroButton save2;
        private MetroFramework.Controls.MetroButton print2;
        private MetroFramework.Controls.MetroButton save3;
        private MetroFramework.Controls.MetroButton print3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FastReport.Report report1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
