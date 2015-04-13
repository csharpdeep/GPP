namespace GPP
{
    partial class frmImportThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportThuoc));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this._lbErrorCount = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this._txtTenSheet = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this._btnImport = new DevComponents.DotNetBar.ButtonX();
            this._checkBoxXoaTruocKhiImport = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this._btnDong = new DevComponents.DotNetBar.ButtonX();
            this._txtDuongDan = new System.Windows.Forms.TextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._btnDuyet = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(489, 131);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // _lbErrorCount
            // 
            this._lbErrorCount.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this._lbErrorCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._lbErrorCount.Location = new System.Drawing.Point(263, 175);
            this._lbErrorCount.Name = "_lbErrorCount";
            this._lbErrorCount.Size = new System.Drawing.Size(73, 18);
            this._lbErrorCount.TabIndex = 58;
            this._lbErrorCount.Text = "0";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(184, 175);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(73, 18);
            this.labelX7.TabIndex = 57;
            this.labelX7.Text = "Số lỗi";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(185, 146);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(73, 18);
            this.labelX6.TabIndex = 56;
            this.labelX6.Text = "Tiến trình";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Red;
            this.labelX5.Location = new System.Drawing.Point(381, 83);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(17, 23);
            this.labelX5.TabIndex = 55;
            this.labelX5.Text = "(*)";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Red;
            this.labelX3.Location = new System.Drawing.Point(553, 32);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(17, 23);
            this.labelX3.TabIndex = 54;
            this.labelX3.Text = "(*)";
            // 
            // _txtTenSheet
            // 
            // 
            // 
            // 
            this._txtTenSheet.Border.Class = "TextBoxBorder";
            this._txtTenSheet.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._txtTenSheet.Location = new System.Drawing.Point(185, 83);
            this._txtTenSheet.Name = "_txtTenSheet";
            this._txtTenSheet.Size = new System.Drawing.Size(193, 23);
            this._txtTenSheet.TabIndex = 53;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(185, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 159);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ghi chú";
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(263, 141);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(425, 23);
            this._progressBar.TabIndex = 51;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(185, 61);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(73, 18);
            this.labelX4.TabIndex = 50;
            this.labelX4.Text = "Tên Sheet";
            // 
            // _btnImport
            // 
            this._btnImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnImport.Location = new System.Drawing.Point(484, 361);
            this._btnImport.Name = "_btnImport";
            this._btnImport.Size = new System.Drawing.Size(99, 31);
            this._btnImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnImport.TabIndex = 48;
            this._btnImport.Text = "Import";
            this._btnImport.Click += new System.EventHandler(this.OnBtnImportClick);
            // 
            // _checkBoxXoaTruocKhiImport
            // 
            this._checkBoxXoaTruocKhiImport.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this._checkBoxXoaTruocKhiImport.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._checkBoxXoaTruocKhiImport.Checked = true;
            this._checkBoxXoaTruocKhiImport.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkBoxXoaTruocKhiImport.CheckValue = "Y";
            this._checkBoxXoaTruocKhiImport.Location = new System.Drawing.Point(184, 112);
            this._checkBoxXoaTruocKhiImport.Name = "_checkBoxXoaTruocKhiImport";
            this._checkBoxXoaTruocKhiImport.Size = new System.Drawing.Size(276, 23);
            this._checkBoxXoaTruocKhiImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._checkBoxXoaTruocKhiImport.TabIndex = 47;
            this._checkBoxXoaTruocKhiImport.Text = "Xóa dữ liệu bảng thuốc trước khi import";
            // 
            // _btnDong
            // 
            this._btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnDong.Location = new System.Drawing.Point(589, 361);
            this._btnDong.Name = "_btnDong";
            this._btnDong.Size = new System.Drawing.Size(99, 31);
            this._btnDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnDong.TabIndex = 46;
            this._btnDong.Text = "Đóng";
            this._btnDong.Click += new System.EventHandler(this.OnBtnDongClick);
            // 
            // _txtDuongDan
            // 
            this._txtDuongDan.Location = new System.Drawing.Point(185, 32);
            this._txtDuongDan.Name = "_txtDuongDan";
            this._txtDuongDan.ReadOnly = true;
            this._txtDuongDan.Size = new System.Drawing.Size(365, 23);
            this._txtDuongDan.TabIndex = 45;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(184, 6);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(73, 29);
            this.labelX1.TabIndex = 44;
            this.labelX1.Text = "Tên file";
            // 
            // _btnDuyet
            // 
            this._btnDuyet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnDuyet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnDuyet.Location = new System.Drawing.Point(575, 31);
            this._btnDuyet.Name = "_btnDuyet";
            this._btnDuyet.Size = new System.Drawing.Size(105, 25);
            this._btnDuyet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnDuyet.TabIndex = 43;
            this._btnDuyet.Text = "Duyệt";
            this._btnDuyet.Click += new System.EventHandler(this.OnBtnDuyetTimClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::GPP.Properties.Resources.import_thuoc_wizard;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // frmImportThuoc
            // 
            this.ClientSize = new System.Drawing.Size(697, 399);
            this.ControlBox = false;
            this.Controls.Add(this._lbErrorCount);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this._txtTenSheet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._btnImport);
            this.Controls.Add(this._checkBoxXoaTruocKhiImport);
            this.Controls.Add(this._btnDong);
            this.Controls.Add(this._txtDuongDan);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this._btnDuyet);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Arial", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import danh sách thuốc từ excel";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevComponents.DotNetBar.LabelX _lbErrorCount;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX _txtTenSheet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar _progressBar;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX _btnImport;
        private DevComponents.DotNetBar.Controls.CheckBoxX _checkBoxXoaTruocKhiImport;
        private DevComponents.DotNetBar.ButtonX _btnDong;
        private System.Windows.Forms.TextBox _txtDuongDan;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX _btnDuyet;



    }
}