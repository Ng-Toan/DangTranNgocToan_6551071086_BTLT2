namespace QuanLySachCoBan
{
    class Sach
    {
        private string _maSach;
        private string _tenSach;
        private string _tacGia;
        private int _namXuatBan;
        private double _giaBan;

        public Sach(string maSach, string tenSach, string tacGia, int namXuatBan, double giaBan)
        {
            _maSach = maSach;
            _tenSach = tenSach;
            _tacGia = tacGia;
            _namXuatBan = namXuatBan;
            _giaBan = giaBan;
        }

        public Sach()
        {
            _maSach = "T001";
            _tenSach = "Lap trinh C#";
            _tacGia = "Nguyen Van A";
            _namXuatBan = 2020;
            _giaBan = 100000;
        }
        
        public string MaSach {
            get { return _maSach; }
        }

        public string TenSach
        {
            get { return _tenSach; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tên sách không được để trống.");
                }
                _tenSach = value;
            }
        }

        public int NamXuatBan
        {
            get { return _namXuatBan; }
            set
            {
                if (value < 1990 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Năm xuất bản không hợp lệ.");
                }
                _namXuatBan = value;
            }
        }

        public double GiaBan
        {
            get { return _giaBan; }
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Mã sách: {_maSach}");
            Console.WriteLine($"Tên sách: {_tenSach}");
            Console.WriteLine($"Tác giả: {_tacGia}");
            Console.WriteLine($"Năm xuất bản: {_namXuatBan}");
            Console.WriteLine($"Giá bán: {_giaBan}");
        }
        public override string ToString()
        {
            return $"Mã sách: {_maSach}, Tên sách: {_tenSach}, Tác giả: {_tacGia}, Năm xuất bản: {_namXuatBan}, Giá bán: {_giaBan}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSSV : 6551071086");
            //Contructor day du
            Sach sach1 = new Sach("T001", "Lap trinh C#", "Nguyen Van A", 2020, 100000);

            //Contructor mac dinh gan property
            Sach sach2 = new Sach();
            sach2.TenSach = "Lap trinh Java";
            sach2.NamXuatBan = 2021;

            //Dung object initializer
            Sach sach3 = new Sach
            {
                TenSach = "Lap trinh Python",
                NamXuatBan = 2022
            };

            //Hien thi thong tin sach
            Console.WriteLine("Thong tin sach 1:");
            sach1.HienThiThongTin();

            Console.WriteLine("Thong tin sach 2:");
            sach2.HienThiThongTin();

            Console.WriteLine("Thong tin sach 3:");
            sach3.HienThiThongTin();

            //Thu gan gia tri khong hop le
            try
            {
                sach2.NamXuatBan = 1700;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }
}
