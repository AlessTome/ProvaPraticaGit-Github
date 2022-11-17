using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPraticaGit
{
    internal class biblioteca
    {
        internal string nome { get; set; }
        internal string indirizzo { get; set; }
        internal string orariApertura { get; set; }
        internal string orariChiusura { get; set; }
        internal int elencoLibri { get; set; }

        public void Biblioteca (string nome, string indirizzo, string orariApertura, string orariChiusura, int elencoLibri)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.orariApertura = orariApertura;
            this.orariChiusura = orariChiusura;
            this.elencoLibri = elencoLibri;
        }
    }
}
