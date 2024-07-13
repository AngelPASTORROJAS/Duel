using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel.Classes
{
    internal class Guerrier
    {
        #region Attributs
        protected string _nom;
        protected int _pv;
        protected int _nbDesAttaques;
        #endregion

        #region Propriétés
        public string Nom { get => _nom; }
        protected int Pv { get => _pv; set => _pv = value>0?value:0; }
        protected int NbDesAttaques { get => _nbDesAttaques; set => _nbDesAttaques = value; }
        #endregion

        #region Constructeur
        public Guerrier(string nom, int pv , int nbAttaques) 
        {
            _nom = nom;
            Pv = pv;
            NbDesAttaques = nbAttaques;
        }
        #endregion

        #region Méthodes
        public void AfficherInfos()
        {
            Console.WriteLine($" {Nom}{{PV={Pv}}}");
        }

        public void SubirDegats(int degats)
        {
            Pv -= degats;
            if (Pv == 0 ) Console.WriteLine($"{Nom} is death.");
        }

        public virtual void Attaquer(Guerrier adv)
        {
            int i = 0;
            Console.WriteLine($"{Nom} attack {adv.Nom}");
            while (!adv.EstMort() && i<NbDesAttaques)
            {
                Random rnd = new Random();
                adv.SubirDegats(rnd.Next(1, 6 + 1));
                i++;
            }
        }

        public bool EstMort() { return Pv==0; }
        #endregion
    }
}
