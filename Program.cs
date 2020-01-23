// Exercise 3
// Input 3 numbers from the user (x,y,z) and find the greatest of them.

using System;

namespace greatest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide your input for a");
            string A = Console.ReadLine();
            int a = Convert.ToInt32(A);

            Console.WriteLine("Please provide your input for b");
            string B = Console.ReadLine();
            int b = Convert.ToInt32(B);

            Console.WriteLine("Please provide your input for c");
            string C = Console.ReadLine();
            int c = Convert.ToInt32(C);

            if (a > b & a > c)

                Console.WriteLine("a is greatest");

            else if (b > a & b > c)

                Console.WriteLine("b is greatest");

            else 

                Console.WriteLine("c is greatest");
        }
    }
}
