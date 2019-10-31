using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
			while (i == 1){

                try{
                Console.WriteLine("Решение квадратного уравнения\n");

                    Console.WriteLine("Введите число A:");
                        double a = Double.Parse(Console.ReadLine());

                            Console.WriteLine("Введите число B:");
                                double b = Double.Parse(Console.ReadLine());

                                Console.WriteLine("Введите число C:");
                                    double c = Double.Parse(Console.ReadLine());
                    i++;
                        //формула для нахождения дискриминанта
                        double D = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);

                            double X1 = (-b - D) / (2 * a);
                                double X2 = (-b + D) / (2 * a);
                                    double X3 = (-b) / (2 * a);
               
                    if(D > 0){

                        Console.WriteLine("Уравнение имеет два корня x1:{0} /n x2:{1}", X1, X2);
                 
                    }
                        else if (D == 0){

                            Console.WriteLine("Уравнение имеет один корень x3:" + X3);

                        }
                    else{

                        Console.WriteLine("Уравнение не имеет действительный корней!");
                            Console.WriteLine("Вывод: x+iy; x-iy");
                                Console.WriteLine(Math.Pow(a, 2) - Math.Pow(b, 2) * (-1));

                    }

                
                }
            catch(FormatException){
                Console.WriteLine("Введите корректное число:");
                    i = 1;
            }
        } 
                Console.ReadKey();  
        }
    }
}
