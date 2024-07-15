namespace Duel.Classes
{
    /// <summary>
    /// La classe `Game` représente une simulation de combat simple entre deux guerriers.
    /// La simulation se déroule pendant un nombre fixe de tours, chaque guerrier attaquant l'autre à tour de rôle.
    /// Le vainqueur est le guerrier qui reste debout à la fin de la simulation.
    /// </summary>
    internal class Game
    {
        /// <summary>
        /// Le constructeur initialise les deux objets guerriers, Galahad et Lancelot, 
        /// avec leurs noms, points de vie et force respectifs.
        /// Il exécute ensuite la simulation de combat pendant un nombre fixe de tours, 
        /// en affichant l'état de chaque guerrier après chaque tour.
        /// La simulation se termine lorsque l'un des guerriers est vaincu ou 
        /// que le nombre maximum de tours est atteint.
        /// </summary>
        public Game()
        {
            // Créer les deux objets guerriers
            Guerrier galahad = new Guerrier("Galahad", 99, 9);
            Guerrier lancelot = new Guerrier("Lancelot", 99, 9);

            // Définir le nombre de tours et un drapeau pour suivre la fin de la simulation
            int nbTour = 4;
            bool isEnd = false;

            // Exécuter la simulation de combat
            while (!isEnd && nbTour > 0)
            {
                // Afficher l'état de chaque guerrier
                lancelot.AfficherInfos();
                galahad.AfficherInfos();

                // Galahad attaque Lancelot
                galahad.Attaquer(lancelot);
                isEnd = lancelot.EstMort();
                if (isEnd)
                {
                    Console.WriteLine($"{galahad.Nom} is the winner.");
                }
                else
                {
                    // Lancelot attaque Galahad
                    lancelot.Attaquer(galahad);
                    isEnd = galahad.EstMort();
                    if (isEnd)
                    {
                        Console.WriteLine($"{lancelot.Nom} is the winner.");
                    }
                }
                Console.WriteLine();
                nbTour -= 1;
            }
        }

        /// <summary>
        /// La classe Game fait combattre <c>guerrier1</c> et <c>guerrier2</c> pendant <c>nbTour</c>
        /// </summary>
        /// <param name="guerrier1">Le premier guerrier</param>
        /// <param name="guerrier2">Le deuxième guerrier</param>
        /// <param name="nbTour">Le nombre de tour jouer</param>
        public Game(Guerrier guerrier1, Guerrier guerrier2, int nbTour)
        {
            bool isEnd = false;

            while (!isEnd && nbTour > 0)
            {
                guerrier2.AfficherInfos();
                guerrier1.AfficherInfos();

                guerrier1.Attaquer(guerrier2);
                isEnd = guerrier2.EstMort();
                if (isEnd)
                {
                    Console.WriteLine($"{guerrier1.Nom} is the winner.");
                }
                else
                {
                    guerrier2.Attaquer(guerrier1);
                    isEnd = guerrier1.EstMort();
                    if (isEnd)
                    {
                        Console.WriteLine($"{guerrier2.Nom} is the winner.");
                    }
                }
                Console.WriteLine();
                nbTour -= 1;
            }
        }
    }
}
