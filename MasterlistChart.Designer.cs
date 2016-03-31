namespace SRS.DeskApp
{
    partial class MasterlistChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCountData = new System.Windows.Forms.Label();
            this.pnlPageSize = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbPaging = new System.Windows.Forms.TextBox();
            this.lbTotalData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtFirst = new System.Windows.Forms.Button();
            this.BtPrev = new System.Windows.Forms.Button();
            this.BtNext = new System.Windows.Forms.Button();
            this.BtLast = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2.SuspendLayout();
            this.pnlPageSize.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbCountData);
            this.panel2.Controls.Add(this.pnlPageSize);
            this.panel2.Controls.Add(this.lbTotalData);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BtFirst);
            this.panel2.Controls.Add(this.BtPrev);
            this.panel2.Controls.Add(this.BtNext);
            this.panel2.Controls.Add(this.BtLast);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 611);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 41);
            this.panel2.TabIndex = 11;
            // 
            // lbCountData
            // 
            this.lbCountData.AutoSize = true;
            this.lbCountData.Enabled = false;
            this.lbCountData.Location = new System.Drawing.Point(117, 13);
            this.lbCountData.Name = "lbCountData";
            this.lbCountData.Size = new System.Drawing.Size(0, 13);
            this.lbCountData.TabIndex = 7;
            // 
            // pnlPageSize
            // 
            this.pnlPageSize.Controls.Add(this.textBox1);
            this.pnlPageSize.Controls.Add(this.tbPaging);
            this.pnlPageSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPageSize.Location = new System.Drawing.Point(840, 0);
            this.pnlPageSize.Name = "pnlPageSize";
            this.pnlPageSize.Size = new System.Drawing.Size(84, 41);
            this.pnlPageSize.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 14);
            this.textBox1.MaxLength = 99;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(39, 13);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Page : ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPaging
            // 
            this.tbPaging.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPaging.Location = new System.Drawing.Point(41, 14);
            this.tbPaging.MaxLength = 99;
            this.tbPaging.Name = "tbPaging";
            this.tbPaging.ReadOnly = true;
            this.tbPaging.Size = new System.Drawing.Size(39, 13);
            this.tbPaging.TabIndex = 7;
            this.tbPaging.Text = "1";
            this.tbPaging.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTotalData
            // 
            this.lbTotalData.AutoSize = true;
            this.lbTotalData.Location = new System.Drawing.Point(360, 15);
            this.lbTotalData.Name = "lbTotalData";
            this.lbTotalData.Size = new System.Drawing.Size(35, 13);
            this.lbTotalData.TabIndex = 5;
            this.lbTotalData.Text = "label5";
            this.lbTotalData.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // BtFirst
            // 
            this.BtFirst.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtFirst.Location = new System.Drawing.Point(924, 0);
            this.BtFirst.Name = "BtFirst";
            this.BtFirst.Size = new System.Drawing.Size(44, 41);
            this.BtFirst.TabIndex = 3;
            this.BtFirst.Text = "<<";
            this.BtFirst.UseVisualStyleBackColor = true;
            this.BtFirst.Click += new System.EventHandler(this.BtFirst_Click_1);
            // 
            // BtPrev
            // 
            this.BtPrev.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtPrev.Location = new System.Drawing.Point(968, 0);
            this.BtPrev.Name = "BtPrev";
            this.BtPrev.Size = new System.Drawing.Size(44, 41);
            this.BtPrev.TabIndex = 1;
            this.BtPrev.Text = "<";
            this.BtPrev.UseVisualStyleBackColor = true;
            this.BtPrev.Click += new System.EventHandler(this.BtPrev_Click);
            // 
            // BtNext
            // 
            this.BtNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtNext.Location = new System.Drawing.Point(1012, 0);
            this.BtNext.Name = "BtNext";
            this.BtNext.Size = new System.Drawing.Size(44, 41);
            this.BtNext.TabIndex = 0;
            this.BtNext.Text = ">";
            this.BtNext.UseVisualStyleBackColor = true;
            this.BtNext.Click += new System.EventHandler(this.BtNext_Click_1);
            // 
            // BtLast
            // 
            this.BtLast.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtLast.Location = new System.Drawing.Point(1056, 0);
            this.BtLast.Name = "BtLast";
            this.BtLast.Size = new System.Drawing.Size(44, 41);
            this.BtLast.TabIndex = 2;
            this.BtLast.Text = ">>";
            this.BtLast.UseVisualStyleBackColor = true;
            this.BtLast.Click += new System.EventHandler(this.BtLast_Click_1);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.chart1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1094, 529);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 20);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1076, 496);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // MasterlistChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 672);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MasterlistChart";
            this.Text = "Masterlist Chart";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.MasterlistChart_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPageSize.ResumeLayout(false);
            this.pnlPageSize.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlPageSize;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbPaging;
        private System.Windows.Forms.Label lbTotalData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtFirst;
        private System.Windows.Forms.Button BtPrev;
        private System.Windows.Forms.Button BtNext;
        private System.Windows.Forms.Button BtLast;
        private System.Windows.Forms.Label lbCountData;

    }
}