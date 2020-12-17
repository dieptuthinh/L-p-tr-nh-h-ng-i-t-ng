using System;
using System.Collections.Generic;
using System.Text;

namespace BaiKT
{
    class Xe
    {
        protected string BienSo;
        protected int Nam;
        protected byte Gia;

        //phương thức thiết lập
        public Xe()
        {
            BienSo = "79A-12345"; Nam = 2019 ; Gia = 2;
        }
        public Xe(string b, int n, byte g)
        {
            BienSo = b; Nam= n; Gia= g;
        }
        //phương thức nhập dữ liệu
        public void Set()
        {
            Console.Write("nhap bien so:");
            BienSo = Console.ReadLine();
            Console.Write("nhap nam san xuat:");
            Nam = int.Parse(Console.ReadLine());
            Console.Write("nhap dia chi:");
            Gia = byte.Parse(Console.ReadLine());
        }
        //phương thức xuất dữ liệu
        public void Get()
        {
            Console.Write("\t{0}\t{1}\t{2}", BienSo, Nam, Gia);
        }
    }
    class XeCon : Xe
    {
/*        string id;
        float avg;
        byte num;
        //phương thức khởi tạo
        public XeCon() : base()
        {
            id = "62131111"; avg = 5.5f; num = 140;
        }
        public XeCon(string i, string n, byte ag, float av, byte nu, string ad) : base(n, ag, ad)
        {
            id = i; avg = av; num = nu;
        }
        //phương thức nhập
        public new void Set()
        {
            base.Set();
            Console.Write("nhap ma so:");
            id = Console.ReadLine();
            Console.Write("nhap diem trung binh tich luy:");
            avg = float.Parse(Console.ReadLine());
            Console.Write("nhap so tin chi da tich luy:");
            num = byte.Parse(Console.ReadLine());
        }
        //phương thức xuất dữ liêu
        public new void Get()
        {
            Console.Write("ID: {0}\t\n", id);
            //base.Get();//in ra name
            Console.Write("Name: {0}\t\n", name);
            Console.Write("Diem Trung binh: {0}\t\n", avg);
            Console.Write("So tin chi da tich luy: {0}\t\n", num);
            Console.Write("Ket qua : ");
            if (Gra())
                Console.Write("du dieu kien TN!");
            else
                Console.Write("chua du dieu kien TN!");
        }
        //phương thức xét tốt nghiệp
        public bool Gra()
        {
            bool result = false;
            if (avg >= 5.5 && num >= 140)
                result = true;
            return result;
            //cách khác
            //if (avg >= 5.5 && num >= 140)
            //    return true;
            //else
            //    return false;
        }*/
    }
}
