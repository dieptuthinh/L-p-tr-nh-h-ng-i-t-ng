using System;
using System.Collections.Generic;
using System.Text;

namespace Sv_Lh
{
    class SinhVien
    {
        private int MSSV , stc,stcKhoaHoc;
        private string HoTen;
        private int GioiTinh;// = double.TryParse(s1, out num);
        private float DTB;

        public void NhapTT()
        {
            Console.WriteLine("Nhập MSSV: ");
            MSSV = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập họ tên SV: ");
            HoTen = Console.ReadLine();

            Console.WriteLine("Nhập Giới Tính: ");
            GioiTinh = int.Parse(Console.ReadLine());


            Console.WriteLine("Nhập điểm trung bình tích luỹ: ");
            DTB = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập số tín chỉ tích luỹ: ");
            stc = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập Tổng số tín chỉ của khoá học: ");
            stcKhoaHoc = int.Parse(Console.ReadLine());
        }

        public void InTTSV()
        {
            Console.WriteLine("----------------------------------------\n Thông tin sinh viên: ")
            Console.WriteLine("MSSV: " + MSSV + "\nHọ và tên: " + HoTen );
            if (GioiTinh == 1)
            {
                Console.WriteLine("Giới tính: Nam");
            }
            else Console.WriteLine("Giới tính: Nữ");
            Console.WriteLine("Điểm tb: " + DTB + "\nSố tín chỉ tích luỹ: " + stc + "\nSố tín chỉ khoá học: " + stcKhoaHoc);
        }
    }
}
