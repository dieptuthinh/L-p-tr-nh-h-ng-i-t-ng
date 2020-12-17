using System;
using System.Text;

namespace Sv_Lh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            SinhVien sv1 = new SinhVien();
            sv1.NhapTT();
            sv1.InTTSV();
            
        }
    }
}
