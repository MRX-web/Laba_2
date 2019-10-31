using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int i1 = 1;
            int numbers = 0;
            while (i < 9999)
            {
                i = i + i1;
                i1 = i1 + i;
                Console.WriteLine(i);
                Console.WriteLine(i1);
                if (i > 1000 && i < 9999)
                {
                    numbers += 1;
                }
                if (i1 > 1000 && i1 < 9999)
                {
                    numbers += 1;
                }
            }
            Console.WriteLine("Всего 4-ёх зн чисел");
            Console.WriteLine(numbers);
            Console.ReadKey();
        }
    }
}
