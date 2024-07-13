using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel.Classes
{
    internal class Elfe : Guerrier
    {
        public Elfe(string nom, int pv, int nbAttaques) : base(nom, pv, nbAttaques) { }

        public override void Attaquer(Guerrier adv){
            int i = 0;
            Console.WriteLine($"{Nom} attack {adv.Nom}");
            while (!adv.EstMort() && i < NbDesAttaques)
            {
                adv.SubirDegats(6);
                i++;
            }
        }
    }
}
