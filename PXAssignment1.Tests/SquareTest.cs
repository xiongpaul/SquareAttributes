using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace PXAssignment1.Tests
{
    [TestFixture]
    public class SquareTest
    {
        Square square;
                
        [SetUp]
        public void Initialize()
        {
            square = new Square();
        }
                
        [Test]
        public void GetSideMethod_Given8_ResultIs8()
        {
            //Arrange
            int value = 0;

            //Act
            square.ChangeSide(8);
            value = square.GetSide();
            
            //Assert
            Assert.AreEqual(8, value);
        }
        
        [Test]
        public void ChangeSideMethod_Given42_ResultIs42()
        {
            //Arrange
            int value = 0;

            //Act
            value = square.ChangeSide(42);

            //Assert
            Assert.AreEqual(42, value);
        }

        [Test]
        public void GetPerimeterMethod_Given22_ResultIs88()
        {
            //Arrange
            int perimeter = 0;
            
            //Act
            square.ChangeSide(22);
            perimeter = square.GetPerimeter();

            //Assert
            Assert.AreEqual(88, perimeter);

        }

        [Test]
        public void GetAreaMethod_Given12_ResultIs144()
        {
            //Arrange
            int area = 0;

            //Act
            square.ChangeSide(12);
            area = square.GetArea();

            //Assert
            Assert.AreEqual(144, area);
        }
    }
}