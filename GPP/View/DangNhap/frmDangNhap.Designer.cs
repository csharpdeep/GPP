namespace GPP.View
{
    partial class frmDangNhap
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
            this._txtUser = new System.Windows.Forms.TextBox();
            this._btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._pictureBoxClosed = new System.Windows.Forms.PictureBox();
            this._txtPassWords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._ckRemeberUser = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxClosed)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtUser
            // 
            this._txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtUser.ForeColor = System.Drawing.Color.Gray;
            this._txtUser.Location = new System.Drawing.Point(23, 65);
            this._txtUser.Name = "_txtUser";
            this._txtUser.Size = new System.Drawing.Size(356, 23);
            this._txtUser.TabIndex = 1;
            this._txtUser.Text = "Tên đăng nhập";
            this._txtUser.Click += new System.EventHandler(this.OnTxtUserClicked);
            this._txtUser.TextChanged += new System.EventHandler(this.OnTxtUserTextChange);
            // 
            // _btnLogin
            // 
            this._btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this._btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLogin.ForeColor = System.Drawing.Color.White;
            this._btnLogin.Location = new System.Drawing.Point(140, 183);
            this._btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(129, 33);
            this._btnLogin.TabIndex = 3;
            this._btnLogin.Text = "Đăng nhập";
            this._btnLogin.UseVisualStyleBackColor = false;
            this._btnLogin.Click += new System.EventHandler(this.OnBtnLoginClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đăng Nhập";
            // 
            // _pictureBoxClosed
            // 
            this._pictureBoxClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pictureBoxClosed.Image = global::GPP.Properties.Resources.Untitled_1;
            this._pictureBoxClosed.Location = new System.Drawing.Point(357, 3);
            this._pictureBoxClosed.Name = "_pictureBoxClosed";
            this._pictureBoxClosed.Size = new System.Drawing.Size(32, 25);
            this._pictureBoxClosed.TabIndex = 6;
            this._pictureBoxClosed.TabStop = false;
            this._pictureBoxClosed.Click += new System.EventHandler(this.OnPictureBoxClosedClick);
            this._pictureBoxClosed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPictureBoxMouseMove);
            // 
            // _txtPassWords
            // 
            this._txtPassWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPassWords.ForeColor = System.Drawing.Color.Gray;
            this._txtPassWords.Location = new System.Drawing.Point(27, 124);
            this._txtPassWords.Name = "_txtPassWords";
            this._txtPassWords.Size = new System.Drawing.Size(356, 23);
            this._txtPassWords.TabIndex = 2;
            this._txtPassWords.Text = "Mật khẩu";
            this._txtPassWords.Click += new System.EventHandler(this.OnTxtPassWordsClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this._pictureBoxClosed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 30);
            this.panel1.TabIndex = 8;
            // 
            // _ckRemeberUser
            // 
            this._ckRemeberUser.AutoSize = true;
            this._ckRemeberUser.Location = new System.Drawing.Point(27, 162);
            this._ckRemeberUser.Name = "_ckRemeberUser";
            this._ckRemeberUser.Size = new System.Drawing.Size(93, 17);
            this._ckRemeberUser.TabIndex = 9;
            this._ckRemeberUser.Text = "Nhớ tài khoản";
            this._ckRemeberUser.UseVisualStyleBackColor = true;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this._btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(393, 225);
            this.Controls.Add(this._ckRemeberUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtPassWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnLogin);
            this.Controls.Add(this._txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.OnFrmDangNhapLoad);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxClosed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtUser;
        private System.Windows.Forms.Button _btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox _pictureBoxClosed;
        private System.Windows.Forms.TextBox _txtPassWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox _ckRemeberUser;
    }
}