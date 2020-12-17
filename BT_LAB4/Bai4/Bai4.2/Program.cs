using System;

namespace Bai4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thong tin sinh vien bang cach 1:\n");
            Student td = new Student();
            Console.WriteLine("SV 1: ");
            //td.Set();
            td.Get();

            Console.WriteLine("\n---------------------------");
            Console.WriteLine("\n\nThong tin sinh vien bang cach 2:\n");
            Student td1 = new Student();
            Console.WriteLine("SV 2: ");
            //td.Set();
            td1.Set();
            td1.Get();


            Console.ReadKey();
        }
    }
}
