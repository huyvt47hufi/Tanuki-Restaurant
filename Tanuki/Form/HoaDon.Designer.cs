namespace Tanuki
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreload = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.btnTimNgay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1291, 618);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1283, 495);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnreload);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.btnTimNgay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 107);
            this.panel1.TabIndex = 1;
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(900, 75);
            this.btnreload.Margin = new System.Windows.Forms.Padding(4);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(133, 28);
            this.btnreload.TabIndex = 8;
            this.btnreload.Text = "Hiển Thị Tất Cả";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(480, 79);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(264, 22);
            this.txtDate.TabIndex = 7;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnTimNgay
            // 
            this.btnTimNgay.Location = new System.Drawing.Point(753, 76);
            this.btnTimNgay.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimNgay.Name = "btnTimNgay";
            this.btnTimNgay.Size = new System.Drawing.Size(100, 28);
            this.btnTimNgay.TabIndex = 6;
            this.btnTimNgay.Text = "Tìm";
            this.btnTimNgay.UseVisualStyleBackColor = true;
            this.btnTimNgay.Click += new System.EventHandler(this.btnTimNgay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(247, 78);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(93, 80);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(132, 22);
            this.txtTim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(695, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị hóa đơn";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 618);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Button btnTimNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
    }
}