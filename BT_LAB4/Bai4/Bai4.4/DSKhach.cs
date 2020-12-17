using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4._4
{
    class DSKhach
    {
        byte n;//số lượng hành khách
        HanhKhach[] dskhach;

        //phương thức thiết lập
        public DSKhach()
        {
            n = 3;
        }
        public DSKhach(byte so)
        {
            n = so;
            dskhach = new HanhKhach[n];

            //nhập vào n hành khách
            for (byte i = 0; i < n; i++)
            {
                dskhach[i] = new HanhKhach();
                dskhach[i].Nhap();
            }
        }
        //phương thức nhập SV tự viết
        public void NhapDS()
        {
            //nhập số khách
            //nhập n hành khách
        }
        //phương thức xuất SV tự viết

        //phương thức sắp xếp
/*        public void SapXep()
        {
            HanhKhach khach;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (dskhach[i].TongTien() < dskhach[j].TongTien())//tự sử dụng toán tử
                    {
                        khach = new HanhKhach();
                        khach = dskhach[i];
                        dskhach[i] = dskhach[j];
                        dskhach[j] = khach;
                    }
        }*/
    }

}

