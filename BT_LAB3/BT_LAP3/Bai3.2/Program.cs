using System;
using System.Text;

namespace Bai3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //Học phần---------------------------------------------
            HocPhan hp = new HocPhan();
            HoaDon hd = new HoaDon();
            hd.Nhapten();
            HocPhan[] ds = new HocPhan[50];
            Console.WriteLine("******* Các học phần trong danh sách đăng kí ********");        
            hd.NhapHoadon_hp();
            hd.xuat();
            Console.WriteLine("Số tín chỉ thực hành của sinh viên: " + hd.Tinh_TH());
        }
    }
}
