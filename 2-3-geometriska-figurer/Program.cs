using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Program
    {
        private static void Main(string[] args)
        {

            do
            {
                ViewMenu();

                switch (Console.ReadLine())
                {
                    case "0":
                        return;

                    case "1":
                        //Ellipse
                        Console.WriteLine("Ellipse");
                        //CreateShape();
                        break;

                    case "2":
                        //Rectangle
                        Console.WriteLine("Rectangle");
                        //CreateShape();
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("FEL! Ange ett nummer mellan 0 och 2");
                        Console.ResetColor();
                        break;
                }
                Console.ReadLine();
            } while (true);
        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            throw new NotImplementedException();
        }

        private static double ReadDoubleGreaterThanZero(string promt)
        {
            throw new NotImplementedException();
        }

        private static void ViewMenu()
        {


            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===========================");
            Console.WriteLine("=                         =");
            Console.WriteLine("=   Geometriska figurer   =");
            Console.WriteLine("=                         =");
            Console.WriteLine("===========================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("0. Avsluta");
            Console.WriteLine("1. Ellips");
            Console.WriteLine("2. Reklangel");
            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine();
            Console.Write("Ange menyval 0-2: ");
        }

        private static void ViewShapeDetail(Shape shape)
        {
            throw new NotImplementedException();
        }

        //private static void ViewErrorMessage(string prompt)
        //{
        //    Console.BackgroundColor = ConsoleColor.Red;
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.WriteLine(prompt);
        //    Console.ResetColor();
        //}
    }
}
