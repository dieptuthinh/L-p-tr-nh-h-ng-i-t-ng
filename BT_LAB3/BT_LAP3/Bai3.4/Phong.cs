using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3._4
{
    class Phong
    {
        //khởi tạo giá trị
        string maphong;
        short people;
        short money_phong, cs_dien_cu, cs_dien_moi, cs_nc_cu, cs_nc_moi;

        public Phong()
        {
            maphong = "";
            people = 0;
            money_phong = 1000; ;
            cs_dien_cu = 0;
            cs_dien_moi = 0;
            cs_nc_cu = 0;
            cs_nc_moi = 0;
        }
        public Phong(string ma, short p, short money, short csdc, short csdm, short csnc, short csnm)
        {
            maphong = ma;
            people = p;
            money_phong = money;
            cs_dien_cu = csdc;
            cs_dien_moi = csdm;
            cs_nc_cu = csnc;
            cs_nc_moi = csnm;
        }
        //-------------------------
        public void NhapThongtin()
        {
            Console.Write("Nhập mã phòng: ");//nhập mã phòng
            maphong = Console.ReadLine();

            //Nhập số người trong phòng--------------------------------------

            Console.Write("Nhập số người: ");
            while (short.TryParse(Console.ReadLine(), out people) == false)
                Console.Write("Nhập sai định dạng, Mời nhập lại: ");

            //Nhập chỉ số điện cũ---------------------------------------------------

            Console.Write("Nhập chỉ số điện cũ đã dùng: ");
            while (short.TryParse(Console.ReadLine(), out cs_dien_cu) == false || cs_dien_cu < 0)
                Console.Write("Nhập sai định dạng, Mời nhập lại: ");

            //Nhập chỉ số điện mới--------------------------------------------------

            Console.Write("Nhập chỉ số điện mới đã dùng: ");
            while (short.TryParse(Console.ReadLine(), out cs_dien_moi) == false || cs_dien_moi < cs_dien_cu)
                Console.Write("Nhập lại, chỉ số điện mới phải lớn hơn chỉ số điện cũ: ");

            //Nhập chỉ số nước cũ-----------------------------------------------------

            Console.Write("Nhập chỉ số nước cũ đã dùng: ");
            while (short.TryParse(Console.ReadLine(), out cs_nc_cu) == false || cs_nc_cu < 0)
                Console.Write("Nhập sai định dạng, Mời nhập lại: ");

            //Nhập chỉ số nước mới---------------------------------------------------

            Console.Write("Nhập chỉ số nước mới đã dùng: ");
            while (short.TryParse(Console.ReadLine(), out cs_nc_moi) == false || cs_nc_moi < cs_nc_cu)
                Console.Write("Nhập lại, chỉ số nước mới phải lớn hơn chỉ số nước cũ: ");
        }
        //-------------Xuất thông tin người dùng
        public void Xuat()
        {
            Console.WriteLine("giá điện: " + Tiendien());
            Console.WriteLine("Mã phòng: " + maphong + "\nSố người ở: " + people + "\nSố kw điện tiêu thụ : " + (cs_dien_moi - cs_dien_cu) + "\nSố m3 nước tiêu thụ : " + (cs_nc_moi - cs_nc_cu));
        }
        //-----------------------------------------------------------
        int Tiendien()
        {
            int temp;
            if ((cs_dien_moi - cs_dien_cu) <= 100)
            {
                temp = (int)(cs_dien_moi - cs_dien_cu) * 3000;
            }
            else
            {
                temp = (int)((100 * 3000) + ((cs_dien_moi - cs_dien_cu - 100) * (3000 * 1.5)));
            }
            return temp;
        }
        int Tiennuoc()
        {
            int temp = (int)(cs_nc_moi - cs_nc_cu) * 8000;
            return temp;
        }
        public int TongTienPhong()
        {

            int tienphong = (money_phong) + Tiendien() + Tiennuoc();
            return tienphong;
        }
        public int TrungBinhPhaitra()
        {
            int temp = (int)(TongTienPhong() / people);
            return temp;
        }
        public void GiaPhong()
        {
            Console.WriteLine("Giá phòng: " + money_phong);
        }
    }
}
