using System;

namespace QuanLySanPhamCuaHang
{
    class SanPham
    {
        private string _maSP;
        private string _tenSP;
        private decimal _gia;
        private int _soLuongTon;

        public string MaSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        public string TenSP
        {
            get { return _tenSP; }
            set { _tenSP = value; }
        }

        public decimal Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set { _soLuongTon = value; }
        }

        public SanPham(string maSP, string tenSP, decimal gia, int soLuongTon)
        {
            _maSP = maSP;
            _tenSP = tenSP;
            _gia = gia;
            _soLuongTon = soLuongTon;
        }

        public virtual decimal TinhGiaBan()
        {
            return _gia;
        }

        public virtual string MoTa()
        {
            return "Ma SP: " + _maSP +
                   ", Ten SP: " + _tenSP +
                   ", Gia: " + _gia +
                   ", So luong ton: " + _soLuongTon;
        }
    }

    class SanPhamThucPham : SanPham
    {
        private DateTime _ngayHetHan;
        private int _nhietDoBAoquan;

        public DateTime NgayHetHan
        {
            get { return _ngayHetHan; }
            set { _ngayHetHan = value; }
        }

        public int NhietDoBaoQuan
        {
            get { return _nhietDoBAoquan; }
            set { _nhietDoBAoquan = value; }
        }

        public SanPhamThucPham(
            string maSP,
            string tenSP,
            decimal gia,
            int soLuongTon,
            DateTime ngayHetHan,
            int nhietDoBaoQuan
        ) : base(maSP, tenSP, gia, soLuongTon)
        {
            _ngayHetHan = ngayHetHan;
            _nhietDoBAoquan = nhietDoBaoQuan;
        }

        public override decimal TinhGiaBan()
        {
            double soNgayConLai = (_ngayHetHan - DateTime.Now).TotalDays;

            if (soNgayConLai <= 3 && soNgayConLai >= 0)
            {
                return Gia * 0.7m;
            }

            return Gia;
        }

        public override string MoTa()
        {
            return base.MoTa() +
                   ", Ngay het han: " + _ngayHetHan.ToString("dd/MM/yyyy") +
                   ", Nhiet do bao quan: " + _nhietDoBAoquan + " do C";
        }
    }

    class SanPhamDienTu : SanPham
    {
        private int _baoHanhThang;
        private string _hangSanXuat;

        public int BaoHanhThang
        {
            get { return _baoHanhThang; }
            set { _baoHanhThang = value; }
        }

        public string HangSanXuat
        {
            get { return _hangSanXuat; }
            set { _hangSanXuat = value; }
        }

        public SanPhamDienTu(
            string maSP,
            string tenSP,
            decimal gia,
            int soLuongTon,
            int baoHanhThang,
            string hangSanXuat
        ) : base(maSP, tenSP, gia, soLuongTon)
        {
            _baoHanhThang = baoHanhThang;
            _hangSanXuat = hangSanXuat;
        }

        public override decimal TinhGiaBan()
        {
            if (_baoHanhThang > 12)
            {
                return Gia * 1.1m;
            }

            return Gia;
        }

        public override string MoTa()
        {
            return base.MoTa() +
                   ", Bao hanh: " + _baoHanhThang + " thang" +
                   ", Hang san xuat: " + _hangSanXuat;
        }
    }
}