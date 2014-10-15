using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Ellipse : Shape
    {
        //Räknar ut elipsens area
        public override double Area
        {
            get { return Math.PI * (Length / 2) * (Width / 2); }
        }

        //Räknar ut elipsens omkrets
        public override double Perimeter
        {
            get { return Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2)); } 
        }

        //Konstruktorn hämtar längd och bredd från Shape
        public Ellipse(double length, double width)
            :base (length, width)
        {
        }
    }
}