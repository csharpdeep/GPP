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
            this.lbPecen = new DevComponents.DotNetBar.LabelX();
            this.btnImport = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.inforError = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.checkUpscae = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkDeleteAllThuoc = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.txtPatch = new System.Windows.Forms.TextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnBrowser = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lbPecen);
            this.groupPanel1.Controls.Add(this.btnImport);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.inforError);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.progressBarX1);
            this.groupPanel1.Controls.Add(this.checkUpscae);
            this.groupPanel1.Controls.Add(this.checkDeleteAllThuoc);
            this.groupPanel1.Controls.Add(this.buttonX2);
            this.groupPanel1.Controls.Add(this.txtPatch);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.btnBrowser);
            this.groupPanel1.Location = new System.Drawing.Point(0, 12);
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
            // lbPecen
            // 
            this.lbPecen.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbPecen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbPecen.Location = new System.Drawing.Point(501, 314);
            this.lbPecen.Name = "lbPecen";
            this.lbPecen.Size = new System.Drawing.Size(75, 23);
            this.lbPecen.TabIndex = 14;
            // 
            // btnImport
            // 
            this.btnImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImport.Location = new System.Drawing.Point(385, 390);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(99, 31);
            this.btnImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImport.TabIndex = 13;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.buttonX3_Click);
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
            // inforError
            // 
            // 
            // 
            // 
            this.inforError.BackgroundStyle.Class = "RichTextBoxBorder";
            this.inforError.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inforError.Location = new System.Drawing.Point(3, 162);
            this.inforError.Name = "inforError";
            this.inforError.ReadOnly = true;
            this.inforError.Size = new System.Drawing.Size(587, 140);
            this.inforError.TabIndex = 11;
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
            // progressBarX1
            // 
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(3, 343);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(587, 33);
            this.progressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.progressBarX1.TabIndex = 9;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // checkUpscae
            // 
            this.checkUpscae.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkUpscae.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkUpscae.Checked = true;
            this.checkUpscae.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUpscae.CheckValue = "Y";
            this.checkUpscae.Location = new System.Drawing.Point(9, 96);
            this.checkUpscae.Name = "checkUpscae";
            this.checkUpscae.Size = new System.Drawing.Size(295, 23);
            this.checkUpscae.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkUpscae.TabIndex = 8;
            this.checkUpscae.Text = "Tự động viết hoa khi import vào";
            // 
            // checkDeleteAllThuoc
            // 
            this.checkDeleteAllThuoc.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkDeleteAllThuoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkDeleteAllThuoc.Checked = true;
            this.checkDeleteAllThuoc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDeleteAllThuoc.CheckValue = "Y";
            this.checkDeleteAllThuoc.Location = new System.Drawing.Point(9, 67);
            this.checkDeleteAllThuoc.Name = "checkDeleteAllThuoc";
            this.checkDeleteAllThuoc.Size = new System.Drawing.Size(276, 23);
            this.checkDeleteAllThuoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkDeleteAllThuoc.TabIndex = 7;
            this.checkDeleteAllThuoc.Text = "Xóa dữ liệu bảng thuốc trước khi import";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(491, 390);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(99, 31);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 6;
            this.buttonX2.Text = "Đóng";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // txtPatch
            // 
            this.txtPatch.Location = new System.Drawing.Point(9, 38);
            this.txtPatch.Name = "txtPatch";
            this.txtPatch.Size = new System.Drawing.Size(456, 23);
            this.txtPatch.TabIndex = 5;
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
            // btnBrowser
            // 
            this.btnBrowser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowser.Location = new System.Drawing.Point(471, 33);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(105, 28);
            this.btnBrowser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowser.TabIndex = 3;
            this.btnBrowser.Text = "Duyệt";
            this.btnBrowser.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmImportThuoc
            // 
            this.ClientSize = new System.Drawing.Size(605, 466);
            this.ControlBox = false;
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Arial", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
        private DevComponents.DotNetBar.ButtonX btnImport;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx inforError;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkUpscae;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkDeleteAllThuoc;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.TextBox txtPatch;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnBrowser;
        private DevComponents.DotNetBar.LabelX lbPecen;
    }
}