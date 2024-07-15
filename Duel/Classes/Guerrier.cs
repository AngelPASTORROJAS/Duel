namespace Duel.Classes
{
    /// <summary>
    /// La classe <c>Guerrier</c> répresente un personnage avec un nom, un nombre de points de vie et d'attaque
    /// </summary>
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
        /// <summary>
        /// Le constructeur <c>Guerrier</c> 
        /// </summary>
        /// <param name="nom">Le nom du guerrier</param>
        /// <param name="pv">Le nombre de points de vie du guerrier</param>
        /// <param name="nbAttaques">Le nombre d'attaque effectuer par le guerrier</param>
        public Guerrier(string nom, int pv , int nbAttaques) 
        {
            _nom = nom;
            Pv = pv;
            NbDesAttaques = nbAttaques;
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// La méthode <c>AfficherInfos</c> affiche le nom et les PV du guerrier.
        /// </summary>
        public void AfficherInfos()
        {
            Console.WriteLine($" {Nom}{{PV={Pv}}}");
        }

        /// <summary>
        /// La méthode <c>SubirDegats</c> soustrait <c>degats</c> au PV du guerrier 
        /// et affiche un message si le guerrier n'as plus de PV.
        /// </summary>
        /// <param name="degats">
        /// Le paramètre <c>degats</c> est le nombre qu'on soustrait au guerrier.
        /// </param>
        /// <example> Exemple d'utilisation:
        /// <code>
        /// Guerrier  g1 = New Guerrier("A",89,7)
        /// g1.SubirDegats(7)
        /// </code>
        /// </example>
        public void SubirDegats(int degats)
        {
            Pv -= degats;
            if (Pv == 0 ) Console.WriteLine($"{Nom} is death.");
        }

        /// <summary>
        /// La méthode <c>Attaquer</c> affiche le nom de l'attaquant et celui de <c>adv</c>.  
        /// Elle fait subir des dégats à <c>adv</c>.
        /// </summary>
        /// <param name="adv">
        /// Le paramètre `adv` est de type Guerrier.
        /// </param>
        public virtual void Attaquer(Guerrier adv)
        {
            int i = 0;
            Console.WriteLine($"{Nom} attack {adv.Nom}");

            // Le guerrier attaque à adv NbDesAttaqus fois ou jusqu'à qu'il n'est plus de Pv
            while (!adv.EstMort() && i<NbDesAttaques)
            {
                // adv subit aléatoirement un dégat entre 1 et 6
                Random rnd = new Random();
                adv.SubirDegats(rnd.Next(1, 6 + 1));
                i++;
            }
        }

        /// <summary>
        /// La méthode <c>EstMort</c> définit si le guerrier ne possède plus de PV
        /// et renvoie un booléen.
        /// </summary>
        /// <returns>
        /// Renvoie true si les PV du guerrier est à 0 et false sinon.
        /// </returns>
        public bool EstMort() { return Pv==0; }
        #endregion
    }
}
