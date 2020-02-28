using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class CompanyA
    {
        private int triangleBase;
        private int triangleHeight;
        private int rectangleBreadth;
        private int rectangleLength;
        private int circleRadius;

        public CompanyA(int triangleBase,int triangleHeight,int rectangleBreadth,int rectangleLength,int circleRadius)
        {
            this.triangleBase = triangleBase;
            this.triangleHeight = triangleHeight;
            this.rectangleBreadth = rectangleBreadth;
            this.rectangleLength = rectangleLength;
            this.circleRadius = circleRadius;
        }
    }

    class Triangle : CompanyA
    {
        private int triangleBase;
        private int triangleHeight;

        public Triangle(int triangleBase, int triangleHeight, int rectangleBreadth, int rectangleLength, int circleRadius) : base(triangleBase, triangleHeight, rectangleBreadth, rectangleLength, circleRadius)
        {
            this.triangleBase = triangleBase;
            this.triangleHeight = triangleHeight;
            Console.WriteLine("\n \n Triangle Area : " + 0.5 * this.triangleBase * this.triangleHeight);
        }
    }

    class Rectangle : CompanyA
    {
        private int rectangleBreadth;
        private int rectangleLength;

        public Rectangle(int triangleBase, int triangleHeight, int rectangleBreadth, int rectangleLength, int circleRadius) : base(triangleBase, triangleHeight, rectangleBreadth, rectangleLength, circleRadius)
        {
            this.rectangleBreadth = rectangleBreadth;
            this.rectangleLength = rectangleLength;
            Console.WriteLine("\n \n Rectangle Area : " + this.rectangleLength * this.rectangleBreadth);
        }
    }

    class Circle : CompanyA
    {
        private int circleRadius;

        public Circle(int triangleBase, int triangleHeight, int rectangleBreadth, int rectangleLength, int circleRadius) : base(triangleBase, triangleHeight, rectangleBreadth, rectangleLength, circleRadius)
        {
            this.circleRadius = circleRadius;
            Console.WriteLine("\n \n Circle Area : " + 2*3.1416*this.circleRadius);
        }
    }
}
