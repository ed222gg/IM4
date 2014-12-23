using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Secretary : Shape
    {
        //Räkna ut rektangelns area
        public override string Area
        {
            get { return UserName; }
        }

        //Räkna ut rektangelns omkrets
        public override string Perimeter
        {
            get { return Password; }
        }

        //Konstruktorn hämtar längd och bredd från Shape
        public Secretary(string username, string password)
            : base(username, password)
        {
        }
    }
}