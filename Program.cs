using System;

namespace Ind_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i == 1) {
                try {
                    Console.WriteLine("Введите число N 1 > N < 10000");
                    int N = Convert.ToInt32(Console.ReadLine());
                    if (N > 1 && N < 10000)
                    {
                        Console.WriteLine("Нечетные делители числа: ");
                        for (int k = 1; k <= N; k = k + 2) {

                            if (N % k == 0)
                            {
                                Console.WriteLine(k + " ");
                            }
           
                        }

                        i++;
                       
                    }
                    else
                    {
                        Console.WriteLine("Введите корректное число");
                        i = 1;
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Введите корректное число");
                    i = 1;
                }
            }
            Console.ReadKey();
        }
    } 
}
