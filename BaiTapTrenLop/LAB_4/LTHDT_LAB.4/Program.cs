using System;
using System.Text;
using System.Collections.Generic;

namespace LTHDT_LAB._4
{
    class Program
    {

        //CÁCH 2:
        static void swap(ref Hanh_khach a, ref Hanh_khach b)
        {
            Hanh_khach temp = a;
            a = b;
            b = temp;
        }
        //CÁCH 3 SỬ DỤNG TOÁN TỬ
        public static void Xapxep(Hanh_khach[] arr, int n)
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
            #region BÀI4.1
            //byte n;
            //do
            //{
            //    Console.Write("Nhập thông cán bộ nhan viên");
            //    Console.Write("\n1: Nhân viên.");
            //    Console.WriteLine("\n2: Giáo viên.");
            //    Console.Write("Mời nhập lựa chọn của bạn: ");
            //    byte m;
            //    while (byte.TryParse(Console.ReadLine(), out m) == false || (m < 1 || m > 2))
            //        Console.Write("Nhập lại lựa chọn");



            //    switch (m)
            //    {
            //        case 1:
            //            {

            //                Employee nv = new Employee();
            //                nv.nhapNV();
            //                Console.WriteLine("\n\tHóa Đơn nhân viên: ");
            //                nv.Xuat();
            //                break;
            //            }
            //        case 2:
            //            {
            //                Teacher nv = new Teacher();
            //                nv.nhapNV();
            //                Console.WriteLine("\n\tHóa Đơn giáo viên: ");
            //                nv.Xuat();
            //                break;
            //            }
            //    }
            //    Console.Write("\n\n\tBạn có muốn tiếp tục 0/Dừng || 1/Tiếp tục: ");
            //    n = byte.Parse(Console.ReadLine());
            //} while ((n != 0));
            #endregion
            #region BÀI4.2
            ////********************có tham số:
            //Student pp = new Student("Hưng", "404/15", 16, "61113333", 140, 5.6f);
            
            //pp.Get();
            //pp.kt_totnghiep();
            //*******************Không tham số:
            //Student st = new Student();
            //st.Set();
            //Console.WriteLine("===========Thông tin sinh viên ========== ");
            //st.Get();
            //st.kt_totnghiep();
            #endregion
            #region BÀI 4.3
            //npixel q = new npixel(3);//truyền n ds thẳng vào hàm
            ////q.Nhap();//cách hai
            //Console.WriteLine("****Danh sách pixcel****");
            //q.inNds();
            //Console.WriteLine("Sô pixcel thuộc đường chéo chính là: " + q.CountCheochinh());
            //Console.ReadKey();
            //Console.Clear();
            //q.inNpixel();




            #endregion
            #region BÀI 4.4
            //Console.Write("Nhập số lượng khách hàng: ");
            //byte n = byte.Parse(Console.ReadLine());
            //Hanh_khach[] hk = new Hanh_khach[n];

            //for (int i = 0; i < n; i++)
            //{
            //    hk[i] = new Hanh_khach();
            //    Console.WriteLine("\t\tNhập hành khách: " + (i + 1));
            //    hk[i].Nhap();

            //}

            //Console.WriteLine("\n\t\t**************Danh sách SAU XẮP XẾP****************");

            //for (int i = 0; i < n - 1; ++i)
            //{
            //    for (int j = 0; j < n - i - 1; ++j)
            //    {
            //        if (hk[j].Tongtien < hk[j + 1].Tongtien)
            //        {
            //            //CÁCH 1 hoán đổi bình thường sử dụng phương thức đóng gói:
            //            //Hanh_khach temp = hk[j];
            //            //hk[j] = hk[j + 1];
            //            //hk[j + 1] = temp;
            //            //CÁCH 2 sử dụng hàm swap để hoán đổi:
            //            //swap(ref hk[j],ref hk[j + 1]);

            //        }
            //    }
            //}
            ////CÁCH 3 SỬ DỤNG TOÁN TỬ
            //Xapxep(hk, n);
            //for (int i = 0; i < n; ++i)
            //{
            //    hk[i].Xuat();
            //    Console.WriteLine("\n------------------\n");
            //}

            #endregion


            Console.ReadKey();
        }
    }
}
