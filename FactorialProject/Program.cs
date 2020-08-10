using System;

namespace FactorialProject
{
    class Program
    {
        
        public static int Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }
        static void Main(string[] args)
        {
            
            
                int n;
                Console.WriteLine("enter a number");

                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("factorial of " + n + " is " + Factorial(n));
            

        }
    }
}
