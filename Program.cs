using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            while (k == 1)
            {
                try
                {
                    Console.WriteLine("Введиет число N, 1 < N < 100");
                    int N = Convert.ToInt32(Console.ReadLine());

                    int n = N % 10 ;
                    k ++;

                    if (N >= 1 && N <= 100)
                    {
                        if (N > 10 && N < 15)
                        {
                            Console.WriteLine("Пользователю " + N + " лет");
                        }
                        else if (n == 1)
                        {
                            Console.WriteLine("Пользователю " + N + " год");
                        }
                        else if (n >= 2 && n < 5)
                        {
                            Console.WriteLine("Пользователю " + N + " года");
                        }
                        else if (n >= 5 || n == 0)
                        {
                            Console.WriteLine("Пользователю " + N + " лет");
                        }

                    }

                    else
                    {
                        Console.WriteLine("Введите корректное число!");
                        k = 1;
                    }

                }

                catch (FormatException)
                {
                    Console.WriteLine("Введите корректное число!");
                    k = 1;
                }
            }
            Console.ReadKey();
        }
    }
}
