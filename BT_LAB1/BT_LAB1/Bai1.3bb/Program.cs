using System;

namespace Bai1._3bb
{
    class Calculator
    {
        private  string op;

        public Calculator(string op)
        {
            this.op = op;
        }

        public  double DoOperation(double? a, double? b, double? c)
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.
            double Pi = 3.14;

            // Use a switch statement to do the math.
            switch (op)
            {
                case "1":
                    result = (double)(Pi * (a * a));
                    break;
                case "2":
                    result = (double)(a * b);
                    break;
                case "3":
                    result = (double)(a + b + c);
                    break;
                default:
                    break;
            }
            return result;
        }

        public double nhapDuLieu(string s)
        {
            Console.Write(s);
            string a = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(a, out cleanNum1))
            {
                Console.Write("không hợp lệ xin hãy nhập sô nguyên: ");
                a = Console.ReadLine();
            }
            return cleanNum1;
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool endApp = false;
            Console.WriteLine("Chương trình có các lựa chọn để tính diện tích\r");
            Console.WriteLine("----------------------------------------------\n");

            while (!endApp)
            {

                Console.WriteLine("1: tinh dien tich hinh tron");
                Console.WriteLine("2: tinh dien tich hinh hinh chu nhat");
                Console.WriteLine("3: tinh chu vi tam giac");
                Console.Write("nhap lua chon cua  ban(1|2|3): ");

                string op = Console.ReadLine();
                Calculator calculator = new Calculator(op);

            

                double a ;
                double b ;
                double c;
                
                double result = 0;

                // Ask the user to type the first number.
                if (op == "1")
                {
                    a = calculator.nhapDuLieu("bán kính của hình tròn: ");
                    result = calculator.DoOperation(a, null, null);
                }

                else if(op == "2")
                {
                    a = calculator.nhapDuLieu("chiều rộng: ");
                    b = calculator.nhapDuLieu("chiều dài: ");
                    result = calculator.DoOperation(a, b, null);
                }
                //

                else if(op=="3")
                {
                    a = calculator.nhapDuLieu("cạnh a: ");
                    b = calculator.nhapDuLieu("cạnh b: ");
                    c = calculator.nhapDuLieu("cạnh c: ");
                    result = calculator.DoOperation(a, b, c);
                }



                Console.WriteLine("Your result: {0:0.##}\n", result);

                Console.Write("nhấn 'n' và enter để kết thúc ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;

        }
    }
}
