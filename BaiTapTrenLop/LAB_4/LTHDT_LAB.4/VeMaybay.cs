using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_LAB._4
{
    public class VeMaybay
    {
        public string ten_chuyen_bay;
        public byte ngay_bay;
        public int gia_ve;
        //-------------------
        public VeMaybay()
        {
            ten_chuyen_bay = "";
            ngay_bay = 0;
            gia_ve = 0;
        }
        //------------------------
        public VeMaybay(string ten_chuyen_bay, byte ngay_bay, int gia_ve)
        {
            this.ten_chuyen_bay = ten_chuyen_bay;
            this.ngay_bay = ngay_bay;
            this.gia_ve = gia_ve;
        }
        //---------------------------
        public void Nhap()
        {
            Console.Write("Nhập tên chuyến bay: ");
            ten_chuyen_bay = Console.ReadLine();
            Console.Write("Nhập ngày bay: ");
            while (byte.TryParse(Console.ReadLine(), out ngay_bay) == false)
                Console.Write("Nhập lại ngày bay, vì sai định dạng: ");
            Console.Write("Nhập giá vé: ");
            while (int.TryParse(Console.ReadLine(), out gia_ve) == false)
                Console.Write("Nhập lại giá vé, vì sai định dạng: ");
        }
        //----------------xuất
        public void Xuat()
        {
            Console.WriteLine("\nTên chuyến bay LÀ: "+ten_chuyen_bay+"\nNgày bay LÀ: "+ngay_bay+"\nGiá vé LÀ: "+gia_ve);

        }
        public int Getgiave()
        {
            return this.gia_ve;
        }


    }
}
