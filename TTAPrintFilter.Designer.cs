namespace SRS.DeskApp
{
    partial class TTAPrintFilter
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtTo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtFrom = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(23, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 23);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Sampai No";
            // 
            // TxtTo
            // 
            this.TxtTo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtTo.Lines = new string[] {
        "4"};
            this.TxtTo.Location = new System.Drawing.Point(137, 120);
            this.TxtTo.MaxLength = 32767;
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.PasswordChar = '\0';
            this.TxtTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTo.SelectedText = "";
            this.TxtTo.Size = new System.Drawing.Size(127, 28);
            this.TxtTo.TabIndex = 2;
            this.TxtTo.Text = "4";
            this.TxtTo.UseCustomBackColor = true;
            this.TxtTo.UseSelectable = true;
            this.TxtTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTo_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(23, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 23);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Dari No";
            // 
            // TxtFrom
            // 
            this.TxtFrom.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtFrom.Lines = new string[] {
        "1"};
            this.TxtFrom.Location = new System.Drawing.Point(137, 86);
            this.TxtFrom.MaxLength = 32767;
            this.TxtFrom.Name = "TxtFrom";
            this.TxtFrom.PasswordChar = '\0';
            this.TxtFrom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtFrom.SelectedText = "";
            this.TxtFrom.Size = new System.Drawing.Size(127, 28);
            this.TxtFrom.TabIndex = 1;
            this.TxtFrom.Text = "1";
            this.TxtFrom.UseCustomBackColor = true;
            this.TxtFrom.UseSelectable = true;
            this.TxtFrom.Click += new System.EventHandler(this.TxtFrom_Click);
            this.TxtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFrom_KeyPress);
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(104, 180);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 35);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Keluar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(23, 180);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 35);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Print";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // TTAPrintFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 252);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.TxtTo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TxtFrom);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TTAPrintFilter";
            this.Resizable = false;
            this.Text = "Print Filter TTA";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtTo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtFrom;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}