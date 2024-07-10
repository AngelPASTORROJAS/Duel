using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel.Classes
{
    internal class Elfe : Guerrier
    {
        public Elfe(string nom, int pv, int nbAttaques) : base(nom, pv, nbAttaques)
        {
        }

        public override int Attaque(Guerrier guerrier){
            Random rnd = new Random();
            int hit = rnd.Next(2, 6 + 1);
            guerrier.Pv -= hit;
            return hit;
        }
    }
}
