using System;

namespace Bai4._3
{
    class Color
    {
        protected byte color;

        public Color()
        {
            color = 14;//màu vàng
        }
        public Color(byte c)
        {
            color = c;
        }
    }
    //lớp pixcel
    class Pixcel : Color
    {
        byte x, y;//tọa độ của điểm
        public Pixcel() : base()
        {
            x = 3; y = 5;
        }
        public Pixcel(byte x, byte y, byte c) : base(c)
        {
            this.x = x; this.y = y;
        }
        //in pixcel tai vị trí x,y với màu color
        public void Out_Pixcel()
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.CursorTop = y;
            Console.CursorLeft = x;
            Console.Write("o");
        }
        //kiểm tra pixcel có nằm trên đường chéo chính không
        public bool Check_Pixcel()
        {
            return x == y;
        }
    }
    //lớp n pixcel
    class NPixcel
    {
        byte n;//số lượng pixcel
        Pixcel[] ds;
        //phương thức thiết lập để nhập vào n pixcel
        public NPixcel() { n = 0; }
        public NPixcel(byte sl)
        {
            n = sl;
            ds = new Pixcel[n];
            //nhập vào n pixcel
            for (byte i = 0; i < n; i++)
            {
                Console.Write("nhap toa do cua pixcel (x,y):");
                byte x = byte.Parse(Console.ReadLine());
                byte y = byte.Parse(Console.ReadLine());
                Console.Write("nhap mau cua pixcel [0,15]:");
                byte c = byte.Parse(Console.ReadLine());
                ds[i] = new Pixcel(x, y, c);//tạo ra đối tượng pixcel thứ i
            }
        }
        //phương thức nhập n pixcel
        public void Nhap()
        {
            Console.Write("nhap so pixcel:");
            n = byte.Parse(Console.ReadLine());
            ds = new Pixcel[n];
            for (byte i = 0; i < n; i++)
            {
                Console.Write("nhap toa do cua pixcel (x,y):");
                byte x = byte.Parse(Console.ReadLine());
                byte y = byte.Parse(Console.ReadLine());
                Console.Write("nhap mau cua pixcel [0,15]:");
                byte c = byte.Parse(Console.ReadLine());
                ds[i] = new Pixcel(x, y, c);//tạo ra đối tượng pixcel thứ i
            }
        }
        //xuất n pixcel ra màn hình
        public void Out_NPixcel()
        {
            foreach (Pixcel p in ds)
                p.Out_Pixcel();
        }
        //đếm số pixcel nằm trên đường chéo chính
        public byte Count_Pixcel()
        {
            byte count = 0;
            foreach (Pixcel p in ds)
                if (p.Check_Pixcel())
                    count++;
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region BT4_3
            //nhập vào số n, sau đó đưa vào là tham số của phương thức thiết lập NPixcel
            NPixcel ls = new NPixcel(4);
            //ls.Nhap();
            Console.Clear();//xóa màn hình
            ls.Out_NPixcel();
            Console.Write("\nSo pixcel tren duong cheo chinh la {0}", ls.Count_Pixcel());
            #endregion

        }
    }
}
