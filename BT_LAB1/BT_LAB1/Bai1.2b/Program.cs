using System;

namespace Bai1._2b
{
    class Program
    {
        static void Main(string[] args)
        {

            /*          Console.WriteLine("Nhập vào a: ");
                        float a = float.Parse(Console.ReadLine());*/
            //khai bao bien
            float a, b;
            //Nhap 
            Console.WriteLine("XU LI BAI TOAN PHUONG TRINH BAC NHAT: ax + b = 0 ");
            Console.Write("Nhap co so a= ");
            while (Single.TryParse(Console.ReadLine(), out a) == false)
                Console.Write("Nhap lai co so a= ");
            Console.Write("Nhap co so b= ");
            while (Single.TryParse(Console.ReadLine(), out b) == false)
                Console.Write("Nhap lai co so b= ");
            //Xu li ne
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Phuong trinh co VSN!");
                else
                    Console.WriteLine("Phuong trinh VN!");
            else
            {
                float x = -b / a;
                Console.WriteLine("Nghiem cua PT x= {0}", x.ToString("0.00"));
            }
        }
    }
}
