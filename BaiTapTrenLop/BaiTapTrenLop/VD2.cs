/*using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapTrenLop
{
    class VD2
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            Console.WriteLine("Nhap kich thuoc cua mang: ");
            //int arraySize = int.Parse(Console.ReadLine());
            int arraySize;
            while(int.TryParse(Console.ReadLine(),out arraySize)==false|| arraySize<3 || arraySize >100)
            {
                Console.Write("Nhap lai: ");
            }

            int[] array = new int[arraySize];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Nhap a[{0}]:", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            //Thêm phần tử
            //array[arraySize] = 4;

            Console.Write("Xuat mang: ");

            foreach (int x in array)
                Console.Write("{0} ", x);

            //Tính trung bình cộng
            int sumArray = 0;
            foreach (int x in array)
            {
                sumArray+=x;
            }
            float avgValue = (float)sumArray / arraySize;
            Console.Write("\nTBC: " + avgValue.ToString("0.00"));


*//*            Console.Write("Nhap gia tri phan tu moi can chen: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vi tri can chen phan tu moi nay: ");
            p = Convert.ToInt32(Console.ReadLine());*//*
        }
    }
}
*/