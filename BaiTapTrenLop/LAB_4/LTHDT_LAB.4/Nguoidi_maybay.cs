using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_LAB._4
{
   public  class Nguoidi_maybay
    {
        public string hoten;
        public bool gt;
        public string namsinh;
        //-------------------
        public Nguoidi_maybay()
        {
            hoten = "";
            gt = true;
            namsinh = "";
        }
        //---------------------Có tham số
        public Nguoidi_maybay(string hoten, bool gt,string namsinh)
        {
            this.hoten = hoten;
            this.gt = gt;
            this.namsinh = namsinh;
        }

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
        public void Xuat()
        {
            Console.WriteLine("Họ Tên: " + hoten + "\tGiới tính: " + gt + "\tNăm sinh: "+namsinh);
        }
    }
    public class Hanh_khach : Nguoidi_maybay
    {
        //Thuộc tính: số lượng vé máy bay, danh sách vé máy bay
        public int sl;
        public VeMaybay[] ds_vemaybay;
        private int tongtien;

        public int Tongtien { get => tongtien; set => tongtien = value; }
       

        //------------
        public Hanh_khach() : base()
        {
            sl = 0;
            ds_vemaybay = new VeMaybay[100];
            tongtien = 0;
        }
        //-------------------------
        public Hanh_khach(string hoten, bool gt, string namsinh, int sl, VeMaybay[] ds_vemaybay, int tongtien) : base(hoten, gt, namsinh)
        {
            this.sl = sl;
            this.ds_vemaybay[100] = ds_vemaybay[100];
            this.tongtien = tongtien;
        }
        //-------------------
        
        
        //------------------------

        public new void Nhap()
        {
            base.Nhap();

            Console.Write("Nhập số lượng vé hành khách đã mua: ");
            while (int.TryParse(Console.ReadLine(), out sl) == false)
                Console.Write("Nhập sai định dạng mời nhập lại số lượng vé: ");
           
            for(int i= 0; i < sl; i++)
            {
                ds_vemaybay[i] = new VeMaybay();
                Console.WriteLine("\tNhập vé thứ: " + (i + 1));
                ds_vemaybay[i].Nhap();
               
                tongtien += ds_vemaybay[i].Getgiave();
            }    
        }
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

        public static bool operator >(Hanh_khach a, Hanh_khach b)
        {
            bool kq = false;
            if (a.Tongtien > b.Tongtien)
            {
                return true;
            }
            return kq;
        }
        public static bool operator <(Hanh_khach a, Hanh_khach b)
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
