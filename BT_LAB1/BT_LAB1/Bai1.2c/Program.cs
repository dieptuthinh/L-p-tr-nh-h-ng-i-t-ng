using System;

namespace Bai1._2c
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Nhập vào A: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào B: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào C: ");
            float c = float.Parse(Console.ReadLine());

            float delta = (b / 2) * (b / 2) - a * c;

            Console.WriteLine("Phương trình nhập vào là:\n {0}x*x + {1}x + {2} = 0", a, b, c);

            Console.WriteLine("Delta phẩy = {0}", delta);

            if (delta < 0)
            {
                Console.WriteLine("Chương trình vô nghiệm");
            }
            else if (delta == 0)
            {
                float x = (-b / 2) / a;
                Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = {0}", x);
            }
            else
            {
                double x1 = 0;
                double x2 = 0;

                x1 = ((-b / 2) - Math.Sqrt(delta)) / a;
                x2 = ((-b / 2) + Math.Sqrt(delta)) / a;

                Console.WriteLine("Phương trình có 2 nghiệm phân biệt: ");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }


            /*            switch (delta < 0)
                        {
                            case true:
                                Console.WriteLine("Chương trình vô nghiệm");
                                break;
                            case false:
                                switch (delta == 0)
                                {
                                    case true:
                                        float x = (-b / 2) / a;
                                        Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = {0}", x);
                                        break;
                                    default:
                                        double x1 = 0;
                                        double x2 = 0;

                                        x1 = ((-b / 2) - Math.Sqrt(delta)) / a;
                                        x2 = ((-b / 2) + Math.Sqrt(delta)) / a;

                                        Console.WriteLine("Phương trình có 2 nghiệm phân biệt: ");
                                        Console.WriteLine("x1 = {0}", x1);
                                        Console.WriteLine("x2 = {0}", x2);
                                        break;
                                }
                                break;
                        }*/

            Console.ReadKey();
        }
    }
}
