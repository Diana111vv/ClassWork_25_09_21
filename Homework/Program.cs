using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.1");
            Console.WriteLine("Введите число");
            double number = Convert.ToDouble(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("Модуль числа = " + number);
            }
            if (number < 0)
            {
                Console.WriteLine("Модуль числа = " + (-number));
            }

            Console.WriteLine();

            Console.WriteLine("Task 1.2");
            Console.WriteLine("Введите первое число");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double number2 = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(number) > Math.Abs(number2))
            {
                Console.WriteLine("Первое число, уменьшенное в два раза = " + number / 2);
            }
            else
            {
                Console.WriteLine("Первое число меньше второго");
            }

            Console.WriteLine();

            Console.WriteLine("Task 1.3");
            Console.WriteLine("Какое животное встретила лягушка?(название животного на русском языке)");
            string typeAnimal = Console.ReadLine();
            string mouthSize;
            if (typeAnimal.ToLower() == "аллигатор")
            {
                mouthSize = "small";
            }
            else
            {
                mouthSize = "wide";
            }
            Console.WriteLine("Размер рта лягушки: " + mouthSize);

            Console.WriteLine();

            Console.WriteLine("Task 1.4");
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }

            Console.WriteLine();

            Console.WriteLine("Task 1.5");
            Console.WriteLine("Введите строку");
            input = Console.ReadLine();
            bool English = input.ToLower().Contains("english");
            Console.WriteLine(English);

            Console.WriteLine();

            Console.WriteLine("Task 2.1");
            double summ = 0;
            number = 1;
            for (int i = 0; i < 9; i++)
            {
                summ += number;
                number /= 3;
            }
            Console.WriteLine("Сумма последовательности = " + summ);

            Console.WriteLine();

            Console.WriteLine("Task 2.2");
            int stage = 100;
            double distance = 0;
            summ = 0;
            int temp = 1;
            double way = 1;
            bool forward = true;
            for (int i = 0; i < stage; i++)
            {
                if (forward)
                {
                    summ += way;
                    distance += way;
                    temp++;
                    way = (double)1 / temp;
                    forward = false;
                }
                else
                {
                    summ += way;
                    distance -= way;
                    temp++;
                    way = (double)1 / temp;
                    forward = true;
                }

            }
            Console.WriteLine("В данный момент муж находится на расстоянии: " + distance + " \nА общий путь составляет: " + summ);

            Console.WriteLine();

            Console.WriteLine("Task 2.3");
            int[] tempJanuary = new int[31];
            int[] tempMarch = new int[30];
            Random r = new Random();
            summ = 0;
            for (int i = 0; i < tempJanuary.Length; i++)
            {
                tempJanuary[i] = r.Next(0, 100);
            }
            for (int i = 0; i < tempJanuary.Length; i++)
            {
                summ += tempJanuary[i];
            }
            Console.WriteLine("Среднее количество осадков в Январе = " + summ / (tempJanuary.Length));
            summ = 0;
            for (int i = 0; i < tempMarch.Length; i++)
            {
                tempMarch[i] = r.Next(0, 100);
            }
            for (int i = 0; i < tempMarch.Length; i++)
            {
                summ += tempMarch[i];
            }
            Console.WriteLine("Средняя количество осадков в Марте = " + summ / (tempMarch.Length));

            Console.WriteLine();

            Console.WriteLine("Task 3.1");
            int numeratorFirst = 1;
            int denominatorFirst = 1;
            int numeratorSecond = 2;
            int denominatorSecond = 1;
            int numeratorThird;
            int denominatorThird;
            temp = 0;
            while (Math.Abs(((double)numeratorFirst / denominatorFirst) - ((double)numeratorSecond / denominatorSecond)) > 0.001)
            {
                numeratorThird = numeratorFirst + numeratorSecond;
                denominatorThird = denominatorSecond + denominatorFirst;
                numeratorFirst = numeratorSecond;
                denominatorFirst = denominatorSecond;
                numeratorSecond = numeratorThird;
                denominatorSecond = denominatorThird;
            }
            Console.WriteLine($"{numeratorFirst} / {denominatorFirst} и {numeratorSecond} / {denominatorSecond}");

            Console.WriteLine();

            Console.WriteLine("Task 3.2");
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i * i > n)
                {
                    Console.WriteLine("Первый квадрат числа, который больше числа n = " + i * i);
                    break;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Task 3.3(a)");
            number = 100;
            while (number > 79)
            {
                Console.WriteLine(number);
                number--;
            }
            number = 100;

            Console.WriteLine();

            Console.WriteLine("Task 3.3(b)");
            number = 100;
            do
            {
                Console.WriteLine(number);
                number--;
            }
            while (number > 79);

            Console.WriteLine();

            Console.WriteLine("Task 3.4");
            for (int i = 5000; i > 0; i--)
            {
                if (i % 39 == 0)
                {
                    Console.WriteLine("Максимальное из натуральных чисел, не превышающих 5000, которое нацело делится на 39 = " + i);
                    break;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Task 3.5(a)");
            temp = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < temp; k++)
                {
                    Console.Write("5 ");
                }
                temp++;
                Console.WriteLine();
            }
            
            Console.WriteLine();

            Console.WriteLine("Task 3.5(b)");
            temp = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int k = temp; k > 0; k--)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine();
                temp--;
            }
            Console.WriteLine();

            Console.WriteLine("Шахматы(a)");
            Console.WriteLine("Введите номер вертикали, где сейчас находится ладья");
            byte a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где сейчас находится ладья");
            byte b = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится ладья");
            byte c = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится ладья");
            byte d = byte.Parse(Console.ReadLine());
            if (c == a || d == b)
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Такой ход невозможен!");
            }

            Console.WriteLine();

            Console.WriteLine("Шахматы(б)");
            Console.WriteLine("Введите номер вертикали, где сейчас находится слон");
            a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где сейчас находится слон");
            b = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится слон");
            c = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится слон");
            d = byte.Parse(Console.ReadLine());
            if (Math.Abs(c - a) == Math.Abs(d - b))
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Такой ход невозможен!");
            }

            Console.WriteLine();

            Console.WriteLine("Шахматы(в)");
            Console.WriteLine("Введите номер вертикали, где сейчас находится король");
            a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где сейчас находится король");
            b = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится король");
            c = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится король");
            d = byte.Parse(Console.ReadLine());
            if (Math.Abs(c - a) <= 1 && Math.Abs(d - b) <= 1)
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Такой ход невозможен!");
            }

            Console.WriteLine();

            Console.WriteLine("Шахматы(г)");
            Console.WriteLine("Введите номер вертикали, где сейчас находится ферзь");
            a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где сейчас находится ферзь");
            b = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится ферзь");
            c = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится ферзь");
            d = byte.Parse(Console.ReadLine());
            if ((c == a || d == b) || (Math.Abs(c - a) == Math.Abs(d - b)))
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Такой ход невозможен!");
            }

            Console.WriteLine();

            Console.WriteLine("Шахматы(д)");
            Console.WriteLine("Введите номер вертикали, где сейчас находится белая пешка");
            a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где сейчас находится белая пешка");
            b = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится белая пешка");
            c = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится белая пешка");
            d = byte.Parse(Console.ReadLine());
            Console.WriteLine("Находится ли фигура на той же клетке куда идет пешка?true/false");
            bool isEmpty = bool.Parse(Console.ReadLine());
            if ((d - b == 1 && c - a == 0) || (isEmpty && c - a == 1 && d - b == 1))
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Такой ход невозможен!");
            }

            Console.WriteLine();

            Console.WriteLine("Шахматы(е)");
            Console.WriteLine("Введите номер вертикали, где сейчас находится черная пешка");
            a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где сейчас находится черная пешка");
            b = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится черная пешка");
            c = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится черная пешка");
            d = byte.Parse(Console.ReadLine());
            Console.WriteLine("Находится ли фигура на той же клетке куда идет пешка?true/false");
            isEmpty = bool.Parse(Console.ReadLine());
            if ((b - d == 1 && a - c == 0) || (isEmpty && a - c == 1 && b - d == 1))
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Такой ход невозможен!");
            }

            Console.WriteLine();

            Console.WriteLine("Шахматы(ж)");
            Console.WriteLine("Введите номер вертикали, где сейчас находится конь");
            a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где сейчас находится конь");
            b = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится конь");
            c = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится конь");
            d = byte.Parse(Console.ReadLine());
            if ((Math.Abs(c - a) == 2 && Math.Abs(d - b) == 1) || (Math.Abs(d - b) == 2 && Math.Abs(c - b) == 1))
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Такой ход невозможен!");
            }
            Console.ReadKey();
        }
    }
}
