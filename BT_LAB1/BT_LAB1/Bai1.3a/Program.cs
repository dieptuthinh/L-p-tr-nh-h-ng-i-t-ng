using System;

namespace Bai1._3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\nnhập vào ký tự: ");
                string kytu = Console.ReadLine();
                switch (kytu)
                {
                case "a":
                    Console.WriteLine("Nguyên âm");

                    break;

                case "e":
                    Console.WriteLine("Nguyên âm");

                    break;


                case "i":
                    Console.WriteLine("Nguyên âm");

                    break;

                case "o":
                    Console.WriteLine("Nguyên âm");

                    break;

                case "u":
                    Console.WriteLine("Nguyên âm");

                    break;

                default:
                    Console.WriteLine("phụ âm");

                    break;
            }    
 
        }
    }
}
