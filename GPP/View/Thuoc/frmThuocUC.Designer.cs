namespace GPP
{
    partial class frmThuocUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._panelBottom = new DevComponents.DotNetBar.PanelEx();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this._btnNhapTuFile = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this._panelContent = new DevComponents.DotNetBar.PanelEx();
            this._dataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this._panelBottom.SuspendLayout();
            this._panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _panelBottom
            // 
            this._panelBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this._panelBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._panelBottom.Controls.Add(this.buttonX6);
            this._panelBottom.Controls.Add(this.textBoxX1);
            this._panelBottom.Controls.Add(this.buttonX5);
            this._panelBottom.Controls.Add(this._btnNhapTuFile);
            this._panelBottom.Controls.Add(this.buttonX3);
            this._panelBottom.Controls.Add(this.buttonX2);
            this._panelBottom.Controls.Add(this.buttonX1);
            this._panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBottom.Location = new System.Drawing.Point(0, 451);
            this._panelBottom.Name = "_panelBottom";
            this._panelBottom.Size = new System.Drawing.Size(1030, 50);
            this._panelBottom.Style.Alignment = System.Drawing.StringAlignment.Center;
            this._panelBottom.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._panelBottom.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._panelBottom.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this._panelBottom.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._panelBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._panelBottom.Style.GradientAngle = 90;
            this._panelBottom.TabIndex = 1;
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Image = global::GPP.Properties.Resources.Search;
            this.buttonX6.ImageTextSpacing = 5;
            this.buttonX6.Location = new System.Drawing.Point(218, 8);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(144, 34);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 6;
            this.buttonX6.Text = "Tìm kiếm";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(3, 15);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(209, 23);
            this.textBoxX1.TabIndex = 5;
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Image = global::GPP.Properties.Resources.Save;
            this.buttonX5.ImageTextSpacing = 5;
            this.buttonX5.Location = new System.Drawing.Point(386, 8);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(144, 34);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 4;
            this.buttonX5.Text = "Xuất ra Excel";
            // 
            // _btnNhapTuFile
            // 
            this._btnNhapTuFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnNhapTuFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnNhapTuFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnNhapTuFile.Image = global::GPP.Properties.Resources.Load;
            this._btnNhapTuFile.ImageTextSpacing = 5;
            this._btnNhapTuFile.Location = new System.Drawing.Point(536, 8);
            this._btnNhapTuFile.Name = "_btnNhapTuFile";
            this._btnNhapTuFile.Size = new System.Drawing.Size(146, 34);
            this._btnNhapTuFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnNhapTuFile.TabIndex = 3;
            this._btnNhapTuFile.Text = "Nhập từ file";
            this._btnNhapTuFile.Click += new System.EventHandler(this._btnNhapTuFile_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Image = global::GPP.Properties.Resources.Add;
            this.buttonX3.ImageTextSpacing = 5;
            this.buttonX3.Location = new System.Drawing.Point(688, 8);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(106, 34);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 2;
            this.buttonX3.Text = "Thêm";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::GPP.Properties.Resources.Modify;
            this.buttonX2.ImageTextSpacing = 5;
            this.buttonX2.Location = new System.Drawing.Point(800, 8);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(106, 34);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 1;
            this.buttonX2.Text = "Sửa";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::GPP.Properties.Resources.Delete;
            this.buttonX1.ImageTextSpacing = 5;
            this.buttonX1.Location = new System.Drawing.Point(912, 8);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(106, 34);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Xóa";
            // 
            // _panelContent
            // 
            this._panelContent.CanvasColor = System.Drawing.SystemColors.Control;
            this._panelContent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._panelContent.Controls.Add(this._dataGridView);
            this._panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelContent.Location = new System.Drawing.Point(0, 0);
            this._panelContent.Name = "_panelContent";
            this._panelContent.Size = new System.Drawing.Size(1030, 451);
            this._panelContent.Style.Alignment = System.Drawing.StringAlignment.Center;
            this._panelContent.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._panelContent.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._panelContent.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this._panelContent.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._panelContent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._panelContent.Style.GradientAngle = 90;
            this._panelContent.TabIndex = 2;
            // 
            // _dataGridView
            // 
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this._dataGridView.Location = new System.Drawing.Point(0, 0);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.Size = new System.Drawing.Size(1030, 451);
            this._dataGridView.TabIndex = 0;
            // 
            // frmThuocUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 501);
            this.Controls.Add(this._panelContent);
            this.Controls.Add(this._panelBottom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThuocUC";
            this._panelBottom.ResumeLayout(false);
            this._panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx _panelBottom;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX _btnNhapTuFile;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.PanelEx _panelContent;
        private DevComponents.DotNetBar.Controls.DataGridViewX _dataGridView;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;

    }
}
