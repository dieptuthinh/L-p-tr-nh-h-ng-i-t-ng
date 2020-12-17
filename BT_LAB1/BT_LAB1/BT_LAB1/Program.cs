using System;

namespace BT_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
/*            object[] A = new object[4];
            A[0] = "MSSV: 59132412";
            A[1] = "Diệp Tư Thịnh";
            A[2] = "Lớp: 59CNTT2";
            A[3] = "Giới tính: Nam";

            for(int i=0;i< A.GetLength(0);i++)
            {
                Console.WriteLine("{0} ", A[i]);
            }
            Console.ReadLine();*/

            string id, name, birthday, male;
            //Nhap du lieu
            Console.Write("Nhap mssv: ");
            id = Console.ReadLine();
            Console.Write("Ho ten sv: ");
            name = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            birthday = Console.ReadLine();
            Console.Write("gioi tinh :");
            male = Console.ReadLine();
            Console.Write("\nThong tin bạn vừa nhập là:\n"+"MSSV: "+ id +"\nTên SV: "+ name +"\nNgày sinh: "+ birthday +"\nGiới tính: "+male );
        }
    }
}
