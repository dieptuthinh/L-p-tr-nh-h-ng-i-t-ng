using System;

namespace Bai1._5b
{
    class Program
    {
        //Ham nhap mang

        public void setArray(ref int n, ref int[] a)

        {

            do

            {

                Console.Write("Nhap n (3<=n<=20): ");

                n = int.Parse(Console.ReadLine());

            } while (n > 20 || n < 3);

            for (int i = 0; i < n; i++)

            {

                Console.Write("Nhap a[{0}]: ", i);

                a[i] = int.Parse(Console.ReadLine().ToString());

            }

        }

        //Ham in tat ca cac phan tu trong mang

        public void print(int[] a, int n)

        {

            String tmp = "";

            for (int i = 0; i < n; i++)

            {

                tmp += a[i] + ", ";

            }

            Console.WriteLine("Day so vua nhap: " + tmp.Substring(0, tmp.Length - 2));

        }

        //Ham in tat ca cac phan tu le trong mang nguoc thu tu nhap

        public void printOddNumber(int[] a, int n)

        {

            String tmp = "";

            for (int i = n - 1; i >= 0; i--)

            {

                if (a[i] % 2 == 1)

                {

                    tmp += a[i] + ", ";

                }

            }

            if (tmp != "")

            {

                tmp = tmp.Substring(0, tmp.Length - 2);

                Console.WriteLine("Cac phan tu le trong mang nguoc thu tu nhap: " + tmp);

            }

            else

            {

                Console.WriteLine("Mang khong co so le!");

            }

        }

        //Ham sap mang tang dan

        public void ascSort(ref int[] a, int n)

        {

            for (int i = 0; i < n - 1; i++)

            {

                for (int j = i + 1; j < n; j++)

                {

                    if (a[i] > a[j]) Swap(ref a[i], ref a[j]);

                }

            }

        }

        private void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }

        static void Main(string[] args)

        {

            Program p = new Program();

            //1. Cho phep nhap n so nguyen(0<n<100)

            int n = 3; int[] a = new int[20];

            p.setArray(ref n, ref a);

            //2. Xuat mang vua nhap

            p.print(a, n);


            //+ Cac phan tu le nguoc thu tu nhap

            p.printOddNumber(a, n);

            //28. Sap xep mang tang dan

            Console.WriteLine("Sap xep mang tang dan");

            p.ascSort(ref a, n);

            p.print(a, n);

            //Dung man hinh

            Console.ReadKey(true);

        }
    }
}
