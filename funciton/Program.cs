using System;

namespace funciton
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(12 , 18);
            Console.WriteLine("Value of first object");
            r1.display();

            Rectangle r2 = new Rectangle(r1);
            Console.WriteLine("Enter the value of second object");
            r2.display();

            Console.WriteLine();
        }
    }
}
