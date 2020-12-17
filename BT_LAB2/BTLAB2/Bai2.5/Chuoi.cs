using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2._5
{
    class Chuoi
    {
        string st;
        int col, row;

        public Chuoi()
        {
            st = "Hello Everyone!";
            col = 3; row = 4;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public Chuoi(string s1 = "Hello Everyone!", int c = 0, int r = 0)
        {
            st = s1; col = c; row = r;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void HienThi()
        {
            Console.Clear();//xóa màn hình
            Console.CursorVisible = false;//ẩn con trỏ chuột
            Console.CursorTop = row;//đưa con trỏ tới row, col
            Console.CursorLeft = col;
            Console.Write(st);//viết chuỗi ra màn hình
        }
        public void ChuyenDong()
        {
            HienThi();
            while (true)
            {
                ConsoleKeyInfo phim = Console.ReadKey(true);
                if (phim.Key == ConsoleKey.Escape)
                    break;
                if (phim.Key == ConsoleKey.LeftArrow)
                    col--;
                else if (phim.Key == ConsoleKey.RightArrow)
                    col++;
                else if (phim.Key == ConsoleKey.UpArrow)
                    row--;
                else if (phim.Key == ConsoleKey.DownArrow)
                    row++;

                //xử lý biên
                if (col <= 0)
                    col = Console.WindowWidth;
                if (col >= Console.WindowWidth)
                    col = 0;
                if (row <= 0)
                    row = Console.WindowHeight;
                if (row >= Console.WindowHeight)
                    row = 0;
                HienThi();
            }
        }

    }
}
