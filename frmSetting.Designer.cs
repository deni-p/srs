namespace SRS.DeskApp
{
    partial class frmSetting
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.IPAddressCoreSamplingLine2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCSVManual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCSV = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.IPAddressGate6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IPAddressGate5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IPAddressGate4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IPAddressGate3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IPAddressGate2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IPAddressGate1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IPAddressCoreSamplingLine1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(615, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(28, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 377);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Core Sampling Line 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.IPAddressCoreSamplingLine2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Core Sampling Line 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP Address";
            // 
            // IPAddressCoreSamplingLine2
            // 
            this.IPAddressCoreSamplingLine2.Location = new System.Drawing.Point(136, 31);
            this.IPAddressCoreSamplingLine2.Name = "IPAddressCoreSamplingLine2";
            this.IPAddressCoreSamplingLine2.Size = new System.Drawing.Size(322, 20);
            this.IPAddressCoreSamplingLine2.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.IPAddressCoreSamplingLine1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtCSVManual);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtCSV);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(658, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "NIR Online";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CSV NIR Manual";
            // 
            // txtCSVManual
            // 
            this.txtCSVManual.Location = new System.Drawing.Point(140, 70);
            this.txtCSVManual.Name = "txtCSVManual";
            this.txtCSVManual.Size = new System.Drawing.Size(322, 20);
            this.txtCSVManual.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CSV NIR Online";
            // 
            // txtCSV
            // 
            this.txtCSV.Location = new System.Drawing.Point(140, 44);
            this.txtCSV.Name = "txtCSV";
            this.txtCSV.Size = new System.Drawing.Size(322, 20);
            this.txtCSV.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.IPAddressGate6);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.IPAddressGate5);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.IPAddressGate4);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.IPAddressGate3);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.IPAddressGate2);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.IPAddressGate1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(658, 351);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gates";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "IP Address Gate 6";
            // 
            // IPAddressGate6
            // 
            this.IPAddressGate6.Location = new System.Drawing.Point(136, 167);
            this.IPAddressGate6.Name = "IPAddressGate6";
            this.IPAddressGate6.Size = new System.Drawing.Size(322, 20);
            this.IPAddressGate6.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "IP Address Gate 5";
            // 
            // IPAddressGate5
            // 
            this.IPAddressGate5.Location = new System.Drawing.Point(136, 141);
            this.IPAddressGate5.Name = "IPAddressGate5";
            this.IPAddressGate5.Size = new System.Drawing.Size(322, 20);
            this.IPAddressGate5.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "IP Address Gate 4";
            // 
            // IPAddressGate4
            // 
            this.IPAddressGate4.Location = new System.Drawing.Point(136, 115);
            this.IPAddressGate4.Name = "IPAddressGate4";
            this.IPAddressGate4.Size = new System.Drawing.Size(322, 20);
            this.IPAddressGate4.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "IP Address Gate 3";
            // 
            // IPAddressGate3
            // 
            this.IPAddressGate3.Location = new System.Drawing.Point(136, 89);
            this.IPAddressGate3.Name = "IPAddressGate3";
            this.IPAddressGate3.Size = new System.Drawing.Size(322, 20);
            this.IPAddressGate3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "IP Address Gate 2";
            // 
            // IPAddressGate2
            // 
            this.IPAddressGate2.Location = new System.Drawing.Point(136, 63);
            this.IPAddressGate2.Name = "IPAddressGate2";
            this.IPAddressGate2.Size = new System.Drawing.Size(322, 20);
            this.IPAddressGate2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "IP Address Gate 1";
            // 
            // IPAddressGate1
            // 
            this.IPAddressGate1.Location = new System.Drawing.Point(136, 37);
            this.IPAddressGate1.Name = "IPAddressGate1";
            this.IPAddressGate1.Size = new System.Drawing.Size(322, 20);
            this.IPAddressGate1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "IP Address";
            // 
            // IPAddressCoreSamplingLine1
            // 
            this.IPAddressCoreSamplingLine1.Location = new System.Drawing.Point(140, 18);
            this.IPAddressCoreSamplingLine1.Name = "IPAddressCoreSamplingLine1";
            this.IPAddressCoreSamplingLine1.Size = new System.Drawing.Size(322, 20);
            this.IPAddressCoreSamplingLine1.TabIndex = 12;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 430);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.Name = "frmSetting";
            this.Text = "System Setting";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IPAddressCoreSamplingLine2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCSVManual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCSV;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IPAddressGate6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IPAddressGate5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IPAddressGate4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IPAddressGate3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IPAddressGate2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IPAddressGate1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IPAddressCoreSamplingLine1;
    }
}