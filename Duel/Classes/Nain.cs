using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel.Classes
{
    internal class Nain : Guerrier
    {
        private int bouclier;
        public int Bouclier {get; set;}
        public Nain(string nom, int pv, int nbAttaques) : base(nom, pv, nbAttaques)
        {
            base.Pv += Bouclier;
        }
    }
}
