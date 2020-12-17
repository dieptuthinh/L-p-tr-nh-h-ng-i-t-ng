using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_LAB3
{
    class Hocphan
    {
        //Các thuộc tính: mã học phần, tên học phần, số đơn vị học trình(sotc), loại học
        //phần(lý thuyết hay thực hành), học phí 1 tín chỉ dùng chung cho tất cả các đối
        //tượng với giá trị khởi tạo là 300
        string ma_hoc_phan;
        string ten_hoc_phan;
        bool loai_hoc_phan;
        byte so_tin_chi;
        int hocphi1tc;

        public byte So_tin_chi { get => so_tin_chi; set => so_tin_chi = value; }
        public bool Loai_hoc_phan { get => loai_hoc_phan; set => loai_hoc_phan = value; }
        



        //-------------------------
        public Hocphan()
        {
            ma_hoc_phan = "";
            ten_hoc_phan = "";
            loai_hoc_phan = true;
            hocphi1tc = 300;
        }
        //-----------------------------
        public Hocphan(string m, string t, bool l, byte h)
        {
            ma_hoc_phan = m;
            ten_hoc_phan = t;
            loai_hoc_phan = l;
            so_tin_chi = h;
            hocphi1tc = 300;
        }

        //Nhập thông tin học phần
        #region
        public void Nhapthongtinhp()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập mã học phần: ");//nhập mã học phần
            ma_hoc_phan = Console.ReadLine();
            Console.Write("Nhập tên học phần: ");//nhập tên học phần
            ten_hoc_phan = Console.ReadLine();
            Console.Write("Nhập số tín chỉ tối đa là 3 tín chỉ: ");
            while (byte.TryParse(Console.ReadLine(), out so_tin_chi) == false && so_tin_chi < 0 || so_tin_chi > 3)
                Console.Write("Số tín chỉ nhập sai. Hãy nhập lại: ");
            Console.Write("Nhập loại học phần (true = Thực Hành||false = Lý thyết): ");//loại học phần
            while (bool.TryParse(Console.ReadLine(), out loai_hoc_phan) == false)
                Console.WriteLine("Nhập lại: ");

        }
        #endregion
        //---------------------------------------------
        public void XuatThongtin()
        {
         
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine(" Mã học Phần: {0}\n Tên học phần: {1}\n Tiền học phí: {2}\n    ", ma_hoc_phan, ten_hoc_phan, this.Tinh_tien_hoc_phi());
        }
        //---------------------------------
        public double Tinh_tien_hoc_phi()//tính tiền học phí của môn theo loại học phần
        {
            if (loai_hoc_phan == true)
                return so_tin_chi * hocphi1tc * 1.5;
            else
                return so_tin_chi * hocphi1tc;
        }
        //---------------------------------------

    }
    
}
