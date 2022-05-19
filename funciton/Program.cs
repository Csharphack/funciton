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

            triangle t1 = new triangle(10, 12, 20);
            Console.WriteLine("Value of first triangle");
            t1.display();

            triangle t2 = new triangle(24, 18, 20);
            Console.WriteLine("Enter value of second triangle");
            t2.display();

            circle C = new circle(10, 12, 3);
            Console.WriteLine("Value of circle");
            C.display();
        }
    }
}
