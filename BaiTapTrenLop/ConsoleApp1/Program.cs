using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string id, name;
            byte birthday;
            bool male;
            //Nhap du lieu
            Console.Write("Nhap mssv: ");
            id = Console.ReadLine();
            Console.Write("Ho ten sv: ");
            name = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            birthday = Convert.ToByte(Console.ReadLine());
            Console.Write("gioi tinh (true|false):");
            male = Convert.ToBoolean(Console.ReadLine());
        }
        static void Bt1_2a()
        {
            short year;
            Console.Write("Nhap nam:  ");
            while (Int16.TryParse(Console.ReadLine(), out year) == false || year < 0)
            {
                Console.WriteLine("Nhap lai di cdmm!!!");
            }
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("{0} la nam nhuan.", year);
            else
                Console.WriteLine("{0} khong la nam nhuan.");
        }
        static void Bt1_2b()
        {
            //khai bao bien
            float a, b;
            //Nhap 
            Console.WriteLine("XU LI BAI TOAN PHUONG TRINH BAC NHAT: ax + b = 0  (AHIHI DO NGOC! ❤)");
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
                Console.WriteLine("Nghiem cua PT x= ", x.ToString("0.00"));
            }
        }
        static void Bt1_2c()
        {
            //Khai baoo
            float a, b, c;
            //Xu li
            Console.WriteLine("XU LI BAI TOAN PHUONG TRINH BAC HAI: ax^2 + bx + c = 0  (AHIHI DO NGOC! ❤)");
            Console.Write("Nhap co so a= ");
            while (Single.TryParse(Console.ReadLine(), out a) == false)
                Console.Write("Nhap lai co so a= ");
            Console.Write("Nhap co so b= ");
            while (Single.TryParse(Console.ReadLine(), out b) == false)
                Console.Write("Nhap lai co so b= ");
            Console.Write("Nhap co so c= ");
            while (Single.TryParse(Console.ReadLine(), out c) == false)
                Console.Write("Nhap lai co so c= ");
            if (a == 0)
            {
                Console.WriteLine("PT chuyen sang PT Bac nhat!");
                Bt1_2b();
            }
        }
    }
}
