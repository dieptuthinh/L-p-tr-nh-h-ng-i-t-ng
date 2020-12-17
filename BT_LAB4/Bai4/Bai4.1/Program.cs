using System;
using System.Text;

namespace Bai4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cách 1
            /*            Person p;
                        Console.Write("1:Employee\nTeacher\nMoi ban chon:");
                        byte opt = byte.Parse(Console.ReadLine());
                        if (opt == 1)
                            p = new Employee("NV1", "NVA", true, 27, 5);
                        else
                            p = new Teacher("T1", "TTB", false, 50, 50);
                        p.Output();
                        Console.ReadKey();*/


            //Cách 2
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            #region BÀI4.1
            byte n;
            do
            {
                Console.Write("Nhập thông cán bộ nhan viên");
                Console.Write("\n1: Nhân viên.");
                Console.WriteLine("\n2: Giáo viên.");
                Console.Write("Mời nhập lựa chọn của bạn: ");
                byte m;
                while (byte.TryParse(Console.ReadLine(), out m) == false || (m < 1 || m > 2))
                    Console.Write("Nhập lại lựa chọn");
                switch (m)
                {
                    case 1:
                        {

                            Employee nv = new Employee();
                            nv.nhapNV();
                            Console.WriteLine("\n\tHóa Đơn nhân viên: ");
                            nv.Xuat();
                            break;
                        }
                    case 2:
                        {
                            Teacher nv = new Teacher();
                            nv.nhapNV();
                            Console.WriteLine("\n\tHóa Đơn giáo viên: ");
                            nv.Xuat();
                            break;
                        }
                }
                Console.Write("\n\n\tBạn có muốn tiếp tục 0/Dừng || 1/Tiếp tục: ");
                n = byte.Parse(Console.ReadLine());
            } while ((n != 0));
            #endregion

        }
    }
}
