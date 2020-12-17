using System;

namespace HuongDoiTuong
{
    class HocSinh
    {
        private string HoTen;
        private int GioiTinh;
        private double DiemToan, DiemLy, DiemHoa;

        //khai bao phuong thuc
        public void NhapHocSinh()
        {
            Console.Write("\nNhap vao ho ten: ");
            HoTen = Console.ReadLine();

            Console.WriteLine("--------------Nhap vao gioi tinh------------");
            Console.WriteLine("1. Nam");
            Console.WriteLine("2. Nu");
            Console.WriteLine("3. Gay");
            Console.WriteLine("4. Less");

            /*            do
                        {
                            Console.WriteLine("Nhap vao gioi tinh");
                            GioiTinh = int.Parse(Console.ReadLine());

                            if (GioiTinh < 1 || GioiTinh > 4)
                            {
                                Console.WriteLine("Gioi tinh khong hop le. xin nhap lai");
                            }
                        } while (GioiTinh < 1 || GioiTinh > 4);*/


            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap vao gioi tinh");
                    GioiTinh = int.Parse(Console.ReadLine());
                    if (GioiTinh < 1 || GioiTinh > 4)
                    {
                        Console.WriteLine("Gioi tinh khong hop le. xin nhap lai");
                    }
                    else break;
                }
                catch
                {
                    Console.WriteLine("Kieu du lieu khong hop le. xin nhap lai");
                }
            }


            do
            {
                Console.WriteLine("Nhap vao diem toan: ");
                DiemToan = double.Parse(Console.ReadLine());

                if (DiemToan < 0 || DiemToan > 10)
                {
                    Console.WriteLine("Khong hop le. Xin nhap lai");
                }
            } while (DiemToan < 0 || DiemToan > 10);

            do
            {
                Console.WriteLine("Nhap vao diem Ly: ");
                DiemLy = double.Parse(Console.ReadLine());

                if (DiemLy < 0 || DiemLy > 10)
                {
                    Console.WriteLine("Khong hop le. Xin nhap lai");
                }
            } while (DiemLy < 0 || DiemLy > 10);

            do
            {
                Console.WriteLine("Nhap vao diem hoa: ");
                DiemHoa = double.Parse(Console.ReadLine());

                if (DiemHoa < 0 || DiemHoa > 10)
                {
                    Console.WriteLine("Khong hop le. Xin nhap lai");
                }
            } while (DiemHoa < 0 || DiemHoa > 10);
        }

        public void XuatHocSinh()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("HoTen: " + HoTen);
            //Console.WriteLine("HoTen: {0}", HoTen);

            Console.Write("Gioi Tinh: ");
            if (GioiTinh == 1)
            {
                Console.WriteLine("Nam");
            }
            else if (GioiTinh == 2)
            {
                Console.WriteLine("Nu");
            }
            else if (GioiTinh == 3)
            {
                Console.WriteLine("Gay");
            }
            else if (GioiTinh == 4)
            {
                Console.WriteLine("Less");
            }

            Console.WriteLine("Diem Toan: {0}", DiemToan);
            Console.WriteLine("Diem Ly: {0}", DiemLy);
            Console.WriteLine("Diem Hoa: {0}", DiemHoa);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("=> Diem trung binh la: {0}", TinhDiemTB());
        }

        public double TinhDiemTB()
        {
            return (DiemToan + DiemHoa + DiemLy) / 3;
        }

        public string XepLoai()
        {
            double dtb = TinhDiemTB();
            if (dtb < 5)
            {
                return "Kem";
            }
            if (dtb < 7)
            {
                return "Trung binh";
            }
            if (dtb < 8)
            {
                return "Kha";
            }
            if (dtb < 9)
            {
                return "Gioi";
            }
            return "Xuat sac";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HocSinh hs = new HocSinh();
            hs.NhapHocSinh();
            hs.XuatHocSinh();
            Console.WriteLine("Xep loai: {0}", hs.XepLoai());
            Console.ReadKey();
        }
    }
}
