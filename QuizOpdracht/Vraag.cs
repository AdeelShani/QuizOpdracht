using System;
using System.Collections.Generic;
using System.Text;

namespace QuizOpdracht
{
    public interface IVraag
    {
        string Tekst { get; set; }
        string Antwoord { get; set; }
        string Categorie { get; set; }
        int MoeilijkheidsGraat { get; set; }

        void Tonen();
        bool AntwoordControleren(string response);
    }

    public class Vraag : IVraag
    {

        public string Tekst { get; set; }
        public string Antwoord { get; set; }
        public string Categorie { get; set; }
        public int MoeilijkheidsGraat { get; set; }

        public void Tonen()
        {
            Console.WriteLine(Tekst);
        }

        public bool AntwoordControleren(string response)
        {
            return ((Antwoord.ToLower() == response.ToLower()));

        }
    }
}
