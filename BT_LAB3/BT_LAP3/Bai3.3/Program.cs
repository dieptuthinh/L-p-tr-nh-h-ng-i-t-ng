using System;
using System.Text;

namespace Bai3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            PhanSo ps3 = new PhanSo();
            byte n;

            do
            {

                Console.WriteLine("\n\t****** Bảng các phép tính! ******");
                Console.WriteLine("1: Cộng");
                Console.WriteLine("2: Trừ");
                Console.WriteLine("3: Nhân");
                Console.WriteLine("4: Chia");
                Console.WriteLine("0: Để thoát");

                Console.Write("Nhập lựa của bạn: ");
                while (byte.TryParse(Console.ReadLine(), out n) == false)
                    Console.Write("Nhập sai! Nhập lại chọn");
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("\nPhân Số thứ nhất");
                            ps1.Nhapgt();
                            Console.WriteLine("Phân Số thứ hai");
                            ps2.Nhapgt();
                            Console.Write("Phép Cộng= ");
                            //ps3 = ps1.Cong(ps2);//phương thức cộng
                            ps3 = ps1 + ps2;//toán tử cộng
                            ps3.RutGon();//C1
                            //ps3 = ps3.RutGon();//C2 của cô
                            ps3.Xuat();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nPhân Số thứ nhất");
                            ps1.Nhapgt();
                            Console.WriteLine("Phân Số thứ hai");
                            ps2.Nhapgt();
                            Console.Write("Phép Trừ= ");
                            //ps3 = ps1.Tru(ps2);//phương thức trừ
                            ps3 = ps1 - ps2;//toán tử trừ
                            ps3.RutGon();//C1
                            //ps3 = ps3.RutGon();//C2 của cô
                            ps3.Xuat();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nPhân Số thứ nhất");
                            ps1.Nhapgt();
                            Console.WriteLine("Phân Số thứ hai");
                            ps2.Nhapgt();
                            Console.Write("Phép Nhân= ");
                            //ps3 = ps1.Nhan(ps2);//phương thức nhân
                            ps3 = ps1 * ps2;//toán tử nhân
                            ps3.RutGon();//C1
                            //ps3 = ps3.RutGon();//C2 của cô
                            ps3.Xuat();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nPhân Số thứ nhất");
                            ps1.Nhapgt();
                            Console.WriteLine("Phân Số thứ hai");
                            ps2.Nhapgt();
                            Console.Write("Phép Chia= ");
                            //ps3 = ps1.Chia(ps2);//phương thức chia
                            ps3 = ps1 / ps2;//toán tử chia
                            ps3.RutGon();//C1
                            //ps3 = ps3.RutGon();//C2 của cô
                            ps3.Xuat();
                            break;
                        }
                }

            } while (n != 0);
        }
    }
}
