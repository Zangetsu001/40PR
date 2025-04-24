using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        delegate void Message();//Обьявляем delegat

        static void Main(string[] args)
        {
            Message message;//Создаем обьект делегата и связываем
            if (DateTime.Now.Hour < 12)
                message = GoodMorning;
            else
                message = GoodEvening;
            message();
            Console.Read();

        }
        

            
        public static void GoodMorning()
        {
            Console.WriteLine("Доброе утро!");
        }
        public static void GoodEvening()
        {
            Console.WriteLine("Добрый вечер!");
        }
    }
}
