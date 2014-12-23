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
            Shape varCreateAdmin;
            do
            {
                ViewMenu();

                switch (Console.ReadLine())
                {
                    case "0":
                        return;

                    case "1":
                        do
                        {
                            varCreateAdmin = CreateAdmin(Admin.Reeferee);
                        }
                        while (varCreateAdmin == null);
                        break;

                    case "2":
                        do
                        {
                            varCreateAdmin = CreateAdmin(Admin.Secretary);
                        }
                        while (varCreateAdmin == null);
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

        //Metoden CreateAdmin skriver ut en header som talar om vilken 
        //typ av form vi har valt att skapa och läser in bredd och längd.
        //När värdena är inmatade skapas ett nytt objekt.
        private static Shape CreateAdmin(Admin adminType)
        {
            string userName;
            string password;

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===========================");
            Console.WriteLine("=                         =");
            Console.WriteLine("= {0,15}         =", adminType);
            Console.WriteLine("=                         =");
            Console.WriteLine("===========================");
            Console.WriteLine();
            Console.ResetColor();

            userName = LogIn("Ange användarnamn: ");
            password = LogIn("Ange Lösenord: ");


            try
            {
                switch (adminType)
                {
                    case Admin.Reeferee:
                        return new Referee(userName, password);

                    case Admin.Secretary:
                        return new Secretary(userName, password);

                    default:
                        throw new ApplicationException();
                }
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Du angav fel användarnamn eller lösenord");
                // Kalla på användare/lösenord igen.

                return null;

                // print("exception caught " + ex.toString();
            }

        }




        //Metoden ReadGreaterThanZero kontrollerar att värdet för längd/bredd
        //är större än noll. Om inte visas ett felmeddelande och man får en ny chans.


        //Metod som skriver programmets huvudmeny.
        private static void ViewMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===========================");
            Console.WriteLine("=                         =");
            Console.WriteLine("=      Välj användare     =");
            Console.WriteLine("=                         =");
            Console.WriteLine("===========================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("0. Avsluta");
            Console.WriteLine("1. Domare");
            Console.WriteLine("2. Sekreterare");
            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine();
            Console.Write("Ange menyval 0-2: ");
        }

        private static string LogIn(string prompt)
        {



            Console.Write(prompt);
            string userName = Console.ReadLine();



            return userName;

        }


        //Skriv ut "detalj-header" och hämta detaljer via ToString i klassen Shape.
        private static void LogIn(Shape shape)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===========================");
            Console.WriteLine("=                         =");
            Console.WriteLine("=         Inloggad        =");
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