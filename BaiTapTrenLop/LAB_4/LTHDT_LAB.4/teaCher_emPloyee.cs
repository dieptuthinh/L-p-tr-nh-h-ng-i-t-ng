using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_LAB._4
{
    class teaCher_emPloyee //lớp cơ sở
    {
        string id, name;
        bool gt;
        public teaCher_emPloyee() //không tham số
        {
            name = "";
            id = "";
            gt = true;
        }
        public teaCher_emPloyee(string id, string name, bool gt) //-Có tham số
        {
            this.id = id;
            this.name = name;
            this.gt = gt;
        }
        //-Khởi tạo sao chép
        public teaCher_emPloyee(teaCher_emPloyee p)
        {
            id = p.id;
            name = p.name;
            gt = p.gt;
        }
        //----------------------------------------------------------------------------

        public void nhapNV()    //Nhập cán bộ nhân viên
        {
            Console.Write("Nhập họ tên: ");
            name = Console.ReadLine();
            Console.Write("Nhập id: ");
            id = Console.ReadLine();
            Console.Write("Nhập giới tính ( Nam : true || Nữ : false ): ");
            while (bool.TryParse(Console.ReadLine(), out gt) == false)
                Console.Write("Mời nhập lại giới tính chỉ có true / false: ");

        }
        public void Xuat()//hàm xuất
        {
            Console.Write("Họ tên: " + name + "\nMã số: " + id + "\nTiền lương:{0} ", tienluong());
        }
        //- TÍNH ĐA HÌNH ĐỘNG C1
        public virtual float tienluong() //tính lương
        {
            return 0;
        }
    }
        //----------Tính kế thừa và đa hình

       class Employee : teaCher_emPloyee //- nhan viên --- Tính kế thừa
        {
            byte so_ngay_cong;
            float luong_thang;
        
            //-khởi tạo không tham số
            public Employee() : base()
            { 
                so_ngay_cong = 0; 
                luong_thang = 0; 
            }
            //-Khởi tạo có tham số
            public Employee(string id, string name, bool gt, byte so_ngay_cong, float luong_thang) : base(id,name,gt)
            {
                this.so_ngay_cong = so_ngay_cong;
                this.luong_thang = luong_thang;
            }
            //- Khởi tạo sao chép
            public Employee(Employee e) : base((teaCher_emPloyee) e)
            { 
                so_ngay_cong = e.so_ngay_cong; 
                luong_thang = e.luong_thang; 
            }

            public new void nhapNV() //nhap số liệu để tính
            {
                base.nhapNV();
                Console.Write("nhap so ngay cong:");
                so_ngay_cong = Convert.ToByte(Console.ReadLine());
                Console.Write("nhap luong thang:");
                luong_thang = float.Parse(Console.ReadLine());
            }
            //tiền lương được tính: số ngày công * lương tháng/26
            //-TÍNH ĐA HÌNH ĐỘNG C1
            public override float tienluong()
            {
                return so_ngay_cong * ((float)(luong_thang / 26));
            }
            //TÍNH ĐA HÌNH TĨNH

        }
        //************************************************************************
        class Teacher :  teaCher_emPloyee //giáo viên------------- Tính kể thừa
        {
            short so_tiet;
            float thu_lao_1tiet;
            //-khởi tạo không tham số
            public Teacher() : base()
            {
                so_tiet = 0;
                thu_lao_1tiet = 0;
            }
            //-Khởi tạo có tham số
            public Teacher(string id, string name, bool gt, byte so_tiet, float thu_lao_1tiet) : base(id, name, gt)
            {
                this.thu_lao_1tiet = thu_lao_1tiet;
                this.so_tiet = so_tiet;
            }
            //- Khởi tạo sao chép
            public Teacher(Teacher e) : base((teaCher_emPloyee)e)
            {
                so_tiet = e.so_tiet;
                thu_lao_1tiet = e.thu_lao_1tiet;
            }
            public new void nhapNV() //nhap số liệu để tính
            {
                base.nhapNV();
                Console.Write("Nhập số tiết:");
                so_tiet = Convert.ToByte(Console.ReadLine());
                Console.Write("Nhập thù lao 1 tiết:");
                thu_lao_1tiet = float.Parse(Console.ReadLine());
            }
            //tiền lương được tính: số tiết * tiền thù lao 1 tiết.
            //-TÍNH ĐA HÌNH ĐỘNG C1
            public override float tienluong() //tính lương
            {
                return so_tiet * thu_lao_1tiet;
            }
            //TÍNH ĐA HÌNH TĨNH
            //public void Xuat(float s) //xuat luong > s
            //{  }
        }

    
}
