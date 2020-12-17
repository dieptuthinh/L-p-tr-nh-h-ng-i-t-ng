using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4._1
{
    // Cách 1
    /*class Person
    {
        protected string id, name;
        protected bool male;
        //phương thức thiết lập
        public Person()
        { id = ""; name = ""; male = true; }

        public Person(string i, string n, bool m)
        { id = i; name = n; male = m; }
        public Person(Person p)
        { id = p.id; name = p.name; male = p.male; }

        public void Input()
        {
            Console.Write("nhap ma so:");
            id = Console.ReadLine();
            Console.Write("nhap ho ten:");
            name = Console.ReadLine();
            Console.Write("nhap gioi tinh:");
            male = Convert.ToBoolean(Console.ReadLine());
        }

        //phương thức ảo tính lương
        public virtual float Salary()
        { return 0; }

        public void Output()
        {
            Console.WriteLine("{0}\t{1}\t{2}", id, name, Salary());
        }
    }
    class Employee : Person
    {
        byte days;
        float m_salary;
        public Employee() : base()
        { days = 26; m_salary = 4.5f; }

        public Employee(string i, string n, bool m, byte d, float s) : base(i, n, m)
        { days = d; m_salary = s; }
        public Employee(Employee e) : base((Person)e)
        { days = e.days; m_salary = e.m_salary; }
        //phương thức nhập
        public new void Input()
        {
            base.Input();//phương thức Input của lớp cơ sở là lớp Person            
            Console.Write("nhap so ngay cong:");
            days = Convert.ToByte(Console.ReadLine());
            Console.Write("nhap luong thang:");
            m_salary = float.Parse(Console.ReadLine());
        }

        public override float Salary() //tính lương 
        { return days * m_salary / 26; }

    }
    class Teacher : Person
    {
        byte hours;
        float h_salary;
        public Teacher() : base()
        { hours = 30; h_salary = 100; }
        public Teacher(string i, string n, bool m, byte h, float s) : base(i, n, m)
        { hours = h; h_salary = s; }
        public override float Salary() //tính lương 
        { return hours * h_salary; }

    }*/
}

