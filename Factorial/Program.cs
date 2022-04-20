using System;
namespace Factorial
{
    class program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            int answer = factorial.Recursion();
            Console.WriteLine("Factorial of given number " + answer);
            Console.ReadLine();
        }
    }
}