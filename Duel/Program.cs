using Duel.Classes;

Guerrier galahad = new Guerrier("Galahad",99,9);
Guerrier lancelot = new Guerrier("Lancelot",99,9);

int nbTour = 4;
bool isEnd = false;

while (!isEnd && nbTour > 0)
{
    lancelot.AfficherInfos();
    galahad.AfficherInfos();

    galahad.Attaquer(lancelot);
    if (lancelot.EstMort())
    {
        isEnd = true;
        Console.WriteLine($"{galahad.Nom} is the winner.");
    }
    else
    {
        lancelot.Attaquer(galahad);
        if (galahad.EstMort())
        {
            isEnd = true;
            Console.WriteLine($"{lancelot.Nom} is the winner.");
        }
    }
    Console.WriteLine();
    nbTour -= 1;
}

/**
int pv;
string nom;
int nbAttaque;
int choice;


/**
Console.WriteLine("--- Duels de guerriers ---\n");
nbTour = Utils.InputInt("Choisissez le nombre de tour jouer : ","\tErreur de saisis!",true);

nom = Utils.InputString("Choisissez le nom de votre premier geurrier : ", "\tVotre nom ne peux pas être vide!",true);
pv = Utils.InputInt($"Choisissez le nombre point de vie de {nom} : ", "\tErreur de saisis!",true);
nbAttaque = Utils.InputInt($"Choisissez le nombre d'attaque par tour de {nom} : ", "\tErreur de saisis!", true);

Console.WriteLine("\n\n--- Choix de la classe ---\n1 - Guerrier\n2 - Nain\n3 - Elfe\n");
choice = Utils.InputInt("Choisissez la classe votre combattant : ", "\tErreur de saisis!", true);


Console.ReadKey();
Console.Clear();
*/