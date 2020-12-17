using System;
using System.Text;

namespace Bai3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //Nhập giờ phút giây
            #region
            byte gio, phut, giay;
            Console.Write("Nhập giờ:  ");
            while (byte.TryParse(Console.ReadLine(), out gio)==false && gio < 0 || gio > 24)
                Console.Write("Nhập lại giờ: ");
            Console.Write("Nhập phút: ");
            phut = byte.Parse(Console.ReadLine());
            Console.Write("Nhập giây: ");
            giay = byte.Parse(Console.ReadLine());
            Time tg = new Time(gio,phut,giay);
            tg.Show24();
            tg++;
            Console.WriteLine("Giờ sau khi ++");
            tg.Show24();
            Time t1 = new Time(gio, phut, giay);
            t1.Show12();
            t1 = t1 + 75;
            Console.WriteLine("Giờ sau khi cộng: ");
            t1.Show12();
            #endregion
        }
    }
}
