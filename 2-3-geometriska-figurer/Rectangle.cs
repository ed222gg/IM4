using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Rectangle : Shape
    {
        //Räkna ut rektangelns area
        public override double Area
        {
            get { return Length * Width; }
        }

        //Räkna ut rektangelns omkrets
        public override double Perimeter
        {
            get { return Length * 2 + Width * 2; }
        }

        //Konstruktorn hämtar längd och bredd från Shape
        public Rectangle(double length, double width)
            :base(length, width)
        {
        }
    }
}