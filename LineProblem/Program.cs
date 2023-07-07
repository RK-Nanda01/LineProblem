using System;
namespace LineProblem {

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Start
            Console.WriteLine("Welcome to Line Comparison Computation");

            //UC1
            Console.WriteLine("---UC1---");
            Console.WriteLine("Enter Coordinates of line");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Line l1 = new Line(x1,y1,x2,y2);
            double length1 = l1.Length();
            Console.WriteLine($"The length of line is {length1}");

        }
    }

}
