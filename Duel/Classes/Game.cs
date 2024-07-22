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
        /// La classe <c>Game</c> fait jouer un utilisateur en saisissant ses 2 guerriers avec leurs caractéristiques qui s'affronteront sur un nombre défini de tour.
        /// </summary>
        public Game()
        {
            Console.ForegroundColor = ConsoleColor.White;

            int nbTour;     // Le nombre de tour jouer dans la partie
            int choice;     // Le choix de la classe Guerrier
            int pv;         // Le nombre de points de vie du guerrier
            string nom;     // Le nom du guerrier
            int nbAttaque;  // Le nombre d'attaque effectuer par un guerrier par tour
            int bouclier;   // Le nombre de dégats encaisser par le bouclier

            // Création des deux guerriers
            Guerrier guerrier1 = new Guerrier("Galahad", 99, 9);
            Guerrier guerrier2 = new Guerrier("Lancelot", 99, 9);

            // Menu de création du guerrier1
            Console.WriteLine("--- Duels de guerriers ---");
            nbTour = Utils.InputInt("Choisissez le nombre de tour jouer : ", "\tErreur de saisis!", true);

            Console.WriteLine("\n\n--- Choix de la classe ---\n1 - Guerrier\n2 - Nain\n3 - Elfe\n");
            choice = Utils.InputInt("Choisissez la classe votre combattant : ", "\tErreur de saisis!", true, [1, 2, 3]);
            nom = Utils.InputString("Choisissez le nom de votre premier geurrier : ", "\tVotre nom ne peux pas être vide!", true);
            pv = Utils.InputInt($"Choisissez le nombre point de vie de {nom} : ", "\tErreur de saisis!", true);
            nbAttaque = Utils.InputInt($"Choisissez le nombre d'attaque par tour de {nom} : ", "\tErreur de saisis!", true);

            switch (choice)
            {
                case 1:
                    guerrier1 = new Guerrier(nom, pv, nbAttaque);
                    break;
                case 2:
                    bouclier = Utils.InputInt("Choisissez le nombre de dégats encaisser par le bouclier : ", "\tErreur de saisis!", true);
                    guerrier1 = new Nain(nom, pv, nbAttaque, bouclier);
                    break;
                case 3:
                    guerrier1 = new Elfe(nom, pv, nbAttaque);
                    break;
                default:
                    break;
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--- Duels de guerriers ---\n");
            Console.WriteLine("--- Choix de la classe ---\n1 - Guerrier\n2 - Nain\n3 - Elfe\n");
            choice = Utils.InputInt("Choisissez la classe votre combattant : ", "\tErreur de saisis!", true, [1, 2, 3]);
            nom = Utils.InputString("Choisissez le nom de votre premier geurrier : ", "\tVotre nom ne peux pas être vide!", true);
            pv = Utils.InputInt($"Choisissez le nombre point de vie de {nom} : ", "\tErreur de saisis!", true);
            nbAttaque = Utils.InputInt($"Choisissez le nombre d'attaque par tour de {nom} : ", "\tErreur de saisis!", true);

            switch (choice)
            {
                case 1:
                    guerrier2 = new Guerrier(nom, pv, nbAttaque);
                    break;
                case 2:
                    bouclier = Utils.InputInt("Choisissez le nombre de dégats encaisser par le bouclier : ", "\tErreur de saisis!", true);
                    guerrier2 = new Nain(nom, pv, nbAttaque, bouclier);
                    break;
                case 3:
                    guerrier2 = new Elfe(nom, pv, nbAttaque);
                    break;
                default:
                    break;
            }

            new Game(guerrier1 , guerrier2,nbTour);

            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// La classe Game fait combattre <c>guerrier1</c> et <c>guerrier2</c> pendant <c>nbTour</c>
        /// </summary>
        /// <param name="guerrier1">Le premier guerrier</param>
        /// <param name="guerrier2">Le deuxième guerrier</param>
        /// <param name="nbTour">Le nombre de tour jouer</param>
        public Game(Guerrier guerrier1, Guerrier guerrier2, int nbTour)
        {
            // Définir le nombre de tours et un drapeau pour suivre la fin de la simulation
            bool isEnd = false;

            // Exécuter la simulation de combat
            while (!isEnd && nbTour > 0)
            {
                // Afficher l'état de chaque guerrier
                guerrier2.AfficherInfos();
                guerrier1.AfficherInfos();

                // guerrier1 attaque guerrier2
                guerrier1.Attaquer(guerrier2);
                isEnd = guerrier2.EstMort();
                if (!isEnd)
                {
                    // guerrier2 attaque guerrier1
                    guerrier2.Attaquer(guerrier1);
                    isEnd = guerrier1.EstMort();
                    if (isEnd)
                    {
                        Console.WriteLine($"{guerrier2.Nom} is the winner.");
                    }
                }
                else
                {
                    Console.WriteLine($"{guerrier1.Nom} is the winner.");
                }
                Console.WriteLine();
                nbTour -= 1;
            }
        }
    }
}
