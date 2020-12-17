using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4._2
{
    class People
    {
        protected string name;
        byte age;
        string address;

        //phương thức thiết lập
        public People()
        {
            name = "NVA"; age = 20; address = "2 NDC";
        }
        public People(string n, byte a, string ad)
        {
            name = n; age = a; address = ad;
        }
        //phương thức nhập dữ liệu
        public void Set()
        {
            Console.Write("nhap ten:");
            name = Console.ReadLine();
            Console.Write("nhap tuoi:");
            while (byte.TryParse(Console.ReadLine(), out age) == false)
                Console.Write("Nhập lại tuổi: ");
            Console.Write("nhap dia chi:");
            address = Console.ReadLine();
        }
        //phương thức xuất dữ liệu
        public void Get()
        {
            Console.Write("\t{0}\t{1}\t{2}", name, age, address);
        }
    }
    //định nghĩa lớp Student
    class Student : People
    {
        string id;
        float avg;
        byte num;
        //phương thức khởi tạo
        public Student() : base()
        {
            id = "62131111"; avg = 5.5f; num = 140;
        }
        public Student(string i, string n, byte ag, float av, byte nu, string ad) : base(n, ag, ad)
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
        }
    }

}
