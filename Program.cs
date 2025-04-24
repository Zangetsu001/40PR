using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        delegate double AverageDelegate(int m, int n);
        public static double Average(int m, int n)
        {
            if (m > n)
            {

                Console.WriteLine("Ошибка: a должно быть меньше или равно b.");
                return 0;
            }

            int sum = 0;
            int count = 0;


            for (int i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }
            return (double)sum / count;
        }
        static void Main(string[] args)
        {
            AverageDelegate averageDel = new AverageDelegate(Average);

          
            Console.WriteLine("Введите два числа для расчета среднего арифметического (m и n):");
            Console.Write("Введите a: ");
            int m1 = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int n1 = int.Parse(Console.ReadLine());

       
            double result1 = averageDel(m1, n1);
            Console.WriteLine($"Среднее арифметическое от {m1} до {n1}: {result1}");

            Console.WriteLine("\nВведите два числа для расчета среднего арифметического (m и n):");
            Console.Write("Введите a: ");
            int m2 = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int n2 = int.Parse(Console.ReadLine());


            double result2 = averageDel(m2, n2);
            Console.WriteLine($"Среднее арифметическое от {m2} до {n2}: {result2}");

       
            Console.WriteLine("\nВведите два числа для расчета среднего арифметического (a и b):");
            Console.Write("Введите a: ");
            int m3 = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int n3 = int.Parse(Console.ReadLine());


            double result3 = averageDel(m3, n3);
            Console.WriteLine($"Среднее арифметическое от {m3} до {n3}: {result3}");

            //AverageDelegate averageDel = new AverageDelegate(Average);

            //double result1 = averageDel(1, 5); 
            //Console.WriteLine($"Среднее арифметическое от 1 до 5: {result1}");

            //double result2 = averageDel(10, 20); 
            //Console.WriteLine($"Среднее арифметическое от 10 до 20: {result2}");

            //double result3 = averageDel(50, 100); 
            //Console.WriteLine($"Среднее арифметическое от 50 до 100: {result3}");

            Console.Read();
        }
    }
}
