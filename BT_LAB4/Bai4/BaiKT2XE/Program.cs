using System;
using System.Text;

namespace BaiKT2XE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            DanhSachXe dsXe = new DanhSachXe();
            dsXe.Nhap();
            dsXe.In();

            Console.Write("Xe thấp giá nhất: ");
            dsXe.GiaThapNhat().Xuat();
            Console.Write("Xe cao giá nhất: ");
            dsXe.GiaCaoNhat().Xuat();

            Console.Write("Nhập biển số xe cần tìm: ");
            String tim = Console.ReadLine();
            dsXe.Tim(tim);



            Console.WriteLine("\n\t\t**************Danh sách SAU XẮP XẾP THEO NAM****************");
            dsXe.SapXep();
            dsXe.In();

            Console.Write("Nhập biển số xe cần xoá: ");
            String xoa = Console.ReadLine();
            dsXe.Xoa(xoa);
            Console.ReadKey();
        }
    }
}
