using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel.Classes
{
    /// <summary>
    /// La classe <c>Nani</c> est une classe fille de <c>Guerrier</c> qui répresente un personnage avec un nom, un nombre de points de vie et d'attaque.
    /// Deplus, la classe Guerrier possède un bouclier qui prolonge ses points de vie
    /// </summary>
    internal class Nain : Guerrier
    {
        private int _bouclier;

        private int Bouclier {get => _bouclier; set => _bouclier=value;}

        /// <summary>
        /// Le constructeur Nain créer un guerrier de classe Nain avec un bouclier
        /// </summary>
        /// <param name="nom">Le nom du Nain</param>
        /// <param name="pv">Les points de vie du Nain</param>
        /// <param name="nbAttaques">Le nombre d'attaque du Nain</param>
        /// <param name="bouclier">Le nombre encaissement d'attaque du bouclier</param>
        public Nain(string nom, int pv, int nbAttaques, int bouclier) : base(nom, pv, nbAttaques)
        {
            Bouclier = bouclier;
            Pv += Bouclier;
        }
    }
}
