using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prog8170_Assignment2;
using NUnit.Framework;

namespace Prog8170_Assignment2_Tests
{
    [TestFixture]
    public class Prog8170_Assignment2_Tests
    {
        [Test]
        //TestCase 1
        ///In the first test case i am testing side1=3,side2=5 and side3=600.
        ///so clearly it looks like this is not a triangle because side3 has value 600 so a triangle dont
        ///have too high value on one side.
        public void Analyze_Triangle_Input_3_5_600_ExpectedOutput_NotTriangle()
        {
            // Arrange
            int a = 3;
            int b = 5;
            int c = 600;

            // Act
            string result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual("This is not a Triangle", result);
        }
        [Test]
        //TestCase 2
        ///side1=2,side2=2,side3=2 all the sides are equal so it is equilateral triangle.
        public void Analyze_Triangle_Input_2_2_2_ExpectedOutput_Equilateral()
        {
            // Arrange
            int a = 2;
            int b = 2;
            int c = 2;

            // Act
            string result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual("Triangle is Equilateral", result);
        }
        [Test]
        //TestCase3
        ///side1=4,side2=4 and side=2 it is neither equailateral nor scalene.
        ///we have two same values. so this is Isosceles triangle.
        public void Analyze_Triangle_Input_4_4_2_ExpectedOutput_Isosceles()
        {
            // Arrange
            int a = 4;
            int b = 4;
            int c = 2;

            // Act
            string result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual("Triangle is Isosceles", result);
        }
        [Test]
        //TestCase4
        ///all the values are different from each other so this is fall under scalene triangle.
        public void Analyze_Triangle_Input_4_3_5_ExpectedOutput_Scalene()
        {
            // Arrange
            int a = 4;
            int b = 3;
            int c = 5;

            // Act
            string result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual("Triangle is Scalene", result);
        }
        [Test]
        //TestCase5
        ///all the values are different like the previous test case so this is also scalene triangle.
        public void Analyze_Triangle_Input_9_7_3_ExpectedOutput_Scalene()
        {
            // Arrange
            int a = 9;
            int b = 7;
            int c = 3;

            // Act
            string result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual("Triangle is Scalene", result);
        }
        [Test]
        //TestCase6
        ///all the values are 0 so these values will not form triangle.
        public void Analyze_Triangle_Input_0_0_0_ExpectedOutput_NotTriangle()
        {
            // Arrange
            int a = 0;
            int b = 0;
            int c = 0;

            // Act
            string result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual("This is not a Triangle", result);
        }
        [Test]
        //TestCase7
        ///two values out of three are zero.one value cannot form a triangle so again 
        ///this is not a triangle.
        public void Analyze_Triangle_Input_0_3_0_ExpectedOutput_NotTriangle()
        {
            // Arrange
            int a = 0;
            int b = 3;
            int c = 0;

            // Act
            string result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual("This is not a Triangle", result);
        }
        [Test]
        //TestCase8
        ///all the values are same so this is equailateral triangle.
        public void Analyze_Triangle_Input_5_5_5_ExpectedOutput_Equilateral()
        {
            // Arrange
            int a = 5;
            int b = 5;
            int c = 5;

            // Act
            string result = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual("Triangle is Equilateral", result);
        }

    }
}
