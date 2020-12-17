using System;

namespace Bai2._3
{
    class XuLy
    {
        /*string[] array = new string[10];*/
        private int n;
        private int[] a = new int[100];
        private int sumArray = 0;
        public void nhap()
        {
            do
            {

                Console.Write("Nhap n (3<=n<=20): ");

                n = int.Parse(Console.ReadLine());

            } while (n > 20 || n < 3);

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap a[{0}]: ", i);

                a[i] = int.Parse(Console.ReadLine());
            }

        }
        public void xuat()
        {
            Console.Write("\nday so la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.Write("\n");
        }

        public void tbc()
        {
            foreach (int x in a)
            {
                sumArray += x;
            }
            float avgValue = (float)sumArray / n;
            Console.WriteLine("\nTBC: " + avgValue.ToString("0.00"));
        }

        public void sort()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[i])
                    {
                        //cach trao doi gia tri
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
            Console.WriteLine("\nHam sau khi xap xep tang dan la: ");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            XuLy b3 = new XuLy();
            b3.nhap();
            b3.xuat();
            b3.tbc();
            b3.sort();
            b3.xuat();
            Console.ReadKey();
        }
    }
}
