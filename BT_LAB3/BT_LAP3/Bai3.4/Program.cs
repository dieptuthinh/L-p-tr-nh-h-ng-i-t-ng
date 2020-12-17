using System;
using System.Text;

namespace Bai3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //Phòng kí túc xá--------------------
            Phong p = new Phong();
            Console.WriteLine("\n\t******* Hóa đơn phòng kí túc *******");
            p.NhapThongtin();
            Console.WriteLine("\n\t****** Thông tin hóa đơn đại gia ******");
            p.Xuat();
            Console.WriteLine("\nTổng tiền phòng: " + p.TongTienPhong());
            Console.WriteLine("\nTrung bình mỗi người phải trả: " + p.TrungBinhPhaitra());
            p.GiaPhong();
            Console.ReadKey();
        }
    }
}
