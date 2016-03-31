namespace SRS.DeskApp
{
    partial class UserListForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPageSize = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbPaging = new System.Windows.Forms.TextBox();
            this.lbTotalData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtFirst = new System.Windows.Forms.Button();
            this.BtPrev = new System.Windows.Forms.Button();
            this.BtNext = new System.Windows.Forms.Button();
            this.BtLast = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlPageSize.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(20, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(901, 333);
            this.panel4.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(901, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlPageSize);
            this.panel2.Controls.Add(this.lbTotalData);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BtFirst);
            this.panel2.Controls.Add(this.BtPrev);
            this.panel2.Controls.Add(this.BtNext);
            this.panel2.Controls.Add(this.BtLast);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 40);
            this.panel2.TabIndex = 9;
            // 
            // pnlPageSize
            // 
            this.pnlPageSize.Controls.Add(this.textBox1);
            this.pnlPageSize.Controls.Add(this.tbPaging);
            this.pnlPageSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPageSize.Location = new System.Drawing.Point(641, 0);
            this.pnlPageSize.Name = "pnlPageSize";
            this.pnlPageSize.Size = new System.Drawing.Size(84, 40);
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
            this.BtFirst.Location = new System.Drawing.Point(725, 0);
            this.BtFirst.Name = "BtFirst";
            this.BtFirst.Size = new System.Drawing.Size(44, 40);
            this.BtFirst.TabIndex = 3;
            this.BtFirst.Text = "<<";
            this.BtFirst.UseVisualStyleBackColor = true;
            this.BtFirst.Click += new System.EventHandler(this.BtFirst_Click);
            // 
            // BtPrev
            // 
            this.BtPrev.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtPrev.Location = new System.Drawing.Point(769, 0);
            this.BtPrev.Name = "BtPrev";
            this.BtPrev.Size = new System.Drawing.Size(44, 40);
            this.BtPrev.TabIndex = 1;
            this.BtPrev.Text = "<";
            this.BtPrev.UseVisualStyleBackColor = true;
            this.BtPrev.Click += new System.EventHandler(this.BtPrev_Click);
            // 
            // BtNext
            // 
            this.BtNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtNext.Location = new System.Drawing.Point(813, 0);
            this.BtNext.Name = "BtNext";
            this.BtNext.Size = new System.Drawing.Size(44, 40);
            this.BtNext.TabIndex = 0;
            this.BtNext.Text = ">";
            this.BtNext.UseVisualStyleBackColor = true;
            this.BtNext.Click += new System.EventHandler(this.BtNext_Click);
            // 
            // BtLast
            // 
            this.BtLast.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtLast.Location = new System.Drawing.Point(857, 0);
            this.BtLast.Name = "BtLast";
            this.BtLast.Size = new System.Drawing.Size(44, 40);
            this.BtLast.TabIndex = 2;
            this.BtLast.Text = ">>";
            this.BtLast.UseVisualStyleBackColor = true;
            this.BtLast.Click += new System.EventHandler(this.BtLast_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 38);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(252, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 38);
            this.panel3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edit Access Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btNew);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.tbSearch);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(423, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(478, 38);
            this.panel6.TabIndex = 7;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(6, 8);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(97, 23);
            this.btNew.TabIndex = 5;
            this.btNew.Text = "New Data";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Show";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(209, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(132, 20);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "10",
            "50",
            "100"});
            this.comboBox1.Location = new System.Drawing.Point(399, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 38);
            this.panel5.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = ".: List of Data User :.";
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 491);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserListForm";
            this.Text = "User Maintenance Form";
            this.Load += new System.EventHandler(this.UserListForm_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPageSize.ResumeLayout(false);
            this.pnlPageSize.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtFirst;
        private System.Windows.Forms.Button BtPrev;
        private System.Windows.Forms.Button BtNext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbTotalData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPageSize;
        private System.Windows.Forms.TextBox tbPaging;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}