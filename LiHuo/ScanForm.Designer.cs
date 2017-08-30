namespace ShenZhenLiHuo
{
    partial class ScanForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.superGrid1 = new FGTran.SuperGrid();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAutoScan = new System.Windows.Forms.RadioButton();
            this.rdmuScan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labBillNo = new System.Windows.Forms.Label();
            this.labScanNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labBuKong = new System.Windows.Forms.Label();
            this.labWuShuJu = new System.Windows.Forms.Label();
            this.labFeiBuKong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.labScanNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labBillNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tbNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 212);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.superGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 500);
            this.panel2.TabIndex = 1;
            // 
            // superGrid1
            // 
            this.superGrid1.AllowUserToAddRows = false;
            this.superGrid1.AllowUserToDeleteRows = false;
            this.superGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.superGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.superGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.superGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.superGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superGrid1.Location = new System.Drawing.Point(0, 0);
            this.superGrid1.Name = "superGrid1";
            this.superGrid1.PageSize = 15;
            this.superGrid1.ReadOnly = true;
            this.superGrid1.RowTemplate.Height = 35;
            this.superGrid1.Size = new System.Drawing.Size(1191, 500);
            this.superGrid1.TabIndex = 1;
            // 
            // tbNo
            // 
            this.tbNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNo.Location = new System.Drawing.Point(123, 25);
            this.tbNo.MaxLength = 50;
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(439, 29);
            this.tbNo.TabIndex = 9;
            this.tbNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNo_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(9, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "扫描条码：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdmuScan);
            this.groupBox1.Controls.Add(this.rdAutoScan);
            this.groupBox1.Location = new System.Drawing.Point(589, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 53);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "扫描类型";
            // 
            // rdAutoScan
            // 
            this.rdAutoScan.AutoSize = true;
            this.rdAutoScan.Location = new System.Drawing.Point(18, 21);
            this.rdAutoScan.Name = "rdAutoScan";
            this.rdAutoScan.Size = new System.Drawing.Size(71, 16);
            this.rdAutoScan.TabIndex = 0;
            this.rdAutoScan.TabStop = true;
            this.rdAutoScan.Text = "自动扫描";
            this.rdAutoScan.UseVisualStyleBackColor = true;
            // 
            // rdmuScan
            // 
            this.rdmuScan.AutoSize = true;
            this.rdmuScan.Location = new System.Drawing.Point(119, 21);
            this.rdmuScan.Name = "rdmuScan";
            this.rdmuScan.Size = new System.Drawing.Size(71, 16);
            this.rdmuScan.TabIndex = 1;
            this.rdmuScan.TabStop = true;
            this.rdmuScan.Text = "手动扫描";
            this.rdmuScan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "分运单号：";
            // 
            // labBillNo
            // 
            this.labBillNo.AutoSize = true;
            this.labBillNo.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBillNo.Location = new System.Drawing.Point(119, 78);
            this.labBillNo.Name = "labBillNo";
            this.labBillNo.Size = new System.Drawing.Size(0, 21);
            this.labBillNo.TabIndex = 12;
            // 
            // labScanNo
            // 
            this.labScanNo.AutoSize = true;
            this.labScanNo.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labScanNo.Location = new System.Drawing.Point(119, 122);
            this.labScanNo.Name = "labScanNo";
            this.labScanNo.Size = new System.Drawing.Size(0, 21);
            this.labScanNo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "当前条码：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labBuKong);
            this.panel3.Controls.Add(this.labWuShuJu);
            this.panel3.Controls.Add(this.labFeiBuKong);
            this.panel3.Location = new System.Drawing.Point(343, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(572, 109);
            this.panel3.TabIndex = 15;
            // 
            // labBuKong
            // 
            this.labBuKong.BackColor = System.Drawing.Color.Silver;
            this.labBuKong.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBuKong.ForeColor = System.Drawing.Color.White;
            this.labBuKong.Location = new System.Drawing.Point(21, 10);
            this.labBuKong.Name = "labBuKong";
            this.labBuKong.Size = new System.Drawing.Size(124, 88);
            this.labBuKong.TabIndex = 10;
            this.labBuKong.Text = "布控";
            this.labBuKong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labWuShuJu
            // 
            this.labWuShuJu.BackColor = System.Drawing.Color.Silver;
            this.labWuShuJu.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labWuShuJu.ForeColor = System.Drawing.Color.White;
            this.labWuShuJu.Location = new System.Drawing.Point(407, 10);
            this.labWuShuJu.Name = "labWuShuJu";
            this.labWuShuJu.Size = new System.Drawing.Size(123, 86);
            this.labWuShuJu.TabIndex = 13;
            this.labWuShuJu.Text = "无数据";
            this.labWuShuJu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labFeiBuKong
            // 
            this.labFeiBuKong.BackColor = System.Drawing.Color.Silver;
            this.labFeiBuKong.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFeiBuKong.ForeColor = System.Drawing.Color.White;
            this.labFeiBuKong.Location = new System.Drawing.Point(216, 10);
            this.labFeiBuKong.Name = "labFeiBuKong";
            this.labFeiBuKong.Size = new System.Drawing.Size(129, 88);
            this.labFeiBuKong.TabIndex = 11;
            this.labFeiBuKong.Text = "非布控";
            this.labFeiBuKong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(994, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 86);
            this.label2.TabIndex = 16;
            this.label2.Text = "扫描失败";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 712);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ScanForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "扫描条码";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FGTran.SuperGrid superGrid1;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labScanNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labBillNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdmuScan;
        private System.Windows.Forms.RadioButton rdAutoScan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labBuKong;
        private System.Windows.Forms.Label labWuShuJu;
        private System.Windows.Forms.Label labFeiBuKong;
    }
}