using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PXAssignment1
{
    public class Square
    {
        //declare object fields
        private int side;
        private int area;
        private int perimeter;

        //default constructor
        public Square()
        {
            this.side = 1;
        }

        //non-default constructor
        public Square(int side)
        {
            this.side = side;
        }

        //method to get a side;
        public int GetSide()
        {
            return this.side;
        }

        //method to change the side value
        public int ChangeSide(int side)
        {
            return this.side = side;
        }

        //method to get perimeter
        public int GetPerimeter()
        {
            return perimeter = side * 4;            
        }

        //method to get area of square
        public int GetArea()
        {
            return area = side * side;
        }
    }
}
