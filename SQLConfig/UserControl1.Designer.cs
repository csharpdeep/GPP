namespace SQLConfig
{
    partial class SqlManagementUC
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._cbMayChu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._txtTenDangNhap = new System.Windows.Forms.TextBox();
            this._txtMatKhau = new System.Windows.Forms.TextBox();
            this._btnKiemTraKetNoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._cbTenCSDL = new System.Windows.Forms.ComboBox();
            this._btnLuuCSDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLConfig.Properties.Resources.Logo_SQL;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _cbMayChu
            // 
            this._cbMayChu.FormattingEnabled = true;
            this._cbMayChu.Location = new System.Drawing.Point(13, 98);
            this._cbMayChu.Name = "_cbMayChu";
            this._cbMayChu.Size = new System.Drawing.Size(376, 25);
            this._cbMayChu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên máy chủ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài khoản đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu:";
            // 
            // _txtTenDangNhap
            // 
            this._txtTenDangNhap.Location = new System.Drawing.Point(13, 150);
            this._txtTenDangNhap.Name = "_txtTenDangNhap";
            this._txtTenDangNhap.Size = new System.Drawing.Size(376, 23);
            this._txtTenDangNhap.TabIndex = 5;
            // 
            // _txtMatKhau
            // 
            this._txtMatKhau.Location = new System.Drawing.Point(13, 203);
            this._txtMatKhau.Name = "_txtMatKhau";
            this._txtMatKhau.Size = new System.Drawing.Size(376, 23);
            this._txtMatKhau.TabIndex = 6;
            this._txtMatKhau.UseSystemPasswordChar = true;
            // 
            // _btnKiemTraKetNoi
            // 
            this._btnKiemTraKetNoi.Location = new System.Drawing.Point(103, 235);
            this._btnKiemTraKetNoi.Name = "_btnKiemTraKetNoi";
            this._btnKiemTraKetNoi.Size = new System.Drawing.Size(173, 27);
            this._btnKiemTraKetNoi.TabIndex = 7;
            this._btnKiemTraKetNoi.Text = "Kiểm tra kết nối CSDL";
            this._btnKiemTraKetNoi.UseVisualStyleBackColor = true;
            this._btnKiemTraKetNoi.Click += new System.EventHandler(this.OnBtnKiemTraKetNoiClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên CSDL";
            // 
            // _cbTenCSDL
            // 
            this._cbTenCSDL.FormattingEnabled = true;
            this._cbTenCSDL.Location = new System.Drawing.Point(13, 281);
            this._cbTenCSDL.Name = "_cbTenCSDL";
            this._cbTenCSDL.Size = new System.Drawing.Size(376, 25);
            this._cbTenCSDL.TabIndex = 8;
            // 
            // _btnLuuCSDL
            // 
            this._btnLuuCSDL.Location = new System.Drawing.Point(103, 349);
            this._btnLuuCSDL.Name = "_btnLuuCSDL";
            this._btnLuuCSDL.Size = new System.Drawing.Size(173, 23);
            this._btnLuuCSDL.TabIndex = 10;
            this._btnLuuCSDL.Text = "Save";
            this._btnLuuCSDL.UseVisualStyleBackColor = true;
            this._btnLuuCSDL.Click += new System.EventHandler(this._btnLuuCSDL_Click);
            // 
            // SqlManagementUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnLuuCSDL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._cbTenCSDL);
            this.Controls.Add(this._btnKiemTraKetNoi);
            this.Controls.Add(this._txtMatKhau);
            this.Controls.Add(this._txtTenDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cbMayChu);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SqlManagementUC";
            this.Size = new System.Drawing.Size(407, 430);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox _cbMayChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtTenDangNhap;
        private System.Windows.Forms.TextBox _txtMatKhau;
        private System.Windows.Forms.Button _btnKiemTraKetNoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _cbTenCSDL;
        private System.Windows.Forms.Button _btnLuuCSDL;
    }
}
