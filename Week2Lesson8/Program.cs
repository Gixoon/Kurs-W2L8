using System;
using System.ComponentModel.DataAnnotations;

namespace Week2Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            exe1();
            exe2();
            exe3();
            exe4();
            exe5();
            exe6();
            exe7();
            exe8();
            exe9();
            exe10();
        }

        public static void exe1()
        {
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i == 0 || i == 1)
                {
                    continue;
                }
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + ", ");
                    count++;
                }
            }
            Console.WriteLine($"\r\nBetween 0 - 100 there are {count} prime numbers.");
        }
        public static void exe2()
        {
            int i = 0;
            int count = 0;

            do
            {
                i++;
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                    count++;
                }
                else
                {
                }
            } while (i <= 1000);

            Console.WriteLine($"\r\nBetween 0 - 1000 there are {count} even numbers");
        }
        public static void exe3()
        {
            Console.WriteLine("Ciąg Fibonacciego");
            ulong a = 0;
            ulong b = 1;
            ulong c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (ulong i = 0; i < 100; i++)
            {
                c = a + b;
                a = b;
                b = c;

                Console.WriteLine(c);
            }
        }
        public static void exe4()
        {
            Console.Write("Podaj liczbę: ");
            int rows = int.Parse(Console.ReadLine());
            int x = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{x} ", x++);
                }
                Console.WriteLine("\n");
            }
        }
        public static void exe5()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{i} do potęgi 3 wynosi: ");
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
        public static void exe6()
        {
            Console.WriteLine();
            Console.Write("Enter number: ");
            float y = float.Parse(Console.ReadLine());
            float x = 0;

            for (float i = 1; i <= 20; i++)
            {
                x += y / i;
               Console.WriteLine(x);
            }
        }
        public static void exe7()
        {
            Console.Write("Enter diagonal (number must be an odd number higher than 1): ");
            int d = int.Parse(Console.ReadLine());

            int row = 0;
            int col = 0;
            int spc = 0;

            //góra
            while (row <= d)
            {
                for (col = 0; col < d / 2 - spc; col++)
                {
                    Console.Write(" ");
                }
                for (col = 0; col <= row; col++)
                {
                    Console.Write("*");
                }
                row += 2;
                spc++;
                Console.WriteLine();
            }

            //dół
            row -= 2;
            spc--;

            while (row >= 0)
            {
                for (col= 0; col < d / 2 - spc + 1; col++)
                {
                    Console.Write(" ");
                }
                for (col = 0; col < row- 1; col++)
                {
                    Console.Write("*");
                }
                row -= 2;
                spc--;
                Console.WriteLine();
            }
        }
        public static void exe8()
        {
            Console.Write("Write sth you want to be reversed: ");
            string input = Console.ReadLine();
            string rev = string.Empty;
            int length = input.Length - 1;

            while (length >= 0)
            {
                rev += input[length];
                length--;
            }
            Console.Write($"Revers:\r\n{rev}");
            Console.WriteLine();
        }
        public static void exe9()
        {
            Console.Write("Decimal to binary.\r\nEnter number you want to convert: ");
            int d = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; d > 0; i++)
            {
                result = d % 2 + result;
                d /= 2;
            }
            Console.WriteLine($"Binary of the given number is: {result}");
        }
        public static void exe10()
        {
            Console.WriteLine("Najmniejsza wspólna wielokrotność");

            Console.Write("Podaj pierwszą liczbę: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            int y = int.Parse(Console.ReadLine());

            int num1, num2, z, nwd, nww;

            if (x > y)
            {
                num1 = x;
                num2 = y;
            }
            else
            {
                num1 = y;
                num2 = x;
            }

            while (num2 != 0)
            {
                z = num2;
                num2 = num1 % num2;
                num1 = z;
            }

            nwd = num1;
            nww = (x * y) / nwd;

            Console.WriteLine($"Najmniejsza wspólna wielokrotność dla {x} i {y} wynosi: {nww}");
        }
    }
}
