using System;
using System.Collections.Generic;
using System.Text;

namespace BaiKTxe
{
    class Xe
    {
        public string BienSo;
        public int Nam;
        public float Gia;
        public int XapXep { get => Nam; set => Nam = value; }

        //phương thức thiết lập không tham số
        public Xe()
        {
            BienSo = ""; Nam = 0; Gia = 0;
        }

        //phương thức thiết lập có tham số
        public Xe(string BienSo, int Nam, float Gia)
        {
            this.BienSo = BienSo; this.Nam = Nam; this.Gia = Gia;
        }
        public void Nhap()
        {
            Console.Write("nhap bien so:");
            BienSo = Console.ReadLine();
            Console.Write("nhap nam san xuat:");
            while (int.TryParse(Console.ReadLine(), out Nam) == false)
                Console.Write("Mời nhập lại nam san xuat");
            Console.Write("nhap gia tien:");
            while (float.TryParse(Console.ReadLine(), out Gia) == false)
                Console.Write("Mời nhập lại gia tien");
        }
        //phương thức xuất dữ liệu
        public void Xuat()
        {
            Console.Write("Bien So xe: " + BienSo+ "\tNăm sản xuất: " + Nam+ "\tGiá tiền: "+Gia);
        }
    }
    class XeCon : Xe
    {
        public int sl;

        public XeCon() : base()
        {
            sl = 0;
        }
        public XeCon(string BienSo, int Nam, float Gia,int sl) : base( BienSo,Nam,Gia)
        {
            this.sl = sl;
        }

        public new void Nhap()
        {
            base.Nhap();

            Console.Write("Nhập số chỗ ngồi: ");
            while (int.TryParse(Console.ReadLine(), out sl) == false)
                Console.Write("Nhập sai định dạng mời nhập lại số lượng chỗ ngồi: ");
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.Write("\tSố lượng chỗ ngồi: " + sl);
            Console.WriteLine();
        }
        public static bool operator >(XeCon a, XeCon b)
        {
            bool kq = false;
            if (a.XapXep > b.XapXep)
            {
                return true;
            }
            return kq;
        }
        public static bool operator <(XeCon a, XeCon b)
        {
            bool kq = false;

            if (a.XapXep < b.XapXep)
            {
                return true;
            }
            return kq;
        }

    }
}
