using System;
using System.Linq;

namespace BaiKT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Console.Write("Moi ban nhap so phan tu cho mang: ");
            int n = int.Parse(Console.ReadLine());

            // Nhap du lieu cho mang
            for (int iCount = 0; iCount < n; iCount++)
            {
                Console.Write("Moi ban nhap vao gia tri cho mang thu {0} la: ", iCount);
                a[iCount] = int.Parse(Console.ReadLine());
            }

            // in mang ra man hinh
            Console.WriteLine();
            for (int iCount = 0; iCount < n; iCount++)
            {
                Console.Write("\t" + a[iCount]);
            }

            // tim max cho mang
            int iMax = int.MinValue;
            for (int iCount = 0; iCount < n; iCount++)
            {
                if (iMax < a[iCount])
                {
                    iMax = a[iCount];
                }
            }
            Console.WriteLine("\nGia tri lon nhat cua mang la: {0}", iMax);

            // tim min cho mang
            int iMin = int.MaxValue;
            for (int iCount = 0; iCount < n; iCount++)
            {
                if (iMin > a[iCount])
                {
                    iMin = a[iCount];
                }
            }
            Console.WriteLine("\nGia tri be nhat cua mang la: {0}", iMin);

            // Tim xem co bao nhieu phan tu mang gia tri MAX
            int trungMax = 0;
            for (int iCount = 0; iCount < n; iCount++)
            {
                if (a[iCount] == iMax)
                {
                    trungMax = trungMax + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Co {0} gia tri trung voi gia tri MAX", trungMax);

            // Tim xem co bao nhieu phan tu mang gia tri MIN
            int trungMin = 0;
            for (int stt = 0; stt < n; stt++)
            {
                if (a[stt] == iMin)
                {
                    trungMin = trungMin + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Co {0} gia tri trung voi gia tri MIN", trungMin);

        }
    }
}
