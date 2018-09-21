/*
 * Name: Paul Xiong
 * Course: PROG2070
 * Assignment#1
 * 
 * Purpose: Unit Tests for methods of the Square object
 * 
 */

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
            int side = 8;
            
            //Act
            square.ChangeSide(side);
            int value = square.GetSide();
            
            //Assert
            Assert.AreEqual(8, value);
        }
        
        [Test]
        public void ChangeSideMethod_Given42_ResultIs42()
        {
            //Arrange
            int side = 42;

            //Act
            int value = square.ChangeSide(side);

            //Assert
            Assert.AreEqual(42, value);
        }

        [Test]
        public void GetPerimeterMethod_Given22_ResultIs88()
        {
            //Arrange
            int side = 22;
            
            //Act
            square.ChangeSide(side);
            int perimeter = square.GetPerimeter();

            //Assert
            Assert.AreEqual(88, perimeter);
        }

        [Test]
        public void GetAreaMethod_Given12_ResultIs144()
        {
            //Arrange
            int side = 12;

            //Act
            square.ChangeSide(side);
            int area = square.GetArea();

            //Assert
            Assert.AreEqual(144, area);
        }
    }
}