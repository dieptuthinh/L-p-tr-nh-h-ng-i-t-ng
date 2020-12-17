using System;

namespace Bai2._2
{
    class XuLy
    {
        private float a, b, c;
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
                        Console.WriteLine("a phai khac 0");
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
                    break;
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
                    Console.Write("Nhap c: ");
                    c = float.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Kieu du lieu khong hop le. xin nhap lai");
                }
            }
        }
        public void delta()
        {
            float dt = (b / 2) * (b / 2) - a * c;

            Console.WriteLine("Phương trình nhập vào là:\n {0}x*x + {1}x + {2} = 0", a, b, c);

            Console.WriteLine("Delta phẩy = {0}", dt);

            if (dt < 0)
            {
                Console.WriteLine("Chương trình vô nghiệm");
            }
            else if (dt == 0)
            {
                float x = (-b / 2) / a;
                Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = {0}", x);
            }
            else
            {
                double x1 = 0;
                double x2 = 0;

                x1 = ((-b / 2) - Math.Sqrt(dt)) / a;
                x2 = ((-b / 2) + Math.Sqrt(dt)) / a;

                Console.WriteLine("Phương trình có 2 nghiệm phân biệt: ");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            XuLy b2 = new XuLy();
            b2.nhap();
            b2.delta();
            Console.ReadKey();
        }
    }
}
