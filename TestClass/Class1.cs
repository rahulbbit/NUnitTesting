using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitDemonstration;
//Rahul Patel
namespace TestClass
{
    [TestFixture]
    public class TriangleTest
    {
        public class TriangleTest1
        {
            [Test]
            public void ValidTriangle_Input60and60and60_OutputvalidTriangle()
            {

                //Arrange
                int firstangle = 60;
                int secondAngle = 60;
                int thirdangle = 60;

                string expected = "The triangle is valid.";

                //Act
                string actual = Triangle.ValidTriangle(firstangle, secondAngle, thirdangle);

                //Assert

                Assert.AreEqual(expected, actual);  


            }

        }

    }
}
