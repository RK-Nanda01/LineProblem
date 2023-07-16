using System;
namespace LineProblem {

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Start
            Console.WriteLine("Welcome to Line Comparison Computation");
            // Initialising 2 lines//
            //Line1
            Console.WriteLine("Enter Coordinates of line");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            //Line2
            Console.WriteLine("Enter Coordinates of 2nd line");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());
            Line l1 = new Line(x1, y1, x2, y2);
            Line l2 = new Line(x3, y3, x4, y4);
            bool flag = true;
            int option;
            while(flag)
            {
                Console.WriteLine("MENU---->");
                Console.WriteLine("1.Calculate the length of a line.");
                Console.WriteLine("2.Check If two lines are equal");
                Console.WriteLine("3.Compare the length of 2 lines");
                Console.WriteLine("4.Change the coordinates of lines");
                Console.WriteLine("0.Quit the Menu");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        {
                            flag = false;
                            break;
                        }

                    case 1:
                        {
                          
                            double length1 = l1.Length();
                            double length2 = l2.Length();
                            Console.WriteLine($"The length of line1 is {length1}");
                            Console.WriteLine($"The length of line2 is {length2}");

                            break;
                        }

                    case 2:
                        {
                           
                            if (l1.IsEqual(l2) == 1)
                            {
                                Console.WriteLine("Lines are Equal");
                            }
                            else
                            {
                                Console.WriteLine("Lines are Not Equal");
                            }
                            break;
                        }
                    case 3:
                        {
                            int res = l1.Compare(l2);
                            if (res == 1)
                            {
                                Console.WriteLine("Line 1 is greater than Line 2");
                            }

                            else if (res == -1)
                            {
                                Console.WriteLine("Line 1 is smaller than Line 2");
                            }
                            else
                            {
                                Console.WriteLine("Both Lines are Equal");
                            }
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Enter New Coordinates of line1");
                            double x1New = Convert.ToDouble(Console.ReadLine());
                            double y1New = Convert.ToDouble(Console.ReadLine());
                            double x2New = Convert.ToDouble(Console.ReadLine());
                            double y2New = Convert.ToDouble(Console.ReadLine());
                            //Line2
                            Console.WriteLine("Enter New Coordinates of 2nd line");
                            double x3New = Convert.ToDouble(Console.ReadLine());
                            double y3New = Convert.ToDouble(Console.ReadLine());
                            double x4New = Convert.ToDouble(Console.ReadLine());
                            double y4New = Convert.ToDouble(Console.ReadLine());
                            l1.SetCoordinates(x1New, y1New, x2New, y2New);
                            l2.SetCoordinates(x3New, y3New, x4New, y4New);
                            break;
                        }

                }



            }
           
           
          
        }
    }

}
