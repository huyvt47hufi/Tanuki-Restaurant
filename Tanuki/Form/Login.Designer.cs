namespace Tanuki
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pnUser = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Image = ((System.Drawing.Image)(resources.GetObject("picDisplay.Image")));
            this.picDisplay.Location = new System.Drawing.Point(44, 28);
            this.picDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(308, 310);
            this.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(385, 28);
            this.picTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(308, 178);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 1;
            this.picTitle.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(425, 236);
            this.picUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(38, 42);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 4;
            this.picUser.TabStop = false;
            // 
            // pnUser
            // 
            this.pnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(37)))));
            this.pnUser.Location = new System.Drawing.Point(425, 280);
            this.pnUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(225, 2);
            this.pnUser.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(37)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(219)))), ((int)(((byte)(201)))));
            this.btnLogin.Location = new System.Drawing.Point(425, 384);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(225, 43);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(200)))));
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserID.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(40)))), ((int)(((byte)(23)))));
            this.txtUserID.Location = new System.Drawing.Point(478, 249);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(157, 25);
            this.txtUserID.TabIndex = 10;
            this.txtUserID.Text = "User ID";
            this.txtUserID.Click += new System.EventHandler(this.txtUserID_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(200)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(40)))), ((int)(((byte)(23)))));
            this.txtPassword.Location = new System.Drawing.Point(478, 315);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(157, 25);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(37)))));
            this.panel2.Location = new System.Drawing.Point(425, 345);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 2);
            this.panel2.TabIndex = 12;
            // 
            // picPass
            // 
            this.picPass.Image = ((System.Drawing.Image)(resources.GetObject("picPass.Image")));
            this.picPass.Location = new System.Drawing.Point(425, 302);
            this.picPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(38, 42);
            this.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPass.TabIndex = 11;
            this.picPass.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 145);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(200)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(723, 480);
            this.Controls.Add(this.picDisplay);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picPass);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnUser);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TanukiPOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.PictureBox pictureBox1;





    }
}

