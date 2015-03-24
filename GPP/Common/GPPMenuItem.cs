using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPP
{
    public partial class GPPMenuItem : UserControl
    {
        private bool _isMouseMove = false;
        private bool _isMouseDown = false;
        private Bitmap _releaseImage = Properties.Resources.setting_icon;
        private Bitmap _pressImage = Properties.Resources.setting_icon_mouse_move;
        private Color _releaseColor = Color.Gray;
        private Color _pressColor = Color.DarkGray;
        private Color _mouseClickColor = Color.Moccasin;

        public GPPMenuItem()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public Color ReleaseColor
        {
            get
            {
                return _releaseColor;
            }
            set
            {
                _releaseColor = value;
                Invalidate();
            }
        }

        public Color PressColor
        {
            get
            {
                return _pressColor;
            }
            set
            {
                _pressColor = value;
            }
        }

        public Bitmap ReleaseImage
        {
            get
            {
                return _releaseImage;
            }
            set
            {
                _releaseImage = value;
                Invalidate();
            }
        }

        public Bitmap PressImage
        {
            get
            {
                return _pressImage;
            }
            set
            {
                _pressImage = value;
            }
        }

        public string TextDisplay
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            _isMouseMove = true;
            Invalidate();
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            _isMouseMove = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            SolidBrush brush = new SolidBrush(Color.White);

            if (_isMouseDown)
            {
                this.BackColor = _mouseClickColor;
            }
            else
            {
                if (_isMouseMove)
                {
                    this.BackColor = _pressColor;
                }
                else
                {
                    this.BackColor = _releaseColor;
                }
            }
            if (_isMouseMove)
            {
                g.DrawImage(_pressImage, 9, 8);
            }
            else
            {
                g.DrawImage(_releaseImage, 9, 8);
            }
            g.DrawString(this.Text, this.Font, brush, 45, 15);

            brush.Dispose();
            base.OnPaint(e);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            Invalidate();
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
            Invalidate();
        }
    }
}
