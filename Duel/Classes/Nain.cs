using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel.Classes
{
    internal class Nain : Guerrier
    {
        private int _bouclier;
        public int Bouclier {get; set;}
        public Nain(string nom, int pv, int nbAttaques, int bouclier) : base(nom, pv, nbAttaques)
        {
            Bouclier = bouclier;
            Pv += Bouclier;
        }
    }
}
