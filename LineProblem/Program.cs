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


            //UC2
            Console.WriteLine("---UC2---");
            Console.WriteLine("Enter Coordinates of 2nd line");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());
            Line l2 = new Line(x3, y3, x4, y4);

            if(l1.IsEqual(l2) == 1)
            {
                Console.WriteLine("Lines are Equal");
            }
            else
            {
                Console.WriteLine("Lines are Not Equal");
            }



        }
    }

}
