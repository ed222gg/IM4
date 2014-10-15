using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    //Definiera vilka typer av figurer applikationen kan hantera
    enum ShapeType { Ellipse, Rectangle }

    public abstract class Shape
    {
        //Deklarera fält
        private double _length;
        private double _width;

        //Egenskapen Length kapslar in fältet _length
        //Om inmatat värde är mindre än 0 kastas undantag
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

        //Egenskapen Width kapslar in egenskapen _width
        //Om inmatat värde är mindre än 0 kastas undantag
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

        //Egenskapen Area representerar en figurs area
        public abstract double Area
        {
            get;
        }

        //Egenskapen Perimeter representerar en figurs omkrets
        public abstract double Perimeter
        {
            get;
        }

        //Metoderna Shape(konstruktorn) och ToString
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        //Överskugga basklassens ToString och skriv ut figurens detalger
        public override string ToString()
        {
            return String.Format("Längd   : {0}\nBredd   : {1}\nOmkrets : {2}\nArea    : {3}\n===========================",
                Length, Width, Perimeter, Area);
        }
    }
}