using System;

namespace Bai1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;



            //Lập trình game kéo búa bao
            Console.WriteLine("<1>Bao - <2>Bua - <3>keo");
		play:
			Console.WriteLine("Mời bạn chọn: ");
			int a = Convert.ToInt32(Console.ReadLine());

            int b = new Random().Next(1, 3);
			switch (b)
            {
				case 1: Console.WriteLine("người chơi b chọn: bao");break;
				case 2: Console.WriteLine("Người chơi b chọn: búa");break;
				case 3: Console.WriteLine("Người chơi b chọn: kéo"); break;
			}
            switch (a)
            {
                case 1://bao
                    Console.WriteLine("Người chơi a chọn: bao");
                    if (b == 2)//bua
                        Console.WriteLine("Nguoi thang: a");
                    else if (b == 3)
                        Console.WriteLine("Nguoi thang: b");
                    else
                        Console.WriteLine("Hoa");
                    break;

                case 2://bua
                    Console.WriteLine("Người chơi a chọn: bua");
                    if (b == 1)//bao
                        Console.WriteLine("Nguoi thang: b");
                    else if (b == 3)
                        Console.WriteLine("Nguoi thang: a");
                    else
                        Console.WriteLine("Hoa");
                    break;

                case 3://keo
                    Console.WriteLine("Người chơi a chọn: keo");
                    if (b == 2)//bua
                        Console.WriteLine("Nguoi thang: b");
                    else if (b == 1)
                        Console.WriteLine("Nguoi thang: a");
                    else
                        Console.WriteLine("Hoa");
                    break;

                default:
                    Console.WriteLine("Nhap sai");
                    goto play;

            }

            Console.WriteLine("Bạn có muốn chơi tiếp không: 1(Yes) || 0(No) ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n==1)
                goto play;
            


        }
    }
}
