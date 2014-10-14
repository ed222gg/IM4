using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    enum ShapeType { Ellipse, Rectangle }

    abstract class Shape
    {
        //Deklarera fält
        private double _length;
        private double _width;

        ////Egenskaperna Area, Length, Perimeter och Width
        //public abstract double Area
        //{
        //    get { return 0; } //?
        //}

        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }
        }

        //public abstract double Perimeter
        //{ 
        //    get { return 0; } //?
        //}

        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }

        ////Metoderna Shape(konstruktorn) och ToString
        //protected Shape(double length, double width)
        //{

        //}

        //public override string ToString()
        //{
        //    //throw new NotImplementedException();

        //    string result;

        //    result = String.Format("Längd   : {0}\nBredd   : {1}\nOmkrets : {2}\nArea    : {3}",
        //        Length, Width, Perimeter, Area);

        //    return result;

        //    //Console.WriteLine("Längd   : {0}", Length);
        //    //Console.WriteLine("Bredd   : {0}", Width);
        //    //Console.WriteLine("Omkrets : {0}", Perimeter);
        //    //Console.WriteLine("Area    : {0}", Area);
        //}
    }
}
