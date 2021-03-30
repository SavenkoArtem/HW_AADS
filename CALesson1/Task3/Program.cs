using System;

namespace Task3
{
    class Program
    {
        public static void FibCycle(int n)
        {
            int[] arrayFib = new int[n];
            for (int i = 0; i < n; i++)
            {
                switch (i)
                {
                    case 0:
                        arrayFib[i] = 0;
                        Console.Write($"{arrayFib[i]}, ");
                        break;
                    case 1:
                        arrayFib[i] = 1;
                        Console.Write($"{arrayFib[i]}");
                        break;
                    default:
                        arrayFib[i] = arrayFib[i - 1] + arrayFib[i - 2];
                        Console.Write($", {arrayFib[i]}");
                        break;
                }
            }
        }

        public static void FibCycleRec(int[] arrayFibRec, int i = 0)
        {
            if (i < arrayFibRec.Length)
            {
                switch (i)
                {
                    case 0:
                        arrayFibRec[i] = 0;
                        Console.Write($"{arrayFibRec[i]}, ");
                        break;
                    case 1:
                        arrayFibRec[i] = 1;
                        Console.Write($"{arrayFibRec[i]}");
                        break;
                    default:
                        arrayFibRec[i] = arrayFibRec[i - 1] + arrayFibRec[i - 2];
                        Console.Write($", {arrayFibRec[i]}");
                        break;
                }
                FibCycleRec(arrayFibRec, i + 1);
            }
            return;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many fibonacci numbers you want to get:");
            if (int.TryParse(Console.ReadLine(), out int result))
            /*
             * при вводе чисел получаю посделовательность чисел, что через цикл, что через рекурсию:
             * при 5 получаю 0, 1, 1, 2, 3
             * при 8 получаю 0, 1, 1, 2, 3, 5, 8, 13
             * при 15 получаю 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377
             * сврил результаты с последовательностью Фибоначи, все сходится
             * Реализовать unit тесты не успел
             */
            {
                if (result > 1) /*
                               * Проверил отрицательные числа -8,-4-1,0,1  во всех этих случаях выходит сообщение:
                               * Please! Input integer only and >1
                               */
                {
                    FibCycle(result);
                    Console.WriteLine(" ");
                    Console.WriteLine("Recurcia ------------------------------------------------");
                    int[] arrayFibRec = new int[result];
                    FibCycleRec(arrayFibRec);
                }
                else
                {
                    Console.WriteLine("Please! Input integer only and >1");

                }
            }
            else
            {
                Console.WriteLine("Input integer only!"); // срабатывает при вводе строки
            }

        }
    }
}
