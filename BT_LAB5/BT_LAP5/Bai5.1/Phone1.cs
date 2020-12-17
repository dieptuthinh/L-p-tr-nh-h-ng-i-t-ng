using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bai5._1
{
    class Phone1
    {

    }
    class Contact1 : Phone, IComparable<Contact1>
    {
        string name;

        public string Name { get => name; set => name = value; }

        //phương thức thiết lập
        public Contact1() : base()
        {
            name = "A";
        }
        public Contact1(string n, string p) : base(p)
        {
            name = n;
        }
        public Contact1(Contact c)
        {
            name = c.Name;
            Num = c.Num;
        }
        //override phương thức trừu tượng
        public override string SearchPhone(string s)
        {
            string n = "";
            if (name.CompareTo(s) == 0)
                n = name;
            return n;
        }
        //phương thức in thông tin
        public void Output()
        {
            Console.WriteLine("{0}\t{1}", name, Num);
        }
        //cách khác override phương thức ToString()
        public override string ToString()
        {
            return name + "\t" + Num;
        }
        //phương thức so sánh
        public int CompareTo(Contact1 c)
        {
            if (name.CompareTo(c.name) > 1) return 1;
            else if (name.CompareTo(c.name) == 0) return 0;
            else return -1;

        }
    }
    //lớp PhoneBook
    class PhoneBook1
    {
        int n;
        List<Contact1> ls;
        public PhoneBook1()
        {
            ls = new List<Contact1>();
            try
            {
                FileStream f = new FileStream("E:\\PhoneBook.txt", FileMode.Open);
                StreamReader rd = new StreamReader(f, Encoding.UTF8);
                string line;
                n = int.Parse(rd.ReadLine());//đọc từng dòng dữ liệu từ file              
                // doc du lieu tu file
                while ((line = rd.ReadLine()) != null)
                {
                    string name = line;
                    string phone_num = rd.ReadLine();
                    Contact1 c = new Contact1(name, phone_num);
                    ls.Add(c);
                }
            }
            catch
            { Console.WriteLine("Khong the doc file da cho: "); }
        }
        //thêm đối tượng vào vị trí pos
        public void InSert(Contact1 c, byte pos)
        {
            ls.Insert(pos, c);
        }
        //xóa đối tượng Contact đầu tiên có name truyền vào
        public void Remove(string name)
        {
            int i = 0;
            for (i = 0; i < n; i++)
                if (String.Compare(ls[i].Name, name) == 0)
                {
                    break;
                }
            if (i < ls.Count)//có người tên name trong danh bạ
                ls.RemoveAt(i);
        }
        //Cập nhật
        public void Update(string name, string phonenew)
        {
            for (int i = 0; i < n; i++)
                if (String.Compare(ls[i].Name, name) == 0)
                {
                    ls[i].Num = phonenew;
                }
        }
        //sắp xếp qua phương thức của interface
        public void Sort()
        {
            ls.Sort();
        }
        //xuất danh bạ
        public void Output()
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(ls[i].ToString());
            //  c.Output();            
        }
    }
    //lớp PhoneBook sử dụng filestream
    class PhoneBook2
    {
        int n;
        List<Contact1> ls;
        public PhoneBook2()
        {
            ls = new List<Contact1>();
            //đọc dữ liệu từ file đưa vào ls, mỗi giá trị của thuộc tính lưu trên 1 dòng trong file
            try
            {
                FileStream f = new FileStream("E:\\PhoneBook.txt", FileMode.Open);
                StreamReader rd = new StreamReader(f, Encoding.UTF8);
                string line;
                n = int.Parse(rd.ReadLine());//đọc từng dòng dữ liệu từ file              
                // doc du lieu tu file
                while ((line = rd.ReadLine()) != null)
                {
                    string name = line;
                    string phone_num = rd.ReadLine();
                    Contact1 c = new Contact1(name, phone_num);
                    ls.Add(c);
                }
            }
            catch
            { Console.WriteLine("Khong the doc file da cho: "); }


        }
        //thêm đối tượng vào vị trí pos
        public void InSert(Contact1 c, byte pos)
        {
            ls.Insert(pos, c);
        }
        //xóa đối tượng Contact đầu tiên có name truyền vào
        public void Remove(string name)
        {
            int i = 0;
            for (i = 0; i < n; i++)
                if (String.Compare(ls[i].Name, name) == 0)
                {
                    break;
                }
            if (i < ls.Count)
                ls.RemoveAt(i);
        }
        //Cập nhật
        public void Update(string name, string phonenew)
        {
            for (int i = 0; i < n; i++)
                if (String.Compare(ls[i].Name, name) == 0)
                {
                    ls[i].Num = phonenew;
                }
        }
        //sắp xếp qua phương thức của interface
        public void Sort()
        {
            ls.Sort();
        }
        //xuất danh bạ
        public void Output()
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(ls[i].ToString());
            //  ls[i].Output();            
        }
    }

}
