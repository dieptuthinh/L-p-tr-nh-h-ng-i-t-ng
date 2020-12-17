using System;
using System.Collections.Generic;
using System.Text;

namespace Sv_Lh
{
    class LopHoc
    {
        private string TenLop;
        private int SiSo;

        public void NhapTTLop()
        {
            Console.WriteLine("Nhập tên lớp: ");
            TenLop = Console.ReadLine();

            Console.WriteLine("Nhập Si số: ");
            SiSo = int.Parse(Console.ReadLine());
        }
    }
}
