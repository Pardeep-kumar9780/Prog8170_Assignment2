using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170_Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int side1, int side2, int side3)
        {
            string output = string.Empty;
            if ((side1 + side2 > side3) && (side3 + side2 > side1) && (side1 + side3 > side2))
            {
                if ((side1 == side2) && (side2 == side3))
                {
                    output = "Triangle is Equilateral";
                }
                else if ((side1 != side2) && (side2 != side3) && (side3 != side1))
                {
                    output = "Triangle is Scalene";
                }
                else
                {
                    output = "Triangle is Isosceles";
                }
            }
            else
            {
                output = "This is not a Triangle";
            }
            return output;
        }
    }
}
















