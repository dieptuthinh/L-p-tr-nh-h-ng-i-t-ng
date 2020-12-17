using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5._1
{
    class PhoneBook
    {
        //Thuộc tính: n số Contact trong danh bạ điện thoại, 
        int n;
        //danh sách các Contact
        Contact[] ds;

        //thiết lập không tham số
        public PhoneBook()
        {
            n = 0;
        }

        //có tham số;
        public PhoneBook(int n1)
        {
            n = n1;
            ds = new Contact[n + 1];
            //nhập n Contact
            for (int i = 0; i < n; i++)
            {
                Console.Write("nhap name, phone_num:");
                string name = Console.ReadLine();
                string phone_num = Console.ReadLine();
                ds[i] = new Contact(name, phone_num);
            }
        }
        //thêm đối tượng vào vị trí pos
        // phương thức Insert(Contact c, byte i) để thêm một đối tượng Contact vào vị trí thứ i của danh sách;
        public void InSert(Contact c, byte pos)
        {
            int i = n;
            ds[n] = new Contact();
            for (i = n; i > pos; i--)
                ds[i] = ds[i - 1];
            ds[i] = c;
            n++;
        }
        //xóa đối tượng Contact đầu tiên có name truyền vào
        //phương thức Remove(string name1) để xóa một Contact đầu tiên có name bằng với tham số truyền vào name1;
        public void Remove(string name)
        {
            for (int i = 0; i < n; i++)
                if (String.Compare(ds[i].Name, name) == 0)
                {
                    for (int j = i; j < n - 1; j++)
                        ds[j] = ds[j + 1];
                    n--;
                    break;
                }
        }
        //Cập nhật
        // phương thức Update(string name1, string num_new) để cập nhật một Contact có name bằng với tham số truyền vào name1 số điện thoại mới là num_new;
        public void Update(string name, string phonenew)
        {
            for (int i = 0; i < n; i++)
                if (String.Compare(ds[i].Name, name) == 0)
                {
                    ds[i].Num = phonenew;
                }
        }
        //sắp xếp bằng thuật toán bubble sort
        //phương thức Sort() để sắp xếp theo chiều tăng dần của thuộc tính name; 
        public void Sort()
        {
            Contact c = new Contact();
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (ds[i] > ds[j])
                    {
                        Console.WriteLine("T");
                        c = ds[i];
                        ds[i] = ds[j];
                        ds[j] = c;
                    }
        }
        //Phương thức Output() để in danh sách các Contact ra màn hình.
        public void Output()
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(ds[i].ToString());
            //  ds[i].Output();            
        }
    }

}

