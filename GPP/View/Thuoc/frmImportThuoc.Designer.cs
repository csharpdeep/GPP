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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._lbError = new DevComponents.DotNetBar.LabelX();
            this._lbSoLoi = new DevComponents.DotNetBar.LabelX();
            this._lbPecen = new DevComponents.DotNetBar.LabelX();
            this._btnImport = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this._richTexBoxEdit = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this._progressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this._checkBoxTuDongVietHoa = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this._checkBoxXoaTruocKhiImport = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this._btnDong = new DevComponents.DotNetBar.ButtonX();
            this._txtDuongDan = new System.Windows.Forms.TextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._btnDuyet = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this._lbError);
            this.groupPanel1.Controls.Add(this._lbSoLoi);
            this.groupPanel1.Controls.Add(this._lbPecen);
            this.groupPanel1.Controls.Add(this._btnImport);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this._richTexBoxEdit);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this._progressBar);
            this.groupPanel1.Controls.Add(this._checkBoxTuDongVietHoa);
            this.groupPanel1.Controls.Add(this._checkBoxXoaTruocKhiImport);
            this.groupPanel1.Controls.Add(this._btnDong);
            this.groupPanel1.Controls.Add(this._txtDuongDan);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this._btnDuyet);
            this.groupPanel1.Location = new System.Drawing.Point(8, 5);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(604, 451);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 4;
            this.groupPanel1.Text = "Nhập thuốc từ file excel";
            // 
            // _lbError
            // 
            this._lbError.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this._lbError.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._lbError.ForeColor = System.Drawing.Color.Red;
            this._lbError.Location = new System.Drawing.Point(546, 311);
            this._lbError.Name = "_lbError";
            this._lbError.Size = new System.Drawing.Size(44, 23);
            this._lbError.TabIndex = 16;
            // 
            // _lbSoLoi
            // 
            this._lbSoLoi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this._lbSoLoi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._lbSoLoi.Location = new System.Drawing.Point(503, 308);
            this._lbSoLoi.Name = "_lbSoLoi";
            this._lbSoLoi.Size = new System.Drawing.Size(37, 29);
            this._lbSoLoi.TabIndex = 15;
            this._lbSoLoi.Text = "Số lỗi";
            // 
            // _lbPecen
            // 
            this._lbPecen.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this._lbPecen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._lbPecen.Location = new System.Drawing.Point(82, 311);
            this._lbPecen.Name = "_lbPecen";
            this._lbPecen.Size = new System.Drawing.Size(75, 23);
            this._lbPecen.TabIndex = 14;
            // 
            // _btnImport
            // 
            this._btnImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnImport.Location = new System.Drawing.Point(385, 390);
            this._btnImport.Name = "_btnImport";
            this._btnImport.Size = new System.Drawing.Size(99, 31);
            this._btnImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnImport.TabIndex = 13;
            this._btnImport.Text = "Import";
            this._btnImport.Click += new System.EventHandler(this.OnBtnImportClick);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(3, 127);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(163, 29);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "Thông báo lỗi khi import";
            // 
            // _richTexBoxEdit
            // 
            // 
            // 
            // 
            this._richTexBoxEdit.BackgroundStyle.Class = "RichTextBoxBorder";
            this._richTexBoxEdit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._richTexBoxEdit.Location = new System.Drawing.Point(3, 162);
            this._richTexBoxEdit.Name = "_richTexBoxEdit";
            this._richTexBoxEdit.ReadOnly = true;
            this._richTexBoxEdit.Size = new System.Drawing.Size(587, 140);
            this._richTexBoxEdit.TabIndex = 11;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 308);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(73, 29);
            this.labelX2.TabIndex = 10;
            this.labelX2.Text = "Tiến trình";
            // 
            // _progressBar
            // 
            // 
            // 
            // 
            this._progressBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._progressBar.Location = new System.Drawing.Point(3, 343);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(587, 33);
            this._progressBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this._progressBar.TabIndex = 9;
            this._progressBar.Text = "progressBarX1";
            // 
            // _checkBoxTuDongVietHoa
            // 
            this._checkBoxTuDongVietHoa.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this._checkBoxTuDongVietHoa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._checkBoxTuDongVietHoa.Checked = true;
            this._checkBoxTuDongVietHoa.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkBoxTuDongVietHoa.CheckValue = "Y";
            this._checkBoxTuDongVietHoa.Location = new System.Drawing.Point(9, 96);
            this._checkBoxTuDongVietHoa.Name = "_checkBoxTuDongVietHoa";
            this._checkBoxTuDongVietHoa.Size = new System.Drawing.Size(295, 23);
            this._checkBoxTuDongVietHoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._checkBoxTuDongVietHoa.TabIndex = 8;
            this._checkBoxTuDongVietHoa.Text = "Tự động viết hoa khi import vào";
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
            this._checkBoxXoaTruocKhiImport.Location = new System.Drawing.Point(9, 67);
            this._checkBoxXoaTruocKhiImport.Name = "_checkBoxXoaTruocKhiImport";
            this._checkBoxXoaTruocKhiImport.Size = new System.Drawing.Size(276, 23);
            this._checkBoxXoaTruocKhiImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._checkBoxXoaTruocKhiImport.TabIndex = 7;
            this._checkBoxXoaTruocKhiImport.Text = "Xóa dữ liệu bảng thuốc trước khi import";
            // 
            // _btnDong
            // 
            this._btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnDong.Location = new System.Drawing.Point(491, 390);
            this._btnDong.Name = "_btnDong";
            this._btnDong.Size = new System.Drawing.Size(99, 31);
            this._btnDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnDong.TabIndex = 6;
            this._btnDong.Text = "Đóng";
            this._btnDong.Click += new System.EventHandler(this.OnBtnDongClick);
            // 
            // _txtDuongDan
            // 
            this._txtDuongDan.Location = new System.Drawing.Point(9, 38);
            this._txtDuongDan.Name = "_txtDuongDan";
            this._txtDuongDan.ReadOnly = true;
            this._txtDuongDan.Size = new System.Drawing.Size(456, 23);
            this._txtDuongDan.TabIndex = 5;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(9, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(189, 29);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Chọn đường dẫn đến file excel";
            // 
            // _btnDuyet
            // 
            this._btnDuyet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnDuyet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnDuyet.Location = new System.Drawing.Point(471, 33);
            this._btnDuyet.Name = "_btnDuyet";
            this._btnDuyet.Size = new System.Drawing.Size(105, 28);
            this._btnDuyet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnDuyet.TabIndex = 3;
            this._btnDuyet.Text = "Duyệt";
            this._btnDuyet.Click += new System.EventHandler(this.OnBtnDuyetTimClick);
            // 
            // frmImportThuoc
            // 
            this.ClientSize = new System.Drawing.Size(621, 462);
            this.ControlBox = false;
            this.Controls.Add(this.groupPanel1);
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Arial", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ THUỐC GPP";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX _btnImport;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx _richTexBoxEdit;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ProgressBarX _progressBar;
        private DevComponents.DotNetBar.Controls.CheckBoxX _checkBoxTuDongVietHoa;
        private DevComponents.DotNetBar.Controls.CheckBoxX _checkBoxXoaTruocKhiImport;
        private DevComponents.DotNetBar.ButtonX _btnDong;
        private System.Windows.Forms.TextBox _txtDuongDan;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX _btnDuyet;
        private DevComponents.DotNetBar.LabelX _lbPecen;
        private DevComponents.DotNetBar.LabelX _lbSoLoi;
        private DevComponents.DotNetBar.LabelX _lbError;
    }
}