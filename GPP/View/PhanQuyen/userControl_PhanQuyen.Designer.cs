namespace GPP.View.PhanQuyen
{
    partial class userControl_PhanQuyen
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
            this.dataChucVu = new System.Windows.Forms.DataGridView();
            this.checkboxXem = new System.Windows.Forms.CheckBox();
            this.checkboxXoa = new System.Windows.Forms.CheckBox();
            this.checkboxSua = new System.Windows.Forms.CheckBox();
            this.checkboxThem = new System.Windows.Forms.CheckBox();
            this.dataChucNang = new System.Windows.Forms.DataGridView();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbChucNang = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataChucNang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataChucVu
            // 
            this.dataChucVu.AllowUserToAddRows = false;
            this.dataChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChucVu.Location = new System.Drawing.Point(3, 16);
            this.dataChucVu.Name = "dataChucVu";
            this.dataChucVu.RowHeadersVisible = false;
            this.dataChucVu.Size = new System.Drawing.Size(476, 240);
            this.dataChucVu.TabIndex = 0;
            this.dataChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChucVu_CellClick);
            // 
            // checkboxXem
            // 
            this.checkboxXem.AutoSize = true;
            this.checkboxXem.Location = new System.Drawing.Point(487, 357);
            this.checkboxXem.Name = "checkboxXem";
            this.checkboxXem.Size = new System.Drawing.Size(47, 17);
            this.checkboxXem.TabIndex = 2;
            this.checkboxXem.Text = "Xem";
            this.checkboxXem.UseVisualStyleBackColor = true;
            // 
            // checkboxXoa
            // 
            this.checkboxXoa.AutoSize = true;
            this.checkboxXoa.Location = new System.Drawing.Point(753, 357);
            this.checkboxXoa.Name = "checkboxXoa";
            this.checkboxXoa.Size = new System.Drawing.Size(45, 17);
            this.checkboxXoa.TabIndex = 3;
            this.checkboxXoa.Text = "Xóa";
            this.checkboxXoa.UseVisualStyleBackColor = true;
            // 
            // checkboxSua
            // 
            this.checkboxSua.AutoSize = true;
            this.checkboxSua.Location = new System.Drawing.Point(619, 357);
            this.checkboxSua.Name = "checkboxSua";
            this.checkboxSua.Size = new System.Drawing.Size(45, 17);
            this.checkboxSua.TabIndex = 4;
            this.checkboxSua.Text = "Sửa";
            this.checkboxSua.UseVisualStyleBackColor = true;
            // 
            // checkboxThem
            // 
            this.checkboxThem.AutoSize = true;
            this.checkboxThem.Location = new System.Drawing.Point(356, 357);
            this.checkboxThem.Name = "checkboxThem";
            this.checkboxThem.Size = new System.Drawing.Size(53, 17);
            this.checkboxThem.TabIndex = 5;
            this.checkboxThem.Text = "Thêm";
            this.checkboxThem.UseVisualStyleBackColor = true;
            // 
            // dataChucNang
            // 
            this.dataChucNang.AllowUserToAddRows = false;
            this.dataChucNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChucNang.Location = new System.Drawing.Point(505, 16);
            this.dataChucNang.Name = "dataChucNang";
            this.dataChucNang.RowHeadersVisible = false;
            this.dataChucNang.Size = new System.Drawing.Size(477, 240);
            this.dataChucNang.TabIndex = 6;
            this.dataChucNang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChucNang_CellClick);
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.Location = new System.Drawing.Point(138, 347);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(0, 18);
            this.lbChucVu.TabIndex = 7;
            // 
            // lbChucNang
            // 
            this.lbChucNang.AutoSize = true;
            this.lbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucNang.Location = new System.Drawing.Point(138, 391);
            this.lbChucNang.Name = "lbChucNang";
            this.lbChucNang.Size = new System.Drawing.Size(0, 18);
            this.lbChucNang.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thay đổi quyền hạn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chức Năng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chức Vụ";
            // 
            // userControl_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbChucNang);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.dataChucNang);
            this.Controls.Add(this.checkboxThem);
            this.Controls.Add(this.checkboxSua);
            this.Controls.Add(this.checkboxXoa);
            this.Controls.Add(this.checkboxXem);
            this.Controls.Add(this.dataChucVu);
            this.Name = "userControl_PhanQuyen";
            this.Size = new System.Drawing.Size(982, 541);
            this.Load += new System.EventHandler(this.userControl_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataChucNang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataChucVu;
        private System.Windows.Forms.CheckBox checkboxXem;
        private System.Windows.Forms.CheckBox checkboxXoa;
        private System.Windows.Forms.CheckBox checkboxSua;
        private System.Windows.Forms.CheckBox checkboxThem;
        private System.Windows.Forms.DataGridView dataChucNang;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbChucNang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
