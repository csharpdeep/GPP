namespace GPP
{
    partial class frmPhanQuyen
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
            this._dataGridViewChucVu = new System.Windows.Forms.DataGridView();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewPhanQuyen = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Them = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridViewChucVu
            // 
            this._dataGridViewChucVu.AllowUserToAddRows = false;
            this._dataGridViewChucVu.AllowUserToDeleteRows = false;
            this._dataGridViewChucVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._dataGridViewChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChucVu,
            this.MoTa});
            this._dataGridViewChucVu.Dock = System.Windows.Forms.DockStyle.Left;
            this._dataGridViewChucVu.Location = new System.Drawing.Point(0, 0);
            this._dataGridViewChucVu.Margin = new System.Windows.Forms.Padding(4);
            this._dataGridViewChucVu.MultiSelect = false;
            this._dataGridViewChucVu.Name = "_dataGridViewChucVu";
            this._dataGridViewChucVu.ReadOnly = true;
            this._dataGridViewChucVu.ShowCellErrors = false;
            this._dataGridViewChucVu.ShowCellToolTips = false;
            this._dataGridViewChucVu.ShowEditingIcon = false;
            this._dataGridViewChucVu.Size = new System.Drawing.Size(275, 453);
            this._dataGridViewChucVu.TabIndex = 0;
            this._dataGridViewChucVu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridViewChucVu_RowEnter);
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "MaChucVu";
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.ReadOnly = true;
            this.MaChucVu.Visible = false;
            // 
            // MoTa
            // 
            this.MoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Chức vụ";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // _dataGridViewPhanQuyen
            // 
            this._dataGridViewPhanQuyen.AllowUserToAddRows = false;
            this._dataGridViewPhanQuyen.AllowUserToDeleteRows = false;
            this._dataGridViewPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaChucNang,
            this.dataGridViewTextBoxColumn2,
            this.Xem,
            this.Them,
            this.Sua,
            this.Xoa});
            this._dataGridViewPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewPhanQuyen.Location = new System.Drawing.Point(275, 0);
            this._dataGridViewPhanQuyen.Margin = new System.Windows.Forms.Padding(4);
            this._dataGridViewPhanQuyen.MultiSelect = false;
            this._dataGridViewPhanQuyen.Name = "_dataGridViewPhanQuyen";
            this._dataGridViewPhanQuyen.Size = new System.Drawing.Size(560, 453);
            this._dataGridViewPhanQuyen.TabIndex = 1;
            this._dataGridViewPhanQuyen.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridViewChucNang_CellEndEdit);
            this._dataGridViewPhanQuyen.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this._dataGridViewChucNang_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPhanQuyen";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaPhanQuyen";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // MaChucNang
            // 
            this.MaChucNang.DataPropertyName = "MACHUCNANG";
            this.MaChucNang.HeaderText = "MaChucNang";
            this.MaChucNang.Name = "MaChucNang";
            this.MaChucNang.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MoTa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Chức năng chương trình";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Xem
            // 
            this.Xem.DataPropertyName = "XEM";
            this.Xem.HeaderText = "Xem";
            this.Xem.Name = "Xem";
            this.Xem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Xem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Xem.Width = 50;
            // 
            // Them
            // 
            this.Them.DataPropertyName = "THEM";
            this.Them.HeaderText = "Thêm";
            this.Them.Name = "Them";
            this.Them.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Them.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Them.Width = 50;
            // 
            // Sua
            // 
            this.Sua.DataPropertyName = "SUA";
            this.Sua.HeaderText = "Sửa";
            this.Sua.Name = "Sua";
            this.Sua.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sua.Width = 50;
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "XOA";
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Xoa.Width = 50;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 453);
            this.Controls.Add(this._dataGridViewPhanQuyen);
            this.Controls.Add(this._dataGridViewChucVu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewPhanQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridViewChucVu;
        private System.Windows.Forms.DataGridView _dataGridViewPhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Xem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Them;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sua;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Xoa;
    }
}
