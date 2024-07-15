namespace Duel.Classes
{
    /// <summary>
    /// La classe <c>Elfe</c> est une classe fille de <c>Guerrier</c> qui répresente un personnage avec un nom, un nombre de points de vie et d'attaque.
    /// Deplus, la classe Elfe possède une très grande précision d'attaque.
    /// </summary>
    internal class Elfe : Guerrier
    {
        /// <summary>
        /// Le constructeur Elfe créer un guerrier de classe Elfe avec une très grande présion d'attaque.
        /// </summary>
        /// <param name="nom">Le nom de l'elfe.</param>
        /// <param name="pv">Les points de vie de l'elfe.</param>
        /// <param name="nbAttaques">Le nombre d'attaque de l'elfe.</param>
        public Elfe(string nom, int pv, int nbAttaques) : base(nom, pv, nbAttaques) { }


        /// <summary>
        /// La méthode <c>Attaquer</c> affiche le nom de l'attaquant et celui de <c>adv</c>.  
        /// Elle fait subir des dégats à <c>adv</c> avec une très grande précision.
        /// </summary>
        /// <param name="adv">
        /// Le paramètre `adv` est de type Guerrier.
        /// </param>
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
