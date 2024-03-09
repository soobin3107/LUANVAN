using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUANVAN
{
    public class LuanVan
    {
        public string MaLuanVan { get; set; }
        public string TenLuanVan { get; set; }
        public string HoTenSV {  get; set; }
        public string HoTenGV { get; set; }
        public int NamThucHien { get; set; }
    }

    public class NhapXuatLuanVan
    {
        public static void NhapLV(ref LuanVan lv)
        {
            Console.Write("Nhập Mã Luận Văn: ");
            lv.MaLuanVan = Console.ReadLine();

            Console.Write("Nhập Tên Luận Văn: ");
            lv.TenLuanVan = Console.ReadLine();

            Console.Write("Nhập Họ Tên Sinh Viên: ");
            lv.HoTenSV = Console.ReadLine();

            Console.Write("Nhập Họ Tên Giảng Viên: ");
            lv.HoTenGV = Console.ReadLine();

            Console.Write("Nhập Năm Thực Hiện: ");
            lv.NamThucHien = int.Parse(Console.ReadLine());
        }

        public static void XuatLV(LuanVan lv)
        {
            Console.WriteLine($"Mã Luận Văn: {lv.MaLuanVan}");
            Console.WriteLine($"Tên Luận Văn: {lv.TenLuanVan}");
            Console.WriteLine($"Họ Tên Sinh Viên: {lv.HoTenSV}");
            Console.WriteLine($"Họ Tên Giảng Viên: {lv.HoTenGV}");
            Console.WriteLine($"Năm Thực Hiện: {lv.NamThucHien}");
        }

        public class Program
        {
            const int N = 100;

            public static void Main()
            {
                Console.OutputEncoding = Encoding.UTF8;
                LuanVan[] lv = new LuanVan[N];
                int n = 0;
                NhapDSLV(lv, ref n);
                XuatDSLV(lv, n);
                Console.ReadLine();
            }

            static void NhapDSLV(LuanVan[] lv, ref int n)
            {
                Console.Write("Nhập số lượng Luận Văn: ");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    lv[i] = new LuanVan();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine($"---Thí Sinh thứ {i + 1}---");
                    NhapXuatLuanVan.NhapLV(ref lv[i]);
                }
            }

            static void XuatDSLV(LuanVan[] lv, int n)
            {
                Console.WriteLine("\n=-=DANH SÁCH CÁC LUẬN VĂN=-=");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"---Thí Sinh thứ {i + 1}---");
                    NhapXuatLuanVan.XuatLV(lv[i]);
                    Console.WriteLine("---------------------------");
                }
            }
        }
    }
}
