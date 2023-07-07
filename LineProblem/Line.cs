using System;
namespace LineProblem
{
	public class Line
	{
		private double x1, x2, y1, y2;

		//parameterized constructor
		public Line(double a ,double b, double c, double d)
		{
			this.x1 = a;
            this.y1 = b;
            this.x2 = c;
            this.y2 = d;

        }

        //Default Constructor
        public Line()
        {
            this.x1 = 0;
            this.y1 = 0;
            this.x2 = 0;
            this.y2 = 0;

        }

        //Calculates length of a line
        public double Length()
        {
            double x = this.x2 - this.x1;
            double y = this.y2 - this.y1;

            double length;
            length = Math.Sqrt((x * x + y * y));
            return length;
        }

        public int IsEqual(Line l2)
        {

            double length1 = this.Length();
            double length2 = l2.Length();
            if (length1 == length2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


    }
}

