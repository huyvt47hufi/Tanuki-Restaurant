namespace Tanuki
{
    partial class StockList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnDong = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbLoai = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.bnTim = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTenMon = new System.Windows.Forms.Label();
            this.lbMaMon = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtTenmon = new System.Windows.Forms.TextBox();
            this.rdoMaMon = new System.Windows.Forms.RadioButton();
            this.rdoTenMon = new System.Windows.Forms.RadioButton();
            this.btnTimMon = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.btnDong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(717, 31);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 28);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 28);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 28);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(61, 28);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(74, 28);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvHienThi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 372);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienThi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHienThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHienThi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHienThi.Location = new System.Drawing.Point(3, 58);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(711, 311);
            this.dgvHienThi.TabIndex = 2;
            this.dgvHienThi.Click += new System.EventHandler(this.dgvHienThi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(713, 51);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbLoai, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbLoai, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.bnTim, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(281, 47);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoai.Location = new System.Drawing.Point(92, 0);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(45, 28);
            this.lbLoai.TabIndex = 1;
            this.lbLoai.Text = "Loại";
            // 
            // cbLoai
            // 
            this.cbLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(143, 3);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(135, 30);
            this.cbLoai.TabIndex = 2;
            // 
            // bnTim
            // 
            this.bnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.bnTim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnTim.Location = new System.Drawing.Point(143, 31);
            this.bnTim.Name = "bnTim";
            this.bnTim.Size = new System.Drawing.Size(135, 13);
            this.bnTim.TabIndex = 3;
            this.bnTim.Text = "Tìm";
            this.bnTim.UseVisualStyleBackColor = false;
            this.bnTim.Click += new System.EventHandler(this.bnTim_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.25806F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.tableLayoutPanel4.Controls.Add(this.btnTenMon, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbMaMon, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtMaMon, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtTenmon, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.rdoMaMon, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.rdoTenMon, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnTimMon, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(287, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(281, 47);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnTenMon
            // 
            this.btnTenMon.AutoSize = true;
            this.btnTenMon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenMon.Location = new System.Drawing.Point(38, 14);
            this.btnTenMon.Name = "btnTenMon";
            this.btnTenMon.Size = new System.Drawing.Size(49, 14);
            this.btnTenMon.TabIndex = 11;
            this.btnTenMon.Text = "Tên món";
            // 
            // lbMaMon
            // 
            this.lbMaMon.AutoSize = true;
            this.lbMaMon.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaMon.Location = new System.Drawing.Point(8, 0);
            this.lbMaMon.Name = "lbMaMon";
            this.lbMaMon.Size = new System.Drawing.Size(79, 14);
            this.lbMaMon.TabIndex = 10;
            this.lbMaMon.Text = "Mã món";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.Location = new System.Drawing.Point(93, 3);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(129, 28);
            this.txtMaMon.TabIndex = 12;
            // 
            // txtTenmon
            // 
            this.txtTenmon.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenmon.Location = new System.Drawing.Point(93, 17);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(129, 28);
            this.txtTenmon.TabIndex = 13;
            // 
            // rdoMaMon
            // 
            this.rdoMaMon.AutoSize = true;
            this.rdoMaMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdoMaMon.Location = new System.Drawing.Point(228, 3);
            this.rdoMaMon.Name = "rdoMaMon";
            this.rdoMaMon.Size = new System.Drawing.Size(50, 8);
            this.rdoMaMon.TabIndex = 14;
            this.rdoMaMon.TabStop = true;
            this.rdoMaMon.UseVisualStyleBackColor = true;
            // 
            // rdoTenMon
            // 
            this.rdoTenMon.AutoSize = true;
            this.rdoTenMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdoTenMon.Location = new System.Drawing.Point(228, 17);
            this.rdoTenMon.Name = "rdoTenMon";
            this.rdoTenMon.Size = new System.Drawing.Size(50, 8);
            this.rdoTenMon.TabIndex = 15;
            this.rdoTenMon.TabStop = true;
            this.rdoTenMon.UseVisualStyleBackColor = true;
            // 
            // btnTimMon
            // 
            this.btnTimMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(170)))));
            this.btnTimMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMon.Location = new System.Drawing.Point(93, 31);
            this.btnTimMon.Name = "btnTimMon";
            this.btnTimMon.Size = new System.Drawing.Size(129, 13);
            this.btnTimMon.TabIndex = 16;
            this.btnTimMon.Text = "Tìm Món";
            this.btnTimMon.UseVisualStyleBackColor = false;
            this.btnTimMon.Click += new System.EventHandler(this.btnTimMon_Click);
            // 
            // StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 403);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StockList";
            this.Text = "StockList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnDong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Label btnTenMon;
        private System.Windows.Forms.Label lbMaMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtTenmon;
        private System.Windows.Forms.RadioButton rdoMaMon;
        private System.Windows.Forms.RadioButton rdoTenMon;
        private System.Windows.Forms.Button btnTimMon;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Button bnTim;

    }
}