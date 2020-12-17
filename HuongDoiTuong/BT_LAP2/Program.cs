using System;
using System.Text;

namespace BT_LAP2
{
    class suckhoe
    {

        string name;
        double cao;
        float nang;
        public suckhoe(string name1, double cao1, float nang1)
        {
            name = name1;
            cao = cao1;
            nang = nang1;
        }
        public void xuatBMI(string name2)
        {
            float BMI;
            Console.WriteLine("{0}\t{1}\t{2}", name, cao, nang);
            BMI = nang / (float)Math.Pow(cao, 2);
            Console.WriteLine("Chỉ số BMI của {0}: " + BMI.ToString("0.0"), name2);
            if (BMI < 18.5)
                Console.WriteLine("Tình trạng sức khỏe của {0}: Thiếu cân ==> {1} cần tăng cân", name2, name2);
            else if (BMI < 25)
                Console.WriteLine("Tình trạng sức khỏe của {0}: Bình thường", name2);
            else if (BMI < 30)
                Console.WriteLine("Tình trạng sức khỏe của {0}: Thừa cân ==> {1} cần giảm cân", name2, name2);
            else Console.WriteLine("Tình trạng sức khỏe của {0}: Béo phì ==> {1} cần giảm cân", name2, name2);


        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //Console.InputEncoding = Encoding.Unicode;
            /*short a1, b1;
            Console.WriteLine("nhap a: ");
            while (Int16.TryParse(Console.ReadLine(), out a1) == false) 
            Console.WriteLine("nhap lai a!");
            Console.WriteLine("nhap b: ");
            while (Int16.TryParse(Console.ReadLine(), out b1) == false) 
            Console.WriteLine("nhap lai b!");
            ptb1 pt = new ptb1(2,3);
            pt.giai();*/
            //*******************************************
            /*mang ma = new mang() ;
            ma.nhap();
            ma.xuat();
            Console.WriteLine("\ntbc cua cac so tren tbc={0} ", ma.tbc());
            ma.sxt();
            ma.xuat();*/
            //*********************************************
            string name1; double cao1; float nang1;
            Console.Write("Nhập tên của Bạn: ");
            name1 = Console.ReadLine();
            Console.Write("Nhập chiều cao của Bạn(m): ");
            cao1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập cân nặng của Bạn: ");
            nang1 = float.Parse(Console.ReadLine());
            Console.WriteLine("***************************************");
            Console.WriteLine("Thông tin cua {0} la: ", name1);
            suckhoe thinh = new suckhoe(name1, cao1, nang1);
            thinh.xuatBMI(name1);
            Console.ReadKey();
        }
    }
}
