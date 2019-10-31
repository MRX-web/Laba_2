using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            Console.WriteLine("Введите количество слогаемых:\n");
            while (k == 1)
            {
                try
                {

                    int n = Convert.ToInt32(Console.ReadLine());

                    double j = 1;

                    double pi = 0;
                    int i = 0;
                    k++;
                    while (i < n)
                    {

                        double sum = 1 / j;
                        j += 2;
                        

                        double sum1 = -1 / j;
                        j += 2;

                        
                        pi = pi + sum + sum1;
                        i += 2;

                        if (i > n) { 
                            pi -= sum1; 
                        }
                    
                    }

                    pi = pi * 4;

                    Console.WriteLine("Приблеженное число П:\n" + pi);


                }

                catch (FormatException)
                {
                    Console.WriteLine("Введи корректное число:");
                    k = 1;

                }

            }
            Console.ReadKey();
        }
    }
}
