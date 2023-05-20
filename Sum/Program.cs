using System;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("---Sum of Digits---");
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num = num / 10;
            }
            Console.WriteLine("Sum of digit is:" + sum);
         }
    }
}


