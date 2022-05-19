using System;
using System.Collections.Generic;
using System.Text;

namespace funciton
{
    internal class circle
    {
        public double r;
        public double d;
        public double pi;
        public double circle_area;
        public double circle_circumference;

        public circle(double R, double D, double Pi = Math.PI)
        {
            R = r;
            d = r + r;
            Pi = pi;
        } 
        public circle(circle c)
        {
            circle_area = c.circle_area;
            circle_circumference = c.circle_circumference;
        }
        public void display()
        {
            while (true)
            {
                Console.WriteLine("Enter Radius");
                r = double.Parse(Console.ReadLine());

                double area_check = pi * (r * r);

                circle_area_check:
                Console.WriteLine("Enter are of a circle");
                circle_area = double.Parse(Console.ReadLine());

                if (circle_area != area_check)
                {
                    Console.WriteLine(area_check);
                    Console.WriteLine("You are wrong, Try again.");
                    goto circle_area_check;
                }
                else
                {
                    Console.WriteLine("Well done, You are right.");
                    while (true)
                    {
                        double circumference = pi * d;

                        circle_circumference_check:
                        Console.WriteLine("Enter the circumference");
                        circle_circumference = double.Parse(Console.ReadLine());

                        if (circle_circumference != circumference)
                        {
                            Console.WriteLine(circumference);
                            Console.WriteLine("You are wrong, Try again.");
                            goto circle_area_check;
                        }
                        else
                        {
                            Console.WriteLine("Well done, You are right");
                            break;
                        }
                    }
                }
                break;
            }
        }
    }
}
