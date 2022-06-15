using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace laba2s2
{
    class Triangle
    {
        public double Vertex1X { get; set; }
        public double Vertex1Y { get; set; }
        public double Vertex2X { get; set; }
        public double Vertex2Y { get; set; }
        public double Vertex3X { get; set; }
        public double Vertex3Y { get; set; }

        public double Side1()
        {
            double side1 = Math.Sqrt(Math.Pow((Vertex2X - Vertex1X), 2) + Math.Pow((Vertex2Y - Vertex1Y), 2));
            return side1;
        }
        public double Side2()
        {
            double side2 = Math.Sqrt(Math.Pow((Vertex3X - Vertex2X), 2) + Math.Pow((Vertex3Y - Vertex2Y), 2));
            return side2;
        }
        public double Side3()
        {
            double side3 = Math.Sqrt(Math.Pow((Vertex3X - Vertex1X), 2) + Math.Pow((Vertex3Y - Vertex1Y), 2));
            return side3;
        }
        public double Perimeter()
        {
            double side1 = Side1();
            double side2 = Side2();
            double side3 = Side3();
            double perimeter = side1 + side2 + side3;
            return perimeter;
        }
        public double Square()
        {
            double halfp = Perimeter() / 2;
            double square = Math.Sqrt(halfp * (halfp - Side1()) * (halfp - Side2()) * (halfp - Side3()));
            return square;
        }
        public double MedianX()
        {
            double Xmed = (Vertex1X + Vertex2X) / 2;
            double Xmid = (Vertex3X + 2 * Xmed) / 3;
            return Xmid;
        }
        public double MedianY()
        {
            double Ymed = (Vertex1Y + Vertex2Y) / 2;
            double Ymid = (Vertex3Y + 2 * Ymed) / 3;
            return Ymid;
        }
        public string Type()
        {
            if (Math.Round(Square(),0) != 0 == true)
            {
                if (Side1() + Side2() > Side3() & Side1() + Side3() > Side2() & Side2() + Side3() > Side1())
                {
                    if (Side1() > Side2() & Side1() > Side3())

                    {
                        if (((Math.Pow(Side2(), 2) + Math.Pow(Side3(), 2) - Math.Pow(Side1(), 2)) / (2 * Side2() * Side3())) > -0.1 & ((Math.Pow(Side2(), 2) + Math.Pow(Side3(), 2) - Math.Pow(Side1(), 2)) / (2 * Side2() * Side3())) < 0.1)
                        {
                            return "Right triangle";
                        }
                        else if (((Math.Pow(Side2(), 2) + Math.Pow(Side3(), 2) - Math.Pow(Side1(), 2)) / (2 * Side2() * Side3())) < 0)
                        {
                            return "Obtuse triangle";
                        }
                        else if (((Math.Pow(Side2(), 2) + Math.Pow(Side3(), 2) - Math.Pow(Side1(), 2)) / (2 * Side2() * Side3())) > 0)
                        {
                            return "Acute triangle";
                        }

                    }
                    else if (Side2() > Side1() & Side2() > Side3())
                    {
                        if (((Math.Pow(Side1(), 2) + Math.Pow(Side3(), 2) - Math.Pow(Side2(), 2)) / (2 * Side1() * Side3())) > -0.1 & (Math.Pow(Side1(), 2) + Math.Pow(Side3(), 2) - Math.Pow(Side2(), 2)) / (2 * Side1() * Side3()) < 0.1)
                        {
                            return "Right triangle";
                        }
                        else if (((Math.Pow(Side1(), 2) + Math.Pow(Side3(), 2) - Math.Pow(Side2(), 2)) / (2 * Side1() * Side3())) < 0)
                        {
                            return "Obtuse triangle";
                        }
                        else if (((Math.Pow(Side1(), 2) + Math.Pow(Side3(), 2) - Math.Pow(Side2(), 2)) / (2 * Side1() * Side3())) > 0)
                        {
                            return "Acute triangle";
                        }

                    }
                    else if (Side3() > Side1() & Side3() > Side2())
                    {
                        if (((Math.Pow(Side1(), 2) + Math.Pow(Side2(), 2) - Math.Pow(Side3(), 2)) / (2 * Side1() * Side2())) > -0.1 & ((Math.Pow(Side1(), 2) + Math.Pow(Side2(), 2) - Math.Pow(Side3(), 2)) / (2 * Side1() * Side2())) < 0.1)
                        {
                            return "Right triangle";
                        }
                        else if (((Math.Pow(Side1(), 2) + Math.Pow(Side2(), 2) - Math.Pow(Side3(), 2)) / (2 * Side1() * Side2())) < 0)
                        {
                            return "Obtuse triangle";
                        }
                        else if (((Math.Pow(Side1(), 2) + Math.Pow(Side2(), 2) - Math.Pow(Side3(), 2)) / (2 * Side1() * Side2())) > 0)
                        {
                            return "Acute triangle";
                        }

                    }
                }
                return "It's not a triangle.";
            }
            else
            return "It's not a triangle.";
        }
        public Triangle(double Ver1x, double Ver1y, double Ver2x, double Ver2y, double Ver3x, double Ver3y)
        {
            Vertex1X = Ver1x;
            Vertex1Y = Ver1y;
            Vertex2X = Ver2x;
            Vertex2Y = Ver2y;
            Vertex3X = Ver3x;
            Vertex3Y = Ver3y;
        }


    }
}
