using System;
using System.Text;

namespace Bai2._1
{
    class XuLy
    {
        private float a, b;

        public void nhap()
        {

            while (true)
            {
                try
                {
                    Console.Write("Nhap a: ");
                    a = float.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("PT vo nghiem");
                    }
                    else break;
                }
                catch
                {
                    Console.WriteLine("Kieu du lieu khong hop le. xin nhap lai");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhap b: ");
                    b = float.Parse(Console.ReadLine());
                    if (b == 0)
                    {
                        Console.WriteLine("PT vo so nghiem");
                    }
                    else break;
                }
                catch
                {
                    Console.WriteLine("Kieu du lieu khong hop le. xin nhap lai");
                }
            }
        }
        public void kq()
        {
            float x = -b / a;
            Console.WriteLine("{0}x + {1} = 0 \n=> x = {2}", a, b, x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            XuLy b1 = new XuLy();
            b1.nhap();
            b1.kq();
            Console.ReadKey();
        }
    }
}
