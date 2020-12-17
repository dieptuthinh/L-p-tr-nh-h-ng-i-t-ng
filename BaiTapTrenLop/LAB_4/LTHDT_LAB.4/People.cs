using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_LAB._4
{
    class People 
    {
        string name, address;
        byte age;
        
        //--Phương thức không tham số
        public People()
        {
            name = "";
            address = "";
            age = 0;
        }

        
        //---Phương thức có tham số
        public People(string name, string address, byte age)
        {
            this.name = name;
            this.address = address;
            this.age = age;
        }
        
//---------------------------------------
        public void Set()
        {
            
            Console.Write("Nhập họ tên: ");
            name = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            address = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            while (byte.TryParse(Console.ReadLine(), out age) == false)
                Console.Write("Nhập lại tuổi: ");
        }
        //-----------Xuất
        public void Get()
        {
            Console.Write("\nHọ tên: " + name + "\nĐịa chỉ: " + address + "\nTuổi: " + age);
        }
        
    }
}
