using System;
using System.Text;
using System.Linq;

namespace BaiKTxe
{
    class Program
    {
        static void swap(ref XeCon a, ref XeCon b)
        {
            XeCon temp = a;
            a = b;
            b = temp;
        }
        public static void Xapxep(XeCon[] arr, int n)
        {
            for (int i = 0; i < n - 1; ++i)
                for (int j = 0; j < n - i - 1; ++j)
                    if (arr[j] > arr[j + 1])
                        swap(ref arr[j], ref arr[j + 1]);
        }
        public static void MaxMin(XeCon[] arr, int n)
        {
            XeCon max = arr[0];
            XeCon min = arr[0];

            for (int i = 1; i < n; ++i)
            {
                float price = arr[i].Gia;
                if(max.Gia < price)
                {
                    max = arr[i];
                }
                if (min.Gia > price)
                {
                    min = arr[i];
                }
            }
            Console.Write("Xe thấp giá nhất: ");
            min.Xuat();
            Console.Write("Xe cao giá nhất: ");
            max.Xuat();
        }

        public static void TimKiem(XeCon[] arr, int n)
        {
            byte bx = 0;
            Console.Write("Nhập biển số xe: ");
            while (byte.TryParse(Console.ReadLine(), out bx) == false || bx > 99 || bx < 1)
            {
                Console.WriteLine("Nhap lai di !!!");
            }
            for(int i = 0; i < n; i++)
            {
                byte temp = Byte.Parse(arr[i].BienSo.Substring(0,2));
                if(temp == bx)
                {
                    arr[i].Xuat();
                }
                
            }
        }

        public static void Xoa(ref XeCon[] arr, int n, String del)
        {
            byte count = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr[i].BienSo.Equals(del))
                {
                    count++;
                    for (int j = i; j < n - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                }
            }
            if (count == 0)
                Console.WriteLine("Không tìm thấy biển số xe này");
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            byte n;
            Console.Write("Nhập số xe con (0 < n < 50): ");
            while (byte.TryParse(Console.ReadLine(), out n) == false || n > 49 || n < 1)
            {
                Console.WriteLine("Nhap lai di !!!");
            }


            XeCon[] xecon = new XeCon[n];
            for (int i = 0; i < n; i++)
            {
                xecon[i] = new XeCon();
                Console.WriteLine("\t\tNhập xe con: " + (i + 1));
                xecon[i].Nhap();

            }

            Console.WriteLine("\n\t\t**************Danh sách SAU XẮP XẾP****************");

            /*            for (int i = 0; i < n - 1; ++i)
                        {
                            for (int j = 0; j < n - i - 1; ++j)
                            {
                                if (xecon[j].XapXep < xecon[j + 1].XapXep)
                                {
                                    //CÁCH 1 hoán đổi bình thường sử dụng phương thức đóng gói:
                                    //XeCon temp = xecon[j];
                                    //xecon[j] = xecon[j + 1];
                                    //xecon[j + 1] = temp;

                                    //-----------------------------
                                    //CÁCH 2 sử dụng hàm swap để hoán đổi:
                                    //swap(ref xecon[j],ref xecon[j + 1]);

                                }
                            }
                        }*/


            ////CÁCH 3 SỬ DỤNG TOÁN TỬ
            Xapxep(xecon, n);
            Console.WriteLine("\t\tThông tin in ra là: ");
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("\tXe con thứ: " + (i + 1));
                xecon[i].Xuat();
                Console.WriteLine("\n------------------\n");
            }

            MaxMin(xecon, n);
            TimKiem(xecon, n);


            Console.Write("Nhập biển số xe cần xoá:");
            string bx = Console.ReadLine();
            Xoa(ref xecon, n, bx);
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("\tXe con thứ: " + (i + 1));
                xecon[i].Xuat();
                Console.WriteLine("\n------------------\n");
            }

            Console.ReadKey();
        }
    }
}
