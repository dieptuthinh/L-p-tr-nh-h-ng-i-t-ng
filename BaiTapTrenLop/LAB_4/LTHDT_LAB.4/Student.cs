using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_LAB._4
{
    class Student:People
    {
        string id;
        byte so_tin_chi_tichluy;
        float avg;
        // không tham số
        public Student():base()
        {
            id = "";
            avg = 0.0f;
            so_tin_chi_tichluy = 0;
        }
        // có tham số
        public Student(string name, string address, byte age, string id, byte so_tin_chi_tichluy, float avg):base(name,address,age)
        {
            this.avg = avg;
            this.id = id;
            this.so_tin_chi_tichluy = so_tin_chi_tichluy;
        }
        
        public new void Set()
        {
            base.Set();
            Console.Write("Nhập id: ");
            id = Console.ReadLine();
            Console.Write("Nhập điểm trung bình tích lũy: ");
            while (float.TryParse(Console.ReadLine(), out avg) == false)
                Console.Write("Nhập lại điểm: ");
            Console.Write("Nhập số tín chỉ tích lũy: ");
            while (byte.TryParse(Console.ReadLine(), out so_tin_chi_tichluy) == false)
                Console.Write("Nhập lại số tín chỉ: ");
        }
        public new void Get()
        {
            base.Get();     
            Console.Write("\nSố tín chỉ: " + so_tin_chi_tichluy + "\nĐiểm trung bình : " + avg + "\nID học sinh: " + id);
        }
        public void kt_totnghiep()
        {
            
            if (avg > 5.5 && so_tin_chi_tichluy >= 140)
                Console.WriteLine("\n\tĐược tốt nghiệp");
            else
                Console.WriteLine("\n\tChưa đủ điều kiện để tốt nghiệp");
        }
    }
}
