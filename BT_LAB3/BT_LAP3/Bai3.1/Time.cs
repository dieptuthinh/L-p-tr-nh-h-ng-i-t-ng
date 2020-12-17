using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3._1
{
    class Time
    {
        byte h, m, s;
        //-----------------------------------
        public Time()
        {
            h = 0;
            m = 0;
            s = 0;
        }
        //-------------------------------
        public Time(byte gio, byte phut, byte giay)
        {
            h = gio;
            m = phut;
            s = giay;
        }
        //---------------------------------------------
        //
        public void Show24()//Hàm hiển thị thời gian theo định dạng 24 giờ
        {
            Console.WriteLine("{0}:{1}:{2}", h, m, s);
        }
        public void Show12()//Hàm hiển thị thời gian theo định dạng 12 giờ
        {
            if (h >= 12)
                h -= 12;
            Console.WriteLine("{0}:{1}:{2}", h, m, s);
        }
        //---------------------------------
        public static Time operator +(Time t, byte n)
        {
            Time kq = new Time();
            kq.s = t.s;
            kq.m = (byte)((t.m + n) % 60);
            kq.h = (byte)((t.h + (t.m + n) / 60));

            if (kq.h >= 24)
                kq.h = (byte)(kq.h - 24);
            return kq;
        }
        //-------------hiển thị thời gian 12 giờ
        public static Time operator ++(Time t)
        {
            Time kq = new Time();
            kq.s = (byte)((t.s + 1) % 60);
            kq.m = (byte)((t.m + ((t.s + 1) / 60)) % 60);
            kq.h = (byte)(t.h + (t.m + (t.s + 1)) / 60);
            return kq;
        }
    }
}
