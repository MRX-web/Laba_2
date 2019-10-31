using System;

namespace Ind_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Введите вещественное число X:");
            double X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вещественное число Y:");
            double Y = Convert.ToDouble(Console.ReadLine());
            while (i == 1)
            {
                try
                {

                    if (X < 0 || Y < 0)
                    {
                        Console.WriteLine("Error!!!");
                        i++;
                    }
                    else if (X < Y)
                    {
                        X = Math.Sqrt(X);
                        Console.WriteLine("Квадратный корень меньшего числа: " + X);
                    }
                    else if (Y < X)
                    {
                        Y = Math.Sqrt(Y);
                        Console.WriteLine("Квадратный корень меньшего числа: " + Y);

                    }
                    else
                    {
                        Console.WriteLine("Введиет корректное значение:");
                        i = 1;
                    }
                    i++;
                }
                catch (FormatException)
                {

                    Console.WriteLine("Введиет корректное значение:");
                    i = 1;
                }
            }
            Console.ReadKey();
        }
    }
}
