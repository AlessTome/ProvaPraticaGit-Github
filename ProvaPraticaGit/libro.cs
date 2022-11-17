using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPraticaGit
{
    internal class libro
    {
        internal string autore { get; set; }
        internal string titolo { get; set; }
        internal string annoDiPubblicazione { get; set; }
        internal string editore { get; set; }
        internal int numeroDiPagine { get; set; }


        //Creo il metodo toString che mi permette di far ritornare i dati generali

        public string toString (string Autore, string Titolo, string AnnoDiPubblicazione, string Editore, int NumeroDiPagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoDiPubblicazione = annoDiPubblicazione;
            Editore = editore;
            NumeroDiPagine = numeroDiPagine;

            string datiLibro = "";
            datiLibro = Autore + Titolo + AnnoDiPubblicazione + Editore + NumeroDiPagine;
            return datiLibro;
        }
        //Creo il metodo readingTime che mi permette di capire il tempo di lettura medio in base al numero di pagine
        public void readingTime(int NumeroPagine)
        {
            NumeroPagine = numeroDiPagine;

            if(NumeroPagine < 100)
            {
                Console.WriteLine("Il tempo di lettura è di un'ora.");
            }
            else
            {
                if(NumeroPagine > 100 && NumeroPagine < 200)
                {
                    Console.WriteLine("Il tempo di lettura è pari a 2 ore.");
                }
                else
                {
                    Console.WriteLine("Il tempo di lettura è superiore a 2 ore.");
                }
            }
        }
    }
}
