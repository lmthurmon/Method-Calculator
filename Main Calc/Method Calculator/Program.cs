using System;

namespace Method_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            MyFirstNumber();
            Console.WriteLine("Enter your second number");
            MySecondNumber();
            Console.WriteLine("Choose one of the listed operators:");

        }

        public static double MyFirstNumber()
        {
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            
            return firstNumber;
            
        }

        public static double MySecondNumber()
        {
         
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            return secondNumber;

        }
    }
}
