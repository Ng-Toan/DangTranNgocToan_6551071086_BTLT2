using System;
using System.Collections.Generic;

namespace QuanLySanPhamCuaHang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSSV : 6551071086");
            List<SanPham> danhSach = new List<SanPham>
            {
                new SanPham
                (
                    "SP001",
                    "But bi",
                    5000,
                    100
                ),

                new SanPhamThucPham
                (
                    "TP001",
                    "Sua tuoi",
                    30000,
                    50,
                    DateTime.Now.AddDays(2),
                    5
                ),

                new SanPhamThucPham
                (
                    "TP002",
                    "Banh quy",
                    45000,
                    30,
                    DateTime.Now.AddDays(20),
                    25
                ),

                new SanPhamDienTu
                (
                    "DT001",
                    "Tai nghe",
                    500000,
                    20,
                    24,
                    "Sony"
                ),

                new SanPhamDienTu
                (
                    "DT002",
                    "Chuot may tinh",
                    300000,
                    15,
                    12,
                    "Logitech"
                )
            };

            decimal tongGiaTriKho = 0;

            Console.WriteLine("DANH SACH SAN PHAM");
            Console.WriteLine();

            foreach (SanPham sp in danhSach)
            {
                decimal giaBan = sp.TinhGiaBan();

                Console.WriteLine(sp.MoTa());
                Console.WriteLine("Gia ban: " + giaBan);
                Console.WriteLine();

                tongGiaTriKho += sp.Gia * sp.SoLuongTon;
            }

            Console.WriteLine("TONG GIA TRI KHO HANG: " + tongGiaTriKho);

            Console.ReadKey();
            Console.ReadLine();
        }
    }
}