using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Labs
{
    class Program
    {
static void Main(string[] args)
        {
            Console.WriteLine("Task 4.1, 4.2, 4.1(Homework)");
            int day = 0;
            while (true)
            {
                Console.WriteLine("Введите число от 1 до 365");
                day = Convert.ToInt32(Console.ReadLine());
                if (day <= 365 && day > 0)
                    break;
                else
                    Console.Clear();
            }
            DateTime date = new DateTime(1, 1, 1);
            Console.WriteLine($"{day} соответствует: {date.AddDays(day - 1).ToString("dd MMMM")}");
            Console.WriteLine("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
                Console.WriteLine($"{year} год - високосный");
            else
                Console.WriteLine($"{year} год - не високосный");
            Console.ReadKey();
        }
    }
}
