using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    // Jag har tagit en del från en gammal lab och försöker pussla ihop den till min nya. därav stämmer inte namnen överrens.

    // program = Progran
    // Shape = Admin
    // Rectangle = Secretary
    // Elipse = Referee


    //  här i Shape vill jag att den ska kolla så att användarnamnet och lösenordet är godkänt som användaren har matat in
    //  jag tänkte att man kunde hårdkoda in till exempel ett användarnamn för domaren och ett för sekreteraren.
    //  Genom att identifiera användarnamnet och lösenordet så anropar man den klassen som stämmer överrens. 

    //  Hamnar vi hos domaren så sker hans flöde där. Lite samspel med sekreteraren då han ska skicka över poängen dit

    //  Hamnar vi hos sekreteraren ska denne ta emot poängen (Hur gör man det när man aldrig får några poäng från domaren 
    //  när man provar programmet?)

    //  












    //Definiera vilka typer av figurer applikationen kan hantera
    enum Admin { Reeferee, Secretary }

    public abstract class Shape
    {
        //Deklarera fält
        private string _userName;
        private string _password;

        //Egenskapen UserName kapslar in fältet _userName
        //Om inmatat värde är mindre än 0 kastas undantag
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value == "")
                {
                    //funkar inte throw new ArgumentException("Tomt användarnamn");
                }
                _userName = value;
            }
        }

        //Egenskapen Password kapslar in egenskapen _password
        //Om inmatat värde är mindre än 0 kastas undantag
        public string Password
        {
            get { return _password; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException();
                }
                _password = value;
            }
        }

        //Egenskapen Area representerar en figurs area
        public abstract string Area
        {
            get;
        }

        //Egenskapen Perimeter representerar en figurs omkrets
        public abstract string Perimeter
        {
            get;
        }

        //Metoderna Shape(konstruktorn) och ToString
        protected Shape(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        //Överskugga basklassens ToString och skriv ut figurens detalger
        public override string ToString()
        {
            return String.Format("Användarnamn   : {0}\nLösenord   : {1}\nOmkrets : {2}\nArea    : {3}\n===========================",
                UserName, Password, Perimeter, Area);
        }
    }
}