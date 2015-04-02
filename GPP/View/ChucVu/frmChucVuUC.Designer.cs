namespace GPP
{
    partial class frmChucVu
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
            this._datagridView = new System.Windows.Forms.DataGridView();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTaCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._datagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _datagridView
            // 
            this._datagridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._datagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._datagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChucVu,
            this.MoTaCongViec});
            this._datagridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._datagridView.GridColor = System.Drawing.Color.Green;
            this._datagridView.Location = new System.Drawing.Point(0, 0);
            this._datagridView.Margin = new System.Windows.Forms.Padding(4);
            this._datagridView.MultiSelect = false;
            this._datagridView.Name = "_datagridView";
            this._datagridView.Size = new System.Drawing.Size(835, 453);
            this._datagridView.TabIndex = 15;
            this._datagridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDataGridViewCellEndEdit);
            this._datagridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.OnDatagridViewUserAddedRow);
            this._datagridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.OnDatagridViewUserDeletingRow);
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MACHUCVU";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.MaChucVu.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaChucVu.HeaderText = "ID";
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.ReadOnly = true;
            this.MaChucVu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MoTaCongViec
            // 
            this.MoTaCongViec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoTaCongViec.DataPropertyName = "MOTA";
            this.MoTaCongViec.HeaderText = "Mô tả";
            this.MoTaCongViec.Name = "MoTaCongViec";
            this.MoTaCongViec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 453);
            this.Controls.Add(this._datagridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this._datagridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _datagridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTaCongViec;

    }
}
