using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4._4
{
    class Nguoi
    {
        public string hoten;
        public bool gt;
        public string namsinh;

        //phương thức khởi tạo
        public Nguoi()
        {
            hoten = "";
            gt = true;
            namsinh = "";
        }


        //---------------------Có tham số
        public Nguoi(string hoten, bool gt, string namsinh)
        {
            this.hoten = hoten;
            this.gt = gt;
            this.namsinh = namsinh;
        }
        //phương thức nhập SV tự viết 

        //--------------Nhập người thông tin người
        public void Nhap()
        {
            Console.Write("Nhập họ tên của bạn: ");
            hoten = Console.ReadLine();
            Console.Write("Nhập giới tính ( Nam : true || Nữ : false ): ");
            while (bool.TryParse(Console.ReadLine(), out gt) == false)
                Console.Write("Mời nhập lại giới tính, chỉ có (true) or (false): ");
            Console.Write("Nhập năm sinh: ");
            namsinh = Console.ReadLine();
        }
        //-------------

        //phương thức xuất thông tin người
        public void Xuat()
        {
            Console.WriteLine("Họ Tên: " + hoten + "\tGiới tính: " + gt + "\tNăm sinh: " + namsinh);
        }
    }
    class HanhKhach : Nguoi
    {
        // byte n;//số lượng vé máy bay
        //VeMB[] dsve;// danh sách vé máy bay của hành khách

        //Thuộc tính: số lượng vé máy bay, danh sách vé máy bay
        public int sl;
        public VeMB[] ds_vemaybay;
        private int tongtien;

        public int Tongtien { get => tongtien; set => tongtien = value; }

        //phương thức thiết lập
        public HanhKhach() : base()
        {
            sl = 0;
            ds_vemaybay = new VeMB[100];
            tongtien = 0;
        }
        public HanhKhach(string hoten, bool gt, string namsinh, int sl, VeMB[] ds_vemaybay, int tongtien) : base(hoten, gt, namsinh)
        {
            //n = so;
            //dsve = new VeMB[n];
            //nhập vào n vé SV tự viết

            this.sl = sl;
            this.ds_vemaybay[100] = ds_vemaybay[100];
            this.tongtien = tongtien;

        }
        //phương thức nhập SV tự viết
        public void Nhap1()
        {
            // nhập họ tên,giới tính, năm sinh
            base.Nhap();

            //nhập số lượng ve
            //nhập n vé
            Console.Write("Nhập số lượng vé hành khách đã mua: ");
            while (int.TryParse(Console.ReadLine(), out sl) == false)
                Console.Write("Nhập sai định dạng mời nhập lại số lượng vé: ");

            for (int i = 0; i < sl; i++)
            {
                ds_vemaybay[i] = new VeMB();
                Console.WriteLine("\tNhập vé thứ: " + (i + 1));
                ds_vemaybay[i].Nhap();

                tongtien += ds_vemaybay[i].Getgiave();
            }
        }
        //phương thức xuất SV tự viết
        public new void Xuat()
        {
            Console.WriteLine("\tThông tin khách hàng:");
            base.Xuat();
            Console.WriteLine("\tThông tin chuyến bay:");
            for (int i = 0; i < sl; i++)
            {
                ds_vemaybay[i].Xuat();
            }
            Console.WriteLine("==>Tổng tiền: " + tongtien);

        }

        //phương thức tính tổng tiền
/*        public int TongTien()
        {
            int tong = 0;
            foreach (VeMB ve in ds_vemaybay)
                tong = tong + ve.Gia;
            return tong;
        }*/
        //tự định nghĩa toán tử để dùng so sánh trong phương thức sắp xếp của DSHanhKhach
        public static bool operator >(HanhKhach a, HanhKhach b)
        {
            bool kq = false;
            if (a.Tongtien > b.Tongtien)
            {
                return true;
            }
            return kq;
        }
        public static bool operator <(HanhKhach a, HanhKhach b)
        {
            bool kq = false;

            if (a.Tongtien < b.Tongtien)
            {
                return true;
            }
            return kq;
        }
    }
}
