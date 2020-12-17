using System;
using System.Text;

namespace Bai2._4
{
    class Adult
    {
        private string name;
        private double weigth, height;

/*        public Adult(string name1, double weigth1, double height1)
        {
            name = name1;
            weigth = weigth1;
            height = height1;
        }

        public void xuatBMI(string name2)
        {
            float BMI;
            Console.WriteLine("{0}\t{1}\t{2}", name, cao, nang);
            BMI = nang / (float)Math.Pow(cao, 2);
            Console.WriteLine("Chỉ số BMI của {0}: " + BMI.ToString("0.0"), name2);
            if (BMI < 18.5)
                Console.WriteLine("Tình trạng sức khỏe của {0}: Thiếu cân ==> {1} cần tăng cân", name2, name2);
            else if (BMI < 25)
                Console.WriteLine("Tình trạng sức khỏe của {0}: Bình thường", name2);
            else if (BMI < 30)
                Console.WriteLine("Tình trạng sức khỏe của {0}: Thừa cân ==> {1} cần giảm cân", name2, name2);
            else Console.WriteLine("Tình trạng sức khỏe của {0}: Béo phì ==> {1} cần giảm cân", name2, name2);
        }
*/
        public void nhapTT()
        {
            Console.Write("Nhập tên: ");
            name = Console.ReadLine();

/*            Console.Write("nhap gioi tinh:");
            male = Convert.ToBoolean(Console.ReadLine());*/

            Console.Write("Nhập cân nặng: ");
            weigth = double.Parse(Console.ReadLine());

            Console.Write("Nhap chiều cao: ");
            height = double.Parse(Console.ReadLine());
        }

        public double tinhBMI()
        {
            return (double)(weigth / (height * height));
        }

        public string XepLoai()
        {
            double them;
            double bmi = tinhBMI();
            if (bmi < 16)
            {
                them = (18.5-bmi)*(height*height);
                return "Gay do III \nbạn cần phải khám và áp dụng một chế độ dinh dưỡng tốt nhất để có thể tăng cân, đảm bảo sức khỏe\nbạn cần phải tăng thêm  " + them+ "kg";
            }
            if (16 <= bmi && bmi <= 17)
            {
                them = (18.5 - bmi) * (height * height);
                return "Gay do II\nbạn cần phải tăng thêm  " + them + "kg";
            }
            if (17 <= bmi && bmi <= 18.5)
            {
                them = (18.5 - bmi) * (height * height);
                return "Gầy độ I\nbạn cần phải tăng thêm  " + them+ "kg";
            }
            if (18.5 <= bmi && bmi <= 25)
            {
                return "Bình thường \nBình thường, bạn có một cơ thể tốt và tương đối khỏe mạnh.";
            }
            if (25 <= bmi && bmi <= 30)
            {
                them = (bmi-25) * (height * height);
                return "Thừa cân \nThừa cân. Tình trạng thừa cân lúc này chưa quá trầm trọng nhưng bạn hãy tìm phương pháp và chế độ giảm cân để đưa cơ thể về vóc dáng cân đối, đảm bảo sức khỏe và phòng ngừa bệnh tật.\nBạn cần giảm " + them + "kg";
            }
            if (30 <= bmi && bmi <= 35)
            {
                them = (bmi - 25) * (height * height);
                return "Thừa cân I\nBạn cần giảm " + them + "kg";
            }
            if (35 <= bmi && bmi <= 40)
            {
                them = (bmi - 25) * (height * height);
                return "Thừa cân độ II\nBạn cần giảm " + them + "kg";
            }
            if (bmi > 40)
            {
                them = (bmi - 25) * (height * height);
                return "Thừa cân độ III \nỞ các cấp độ béo phì, cơ thể của bạn gặp khó khăn mỗi ngày khi trọng lượng mỡ tạo áp lực lên cơ xương. Từ đó, không chỉ sinh hoạt của bạn bị xáo trộn mà sức khỏe của bạn cũng bị ảnh hưởng rất nhiều.\nBạn cần giảm " + them + "kg";
            }
            return "Bạn đã nhập sai xin vui lòng nhập lại";
        }

        public void XuatTT()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Họ và tên: {0}\nCân nặng: {1}\nChiều cao: {2}",name,weigth,height);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Adult p1 = new Adult();
            p1.nhapTT();
            p1.XuatTT();
            Console.WriteLine("Chỉ số BMI: {1}\nXếp loại: {0}", p1.XepLoai(),(double)p1.tinhBMI());


/*            string name1; double cao1; float nang1;
            Console.Write("Nhập tên của Bạn: ");
            name1 = Console.ReadLine();
            Console.Write("Nhập chiều cao của Bạn(m): ");
            cao1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập cân nặng của Bạn: ");
            nang1 = float.Parse(Console.ReadLine());
            Console.WriteLine("***************************************");
            Console.WriteLine("Thông tin cua {0} la: ", name1);
            suckhoe thinh = new suckhoe(name1, cao1, nang1);
            thinh.xuatBMI(name1);*/
            //Adult thinh = new Adult(name1, cao1, nang1);

            Console.ReadKey();
        }
    }
}
