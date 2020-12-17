using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai1._5a
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap so bat dau: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ket thuc: ");
            b = int.Parse(Console.ReadLine());
            IEnumerable<int> squares = Enumerable.Range(a,b-a+1);

            foreach (int num in squares)
            {
                if (XulySHH(num) == 1)
                {
                    Console.Write("\n"+num+" la so hoan hao.");
                }
            }
            Console.ReadKey();
        }
        private static int XulySHH(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    //Console.Write("{0}  ", i);
                }
            }
            //Console.Write("\nTong cua cac uoc so: {0}", sum);
            if (sum == n)
                //Console.Write("\nSo da cho la so hoan hao.");
                return 1;
            else
                //Console.Write("\nSo da cho khong phai la so hoan hao.");
                return 0;

        }
    }
}
