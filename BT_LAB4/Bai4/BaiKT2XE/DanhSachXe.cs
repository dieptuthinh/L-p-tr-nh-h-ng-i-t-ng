using System;
using System.Collections.Generic;
using System.Text;

namespace BaiKT2XE
{
    class DanhSachXe
    {
        byte n;
        XeCon[] dsXe;

        public DanhSachXe()
        {
            n = 0;
        }

        public void Nhap()
        {
            Console.Write("Nhập số xe con (0 < n < 50): ");
            while (byte.TryParse(Console.ReadLine(), out n) == false || n > 49 || n < 1)
            {
                Console.WriteLine("Nhập lại đi!!!");
            }

            dsXe = new XeCon[n];

            for (int i = 0; i < n; i++)
            {
                XeCon newXe = new XeCon();
                Console.WriteLine("\t\tNhập xe con: " + (i + 1));
                newXe.Nhap();
                dsXe[i] = newXe;
            }
        }

        public void In()
        {
            Console.WriteLine("\t\tThông tin in ra là: ");
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("\tXe con thứ: " + (i + 1));
                dsXe[i].Xuat();
                Console.WriteLine("\n------------------\n");
            }
        }

        public XeCon GiaThapNhat()
        {
            XeCon min = dsXe[0];
            foreach(XeCon xe in dsXe)
            {
                if(xe.Gia < min.Gia)
                {
                    min = xe;
                }
            }
            return min;
        }
        public XeCon GiaCaoNhat()
        {
            XeCon max = dsXe[0];
            foreach (XeCon xe in dsXe)
            {
                if (xe.Gia > max.Gia)
                {
                    max = xe;
                }
            }
            return max;
        }

        public void Xoa(String BienSo)
        {
            bool isDeleted = false;
            for(int i = 0; i < n; i++)
            {

                if(dsXe[i].BienSo.Equals(BienSo))
                {
                    for (int j = i; j < n - 1; j++)
                        dsXe[j] = dsXe[j + 1];
                    n--;
                    isDeleted = true;
                    break;
                }
            }
            if(!isDeleted)
            {
                Console.WriteLine("Không tìm thấy biển số xe này!!!");
            } else
            {
                Console.WriteLine("Đã xoá biển số xe: " + BienSo);
                this.In();
            }
            Console.ReadLine();
        }

        public void Tim(String BienSo)
        {
            foreach (XeCon xe in dsXe)
            {
                String temp = xe.BienSo.Substring(0, 2);
                if (temp.Equals(BienSo))
                {
                    xe.Xuat();
                }
            }
        }

        public void swap (ref XeCon a, ref XeCon b)
        {
            XeCon temp = a;
            a = b;
            b = temp;
        }
        public void SapXep()
        {
            for (int i = 0; i < n - 1; ++i)
                for (int j = 0; j < n - i - 1; ++j)
                    if (dsXe[j] > dsXe[j + 1])
                        swap(ref dsXe[j], ref dsXe[j + 1]);
        }
    }
}
