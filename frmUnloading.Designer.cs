namespace SRS.DeskApp
{
    partial class frmUnloading
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
            this.btn1 = new MetroFramework.Controls.MetroButton();
            this.lbLine = new MetroFramework.Controls.MetroLabel();
            this.btn2 = new MetroFramework.Controls.MetroButton();
            this.btn4 = new MetroFramework.Controls.MetroButton();
            this.btn3 = new MetroFramework.Controls.MetroButton();
            this.btn6 = new MetroFramework.Controls.MetroButton();
            this.btn5 = new MetroFramework.Controls.MetroButton();
            this.btn8 = new MetroFramework.Controls.MetroButton();
            this.btn7 = new MetroFramework.Controls.MetroButton();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.Location = new System.Drawing.Point(30, 89);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(115, 36);
            this.btn1.TabIndex = 81;
            this.btn1.Text = "1";
            this.btn1.UseCustomBackColor = true;
            this.btn1.UseCustomForeColor = true;
            this.btn1.UseSelectable = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbLine.Location = new System.Drawing.Point(148, 75);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(0, 0);
            this.lbLine.TabIndex = 76;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Control;
            this.btn2.Location = new System.Drawing.Point(30, 135);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(115, 36);
            this.btn2.TabIndex = 82;
            this.btn2.Text = "2";
            this.btn2.UseCustomBackColor = true;
            this.btn2.UseCustomForeColor = true;
            this.btn2.UseSelectable = true;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Control;
            this.btn4.Location = new System.Drawing.Point(30, 228);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(115, 36);
            this.btn4.TabIndex = 84;
            this.btn4.Text = "4";
            this.btn4.UseCustomBackColor = true;
            this.btn4.UseCustomForeColor = true;
            this.btn4.UseSelectable = true;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Control;
            this.btn3.Location = new System.Drawing.Point(30, 182);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(115, 36);
            this.btn3.TabIndex = 83;
            this.btn3.Text = "3";
            this.btn3.UseCustomBackColor = true;
            this.btn3.UseCustomForeColor = true;
            this.btn3.UseSelectable = true;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.Control;
            this.btn6.Location = new System.Drawing.Point(163, 135);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(115, 36);
            this.btn6.TabIndex = 86;
            this.btn6.Text = "6";
            this.btn6.UseCustomBackColor = true;
            this.btn6.UseCustomForeColor = true;
            this.btn6.UseSelectable = true;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Control;
            this.btn5.Location = new System.Drawing.Point(163, 89);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(115, 36);
            this.btn5.TabIndex = 85;
            this.btn5.Text = "5";
            this.btn5.UseCustomBackColor = true;
            this.btn5.UseCustomForeColor = true;
            this.btn5.UseSelectable = true;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Control;
            this.btn8.Location = new System.Drawing.Point(163, 228);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(115, 36);
            this.btn8.TabIndex = 88;
            this.btn8.Text = "8";
            this.btn8.UseCustomBackColor = true;
            this.btn8.UseCustomForeColor = true;
            this.btn8.UseSelectable = true;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Control;
            this.btn7.Location = new System.Drawing.Point(163, 182);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(115, 36);
            this.btn7.TabIndex = 87;
            this.btn7.Text = "7";
            this.btn7.UseCustomBackColor = true;
            this.btn7.UseCustomForeColor = true;
            this.btn7.UseSelectable = true;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            // 
            // frmUnloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(313, 324);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbLine);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmUnloading";
            this.Text = "Unloading ";
            this.Load += new System.EventHandler(this.frmUnloading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn1;
        private MetroFramework.Controls.MetroLabel lbLine;
        private MetroFramework.Controls.MetroButton btn2;
        private MetroFramework.Controls.MetroButton btn4;
        private MetroFramework.Controls.MetroButton btn3;
        private MetroFramework.Controls.MetroButton btn6;
        private MetroFramework.Controls.MetroButton btn5;
        private MetroFramework.Controls.MetroButton btn8;
        private MetroFramework.Controls.MetroButton btn7;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}
