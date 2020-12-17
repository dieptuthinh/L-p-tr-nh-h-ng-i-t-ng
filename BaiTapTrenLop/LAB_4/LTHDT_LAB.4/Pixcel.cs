using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_LAB._4
{
    class Pixcel : Color
    {
     protected byte x, y;
        
        public Pixcel(): base()
        {
            x = 0;
            y = 0;
        }
        //-----------
        public Pixcel( byte x, byte y,byte mau): base(mau)
        {
            this.x = x;
            this.y = y;
        }
        //------------------
        //public void nhap()
        //{
        //    Console.Write("Nhập tọa độ x: ");
        //    byte x = byte.Parse(Console.ReadLine());
        //    Console.Write("Nhập tọa độ y: ");
        //    byte y = byte.Parse(Console.ReadLine());
        //}
        //-----------------------
        //-----------------------
        public void intpixel()
        {
            Console.ForegroundColor=(ConsoleColor)mau;
            Console.CursorTop = y;
            Console.CursorLeft = x;
            Console.Write("o");

        }
        public void Inds()
        {
            Console.WriteLine("{0},{1}", x, y);
        }
        public bool KTCheoChinh()
        {
            if (x == y)
           
                return true;
            else
                return false;
        }
        //--------------------
       
    }
    class npixel 
    {
        byte n;
        Pixcel[] ds;

        public npixel(){ n = 0; }
        public npixel( byte n1) 
        { 
            n = n1;
            ds = new Pixcel[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập tọa độ x: ");
                byte x = byte.Parse(Console.ReadLine());
                Console.Write("Nhập tọa độ y: ");
                byte y = byte.Parse(Console.ReadLine());
                Console.Write("Nhập màu từ 0->15: ");
                byte c = byte.Parse(Console.ReadLine());
                ds[i] = new Pixcel(x, y, c);
            }

        }

        //-------------------------
        public void Nhap()
        {
            byte c;
            Console.Write("Nhập số Pixcel: ");
            while ((byte.TryParse(Console.ReadLine(), out n) == false) || (n < 3 || n > 100))
                Console.Write("Nhập lại: ");
            ds = new Pixcel[n];
            for (int i = 0; i < n; i++)
            {
              
                Console.Write("Nhập tọa độ x: ");
                byte x = byte.Parse(Console.ReadLine());
                Console.Write("Nhập tọa độ y: ");
                byte y = byte.Parse(Console.ReadLine());
                Console.Write("Nhập màu từ 0->15: ");
                c = byte.Parse(Console.ReadLine());
                ds[i] = new Pixcel(x, y, c);
            }

        }
        //public void Inpixel()
        //{

        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.WriteLine("{0},{1}", x, y);
        //    }
        //}
        //---------------
        public void inNpixel()
        {
            
            foreach(Pixcel p in ds)
            {
                p.intpixel();
            }    
        }
        public void inNds()
        {

            foreach (Pixcel q in ds)
            {
                q.Inds();
            }
        }
        //-------------ĐẾm pixel thuộc dg chéo chính---------------
        public byte CountCheochinh()
        {
            byte dem = 0;
           
            foreach(Pixcel pi in ds)
                if (pi.KTCheoChinh() == true)
                    dem++;
            return dem;
        }
        
    }
}
