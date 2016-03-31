namespace SRS.DeskApp
{
    partial class UploadExcelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadExcelForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btGenerate = new MetroFramework.Controls.MetroButton();
            this.btSmart = new MetroFramework.Controls.MetroButton();
            this.lbLoading = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.btInput = new MetroFramework.Controls.MetroButton();
            this.btReset = new MetroFramework.Controls.MetroButton();
            this.btSimpan = new MetroFramework.Controls.MetroButton();
            this.btChart = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.lb1 = new MetroFramework.Controls.MetroLabel();
            this.btnShow = new MetroFramework.Controls.MetroButton();
            this.btUpload = new MetroFramework.Controls.MetroButton();
            this.btSAP = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel 2000 Files (.xls)|*.xls |Excel Files (.xls)|*.xlsx|Excel Macro Enable Files" +
    " (.xlsm)|*.xlsm";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(188, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(362, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "(silahkan memilih masterlist file yang diproses)";
            this.metroLabel2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(188, 154);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(349, 23);
            this.progressBar1.TabIndex = 17;
            this.progressBar1.Visible = false;
            // 
            // btGenerate
            // 
            this.btGenerate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btGenerate.Location = new System.Drawing.Point(1118, 123);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(159, 54);
            this.btGenerate.TabIndex = 16;
            this.btGenerate.Text = "Generate Tiket";
            this.btGenerate.UseSelectable = true;
            this.btGenerate.Visible = false;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // btSmart
            // 
            this.btSmart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSmart.Location = new System.Drawing.Point(953, 123);
            this.btSmart.Name = "btSmart";
            this.btSmart.Size = new System.Drawing.Size(159, 54);
            this.btSmart.TabIndex = 15;
            this.btSmart.Text = "Smart";
            this.btSmart.UseSelectable = true;
            this.btSmart.Visible = false;
            this.btSmart.Click += new System.EventHandler(this.btSmart_Click);
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.Location = new System.Drawing.Point(23, 190);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(0, 0);
            this.lbLoading.TabIndex = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1046, 220);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Pencarian";
            // 
            // tbSearch
            // 
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(1117, 220);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(159, 23);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // btInput
            // 
            this.btInput.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btInput.Location = new System.Drawing.Point(788, 63);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(159, 54);
            this.btInput.TabIndex = 10;
            this.btInput.Text = "Input Manual";
            this.btInput.UseSelectable = true;
            this.btInput.Click += new System.EventHandler(this.metroButton4_Click_1);
            // 
            // btReset
            // 
            this.btReset.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btReset.Location = new System.Drawing.Point(953, 63);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(159, 54);
            this.btReset.TabIndex = 9;
            this.btReset.Text = "Reset Data";
            this.btReset.UseSelectable = true;
            this.btReset.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSimpan.Location = new System.Drawing.Point(1118, 63);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(159, 54);
            this.btSimpan.TabIndex = 8;
            this.btSimpan.Text = "Simpan Masterlist";
            this.btSimpan.UseSelectable = true;
            this.btSimpan.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btChart
            // 
            this.btChart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btChart.Location = new System.Drawing.Point(788, 123);
            this.btChart.Name = "btChart";
            this.btChart.Size = new System.Drawing.Size(159, 54);
            this.btChart.TabIndex = 7;
            this.btChart.Text = "Schedule Chart";
            this.btChart.UseSelectable = true;
            this.btChart.Visible = false;
            this.btChart.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(20, 249);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1256, 337);
            this.metroGrid1.TabIndex = 6;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.metroGrid1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGrid1_RowHeaderMouseDoubleClick);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb1.Location = new System.Drawing.Point(188, 63);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(362, 25);
            this.lb1.Style = MetroFramework.MetroColorStyle.Blue;
            this.lb1.TabIndex = 5;
            this.lb1.Text = "(silahkan memilih masterlist file yang diproses)";
            // 
            // btnShow
            // 
            this.btnShow.Enabled = false;
            this.btnShow.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShow.Location = new System.Drawing.Point(23, 123);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(159, 54);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Tampilkan Data";
            this.btnShow.UseSelectable = true;
            this.btnShow.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btUpload
            // 
            this.btUpload.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btUpload.Location = new System.Drawing.Point(23, 63);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(159, 54);
            this.btUpload.TabIndex = 3;
            this.btUpload.Text = "Unggah File";
            this.btUpload.UseSelectable = true;
            this.btUpload.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btSAP
            // 
            this.btSAP.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSAP.Location = new System.Drawing.Point(788, 187);
            this.btSAP.Name = "btSAP";
            this.btSAP.Size = new System.Drawing.Size(159, 54);
            this.btSAP.TabIndex = 23;
            this.btSAP.Text = "Upload SAP";
            this.btSAP.UseSelectable = true;
            this.btSAP.Click += new System.EventHandler(this.btSAP_Click);
            // 
            // UploadExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 603);
            this.Controls.Add(this.btSAP);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.btSmart);
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.btChart);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btUpload);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadExcelForm";
            this.Text = "Pemrosesan Data Masterlist Excel";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.UploadExcelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroButton btUpload;
        private MetroFramework.Controls.MetroButton btnShow;
        private MetroFramework.Controls.MetroLabel lb1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btChart;
        private MetroFramework.Controls.MetroButton btSimpan;
        private MetroFramework.Controls.MetroButton btReset;
        private MetroFramework.Controls.MetroButton btInput;
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbLoading;
        private MetroFramework.Controls.MetroButton btSmart;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MetroFramework.Controls.MetroButton btGenerate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btSAP;
    }
}