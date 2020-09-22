namespace TimeInOut
{
    partial class Time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Time));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.pnUser = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV_TT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVaoCa = new System.Windows.Forms.Button();
            this.btnRaCa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(707, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNV.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(40)))), ((int)(((byte)(23)))));
            this.txtMaNV.Location = new System.Drawing.Point(225, 41);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(351, 31);
            this.txtMaNV.TabIndex = 13;
            this.txtMaNV.Text = "Nhâp vào mã nhân viên . . .";
            this.txtMaNV.Click += new System.EventHandler(this.txtMaNV_Click);
            // 
            // pnUser
            // 
            this.pnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(37)))));
            this.pnUser.Location = new System.Drawing.Point(168, 78);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(400, 2);
            this.pnUser.TabIndex = 12;
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(168, 25);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(51, 52);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 11;
            this.picUser.TabStop = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(219)))), ((int)(((byte)(201)))));
            this.btnXacNhan.Location = new System.Drawing.Point(620, 24);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(188, 53);
            this.btnXacNhan.TabIndex = 14;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.txtGio);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.txtNgay);
            this.gbThongTin.Controls.Add(this.txtTenNV);
            this.gbThongTin.Controls.Add(this.txtMaNV_TT);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold);
            this.gbThongTin.Location = new System.Drawing.Point(50, 113);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(628, 266);
            this.gbThongTin.TabIndex = 15;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin nhân viên";
            // 
            // txtNgay
            // 
            this.txtNgay.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(175, 193);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(131, 34);
            this.txtNgay.TabIndex = 6;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(175, 128);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(432, 34);
            this.txtTenNV.TabIndex = 5;
            // 
            // txtMaNV_TT
            // 
            this.txtMaNV_TT.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV_TT.Location = new System.Drawing.Point(175, 65);
            this.txtMaNV_TT.Name = "txtMaNV_TT";
            this.txtMaNV_TT.Size = new System.Drawing.Size(432, 34);
            this.txtMaNV_TT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày hiện tại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // btnVaoCa
            // 
            this.btnVaoCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.btnVaoCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaoCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaoCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(219)))), ((int)(((byte)(201)))));
            this.btnVaoCa.Location = new System.Drawing.Point(50, 409);
            this.btnVaoCa.Name = "btnVaoCa";
            this.btnVaoCa.Size = new System.Drawing.Size(243, 53);
            this.btnVaoCa.TabIndex = 16;
            this.btnVaoCa.Text = "Vào ca";
            this.btnVaoCa.UseVisualStyleBackColor = false;
            this.btnVaoCa.Click += new System.EventHandler(this.btnVaoCa_Click);
            // 
            // btnRaCa
            // 
            this.btnRaCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.btnRaCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(219)))), ((int)(((byte)(201)))));
            this.btnRaCa.Location = new System.Drawing.Point(350, 409);
            this.btnRaCa.Name = "btnRaCa";
            this.btnRaCa.Size = new System.Drawing.Size(245, 53);
            this.btnRaCa.TabIndex = 17;
            this.btnRaCa.Text = "Ra ca";
            this.btnRaCa.UseVisualStyleBackColor = false;
            this.btnRaCa.Click += new System.EventHandler(this.btnRaCa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giờ hiện tại:";
            // 
            // txtGio
            // 
            this.txtGio.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGio.Location = new System.Drawing.Point(453, 193);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(154, 34);
            this.txtGio.TabIndex = 8;
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(952, 489);
            this.Controls.Add(this.btnRaCa);
            this.Controls.Add(this.btnVaoCa);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.pnUser);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Time";
            this.Text = "Time-In-Out";
            this.Load += new System.EventHandler(this.Time_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Button btnVaoCa;
        private System.Windows.Forms.Button btnRaCa;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV_TT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.Label label4;
    }
}

