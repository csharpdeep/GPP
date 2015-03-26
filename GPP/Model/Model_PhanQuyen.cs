using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPP.Model
{
    class Model_PhanQuyen
    {
        private String _maPhanQuyen,
                       _maChucVu,
                       _maChucNang;

        public String MaChucNang
        {
            get { return _maChucNang; }
            set { _maChucNang = value; }
        }

        public String MaChucVu
        {
            get { return _maChucVu; }
            set { _maChucVu = value; }
        }

        public String MaPhanQuyen
        {
            get { return _maPhanQuyen; }
            set { _maPhanQuyen = value; }
        }
        private int _xem,
                    _them,
                    _sua,
                    _xoa;

        public int Xoa
        {
            get { return _xoa; }
            set { _xoa = value; }
        }

        public int Sua
        {
            get { return _sua; }
            set { _sua = value; }
        }

        public int Them
        {
            get { return _them; }
            set { _them = value; }
        }

        public int Xem
        {
            get { return _xem; }
            set { _xem = value; }
        }
    }
}
