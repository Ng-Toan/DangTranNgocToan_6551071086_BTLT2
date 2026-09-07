namespace TinhLuongNhanVien
{
    class NhanVien
    {
        private string _maNV;
        private string _hoTen;
        private decimal _luongCoBan;
        private int _soNgayLam;
        private int _soNgayNghiPhep;

        public NhanVien()
        {
            _maNV = "T001";
            _hoTen = "Nguyen Van A";
            _luongCoBan = 5000000;
            _soNgayLam = 22;
            _soNgayNghiPhep = 2;
        }

        public NhanVien(string maNV, string hoTen)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            _luongCoBan = 5000000;
            _soNgayLam = 22;
            _soNgayNghiPhep = 2;
        }

        public NhanVien(string maNV, string hoTen, decimal luongCoBan, int soNgayLam, int soNgayNghiPhep)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            _luongCoBan = luongCoBan;
            _soNgayLam = soNgayLam;
            _soNgayNghiPhep = soNgayNghiPhep;
        }

        public NhanVien(string maNV, string hoTen, decimal luongCoBan = 5000000, int soNgayLam = 26)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            _luongCoBan = luongCoBan;
            _soNgayLam = soNgayLam;
            _soNgayNghiPhep = 0;
        }

        public string HoTen
        {
            get { return _hoTen; }
        }
        public decimal LuongCoBan
        {
            get { return _luongCoBan; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Luong co ban phai lon hon hoac bang 0");
                }
                _luongCoBan = value;
            }
        }
        public int soNgayLam
        {
            get { return _soNgayLam; }
            set
            {
                if (value < 0 || value > 31)
                {
                    throw new ArgumentException("So ngay lam phai lon hon hoac bang 0 va nho hon hoac bang 31");
                }
                _soNgayLam = value;
            }
        }

        public decimal LuongThucNhan()
        {
            decimal luongThucNhan = _luongCoBan / 26 * _soNgayLam - _luongCoBan * 0.08m;
            return luongThucNhan;
        }

        public decimal tinhThuong()
        {
            return 0;
        }
        public decimal tinhThuong(decimal heSo)
        {
            return _luongCoBan * heSo;
        }

        public decimal tinhThuong(decimal heSo, bool coPhucLoi)
        {
            decimal thuong = _luongCoBan * heSo;
            if (coPhucLoi)
            {
                thuong += 500000; ;
            }
            return thuong;
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv1 = new NhanVien();

            NhanVien nv2 = new NhanVien(maNV: "T002", hoTen: "Tran Van B",soNgayLam: 20);

            NhanVien nv3 = new NhanVien("T003", "Le Thi C", 6000000, 25, 1);

            Console.WriteLine("===== NHAN VIEN 1 =====");
            Console.WriteLine("Thuong 1: " + nv1.tinhThuong());
            Console.WriteLine("Thuong 2: " + nv1.tinhThuong(0.5m));
            Console.WriteLine("Thuong 3: " + nv1.tinhThuong(0.5m, true));

            Console.WriteLine("\n===== NHAN VIEN 2 =====");
            Console.WriteLine("Thuong 1: " + nv2.tinhThuong());
            Console.WriteLine("Thuong 2: " + nv2.tinhThuong(0.5m));
            Console.WriteLine("Thuong 3: " + nv2.tinhThuong(0.5m, true));

            Console.WriteLine("\n===== NHAN VIEN 3 =====");
            Console.WriteLine("Thuong 1: " + nv3.tinhThuong());
            Console.WriteLine("Thuong 2: " + nv3.tinhThuong(0.5m));
            Console.WriteLine("Thuong 3: " + nv3.tinhThuong(0.5m, true));
        }
    }
}
