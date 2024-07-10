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
        public int Pv { get => _pv; set => _pv = value; }
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
        public int Attaque()
        {
            Random rnd = new Random();
            return rnd.Next(1,6+1);
        }
        #endregion
    }
}
