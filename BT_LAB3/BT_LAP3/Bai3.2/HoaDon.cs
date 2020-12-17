using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3._2
{
    class HoaDon
    {
        string ma_so_sinh_vien, ho_ten_sv;
        byte sohp;
        HocPhan[] list_hp;//Danh sách các học phần.

        public HoaDon()
        {
            ma_so_sinh_vien = "";
            ho_ten_sv = "";
            sohp = 0;
        }

        //---------------------------
        public HoaDon(string mssv, string hoten, byte so)
        {
            ma_so_sinh_vien = mssv;
            ho_ten_sv = hoten;
            sohp = so;
            
        }
        public void Nhapten()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập họ và tên: ");
            ho_ten_sv = Console.ReadLine();
            Console.Write("Nhập mã số sinh viên: ");
            ma_so_sinh_vien = Console.ReadLine();
        }
        //----------------------------------------
    
        public void NhapHoadon_hp()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập số học phần: ");

            while (byte.TryParse(Console.ReadLine(), out sohp) == false)
                Console.Write("Mời nhập lại số học phần đang học: ");
            list_hp = new HocPhan[sohp];
            for (int i = 0; i < sohp; i++)
            {
                Console.WriteLine("\n\t****** Nhập thông tin học phần {0} ******", i + 1);
                list_hp[i] = new HocPhan();
                list_hp[i].Nhapthongtinhp();
            }

        }
  
        public void xuat()
        {
            
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("\nHọ tên: {0}\nMã số sinh viên: {1}",ho_ten_sv,ma_so_sinh_vien);
            for (int i = 0; i <sohp ; i++)
            {
                Console.WriteLine("\n\t----------Thông tin học phần {0}----------",i+1);
                list_hp[i].XuatThongtin();
            }
        }
        //------------------------------------------------------------
        public byte Tinh_TH()
        {
            byte d = 0;
            foreach(HocPhan hp in list_hp)
            {
                if(hp.So_tin_chi > 0 && hp.Loai_hoc_phan==false)
                {
                    d += hp.So_tin_chi ;
                }    
            }
            return d;
        }

        //-------Danh sách các học phần đăng kí-----
    }
}
