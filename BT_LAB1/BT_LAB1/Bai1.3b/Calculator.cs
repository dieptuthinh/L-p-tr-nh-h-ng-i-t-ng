using System;

namespace Bai1._3b
{
    class Calculator
    {
        public static double DoOperation(double? a, double? b,double? c ,string op)
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.
            double Pi = 3.14;

            // Use a switch statement to do the math.
            switch (op)
            {
                case "1":
                    result = (double)(Pi *(a*a));
                    break;
                case "2":
                    result = (double)(a * b);
                    break;
                case "3":
                    result = (double)(a + b +c);
                    break;
                default:
                    break;
            }
            return result;
        }
    }

    class Run
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Chương trình có các lựa chọn để tính diện tích\r");
            Console.WriteLine("----------------------------------------------\n");

            while (!endApp)
            {
 
                Console.WriteLine("1: tinh dien tich hinh tron");
                Console.WriteLine("2: tinh dien tich hinh hinh chu nhat");
                Console.WriteLine("3: tinh chu vi tam giac");
                Console.Write("nhap lua chon cua  ban(1|2|3): ");

                string op = Console.ReadLine();


                string a = "";
                string b = "";
                string c = "";
                double result = 0;

                // Ask the user to type the first number.
                if (op == "1")
                {
                    Console.Write("nhập bán kính của hình tròn: ");
                    a = Console.ReadLine();

                    double cleanNum1 = 0;
                    while (!double.TryParse(a, out cleanNum1))
                    {
                        Console.Write("không hợp lệ xin hãy nhập sô nguyên: ");
                        a = Console.ReadLine();
                    }
                    result = Calculator.DoOperation(cleanNum1, null, null, op);
                }

                if (op == "2")
                {
                    Console.Write("nhập chiều dài: ");
                    a = Console.ReadLine();

                    double cleanNum1 = 0;
                    while (!double.TryParse(a, out cleanNum1))
                    {
                        Console.Write("không hợp lệ xin hãy nhập sô nguyên: ");
                        a = Console.ReadLine();
                    }
                    
                    // Ask the user to type the second number.
                    Console.Write("nhập chiều rộng hình chữ nhật: ");
                    b = Console.ReadLine();

                    double cleanNum2 = 0;
                    while (!double.TryParse(b, out cleanNum2))
                    {
                        Console.Write("không hợp lệ xin hãy nhập sô nguyên: ");
                        b = Console.ReadLine();
                    }
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, null, op);
                }
                //

                if (op == "3")
                {
                    Console.Write("nhập số a: ");
                    c = Console.ReadLine();

                    double cleanNum3 = 0;
                    while (!double.TryParse(c, out cleanNum3))
                    {
                        Console.Write("không hợp lệ xin hãy nhập sô nguyên: ");
                        c = Console.ReadLine();
                    }

                    Console.Write("nhập số b: ");
                    a = Console.ReadLine();

                    double cleanNum1 = 0;
                    while (!double.TryParse(a, out cleanNum1))
                    {
                        Console.Write("không hợp lệ xin hãy nhập sô nguyên: ");
                        a = Console.ReadLine();
                    }

                    // Ask the user to type the second number.
                    Console.Write("nhập số c: ");
                    b = Console.ReadLine();

                    double cleanNum2 = 0;
                    while (!double.TryParse(b, out cleanNum2))
                    {
                        Console.Write("không hợp lệ xin hãy nhập sô nguyên: ");
                        b = Console.ReadLine();
                    }
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, cleanNum3, op);
                }



                //try
                //{
                //    result = Calculator.DoOperation(cleanNum1, cleanNum2,cleanNum3 ,op);
                //    if (double.IsNaN(result))
                //    {
                //        Console.WriteLine(" error.\n");
                //    }    else 
                Console.WriteLine("Your result: {0:0.##}\n", result);
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine("error.\n - Details: " + e.Message);
                //}

                //Console.WriteLine("------------------------\n");

                //// Wait for the user to respond before closing.
                Console.Write("nhấn 'n' và enter để kết thúc ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
}
