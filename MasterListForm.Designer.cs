namespace SRS.DeskApp
{
    partial class MasterListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotalData = new MetroFramework.Controls.MetroLabel();
            this.pnlPageSize = new System.Windows.Forms.Panel();
            this.LBLPaging = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtFirst = new System.Windows.Forms.Button();
            this.BtPrev = new System.Windows.Forms.Button();
            this.BtNext = new System.Windows.Forms.Button();
            this.BtLast = new System.Windows.Forms.Button();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.tbEntryTTA = new MetroFramework.Controls.MetroButton();
            this.btReset = new MetroFramework.Controls.MetroButton();
            this.btInput = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPageSize.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.panel2);
            this.metroPanel1.Controls.Add(this.metroPanel4);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1215, 469);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTotalData);
            this.panel2.Controls.Add(this.pnlPageSize);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BtFirst);
            this.panel2.Controls.Add(this.BtPrev);
            this.panel2.Controls.Add(this.BtNext);
            this.panel2.Controls.Add(this.BtLast);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 42);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbTotalData
            // 
            this.lbTotalData.AutoSize = true;
            this.lbTotalData.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbTotalData.Location = new System.Drawing.Point(18, 9);
            this.lbTotalData.Name = "lbTotalData";
            this.lbTotalData.Size = new System.Drawing.Size(94, 19);
            this.lbTotalData.TabIndex = 13;
            this.lbTotalData.Text = "metroLabel3";
            // 
            // pnlPageSize
            // 
            this.pnlPageSize.Controls.Add(this.LBLPaging);
            this.pnlPageSize.Controls.Add(this.metroLabel3);
            this.pnlPageSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPageSize.Location = new System.Drawing.Point(942, 0);
            this.pnlPageSize.Name = "pnlPageSize";
            this.pnlPageSize.Size = new System.Drawing.Size(97, 42);
            this.pnlPageSize.TabIndex = 6;
            // 
            // LBLPaging
            // 
            this.LBLPaging.AutoSize = true;
            this.LBLPaging.FontSize = MetroFramework.MetroLabelSize.Small;
            this.LBLPaging.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LBLPaging.Location = new System.Drawing.Point(64, 14);
            this.LBLPaging.Name = "LBLPaging";
            this.LBLPaging.Size = new System.Drawing.Size(14, 15);
            this.LBLPaging.TabIndex = 18;
            this.LBLPaging.Text = "1";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(19, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 15);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Page :";
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
            this.BtFirst.Location = new System.Drawing.Point(1039, 0);
            this.BtFirst.Name = "BtFirst";
            this.BtFirst.Size = new System.Drawing.Size(44, 42);
            this.BtFirst.TabIndex = 3;
            this.BtFirst.Text = "<<";
            this.BtFirst.UseVisualStyleBackColor = true;
            this.BtFirst.Click += new System.EventHandler(this.BtFirst_Click_1);
            // 
            // BtPrev
            // 
            this.BtPrev.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtPrev.Location = new System.Drawing.Point(1083, 0);
            this.BtPrev.Name = "BtPrev";
            this.BtPrev.Size = new System.Drawing.Size(44, 42);
            this.BtPrev.TabIndex = 1;
            this.BtPrev.Text = "<";
            this.BtPrev.UseVisualStyleBackColor = true;
            this.BtPrev.Click += new System.EventHandler(this.BtPrev_Click_1);
            // 
            // BtNext
            // 
            this.BtNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtNext.Location = new System.Drawing.Point(1127, 0);
            this.BtNext.Name = "BtNext";
            this.BtNext.Size = new System.Drawing.Size(44, 42);
            this.BtNext.TabIndex = 0;
            this.BtNext.Text = ">";
            this.BtNext.UseVisualStyleBackColor = true;
            this.BtNext.Click += new System.EventHandler(this.BtNext_Click_1);
            // 
            // BtLast
            // 
            this.BtLast.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtLast.Location = new System.Drawing.Point(1171, 0);
            this.BtLast.Name = "BtLast";
            this.BtLast.Size = new System.Drawing.Size(44, 42);
            this.BtLast.TabIndex = 2;
            this.BtLast.Text = ">>";
            this.BtLast.UseVisualStyleBackColor = true;
            this.BtLast.Click += new System.EventHandler(this.BtLast_Click_1);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroGrid1);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 62);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1215, 359);
            this.metroPanel4.TabIndex = 4;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
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
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGrid1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroGrid1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.metroGrid1.RowTemplate.DividerHeight = 1;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1215, 359);
            this.metroGrid1.TabIndex = 3;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseCustomForeColor = true;
            this.metroGrid1.UseStyleColors = true;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick_1);
            this.metroGrid1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGrid1_RowHeaderMouseDoubleClick);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.panel6);
            this.metroPanel2.Controls.Add(this.metroPanel3);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1215, 62);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.metroComboBox1);
            this.panel6.Controls.Add(this.metroLabel2);
            this.panel6.Controls.Add(this.metroLabel1);
            this.panel6.Controls.Add(this.tbSearch);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(689, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(526, 62);
            this.panel6.TabIndex = 8;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "5",
            "10",
            "50",
            "100"});
            this.metroComboBox1.Location = new System.Drawing.Point(458, 27);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(65, 29);
            this.metroComboBox1.TabIndex = 15;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(388, 32);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Tampilkan";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(152, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Pencarian";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tbSearch.Location = new System.Drawing.Point(223, 31);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(159, 20);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.tbEntryTTA);
            this.metroPanel3.Controls.Add(this.btReset);
            this.metroPanel3.Controls.Add(this.btInput);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(533, 62);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // tbEntryTTA
            // 
            this.tbEntryTTA.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.tbEntryTTA.Location = new System.Drawing.Point(168, 2);
            this.tbEntryTTA.Name = "tbEntryTTA";
            this.tbEntryTTA.Size = new System.Drawing.Size(159, 54);
            this.tbEntryTTA.TabIndex = 15;
            this.tbEntryTTA.Text = "Entry TTA";
            this.tbEntryTTA.UseSelectable = true;
            this.tbEntryTTA.Click += new System.EventHandler(this.tbEntryTTA_Click);
            // 
            // btReset
            // 
            this.btReset.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btReset.Location = new System.Drawing.Point(333, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(159, 54);
            this.btReset.TabIndex = 14;
            this.btReset.Text = "Reset Data";
            this.btReset.UseSelectable = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btInput
            // 
            this.btInput.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btInput.Location = new System.Drawing.Point(3, 2);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(159, 54);
            this.btInput.TabIndex = 13;
            this.btInput.Text = "Manual Entry";
            this.btInput.UseSelectable = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click_1);
            // 
            // MasterListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 601);
            this.Controls.Add(this.metroPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterListForm";
            this.Text = "Masterlist Data (Plantation)";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.MasterListForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPageSize.ResumeLayout(false);
            this.pnlPageSize.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlPageSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtFirst;
        private System.Windows.Forms.Button BtPrev;
        private System.Windows.Forms.Button BtNext;
        private System.Windows.Forms.Button BtLast;
        private MetroFramework.Controls.MetroButton btInput;
        private MetroFramework.Controls.MetroButton btReset;
        private MetroFramework.Controls.MetroButton tbEntryTTA;
        private MetroFramework.Controls.MetroLabel lbTotalData;
        private MetroFramework.Controls.MetroLabel LBLPaging;
        private MetroFramework.Controls.MetroLabel metroLabel3;

    }
}