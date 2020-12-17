using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_LAB3
{
    class PhanSo
    {
        short tuso, mauso;//khai báo hai thuộc tính kiểu int
        
        //-----------------------------Không tham số--------------------------------
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;

        }
        //-------------------------Có tham số------------
        public PhanSo(short t, short m)
        {
          
                tuso = t;
                mauso = m;
           
        }
        //---------------------Thiết lập sao chép-------------
        public PhanSo(PhanSo s)
        {
            tuso = s.tuso;
            mauso = s.mauso;
        }
        //--HÀm nhập giá trị
        public void Nhapgt()
        {

            Console.Write("Nhập tử số: ");
            while (short.TryParse(Console.ReadLine(), out tuso) == false)
                Console.Write("Nhập sai! Nhập lại tử số:");
            Console.Write("Nhập mẫu số: ");
            while (short.TryParse(Console.ReadLine(), out mauso) == false)
                Console.Write("Nhập sai! Nhập lại mẫu số:");
        }
        public PhanSo Cong(PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = (short)(tuso * p2.mauso + mauso * p2.tuso);
            kq.mauso = (short)(mauso * p2.mauso);
            return kq;
        }
        //Toán tử cộng----------------------------
        public static PhanSo operator +(PhanSo p1, PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = (short)(p1.tuso * p2.mauso + p1.mauso * p2.tuso);
            kq.mauso = (short)(p1.mauso * p2.mauso);
            return kq;
        }
        //Trừ hai phân số
        public PhanSo Tru(PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = (short)(tuso * p2.mauso - mauso * p2.tuso);
            kq.mauso = (short)(mauso * p2.mauso);
            return kq;
        }
        //Toán tử trừ----------------------------
        public static PhanSo operator -(PhanSo p1, PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = (short)(p1.tuso * p2.mauso - p1.mauso * p2.tuso);
            kq.mauso = (short)(p1.mauso * p2.mauso);
            return kq;
        }
        //Nhân hai phân số
        public PhanSo Nhan(PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = (short)(tuso * p2.tuso);
            kq.mauso = (short)(mauso * p2.mauso);
            return kq;
        }
        //Toán tử nhân----------------------------
        
       
        public static PhanSo operator *(PhanSo p1, PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = (short)(p1.tuso * p2.tuso);
            kq.mauso = (short)(p1.mauso * p2.mauso);

            return kq;
        }
        public PhanSo Chia(PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            
            kq.tuso = (short)(tuso * p2.mauso);
            kq.mauso = (short)(mauso * p2.tuso);
            return kq;
        }
        //Toán tử chia----------------------------
        public static PhanSo operator /(PhanSo p1, PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = (short)(p1.tuso * p2.mauso);
            kq.mauso = (short)(p1.mauso * p2.tuso);
            return kq;
        }
        //Hàm xuất
        public void Xuat()
        {
            if (tuso == 0 && mauso == 0 || mauso == 0)
                Console.WriteLine("CAN NOT RESUM!");
            else
            {
                if (tuso == 0)
                    Console.WriteLine(tuso);
                else
                    Console.WriteLine(tuso + " / " + mauso);
            }
        }
        //------rút gọn CÁch một
        public byte RutGon()
        {
            
            if (mauso < 0)
            {
                mauso = (short)-mauso;
                tuso = (short)-tuso;
            }
            for (int i = 2; i <= (Math.Abs(tuso) + Math.Abs(mauso)); i++)
            {
                while (tuso % i == 0 && mauso % i == 0)
                {
                    tuso /= (short)i;
                    mauso /= (short)i;
                }
            }
            return 1;
        }
        //------------Cách hai
        //short USC(short a, short b)
        //{
        //    a = Math.Abs(a);
        //    b = Math.Abs(b);
        //    while (a != b)
        //    {
        //        if (a > b)
        //            a = (short)(a - b);
        //        else
        //            b = (short)(b - a);
        //    }
        //    return a;
        //}
        //public PhanSo RutGon()
        //{
        //    PhanSo kq = new PhanSo();
        //    kq.tuso = (short)(tuso / USC(tuso, mauso));
        //    kq.mauso = (short)(mauso / USC(tuso, mauso));
        //    return kq;
        //}


    }
}
