using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel.Classes
{
    internal class Guerrier
    {
        #region Attributs
        protected String _nom;
        protected int _pv;
        protected int _nbDesAttaques;
        #endregion

        #region Propriétés
        public String Nom { get => _nom; set => _nom = value; }
        public int Pv { get => _pv; set => _pv = value>0?value:0; }
        public int NbDesAttaques { get => _nbDesAttaques; set => _nbDesAttaques = value; }
        #endregion

        #region Constructeur
        public Guerrier(String nom, int pv , int nbAttaques) 
        {
            Nom = nom;
            Pv = pv;
            NbDesAttaques = nbAttaques;
        }
        #endregion

        #region Méthodes
        public bool IsDeath()
        {
            return Pv == 0;
        }

        public virtual int Attaque(Guerrier guerrier)
        {
            Random rnd = new Random();
            int hit = rnd.Next(1, 6 + 1);
            guerrier.Pv -= hit;
            return hit;
        }

        public void AffichePv()
        {
            Console.WriteLine($"{Nom} possède {Pv} pv");
        }
        #endregion
    }
}
