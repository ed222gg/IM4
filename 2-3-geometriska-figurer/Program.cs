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
                        ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                      break;

                    case "2":
                        ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                        break;

                    default:
                        ViewErrorMessage("FEL! Ange ett nummer mellan 0 och 2");
                        break;
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tryck tangent för att fortsätta");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        //Metoden CreateShape skriver ut en header som talar om vilken 
        //typ av form vi har valt att skapa och läser in bredd och längd.
        //När värdena är inmatade skapas ett nytt objekt.
        private static Shape CreateShape(ShapeType shapeType)
        {
            double width;
            double length;

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===========================");
            Console.WriteLine("=                         =");
            Console.WriteLine("= {0,15}         =", shapeType);
            Console.WriteLine("=                         =");
            Console.WriteLine("===========================");
            Console.WriteLine();
            Console.ResetColor();

            width = ReadDoubleGreaterThanZero("Ange bredd: ");
            length = ReadDoubleGreaterThanZero("Ange längd: ");

            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    return new Ellipse(width, length);

                case ShapeType.Rectangle:
                    return new Rectangle(width, length);

                default:
                    throw new ApplicationException();
            }
        }

        //Metoden ReadGreaterThanZero kontrollerar att värdet för längd/bredd
        //är större än noll. Om inte visas ett felmeddelande och man får en ny chans.
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double input;

            do
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out input) && input > 0)
                {
                    return input;
                }
                ViewErrorMessage("Fel! Ange ett flyttal större än 0.");
            } while (true);
        }

        //Metod som skriver programmets huvudmeny.
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

        //Skriv ut "detalj-header" och hämta detaljer via ToString i klassen Shape.
        private static void ViewShapeDetail(Shape shape)
        {
            Console.WriteLine(); 
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===========================");
            Console.WriteLine("=                         =");
            Console.WriteLine("=         Detaljer        =");
            Console.WriteLine("=                         =");
            Console.WriteLine("===========================");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine(shape);
        }

        //Röda felmeddelanden
        private static void ViewErrorMessage(string prompt)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(prompt);
            Console.ResetColor();
        }
    }
}