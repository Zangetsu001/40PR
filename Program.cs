using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        delegate double Operation(double a, double b);
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Operation sum = new Operation(Sum);
            Operation subtract = new Operation(Subtract);
            Operation multiply = new Operation(Multiply);
            Operation divide = new Operation(Divide);
            double num1 = 10;
            double num2 = 5;
            Console.WriteLine($"Сумма: {sum(num1, num2)}");
            Console.WriteLine($"Разность: {subtract(num1, num2)}");
            Console.WriteLine($"Произведение: {multiply(num1, num2)}");
            Console.WriteLine($"Деление: {divide(num1, num2)}");
            Console.Read();

        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }


        public static double Multiply(double a, double b)
        {
            return a * b;
        }


        public static double Divide(double a, double b)
        {

            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return 0;
            }
            return a / b;
        }
    }
}
