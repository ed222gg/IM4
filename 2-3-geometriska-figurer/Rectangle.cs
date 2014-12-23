using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Referee : Shape
    {
        //Räknar ut elipsens area

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
        public Referee(string username, string password)
            : base(username, password)
        {

            string _username = "anna";
            if (username != _username)
            {
                throw new ArgumentException();
            }


            bool done = false;
            do
            {

                Console.WriteLine("Välj menyval");

                Console.WriteLine("1 Se förfrågningar  ");
                Console.WriteLine("2 Välj aktuell tävling");
                Console.WriteLine("3 Avsluta");

                Console.WriteLine();
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine("TIPS: gör om ditt val och välj alernativ 2\n");
                        break;

                    case 2:
                        showDate();
                        done = true;
                        break;

                    case 3:
                        Console.WriteLine("TIPS: gör om ditt val och välj alernativ 2\n");
                        break;

                }
            }
            while (!done);
        }

        static void showDate()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=======================================");
            Console.WriteLine("=  Du är registrerad att dömma        =");
            Console.WriteLine("=  i följande tävlingar.              =");
            Console.WriteLine("=  Var vänlig välj aktuell tävling    =");
            Console.WriteLine("=======================================\n");
            Console.ResetColor();


            Console.WriteLine("[1] 12/2");
            Console.WriteLine("[2] 28/2");
            Console.WriteLine("[3] 13/3");
            Console.WriteLine("[4] 19/4");


            Console.WriteLine();
            int chooseperson = int.Parse(Console.ReadLine());

            switch (chooseperson)
            {
                case 1:
                    chosebrance();
                    break;

                case 2:
                    chosebrance();
                    break;

                case 3:
                    chosebrance();
                    break;

                case 4:
                    chosebrance();
                    break;

                case 5:
                    chosebrance();
                    break;

                case 6:
                    chosebrance();
                    break;

                case 7:
                    chosebrance();
                    break;
            }
        }
        static void chosebrance()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=========================");
            Console.WriteLine("=         Grenar        =");
            Console.WriteLine("=========================\n");
            Console.ResetColor();

            Console.WriteLine("Välj gren!");

            Console.WriteLine("1 Trampett");
            Console.WriteLine("2 Trampolin");
            Console.WriteLine("3 Barr");
            Console.WriteLine("4 Fristående");

            Console.WriteLine();
            int brance = int.Parse(Console.ReadLine());


            switch (brance)
            {
                case 1:
                    gymnast();
                    break;

                case 2:
                    gymnast();
                    break;

                case 3:
                    gymnast();
                    break;

                case 4:
                    gymnast();
                    break;
            }
        }



        static void gymnast()
        {
            string[] names = { "Hampus", "Carro", "Rebecca", "Richard", "Kristoffer", "Anton", "Josefin", "Tilda" };
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("============================");
            Console.WriteLine("=     Tävlande gymnaster   =");
            Console.WriteLine("============================\n");
            Console.ResetColor();

            Console.WriteLine("Välj gymnast!\n");

            Console.WriteLine("\nLAG 1\n");
            Console.WriteLine("1 {0}", names[0]);
            Console.WriteLine("2 {0}", names[1]);
            Console.WriteLine("3 {0}", names[2]);
            Console.WriteLine("4 {0}", names[3]);

            Console.WriteLine("\nLAG 2\n");
            Console.WriteLine("5 {0}", names[4]);
            Console.WriteLine("6 {0}", names[5]);
            Console.WriteLine("7 {0}", names[6]);
            Console.WriteLine("8 {0}", names[7]);

            Console.WriteLine();
            int chooseperson = int.Parse(Console.ReadLine());

            switch (chooseperson)
            {
                case 1:
                    pointsystem(names[0]);
                    break;

                case 2:
                    pointsystem(names[1]);
                    break;

                case 3:
                    pointsystem(names[2]);
                    break;

                case 4:
                    pointsystem(names[3]);
                    break;

                case 5:
                    pointsystem(names[4]);
                    break;

                case 6:
                    pointsystem(names[5]);
                    break;

                case 7:
                    pointsystem(names[6]);
                    break;


                case 8:
                    pointsystem(names[7]);
                    break;
            }
        }



        static void pointsystem(string prompt)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=========================");
            Console.WriteLine("=       Poängsystem     =");
            Console.WriteLine("=========================");
            Console.ResetColor();

            Console.WriteLine("Mata in poäng för {0}", prompt);

            Console.WriteLine();
            int point = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInmatning av poäng avklarad!");
        }

    }
}





