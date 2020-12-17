using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4._4
{
    class VeMB
    {
        public string ten_chuyen_bay;
        public byte ngay_bay;
        public int gia_ve;
        //public short Gia { get => gia; set => gia = value; }
        //phương thức khởỉ tạo
        public VeMB()
        {
            ten_chuyen_bay = "";
            ngay_bay = 0;
            gia_ve = 0;
        }
        public VeMB(string ten_chuyen_bay, byte ngay_bay, int gia_ve)
        {
            this.ten_chuyen_bay = ten_chuyen_bay;
            this.ngay_bay = ngay_bay;
            this.gia_ve = gia_ve;
        }

        //SV tự viết phương thức nhập
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




        //phương thức xuất thông tin vé
        public void Xuat()
        {
            Console.WriteLine("\nTên chuyến bay LÀ: " + ten_chuyen_bay + "\nNgày bay LÀ: " + ngay_bay + "\nGiá vé LÀ: " + gia_ve);

        }
        public int Getgiave()
        {
            return this.gia_ve;
        }

    }
}
