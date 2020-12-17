using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_LAB3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //Nhập giờ phút giây
            #region
            //byte gio, phut, giay;
            //Console.Write("Nhập giờ:  ");
            //while (byte.TryParse(Console.ReadLine(), out gio)==false && gio < 0 || gio > 24)
            //    Console.Write("Nhập lại giờ: ");
            //Console.Write("Nhập phút: ");
            //phut = byte.Parse(Console.ReadLine());
            //Console.Write("Nhập giây: ");
            //giay = byte.Parse(Console.ReadLine());
            //Time tg = new Time(gio,phut,giay);
            //tg.Show24();
            //tg++;
            //Console.WriteLine("Giờ sau khi ++");
            //tg.Show24();
            //Time t1 = new Time(gio, phut, giay);
            //t1.Show12();
            //t1 = t1 + 75;
            //Console.WriteLine("Giờ sau khi cộng: ");
            //t1.Show12();
            #endregion

            //Học phần---------------------------------------------
            //Hocphan hp = new Hocphan();
            //Hoadon hd = new Hoadon();
            //hd.Nhapten();
            ////Hocphan[] ds = new Hocphan[50];
            //Console.WriteLine("******* Các học phần trong danh sách đăng kí ********");        
            //hd.NhapHoadon_hp();
            //hd.xuat();
            //Console.WriteLine("Số tín chỉ thực hành của sinh viên: " + hd.Tinh_TH());

            //Phân số------------------------------------------     
            #region
            //PhanSo ps1 = new PhanSo();
            //PhanSo ps2 = new PhanSo();
            //PhanSo ps3 = new PhanSo();
            //byte n;

            //do
            //{

            //    Console.WriteLine("\n\t****** Bảng các phép tính! ******");
            //    Console.WriteLine("1: Cộng");
            //    Console.WriteLine("2: Trừ");
            //    Console.WriteLine("3: Nhân");
            //    Console.WriteLine("4: Chia");
            //    Console.WriteLine("0: Để thoát");

            //    Console.Write("Nhập lựa của bạn: ");
            //    while (byte.TryParse(Console.ReadLine(), out n) == false)
            //        Console.Write("Nhập sai! Nhập lại chọn");
            //    switch (n)
            //    {
            //        case 1:
            //            {
            //                Console.WriteLine("\nPhân Số thứ nhất");
            //                ps1.Nhapgt();
            //                Console.WriteLine("Phân Số thứ hai");
            //                ps2.Nhapgt();
            //                Console.Write("Phép Cộng= ");
            //                //ps3 = ps1.Cong(ps2);//phương thức cộng
            //                ps3 = ps1 + ps2;//toán tử cộng
            //                ps3.RutGon();//C1
            //                //ps3 = ps3.RutGon();//C2 của cô
            //                ps3.Xuat();
            //                break;
            //            }
            //        case 2:
            //            {
            //                Console.WriteLine("\nPhân Số thứ nhất");
            //                ps1.Nhapgt();
            //                Console.WriteLine("Phân Số thứ hai");
            //                ps2.Nhapgt();
            //                Console.Write("Phép Trừ= ");
            //                //ps3 = ps1.Tru(ps2);//phương thức trừ
            //                ps3 = ps1 - ps2;//toán tử trừ
            //                ps3.RutGon();//C1
            //                //ps3 = ps3.RutGon();//C2 của cô
            //                ps3.Xuat();
            //                break;
            //            }
            //        case 3:
            //            {
            //                Console.WriteLine("\nPhân Số thứ nhất");
            //                ps1.Nhapgt();
            //                Console.WriteLine("Phân Số thứ hai");
            //                ps2.Nhapgt();
            //                Console.Write("Phép Nhân= ");
            //                //ps3 = ps1.Nhan(ps2);//phương thức nhân
            //                ps3 = ps1 * ps2;//toán tử nhân
            //                ps3.RutGon();//C1
            //                //ps3 = ps3.RutGon();//C2 của cô
            //                ps3.Xuat();
            //                break;
            //            }
            //        case 4:
            //            {
            //                Console.WriteLine("\nPhân Số thứ nhất");
            //                ps1.Nhapgt();
            //                Console.WriteLine("Phân Số thứ hai");
            //                ps2.Nhapgt();
            //                Console.Write("Phép Chia= ");
            //                //ps3 = ps1.Chia(ps2);//phương thức chia
            //                ps3 = ps1 / ps2;//toán tử chia
            //                ps3.RutGon();//C1
            //                //ps3 = ps3.RutGon();//C2 của cô
            //                ps3.Xuat();
            //                break;
            //            }
            //    }

            //} while (n != 0);

            #endregion

            //Phòng kí túc xá--------------------
            Phong p = new Phong();
            Console.WriteLine("\n\t******* Hóa đơn phòng kí túc *******");
            p.NhapThongtin();
            Console.WriteLine("\n\t****** Thông tin hóa đơn đại gia ******");
            p.Xuat();
            Console.WriteLine("\nTổng tiền phòng: " + p.TongTienPhong());
            Console.WriteLine("\nTrung bình mỗi người phải trả: " + p.TrungBinhPhaitra());
            p.GiaPhong();
            Console.ReadKey();
        }
    }
}
