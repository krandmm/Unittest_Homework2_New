using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Unittest_Homework2_New;

namespace Unittest_Homework2_New_Test
{
    [TestFixture]
    public class TriangleSolverTest
    {
        ///Eheck if the input is an EQUILATERAL TRIANGLE
        [Test]
        public void EquilateralTriangle()
        {
            //Arrange   
            int a = 4;
            int b = 4;
            int c = 4;

            //Act
            string add = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(add, "Your input is an EQUILATERAL TRIANGLE.");
        }

        ///Eheck if the input is an ISOSCELES TRIANGLE
        [Test]
        public void IsoscelesTriangle()
        {
            //Arrange   
            int a = 4;
            int b = 4;
            int c = 7;

            //Act
            string add = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(add, "Your input is an ISOSCELES TRIANGLE.");
        }

        ///Eheck if the input is an SCALENE TRIANGLE
        [Test]
        public void ScaleneTriangle()
        {
            //Arrange   
            int a = 2;
            int b = 3;
            int c = 4;

            //Act
            string add = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(add, "Your input is a SCALENE TRIANGLE.");
        }

        ///Eheck if the input is an Zero Number
        [Test]
        public void ZeroTriangle()
        {
            //Arrange   
            int a = 0;
            int b = 0;
            int c = 0;

            //Act
            string add = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(add, "Your input are Zero number.");
        }

        ///Eheck if the input is an Negative Number
        [Test]
        public void NegativeTriangle()
        {
            //Arrange   
            int a = -2;
            int b = -2;
            int c = -2;

            //Act
            string add = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(add, "Your input are all of negative number.");
        }

        ///Eheck if the input of Side A is an Negative Number
        [Test]
        public void SideaNegative()
        {
            //Arrange   
            int a = -2;
            int b = 4;
            int c = 4;

            //Act
            string add = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(add, "Side A input is a negative number.");
        }

        ///Eheck if the input of Side B is an Negative Number
        [Test]
        public void SidebNegative()
        {
            //Arrange   
            int a = 4;
            int b = -2;
            int c = 4;

            //Act
            string add = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(add, "Side B input is a negative number.");
        }

        ///Eheck if the input of Side C is an Negative Number
        [Test]
        public void SidecNegative()
        {
            //Arrange   
            int a = 4;
            int b = 4;
            int c = -2;

            //Act
            string add = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(add, "Side C input is a negative number.");
        }


    }
}
