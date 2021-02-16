using System;

namespace Conditional_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero:");
            string date = Console.ReadLine();
            var numberValidation = int.TryParse(date, out int number);
            if (numberValidation && number>0 && number<=10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
