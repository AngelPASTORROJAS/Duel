using Duel.Classes;

// Game game = new Game();

int nbTour;

int choice;
int pv;
string nom;
int nbAttaque;
Guerrier g1 = new Guerrier("1", 0, 0);
Guerrier g2 = new Guerrier("2", 0, 0);

Console.WriteLine("--- Duels de guerriers ---\n");
nbTour = Utils.InputInt("Choisissez le nombre de tour jouer : ","\tErreur de saisis!",true);

Console.WriteLine("\n\n--- Choix de la classe ---\n1 - Guerrier\n2 - Nain\n3 - Elfe\n");
choice = Utils.InputInt("Choisissez la classe votre combattant : ", "\tErreur de saisis!", true, [1,2,3]);
nom = Utils.InputString("Choisissez le nom de votre premier geurrier : ", "\tVotre nom ne peux pas être vide!",true);
pv = Utils.InputInt($"Choisissez le nombre point de vie de {nom} : ", "\tErreur de saisis!",true);
nbAttaque = Utils.InputInt($"Choisissez le nombre d'attaque par tour de {nom} : ", "\tErreur de saisis!", true);


if (choice == 1)
{
    g1 = new Guerrier(nom,pv,nbAttaque);
}else if (choice == 2)
{
    g1 = new Nain(nom,pv,nbAttaque);
}
else
{
    g1 = new Elfe(nom,pv,nbAttaque);
}

Console.ReadKey();
Console.Clear();

Console.WriteLine("--- Duels de guerriers ---\n");
Console.WriteLine("\n\n--- Choix de la classe ---\n1 - Guerrier\n2 - Nain\n3 - Elfe\n");
choice = Utils.InputInt("Choisissez la classe votre combattant : ", "\tErreur de saisis!", true, [1, 2, 3]);
nom = Utils.InputString("Choisissez le nom de votre premier geurrier : ", "\tVotre nom ne peux pas être vide!", true);
pv = Utils.InputInt($"Choisissez le nombre point de vie de {nom} : ", "\tErreur de saisis!", true);
nbAttaque = Utils.InputInt($"Choisissez le nombre d'attaque par tour de {nom} : ", "\tErreur de saisis!", true);

if (choice == 1)
{
    g2 = new Guerrier(nom, pv, nbAttaque);
}
else if (choice == 2)
{
    g2 = new Nain(nom, pv, nbAttaque);
}
else
{
    g2 = new Elfe(nom, pv, nbAttaque);
}

Game game = new Game(g1,g2,nbTour);

Console.ReadKey();
Console.Clear();