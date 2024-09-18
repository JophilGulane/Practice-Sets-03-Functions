using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Quest_01
{
    internal class Program
    {
        //Create a function that computes the area of a triangle using Heron’s formula:
        //Area = √s(s - a)(s - b)(s - c)
        //where s is half the perimeter, or(a + b + c)/2
        static void Main(string[] args)
        {
            Console.Write("Enter the length of 'a': ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of 'b': ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of 'c': ");
            double c = double.Parse(Console.ReadLine());

            double Area = AreaOfTriangle(a, b, c);

            Console.WriteLine($"The Area of the triangle is: {Area}");
        }

        static double AreaOfTriangle(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }
    }
}
