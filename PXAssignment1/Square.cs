using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PXAssignment1
{    
    public class Square
    {
        private int side;

        //default constructor
        public Square()
        {
            
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
            this.side = side;
            return side;
        }

        //method to get perimeter
        public int GetPerimeter()
        {
            int perimeter = side * 4;
            return perimeter;
        }

        //method to get area of square
        public int GetArea()
        {
            int area = side ^ 2;
            return area;
        }

    }
}
