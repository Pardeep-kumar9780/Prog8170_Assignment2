using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Declaration of the sides 
            int side1, side2, side3;
            /// string declarations of the sides of the triangle 
            string strside1, strside2, strside3;
            string value = string.Empty;
            bool validMenuSelection = false;
            while (validMenuSelection == false)
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("1 Enter triangle dimensions");
                Console.WriteLine("2 Exit");
                value = Console.ReadLine();
                switch (value)
                {
                    case "1":
                        Console.WriteLine("");
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("Please Enter the Sides of the Triangle");
                        Console.WriteLine("");
                        ///Getting the values of the three sides
                        bool isNum;
                        do
                        {
                            Console.WriteLine("Enter value for the First Side of the Triangle");
                            strside1 = Console.ReadLine();
                            isNum = int.TryParse(strside1, out side1);
                        } while (!(isNum));
                        do
                        {
                            Console.WriteLine("Enter value for the Second Side of the Triangle");
                            strside2 = Console.ReadLine();
                            isNum = int.TryParse(strside2, out side2);
                        } while (!(isNum));
                        do
                        {
                            Console.WriteLine("Enter value for the Third Side of the Triangle");
                            strside3 = Console.ReadLine();
                            isNum = int.TryParse(strside3, out side3);
                        } while (!(isNum));
                        if ((side1 <= 0) && (side2 <= 0) && (side3 <= 0) && (float.IsNaN(side1) && (float.IsNaN(side2) && (float.IsNaN(side3)))))
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("----------Error--------");
                            Console.WriteLine("Please Enter Correctly");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        ///making a relation to the trianglesolver class and passing the values to the 
                        ///triangle solver attributes
                        else
                        {
                            Console.WriteLine($"Output : {TriangleSolver.Analyze(int.Parse(strside1), int.Parse(strside2), int.Parse(strside3))}");
                        }
                        break;
                    case "2":
                        {
                            System.Environment.Exit(0);
                            break;
                        }
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("----------Error--------");
                        Console.WriteLine("Please Enter Correctly");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}










