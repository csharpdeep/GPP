namespace GPP
{
    partial class frmLoaiThuoc
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
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.MaLoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiThuoc,
            this.TenLoaiThuoc});
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(0, 0);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.Size = new System.Drawing.Size(922, 524);
            this._dataGridView.TabIndex = 0;
            this._dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDataGridviewEndClick);
            this._dataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.OnDataGridviewAddRow);
            this._dataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.OnUserDeletingRow);
            // 
            // MaLoaiThuoc
            // 
            this.MaLoaiThuoc.DataPropertyName = "MaLoaiThuoc";
            this.MaLoaiThuoc.Frozen = true;
            this.MaLoaiThuoc.HeaderText = "Ma Loai Thuoc";
            this.MaLoaiThuoc.Name = "MaLoaiThuoc";
            this.MaLoaiThuoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaLoaiThuoc.Width = 150;
            // 
            // TenLoaiThuoc
            // 
            this.TenLoaiThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiThuoc.DataPropertyName = "TenLoaiThuoc";
            this.TenLoaiThuoc.HeaderText = "Ten Loai Thuoc";
            this.TenLoaiThuoc.Name = "TenLoaiThuoc";
            // 
            // frmLoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._dataGridView);
            this.Name = "frmLoaiThuoc";
            this.Size = new System.Drawing.Size(922, 524);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThuoc;
    }
}
