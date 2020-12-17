using System;
using System.Text;

namespace Bai4._4
{
    class Program
    {
        //CÁCH 2:
        static void swap(ref HanhKhach a, ref HanhKhach b)
        {
            HanhKhach temp = a;
            a = b;
            b = temp;
        }
        //CÁCH 3 SỬ DỤNG TOÁN TỬ
        public static void Xapxep(HanhKhach[] arr, int n)
        {
            for (int i = 0; i < n - 1; ++i)
                for (int j = 0; j < n - i - 1; ++j)
                    if (arr[j] < arr[j + 1])
                        swap(ref arr[j], ref arr[j + 1]);
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            #region BÀI 4.4
            Console.Write("Nhập số lượng khách hàng: ");
            byte n = byte.Parse(Console.ReadLine());
            HanhKhach[] hk = new HanhKhach[n];

            for (int i = 0; i < n; i++)
            {
                hk[i] = new HanhKhach();
                Console.WriteLine("\t\tNhập hành khách: " + (i + 1));
                hk[i].Nhap1();

            }

            Console.WriteLine("\n\t\t**************Danh sách SAU XẮP XẾP****************");

            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = 0; j < n - i - 1; ++j)
                {
                    if (hk[j].Tongtien < hk[j + 1].Tongtien)
                    {
                        //CÁCH 1 hoán đổi bình thường sử dụng phương thức đóng gói:
                                    HanhKhach temp = hk[j];
                                    hk[j] = hk[j + 1];
                                    hk[j + 1] = temp;
                        //            //CÁCH 2 sử dụng hàm swap để hoán đổi:
                        //            //swap(ref hk[j],ref hk[j + 1]);

                    }
                }
            }
                        ////CÁCH 3 SỬ DỤNG TOÁN TỬ
            Xapxep(hk, n);

            for (int i = 0; i < n; ++i)
            {
                hk[i].Xuat();
                Console.WriteLine("\n------------------\n");
            }

            #endregion


            Console.ReadKey();

        }
    }
}
