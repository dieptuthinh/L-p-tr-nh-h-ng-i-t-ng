using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5._1
{
    abstract class Phone
    {
        private string num;//số điện thoại

        //thiết lập không tham số
        public Phone()
        {
            num = "0911111122";
        }

        //thiết lập có tham số
        public Phone(string p)
        {
            num = p;
        }

        public string Num 
        { 
            get => num; 
            set => num = value; 
        }

        //phương thức trừu tượng: string SearchPhone(string name1) tìm số điện thoại của một người nào đó có name là tham số truyền vào name1.
        public abstract string SearchPhone(string name1);

    }

    //Lớp Contact kế thừa từ lớp Phone và có những thành phần sau:
    class Contact : Phone
    {
        //Thuộc tính: name chỉ tên một người.
        string name;

        public string Name { get => name; set => name = value; }

        //thiết lập không tham số
        public Contact() : base()
        {
            name = "A";
        }

        //có tham số,sao chép;
        public Contact(string n, string p) : base(p)
        {
            name = n;
        }
        public Contact(Contact c)
        {
            name = c.name;
            Num = c.Num;
        }
        //override phương thức trừu tượng
        //SearchPhone(string name); 
        public override string SearchPhone(string s)
        {
            string n = "";
            if (name.CompareTo(s) == 0) //String.Compare(name,s)==0
                n = Num;//trả về số điện thoại của người tên s
            return n;
        }


        //phương thức in thông tin phương thức OutPut() in ra thông tin name, num
        public void Output()
        {
            Console.WriteLine("{0}\t{1}", name, Num);
        }


        //cách khác override phương thức ToString()
        public override string ToString()
        {
            return name + "\t" + Num;
        }


        //toán tử so sánh theo thuộc tính name
        public static bool operator >(Contact c1, Contact c2)
        {
            if (String.Compare(c1.Name, c2.Name) == 1)
                return true;
            else return false;
        }
        public static bool operator <(Contact c1, Contact c2)
        {
            if (String.Compare(c1.Name, c2.Name) == -1) 
                return true;
            else return false;
        }
    }

}
