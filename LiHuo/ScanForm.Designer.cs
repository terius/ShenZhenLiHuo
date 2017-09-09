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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labNowScan = new System.Windows.Forms.Label();
            this.labMessage = new System.Windows.Forms.Label();
            this.labScanFail = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labFangXing = new System.Windows.Forms.Label();
            this.labWuShuJu = new System.Windows.Forms.Label();
            this.labChaYan = new System.Windows.Forms.Label();
            this.labScanNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labBillNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdmuScan = new System.Windows.Forms.RadioButton();
            this.rdAutoScan = new System.Windows.Forms.RadioButton();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.superGrid1 = new FGTran.SuperGrid();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labNowScan);
            this.panel1.Controls.Add(this.labMessage);
            this.panel1.Controls.Add(this.labScanFail);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.labScanNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labBillNo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tbNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 212);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(880, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labNowScan
            // 
            this.labNowScan.AutoSize = true;
            this.labNowScan.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNowScan.Location = new System.Drawing.Point(131, 90);
            this.labNowScan.Name = "labNowScan";
            this.labNowScan.Size = new System.Drawing.Size(0, 21);
            this.labNowScan.TabIndex = 19;
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMessage.ForeColor = System.Drawing.Color.Red;
            this.labMessage.Location = new System.Drawing.Point(12, 155);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(0, 21);
            this.labMessage.TabIndex = 18;
            // 
            // labScanFail
            // 
            this.labScanFail.BackColor = System.Drawing.Color.Silver;
            this.labScanFail.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labScanFail.ForeColor = System.Drawing.Color.White;
            this.labScanFail.Location = new System.Drawing.Point(1021, 101);
            this.labScanFail.Name = "labScanFail";
            this.labScanFail.Size = new System.Drawing.Size(143, 86);
            this.labScanFail.TabIndex = 16;
            this.labScanFail.Text = "扫描失败";
            this.labScanFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labFangXing);
            this.panel3.Controls.Add(this.labWuShuJu);
            this.panel3.Controls.Add(this.labChaYan);
            this.panel3.Location = new System.Drawing.Point(407, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(572, 109);
            this.panel3.TabIndex = 15;
            // 
            // labFangXing
            // 
            this.labFangXing.BackColor = System.Drawing.Color.Silver;
            this.labFangXing.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFangXing.ForeColor = System.Drawing.Color.White;
            this.labFangXing.Location = new System.Drawing.Point(21, 10);
            this.labFangXing.Name = "labFangXing";
            this.labFangXing.Size = new System.Drawing.Size(124, 88);
            this.labFangXing.TabIndex = 10;
            this.labFangXing.Text = "放行";
            this.labFangXing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // labChaYan
            // 
            this.labChaYan.BackColor = System.Drawing.Color.Silver;
            this.labChaYan.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labChaYan.ForeColor = System.Drawing.Color.White;
            this.labChaYan.Location = new System.Drawing.Point(216, 10);
            this.labChaYan.Name = "labChaYan";
            this.labChaYan.Size = new System.Drawing.Size(145, 88);
            this.labChaYan.TabIndex = 11;
            this.labChaYan.Text = "海关查验";
            this.labChaYan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labScanNo
            // 
            this.labScanNo.AutoSize = true;
            this.labScanNo.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labScanNo.Location = new System.Drawing.Point(119, 90);
            this.labScanNo.Name = "labScanNo";
            this.labScanNo.Size = new System.Drawing.Size(0, 21);
            this.labScanNo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "当前条码：";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdmuScan);
            this.groupBox1.Controls.Add(this.rdAutoScan);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(589, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 69);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "扫描类型";
            // 
            // rdmuScan
            // 
            this.rdmuScan.AutoSize = true;
            this.rdmuScan.Location = new System.Drawing.Point(146, 29);
            this.rdmuScan.Name = "rdmuScan";
            this.rdmuScan.Size = new System.Drawing.Size(107, 24);
            this.rdmuScan.TabIndex = 1;
            this.rdmuScan.Text = "手动扫描";
            this.rdmuScan.UseVisualStyleBackColor = true;
            this.rdmuScan.CheckedChanged += new System.EventHandler(this.rdmuScan_CheckedChanged);
            // 
            // rdAutoScan
            // 
            this.rdAutoScan.AutoSize = true;
            this.rdAutoScan.Checked = true;
            this.rdAutoScan.Location = new System.Drawing.Point(16, 29);
            this.rdAutoScan.Name = "rdAutoScan";
            this.rdAutoScan.Size = new System.Drawing.Size(107, 24);
            this.rdAutoScan.TabIndex = 0;
            this.rdAutoScan.TabStop = true;
            this.rdAutoScan.Text = "自动扫描";
            this.rdAutoScan.UseVisualStyleBackColor = true;
            this.rdAutoScan.CheckedChanged += new System.EventHandler(this.rdAutoScan_CheckedChanged);
            // 
            // tbNo
            // 
            this.tbNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNo.Location = new System.Drawing.Point(123, 25);
            this.tbNo.MaxLength = 34;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.superGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1195, 496);
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.superGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.superGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.superGrid1.DefaultCellStyle = dataGridViewCellStyle4;
            this.superGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superGrid1.Location = new System.Drawing.Point(0, 0);
            this.superGrid1.MultiSelect = false;
            this.superGrid1.Name = "superGrid1";
            this.superGrid1.PageSize = 15;
            this.superGrid1.ReadOnly = true;
            this.superGrid1.RowTemplate.Height = 35;
            this.superGrid1.Size = new System.Drawing.Size(1195, 496);
            this.superGrid1.TabIndex = 1;
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ScanForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "扫描条码";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superGrid1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdmuScan;
        private System.Windows.Forms.RadioButton rdAutoScan;
        private System.Windows.Forms.Label labScanFail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labFangXing;
        private System.Windows.Forms.Label labWuShuJu;
        private System.Windows.Forms.Label labChaYan;
        private System.Windows.Forms.Label labMessage;
        private System.Windows.Forms.Label labNowScan;
        private System.Windows.Forms.Button button1;
    }
}