namespace GPP.View.HeThong.PhucHoiCSDL
{
    partial class FrmRestoreDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRestoreDatabase));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this._btnHelp = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._cbTenCSDL = new System.Windows.Forms.ComboBox();
            this._btnRestore = new DevComponents.DotNetBar.ButtonX();
            this._txtDuongDan = new System.Windows.Forms.TextBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this._progressBarKhoiPhuc = new System.Windows.Forms.ProgressBar();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnKiemTraKetNoi = new DevComponents.DotNetBar.ButtonX();
            this._txtMatKhau = new System.Windows.Forms.TextBox();
            this._txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._cbMayChu = new System.Windows.Forms.ComboBox();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEx1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this._btnHelp);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.groupBox4);
            this.panelEx1.Controls.Add(this.groupBox1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx1.Font = new System.Drawing.Font("Arial", 10.25F);
            this.panelEx1.Location = new System.Drawing.Point(147, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(472, 512);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // _btnHelp
            // 
            this._btnHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnHelp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnHelp.Image = global::GPP.Properties.Resources.Info;
            this._btnHelp.Location = new System.Drawing.Point(5, 474);
            this._btnHelp.Name = "_btnHelp";
            this._btnHelp.Size = new System.Drawing.Size(103, 26);
            this._btnHelp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnHelp.TabIndex = 7;
            this._btnHelp.Text = "Trợ giúp";
            this._btnHelp.Click += new System.EventHandler(this._btnHelp_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelX5.Location = new System.Drawing.Point(24, 3);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(395, 45);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Khôi phục cơ sở dữ liệu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelX1);
            this.groupBox4.Controls.Add(this._cbTenCSDL);
            this.groupBox4.Controls.Add(this._btnRestore);
            this.groupBox4.Controls.Add(this._txtDuongDan);
            this.groupBox4.Controls.Add(this.labelX4);
            this.groupBox4.Controls.Add(this._progressBarKhoiPhuc);
            this.groupBox4.Controls.Add(this.labelX3);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox4.Location = new System.Drawing.Point(4, 229);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 183);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Khôi phục dữ liệu";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(17, 63);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 17;
            this.labelX1.Text = "CSDL";
            // 
            // _cbTenCSDL
            // 
            this._cbTenCSDL.FormattingEnabled = true;
            this._cbTenCSDL.Location = new System.Drawing.Point(115, 62);
            this._cbTenCSDL.Name = "_cbTenCSDL";
            this._cbTenCSDL.Size = new System.Drawing.Size(221, 24);
            this._cbTenCSDL.TabIndex = 16;
            // 
            // _btnRestore
            // 
            this._btnRestore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnRestore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnRestore.Image = global::GPP.Properties.Resources.Load;
            this._btnRestore.Location = new System.Drawing.Point(162, 142);
            this._btnRestore.Name = "_btnRestore";
            this._btnRestore.Size = new System.Drawing.Size(138, 25);
            this._btnRestore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnRestore.TabIndex = 8;
            this._btnRestore.Text = "Khôi phục";
            this._btnRestore.Click += new System.EventHandler(this._btnRestore_Click);
            // 
            // _txtDuongDan
            // 
            this._txtDuongDan.Location = new System.Drawing.Point(115, 102);
            this._txtDuongDan.Name = "_txtDuongDan";
            this._txtDuongDan.Size = new System.Drawing.Size(221, 23);
            this._txtDuongDan.TabIndex = 7;
            this._txtDuongDan.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(20, 102);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Đường dẫn";
            // 
            // _progressBarKhoiPhuc
            // 
            this._progressBarKhoiPhuc.Location = new System.Drawing.Point(115, 33);
            this._progressBarKhoiPhuc.Name = "_progressBarKhoiPhuc";
            this._progressBarKhoiPhuc.Size = new System.Drawing.Size(221, 16);
            this._progressBarKhoiPhuc.TabIndex = 7;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(18, 33);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Tiến trình";
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
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server";
            // 
            // _btnKiemTraKetNoi
            // 
            this._btnKiemTraKetNoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnKiemTraKetNoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnKiemTraKetNoi.Location = new System.Drawing.Point(161, 112);
            this._btnKiemTraKetNoi.Name = "_btnKiemTraKetNoi";
            this._btnKiemTraKetNoi.Size = new System.Drawing.Size(140, 23);
            this._btnKiemTraKetNoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnKiemTraKetNoi.TabIndex = 16;
            this._btnKiemTraKetNoi.Text = "Kết nối CSDL";
            this._btnKiemTraKetNoi.Click += new System.EventHandler(this._btnKiemTraKetNoi_Click_1);
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
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.Controls.Add(this.pictureBox1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(146, 512);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GPP.Properties.Resources.Document_Download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRestoreDatabase
            // 
            this.ClientSize = new System.Drawing.Size(619, 512);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRestoreDatabase";
            this.Text = "Sao lưu phục hồi cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.SaoLuuPhucHoiDuLieu_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtMatKhau;
        private System.Windows.Forms.TextBox _txtTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbMayChu;
        private System.Windows.Forms.ComboBox _cbTenCSDL;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.ButtonX _btnRestore;
        private System.Windows.Forms.TextBox _txtDuongDan;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ProgressBar _progressBarKhoiPhuc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX _btnKiemTraKetNoi;
        private DevComponents.DotNetBar.ButtonX _btnHelp;
    }
}