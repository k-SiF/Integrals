using System;

namespace Integrals
{
    class MainClass
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Integrals - Riemann Rule");
            Console.WriteLine("\nf(x) = (c + x^n)\n\n");
            Console.Write("min : ");
            double min = Convert.ToInt32(Console.ReadLine());
            Console.Write("max : ");
            double max = Convert.ToInt32(Console.ReadLine());
            Console.Write("c : ");
            double c = Convert.ToInt32(Console.ReadLine());
            Console.Write("n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("i(no. of rectangles) : ");
            int i = Convert.ToInt32(Console.ReadLine());
            
            double deltax = (max - min) / i;
            double sum = 0;

            Console.WriteLine("\n1. Right Riemann sum\n2. Left Riemann sum");
            Console.Write("> ");
            string choice = Console.ReadLine();

            if(choice == "1")
            {
                for (double x = max; x > min; x -= deltax)
                {
                    double result = (c + Math.Pow(x, n)) * deltax;
                    sum += result;

                }

            }
            else if(choice == "2")
            {
                for (double x = min; x < max; x += deltax)
                {
                    double result = (c + Math.Pow(x, n)) * deltax;
                    sum += result;

                }
            }
            Console.WriteLine("\nsum = " + sum);
        }
    }
}
