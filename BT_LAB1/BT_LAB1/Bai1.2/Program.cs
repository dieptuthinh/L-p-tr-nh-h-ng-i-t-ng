using System;

namespace Bai1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            short year;
            Console.Write("Nhap nam:  ");
            while (Int16.TryParse(Console.ReadLine(), out year) == false || year < 0)
            {
                Console.WriteLine("Xin vui long nhap lai!");
            }
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("{0} la nam nhuan.", year);
            else
                Console.WriteLine("{0} khong la nam nhuan.",year);
        }
    }
}
