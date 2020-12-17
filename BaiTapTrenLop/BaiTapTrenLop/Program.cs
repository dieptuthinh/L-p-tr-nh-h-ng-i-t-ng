/*using System;
using System.Security.Cryptography.X509Certificates;

namespace BaiTapTrenLop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            Console.WriteLine("Nhap so phan tu cua mang");
            byte n = Convert.ToByte(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("A[{0}]:", i);
                A[i] = Convert.ToInt16(Console.ReadLine());
            }

            int tong = 0;
            //foreach (int x in A)
            //tong += x;
            for (int i = 0; i < A.Length; i++)
            {
                tong += A[i];
            }
            Console.WriteLine("Tong mang:{0}", tong);
            Console.ReadLine();
        }
    }
}
*/