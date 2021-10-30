using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    enum Cards
    {
        Шестёрка = 6,
        Семёрка,
        Восьмёрка,
        Девятка,
        Десятка,
        Валет,
        Дама,
        Король,
        Туз
    }
    class Program
    {
        static int GetCountNumbers(int number)
        {
            int count = 0;
            while (number > 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.Write("Введите трехзначное число ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (GetCountNumbers(number) == 3)
            {
                if (number % 10 == number / 100)
                {
                    Console.WriteLine("Классно, это число является палиндромом");
                }
                else
                {
                    Console.WriteLine("Увы, но это обычное число, и оно не является палиндромом");
                }
            }
            else
            {
                Console.WriteLine("Вы нарушаете правила, введите трёхзначное число");
            }
            
            Console.WriteLine();

            Console.WriteLine("Task 2");
            Console.WriteLine("Введите размер форточки(a и b) в сантиметрах");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double diagonal = (double)Math.Sqrt(a * a + b * b);
            double diagonal1 = ++diagonal;
            Console.WriteLine("Диагональ форточки = " + diagonal);
            Console.WriteLine("Введите размер диаметра головы Васи в сантиметрах");
            double d = Convert.ToDouble(Console.ReadLine());
            double radius = d / 2;
            Console.WriteLine("Радиус головы Васи = " + radius);
            if(diagonal1>radius)
            {
                Console.WriteLine("Голова Васи успешно пройдёт в форточку");
            }
            else
            {
                Console.WriteLine("Вася не сможет просунуть голову в форточку");
            }

            Console.WriteLine();

            Console.WriteLine("Task 3");
            Console.WriteLine("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1: Console.WriteLine("Понедельник"); break;
                case 2: Console.WriteLine("Вторник"); break;
                case 3: Console.WriteLine("Среда"); break;
                case 4: Console.WriteLine("Четверг"); break;
                case 5: Console.WriteLine("Пятница"); break;
                case 6: Console.WriteLine("Суббота"); break;
                case 7: Console.WriteLine("Воскресенье"); break;
                default: Console.WriteLine("ERROR"); break;
            }

            Console.WriteLine();

            Console.WriteLine("Task 4");
            Console.WriteLine("Введите число");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Исключение!");
            }
            finally
            {
                if (number > 5 && number < 15)
                {
                    Console.WriteLine((Cards)number);
                }
                else
                {
                    Console.WriteLine("Карты под таким номером не существует");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Task 5");
            radius = 6370;
            Console.WriteLine("Радиус Земли = 6370 км");
            Console.WriteLine("Введите высоту над Землей в км");
            double high = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt((radius + high) * (radius + high) - (radius * radius));
            Console.WriteLine("Расстояние до линии горизонта = " + distance);

            Console.WriteLine();

            Console.WriteLine("Task 6");
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Таблица умножения для данного числа:");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{n}*{i} = {n * i}");
            }

            Console.WriteLine();

            Console.WriteLine("Task 7");
            Console.WriteLine("Введите числа");
            double result = 0;
            int count = 0;
            int summ = 0;
            bool flag = true;
            try
            {
                int sequence;
                while (flag)
                {
                    sequence = Convert.ToInt32(Console.ReadLine());
                    if (sequence >= 0)
                    {
                        summ += sequence;
                        count++;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                result = (double)summ / count;
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка");
            }
            finally
            {
                if (count != 0)
                {
                    Console.WriteLine("Среднее арифметическое всех чисел последовательности без учёта отрицательного числа = " + result);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Task 8");
            int[] Numbers = new int[10];
            Console.WriteLine("Введите последовательность из 10 чисел");
            for (int i = 0; i < 10; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (i > 0 && Numbers[i] < Numbers[i - 1])
                {
                    Console.WriteLine((i) + " - порядковый номер числа, нарушающего последовательность возрастания!");
                    break;
                }
                if (i == Numbers.Length - 1)
                {
                    Console.WriteLine("Возрастающая последовательность!");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Task 9");
            summ = 0;
            count = 1;
            Console.WriteLine("Введите целые числа");
            flag = true;
            while (flag)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    flag = false;
                    continue;
                }
                if (count % 3 == 0)
                {
                    summ += number;
                }
                count++;
            }
            Console.WriteLine(summ);

            Console.WriteLine();

            Console.WriteLine("Task 10");
            summ = 0;
            count = 1;
            Console.WriteLine("Введите целые числа");
            flag = true;
            while (flag)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    goto switchFlag;
                }
                if (count % 3 == 0)
                {
                    summ += number;
                }
                count++;
            }
        switchFlag:
            {
                Console.WriteLine(summ);
            }

            Console.ReadKey();
                
            

        }
    }
}
