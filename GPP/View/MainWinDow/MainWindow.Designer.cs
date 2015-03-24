namespace GPP
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this._panelTop = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._panelLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._panelMain = new System.Windows.Forms.Panel();
            this._panelBottom = new System.Windows.Forms.Panel();
            this.gppMenuItem10 = new GPP.GPPMenuItem();
            this.gppMenuItem9 = new GPP.GPPMenuItem();
            this.gppMenuItem8 = new GPP.GPPMenuItem();
            this.gppMenuItem7 = new GPP.GPPMenuItem();
            this.gppMenuItem6 = new GPP.GPPMenuItem();
            this.gppMenuItem5 = new GPP.GPPMenuItem();
            this.gppMenuItem4 = new GPP.GPPMenuItem();
            this.gppMenuItem3 = new GPP.GPPMenuItem();
            this.gppMenuItem2 = new GPP.GPPMenuItem();
            this.gppMenuItem1 = new GPP.GPPMenuItem();
            this._panelTop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this._panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelTop
            // 
            this._panelTop.BackColor = System.Drawing.Color.Teal;
            this._panelTop.Controls.Add(this.menuStrip1);
            this._panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelTop.Location = new System.Drawing.Point(0, 0);
            this._panelTop.Name = "_panelTop";
            this._panelTop.Size = new System.Drawing.Size(1148, 29);
            this._panelTop.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.bảoCáoToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // bảoCáoToolStripMenuItem
            // 
            this.bảoCáoToolStripMenuItem.Name = "bảoCáoToolStripMenuItem";
            this.bảoCáoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.bảoCáoToolStripMenuItem.Text = "Bảo cáo";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // _panelLeft
            // 
            this._panelLeft.BackColor = System.Drawing.Color.DarkGray;
            this._panelLeft.Controls.Add(this.gppMenuItem10);
            this._panelLeft.Controls.Add(this.gppMenuItem9);
            this._panelLeft.Controls.Add(this.gppMenuItem8);
            this._panelLeft.Controls.Add(this.gppMenuItem7);
            this._panelLeft.Controls.Add(this.gppMenuItem6);
            this._panelLeft.Controls.Add(this.gppMenuItem5);
            this._panelLeft.Controls.Add(this.gppMenuItem4);
            this._panelLeft.Controls.Add(this.gppMenuItem3);
            this._panelLeft.Controls.Add(this.gppMenuItem2);
            this._panelLeft.Controls.Add(this.gppMenuItem1);
            this._panelLeft.Controls.Add(this.label1);
            this._panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this._panelLeft.Location = new System.Drawing.Point(0, 29);
            this._panelLeft.Name = "_panelLeft";
            this._panelLeft.Size = new System.Drawing.Size(170, 458);
            this._panelLeft.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chức năng chính";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _panelMain
            // 
            this._panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelMain.Location = new System.Drawing.Point(170, 29);
            this._panelMain.Name = "_panelMain";
            this._panelMain.Size = new System.Drawing.Size(978, 458);
            this._panelMain.TabIndex = 5;
            // 
            // _panelBottom
            // 
            this._panelBottom.BackColor = System.Drawing.Color.Olive;
            this._panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBottom.Location = new System.Drawing.Point(0, 487);
            this._panelBottom.Name = "_panelBottom";
            this._panelBottom.Size = new System.Drawing.Size(1148, 23);
            this._panelBottom.TabIndex = 3;
            // 
            // gppMenuItem10
            // 
            this.gppMenuItem10.BackColor = System.Drawing.Color.Gray;
            this.gppMenuItem10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gppMenuItem10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gppMenuItem10.Dock = System.Windows.Forms.DockStyle.Top;
            this.gppMenuItem10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gppMenuItem10.Location = new System.Drawing.Point(0, 457);
            this.gppMenuItem10.Margin = new System.Windows.Forms.Padding(4);
            this.gppMenuItem10.Name = "gppMenuItem10";
            this.gppMenuItem10.PressColor = System.Drawing.Color.DarkGray;
            this.gppMenuItem10.PressImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem10.PressImage")));
            this.gppMenuItem10.ReleaseColor = System.Drawing.Color.Gray;
            this.gppMenuItem10.ReleaseImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem10.ReleaseImage")));
            this.gppMenuItem10.Size = new System.Drawing.Size(170, 48);
            this.gppMenuItem10.TabIndex = 10;
            this.gppMenuItem10.TextDisplay = "MenuItem 1";
            this.gppMenuItem10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gppMenuItem1_MouseClick);
            // 
            // gppMenuItem9
            // 
            this.gppMenuItem9.BackColor = System.Drawing.Color.Gray;
            this.gppMenuItem9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gppMenuItem9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gppMenuItem9.Dock = System.Windows.Forms.DockStyle.Top;
            this.gppMenuItem9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gppMenuItem9.Location = new System.Drawing.Point(0, 409);
            this.gppMenuItem9.Margin = new System.Windows.Forms.Padding(4);
            this.gppMenuItem9.Name = "gppMenuItem9";
            this.gppMenuItem9.PressColor = System.Drawing.Color.DarkGray;
            this.gppMenuItem9.PressImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem9.PressImage")));
            this.gppMenuItem9.ReleaseColor = System.Drawing.Color.Gray;
            this.gppMenuItem9.ReleaseImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem9.ReleaseImage")));
            this.gppMenuItem9.Size = new System.Drawing.Size(170, 48);
            this.gppMenuItem9.TabIndex = 9;
            this.gppMenuItem9.TextDisplay = "MenuItem 1";
            this.gppMenuItem9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gppMenuItem1_MouseClick);
            // 
            // gppMenuItem8
            // 
            this.gppMenuItem8.BackColor = System.Drawing.Color.Gray;
            this.gppMenuItem8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gppMenuItem8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gppMenuItem8.Dock = System.Windows.Forms.DockStyle.Top;
            this.gppMenuItem8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gppMenuItem8.Location = new System.Drawing.Point(0, 361);
            this.gppMenuItem8.Margin = new System.Windows.Forms.Padding(4);
            this.gppMenuItem8.Name = "gppMenuItem8";
            this.gppMenuItem8.PressColor = System.Drawing.Color.DarkGray;
            this.gppMenuItem8.PressImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem8.PressImage")));
            this.gppMenuItem8.ReleaseColor = System.Drawing.Color.Gray;
            this.gppMenuItem8.ReleaseImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem8.ReleaseImage")));
            this.gppMenuItem8.Size = new System.Drawing.Size(170, 48);
            this.gppMenuItem8.TabIndex = 8;
            this.gppMenuItem8.TextDisplay = "MenuItem 1";
            this.gppMenuItem8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gppMenuItem1_MouseClick);
            // 
            // gppMenuItem7
            // 
            this.gppMenuItem7.BackColor = System.Drawing.Color.Gray;
            this.gppMenuItem7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gppMenuItem7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gppMenuItem7.Dock = System.Windows.Forms.DockStyle.Top;
            this.gppMenuItem7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gppMenuItem7.Location = new System.Drawing.Point(0, 313);
            this.gppMenuItem7.Margin = new System.Windows.Forms.Padding(4);
            this.gppMenuItem7.Name = "gppMenuItem7";
            this.gppMenuItem7.PressColor = System.Drawing.Color.DarkGray;
            this.gppMenuItem7.PressImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem7.PressImage")));
            this.gppMenuItem7.ReleaseColor = System.Drawing.Color.Gray;
            this.gppMenuItem7.ReleaseImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem7.ReleaseImage")));
            this.gppMenuItem7.Size = new System.Drawing.Size(170, 48);
            this.gppMenuItem7.TabIndex = 7;
            this.gppMenuItem7.TextDisplay = "MenuItem 1";
            this.gppMenuItem7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gppMenuItem1_MouseClick);
            // 
            // gppMenuItem6
            // 
            this.gppMenuItem6.BackColor = System.Drawing.Color.Gray;
            this.gppMenuItem6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gppMenuItem6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gppMenuItem6.Dock = System.Windows.Forms.DockStyle.Top;
            this.gppMenuItem6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gppMenuItem6.Location = new System.Drawing.Point(0, 265);
            this.gppMenuItem6.Margin = new System.Windows.Forms.Padding(4);
            this.gppMenuItem6.Name = "gppMenuItem6";
            this.gppMenuItem6.PressColor = System.Drawing.Color.DarkGray;
            this.gppMenuItem6.PressImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem6.PressImage")));
            this.gppMenuItem6.ReleaseColor = System.Drawing.Color.Gray;
            this.gppMenuItem6.ReleaseImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem6.ReleaseImage")));
            this.gppMenuItem6.Size = new System.Drawing.Size(170, 48);
            this.gppMenuItem6.TabIndex = 6;
            this.gppMenuItem6.TextDisplay = "MenuItem 1";
            this.gppMenuItem6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gppMenuItem1_MouseClick);
            // 
            // gppMenuItem5
            // 
            this.gppMenuItem5.BackColor = System.Drawing.Color.Gray;
            this.gppMenuItem5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gppMenuItem5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gppMenuItem5.Dock = System.Windows.Forms.DockStyle.Top;
            this.gppMenuItem5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gppMenuItem5.Location = new System.Drawing.Point(0, 217);
            this.gppMenuItem5.Margin = new System.Windows.Forms.Padding(4);
            this.gppMenuItem5.Name = "gppMenuItem5";
            this.gppMenuItem5.PressColor = System.Drawing.Color.DarkGray;
            this.gppMenuItem5.PressImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem5.PressImage")));
            this.gppMenuItem5.ReleaseColor = System.Drawing.Color.Gray;
            this.gppMenuItem5.ReleaseImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem5.ReleaseImage")));
            this.gppMenuItem5.Size = new System.Drawing.Size(170, 48);
            this.gppMenuItem5.TabIndex = 5;
            this.gppMenuItem5.TextDisplay = "MenuItem 1";
            this.gppMenuItem5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gppMenuItem1_MouseClick);
            // 
            // gppMenuItem4
            // 
            this.gppMenuItem4.BackColor = System.Drawing.Color.Gray;
            this.gppMenuItem4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gppMenuItem4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gppMenuItem4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gppMenuItem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gppMenuItem4.Location = new System.Drawing.Point(0, 169);
            this.gppMenuItem4.Margin = new System.Windows.Forms.Padding(4);
            this.gppMenuItem4.Name = "gppMenuItem4";
            this.gppMenuItem4.PressColor = System.Drawing.Color.DarkGray;
            this.gppMenuItem4.PressImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem4.PressImage")));
            this.gppMenuItem4.ReleaseColor = System.Drawing.Color.Gray;
            this.gppMenuItem4.ReleaseImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem4.ReleaseImage")));
            this.gppMenuItem4.Size = new System.Drawing.Size(170, 48);
            this.gppMenuItem4.TabIndex = 4;
            this.gppMenuItem4.TextDisplay = "MenuItem 1";
            this.gppMenuItem4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gppMenuItem1_MouseClick);
            // 
            // gppMenuItem3
            // 
            this.gppMenuItem3.BackColor = System.Drawing.Color.Gray;
            this.gppMenuItem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gppMenuItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gppMenuItem3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gppMenuItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gppMenuItem3.Location = new System.Drawing.Point(0, 121);
            this.gppMenuItem3.Margin = new System.Windows.Forms.Padding(4);
            this.gppMenuItem3.Name = "gppMenuItem3";
            this.gppMenuItem3.PressColor = System.Drawing.Color.DarkGray;
            this.gppMenuItem3.PressImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem3.PressImage")));
            this.gppMenuItem3.ReleaseColor = System.Drawing.Color.Gray;
            this.gppMenuItem3.ReleaseImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem3.ReleaseImage")));
            this.gppMenuItem3.Size = new System.Drawing.Size(170, 48);
            this.gppMenuItem3.TabIndex = 3;
            this.gppMenuItem3.TextDisplay = "MenuItem 1";
            this.gppMenuItem3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gppMenuItem1_MouseClick);
            // 
            // gppMenuItem2
            // 
            this.gppMenuItem2.BackColor = System.Drawing.Color.Gray;
            this.gppMenuItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gppMenuItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gppMenuItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gppMenuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gppMenuItem2.Location = new System.Drawing.Point(0, 73);
            this.gppMenuItem2.Margin = new System.Windows.Forms.Padding(4);
            this.gppMenuItem2.Name = "gppMenuItem2";
            this.gppMenuItem2.PressColor = System.Drawing.Color.DarkGray;
            this.gppMenuItem2.PressImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem2.PressImage")));
            this.gppMenuItem2.ReleaseColor = System.Drawing.Color.Gray;
            this.gppMenuItem2.ReleaseImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem2.ReleaseImage")));
            this.gppMenuItem2.Size = new System.Drawing.Size(170, 48);
            this.gppMenuItem2.TabIndex = 2;
            this.gppMenuItem2.TextDisplay = "MenuItem 1";
            this.gppMenuItem2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gppMenuItem1_MouseClick);
            // 
            // gppMenuItem1
            // 
            this.gppMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.gppMenuItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gppMenuItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gppMenuItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gppMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gppMenuItem1.Location = new System.Drawing.Point(0, 25);
            this.gppMenuItem1.Margin = new System.Windows.Forms.Padding(4);
            this.gppMenuItem1.Name = "gppMenuItem1";
            this.gppMenuItem1.PressColor = System.Drawing.Color.DarkGray;
            this.gppMenuItem1.PressImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem1.PressImage")));
            this.gppMenuItem1.ReleaseColor = System.Drawing.Color.Gray;
            this.gppMenuItem1.ReleaseImage = ((System.Drawing.Bitmap)(resources.GetObject("gppMenuItem1.ReleaseImage")));
            this.gppMenuItem1.Size = new System.Drawing.Size(170, 48);
            this.gppMenuItem1.TabIndex = 1;
            this.gppMenuItem1.TextDisplay = "MenuItem 1";
            this.gppMenuItem1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gppMenuItem1_MouseClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 510);
            this.Controls.Add(this._panelMain);
            this.Controls.Add(this._panelLeft);
            this.Controls.Add(this._panelBottom);
            this.Controls.Add(this._panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._panelTop.ResumeLayout(false);
            this._panelTop.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelTop;
        private System.Windows.Forms.Panel _panelLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Panel _panelMain;
        private System.Windows.Forms.Panel _panelBottom;
        private GPPMenuItem gppMenuItem10;
        private GPPMenuItem gppMenuItem9;
        private GPPMenuItem gppMenuItem8;
        private GPPMenuItem gppMenuItem7;
        private GPPMenuItem gppMenuItem6;
        private GPPMenuItem gppMenuItem5;
        private GPPMenuItem gppMenuItem4;
        private GPPMenuItem gppMenuItem3;
        private GPPMenuItem gppMenuItem2;
        private GPPMenuItem gppMenuItem1;
    }
}