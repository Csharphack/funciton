using System;
using System.Collections.Generic;
using System.Text;

namespace funciton
{
    class Rectangle
    {
        public int length;
        public int width;

        public Rectangle(int x, int y)
        {
            length = x;
            width = y;
        }
        public Rectangle(Rectangle r)
        {
            length = r.length;
            width = r.width;
        }
        public void display()
        {
            Console.WriteLine(" __________x_____________  ");
            Console.WriteLine("|                        | ");
            Console.WriteLine("|                        | ");
            Console.WriteLine("|y                       | ");
            Console.WriteLine("|                        | ");
            Console.WriteLine("|________________________| ");

            Console.WriteLine("Length:" + length);
            Console.WriteLine("Width:" + width);

            int perimeter = (length * 2) + (width * 2);

            Console.WriteLine("-------------------------");

            Console.WriteLine("Area:" + length * width);
            Console.WriteLine("Perimeter:" + perimeter);
        }
    }
}
