using System;

namespace Bai5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap danh ba dien thoai:");
            PhoneBook ls = new PhoneBook(2);

            //nhập thông tin đối tượng cần thêm
            Console.Write("nhap name, phone can them:");
            string name = Console.ReadLine();
            string phone_num = Console.ReadLine();
            Contact c = new Contact(name, phone_num);
            Console.Write("nhap vi tri can them:");
            byte i = byte.Parse(Console.ReadLine());//SV tự kiểm tra ràng buộc giá trị
            ls.InSert(c, i);

            ////xóa phần tử có name đầu tiên
            Console.Write("nhap name can xoa:");
            string name1 = Console.ReadLine();
            ls.Remove(name1);

            ////nhập thông tin đối tượng cần cập nhật
            //Console.Write("nhap name, phone can cap nhat:");
            //string name = Console.ReadLine();
            //string phone_new = Console.ReadLine();
            //ls.Update(name, phone_new);

            ls.Sort();
            ls.Output();
            Console.ReadKey();

        }
    }
}
