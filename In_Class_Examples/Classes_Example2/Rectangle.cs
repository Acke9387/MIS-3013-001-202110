using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example2
{
    public class Rectangle
    {

        private int width;

        private int height;

        public Rectangle()
        {
            width = 0;
            height = 0;
        }
        
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public double area()
        {
            return width * height;
        }

    }
}
