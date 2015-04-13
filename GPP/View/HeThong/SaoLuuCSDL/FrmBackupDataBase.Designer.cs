namespace GPP.View.HeThong.SaoLuuCSDL
{
    partial class FrmBackupDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackupDataBase));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtMatKhau = new System.Windows.Forms.TextBox();
            this._txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._cbMayChu = new System.Windows.Forms.ComboBox();
            this._btnKiemTraKetNoi = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this._btnHelp = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._txtDuongDan = new System.Windows.Forms.TextBox();
            this._progressBarSaoLuu = new System.Windows.Forms.ProgressBar();
            this._txtBackup = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this._cbTenCSDL = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.pictureBox1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(174, 512);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this._btnHelp);
            this.panelEx2.Controls.Add(this.label4);
            this.panelEx2.Controls.Add(this.groupBox2);
            this.panelEx2.Controls.Add(this.groupBox1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx2.Location = new System.Drawing.Point(143, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(476, 512);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnKiemTraKetNoi);
            this.groupBox1.Controls.Add(this._txtMatKhau);
            this.groupBox1.Controls.Add(this._txtTenDangNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._cbMayChu);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(15, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server Authentication";
            // 
            // _txtMatKhau
            // 
            this._txtMatKhau.Location = new System.Drawing.Point(140, 83);
            this._txtMatKhau.Name = "_txtMatKhau";
            this._txtMatKhau.Size = new System.Drawing.Size(232, 23);
            this._txtMatKhau.TabIndex = 14;
            this._txtMatKhau.UseSystemPasswordChar = true;
            // 
            // _txtTenDangNhap
            // 
            this._txtTenDangNhap.Location = new System.Drawing.Point(140, 57);
            this._txtTenDangNhap.Name = "_txtTenDangNhap";
            this._txtTenDangNhap.Size = new System.Drawing.Size(233, 23);
            this._txtTenDangNhap.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên máy chủ";
            // 
            // _cbMayChu
            // 
            this._cbMayChu.FormattingEnabled = true;
            this._cbMayChu.Location = new System.Drawing.Point(140, 29);
            this._cbMayChu.Name = "_cbMayChu";
            this._cbMayChu.Size = new System.Drawing.Size(233, 24);
            this._cbMayChu.TabIndex = 9;
            // 
            // _btnKiemTraKetNoi
            // 
            this._btnKiemTraKetNoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnKiemTraKetNoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnKiemTraKetNoi.Location = new System.Drawing.Point(161, 112);
            this._btnKiemTraKetNoi.Name = "_btnKiemTraKetNoi";
            this._btnKiemTraKetNoi.Size = new System.Drawing.Size(152, 24);
            this._btnKiemTraKetNoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnKiemTraKetNoi.TabIndex = 16;
            this._btnKiemTraKetNoi.Text = "Kết nối CSDL";
            this._btnKiemTraKetNoi.Click += new System.EventHandler(this._btnKiemTraKetNoi_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sao lưu dữ liệu";
            // 
            // _btnHelp
            // 
            this._btnHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnHelp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnHelp.Image = global::GPP.Properties.Resources.Info;
            this._btnHelp.Location = new System.Drawing.Point(15, 473);
            this._btnHelp.Name = "_btnHelp";
            this._btnHelp.Size = new System.Drawing.Size(102, 27);
            this._btnHelp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnHelp.TabIndex = 6;
            this._btnHelp.Text = "Trợ giúp";
            this._btnHelp.Click += new System.EventHandler(this._btnHelp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this._cbTenCSDL);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this._txtBackup);
            this.groupBox2.Controls.Add(this._progressBarSaoLuu);
            this.groupBox2.Controls.Add(this._txtDuongDan);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(15, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 176);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sao lưu dữ liệu";
            // 
            // _txtDuongDan
            // 
            this._txtDuongDan.Location = new System.Drawing.Point(125, 100);
            this._txtDuongDan.Name = "_txtDuongDan";
            this._txtDuongDan.Size = new System.Drawing.Size(247, 23);
            this._txtDuongDan.TabIndex = 1;
            this._txtDuongDan.Click += new System.EventHandler(this._txtDuongDan_Click);
            this._txtDuongDan.TextChanged += new System.EventHandler(this._txtDuongDan_TextChanged);
            // 
            // _progressBarSaoLuu
            // 
            this._progressBarSaoLuu.Location = new System.Drawing.Point(125, 26);
            this._progressBarSaoLuu.Name = "_progressBarSaoLuu";
            this._progressBarSaoLuu.Size = new System.Drawing.Size(247, 16);
            this._progressBarSaoLuu.TabIndex = 2;
            this._progressBarSaoLuu.Click += new System.EventHandler(this._progressBarSaoLuu_Click);
            // 
            // _txtBackup
            // 
            this._txtBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._txtBackup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._txtBackup.Image = global::GPP.Properties.Resources.Load;
            this._txtBackup.Location = new System.Drawing.Point(161, 145);
            this._txtBackup.Name = "_txtBackup";
            this._txtBackup.Size = new System.Drawing.Size(150, 25);
            this._txtBackup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._txtBackup.TabIndex = 3;
            this._txtBackup.Text = "Sao lưu";
            this._txtBackup.Click += new System.EventHandler(this._txtBackup_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(26, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Tiến trình";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(26, 100);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Đường dẫn";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // _cbTenCSDL
            // 
            this._cbTenCSDL.FormattingEnabled = true;
            this._cbTenCSDL.Location = new System.Drawing.Point(125, 59);
            this._cbTenCSDL.Name = "_cbTenCSDL";
            this._cbTenCSDL.Size = new System.Drawing.Size(247, 24);
            this._cbTenCSDL.TabIndex = 16;
            this._cbTenCSDL.SelectedIndexChanged += new System.EventHandler(this._cbTenCSDL_SelectedIndexChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(26, 58);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 24);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "CSDL";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GPP.Properties.Resources.Document_Download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBackupDataBase
            // 
            this.ClientSize = new System.Drawing.Size(619, 512);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBackupDataBase";
            this.Text = "Sao lưu dữ liệu";
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtMatKhau;
        private System.Windows.Forms.TextBox _txtTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbMayChu;
        private DevComponents.DotNetBar.ButtonX _btnKiemTraKetNoi;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.ButtonX _btnHelp;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ComboBox _cbTenCSDL;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX _txtBackup;
        private System.Windows.Forms.ProgressBar _progressBarSaoLuu;
        private System.Windows.Forms.TextBox _txtDuongDan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}