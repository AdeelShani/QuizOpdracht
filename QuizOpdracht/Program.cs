using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ben je klaar om mee te doen met het Quiz? \n");

            List<IVraag> vragen = new List<IVraag>{
                new Vraag{Tekst = "Hoeveel is 20 + 1", Antwoord = "21", Categorie = "Rekenen", MoeilijkheidsGraat = 1},
                new Vraag{Tekst = "Hoeveel is 20 - 1", Antwoord = "20", Categorie = "Rekenen", MoeilijkheidsGraat = 1},
                new Vraag{Tekst = "Hoeveel is 1753 - 544", Antwoord = "1209", Categorie = "Rekenen", MoeilijkheidsGraat = 2},
                new Vraag{Tekst = "Hoeveel is 1753 * 544", Antwoord = "953630", Categorie = "Rekenen", MoeilijkheidsGraat = 3},
                new Vraag{Tekst = "Hoeveel is 100 / 5", Antwoord = "20", Categorie = "Rekenen", MoeilijkheidsGraat = 2},
            };

            // Only math questions
            var DeVraag = from x in vragen
                          where x.Categorie == "Rekenen"
                          select x;

            foreach (var x in DeVraag)
            {
                AntwoordControle(x);
            }
        }

        static void AntwoordControle(IVraag vraag)
        {
            vraag.Tonen();
            string answer = Console.ReadLine();

            if (vraag.AntwoordControleren(answer))
            {
                Console.WriteLine("Je antwoord is juist! \n");
            }
            else
            {
                Console.WriteLine("Je antwoord is fout probeer het nogmaals! \n");
            }
        }
    }
}
