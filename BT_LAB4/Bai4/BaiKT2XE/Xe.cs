using System;
using System.Collections.Generic;
using System.Text;

namespace BaiKT2XE
{
    class Xe
    {
        public String BienSo;
        public int NamSX;
        public float Gia;

        public Xe()
        {
            BienSo = "79A-12345";
            NamSX = 2019;
            Gia = 100;
        }
        public Xe(String BienSo, int NamSX, float Gia)
        {
            this.BienSo = BienSo;
            this.NamSX = NamSX;
            this.Gia = Gia;
        }
        public void Nhap()
        {
            Console.Write("Nhập biển số:");
            BienSo = Console.ReadLine();
            Console.Write("Nhập năm sản xuất:");
            while (int.TryParse(Console.ReadLine(), out NamSX) == false)
                Console.Write("Mời nhập lại nam san xuat");
            Console.Write("Nhập giá tiền:");
            while (float.TryParse(Console.ReadLine(), out Gia) == false)
                Console.Write("Mời nhập lại gia tien");
        }

        public void Xuat()
        {
            Console.Write("Bien So xe: " + BienSo + "\tNăm sản xuất: " + NamSX + "\tGiá tiền: " + Gia);
        }
    }

    class XeCon : Xe
    {
        public byte Sl;

        public XeCon() : base()
        {
            Sl = 4;
        }
        public XeCon(string BienSo, int NamSX, float Gia, byte Sl) : base(BienSo, NamSX, Gia)
        {
            this.Sl = Sl;
        }
        public new void Nhap()
        {
            base.Nhap();

            Console.Write("Nhập số chỗ:");
            while (byte.TryParse(Console.ReadLine(), out Sl) == false)
                Console.Write("Mời nhập lại số chỗ");
        }

        public new void Xuat()
        {
            base.Xuat();
            Console.Write("\tSố lượng chỗ ngồi: " + Sl);
            Console.WriteLine();
        }

        public static bool operator >(XeCon a, XeCon b)
        {
            bool kq = false;
            if (a.NamSX > b.NamSX)
            {
                return true;
            }
            return kq;
        }
        public static bool operator <(XeCon a, XeCon b)
        {
            bool kq = false;

            if (a.NamSX < b.NamSX)
            {
                return true;
            }
            return kq;
        }
    }
}
