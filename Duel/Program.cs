using Duel.Classes;

// Variable de valeur
int pv;
String? nom;
int nbAttaque;
int nbTour;

bool existPv;
bool existNbAttaque;
bool existChoice;
int choice;

Guerrier guerrier1;
Guerrier guerrier2;

Console.WriteLine("--- Duels de guerriers ---\n");

Console.Write("Choisissez le nombre de tour jouer : ");
bool isValidNbTour;
isValidNbTour = int.TryParse(Console.ReadLine(), out nbTour);
while (!(isValidNbTour && nbTour>0))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\tErreur de saisis!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Choisissez le nombre de tour jouer : ");
    isValidNbTour = int.TryParse(Console.ReadLine(), out nbTour);
}

Console.Write("Choisissez le nom de votre premier geurrier : ");
nom = Console.ReadLine();
while (!(nom?.Length > 0))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\tVotre nom ne peux pas être vide!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Choisissez le nom de votre premier guerrier : ");
    nom = Console.ReadLine();
}

Console.Write($"Choisissez le nombre point de vie de {nom} : ");
existPv = int.TryParse(Console.ReadLine(), out pv);
while (!(existPv && nbTour > 0))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\tErreur de saisis!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Choisissez le nombre point de vie de {nom} : ");
    existPv = int.TryParse(Console.ReadLine(), out pv);
}

Console.Write($"Choisissez le nombre d'attaque par tour de {nom} : ");
existNbAttaque = int.TryParse(Console.ReadLine(), out nbAttaque);
while (!(existNbAttaque && nbTour > 0))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\tErreur de saisis!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Choisissez le nombre d'attaque par tour de {nom} : ");
    existNbAttaque = int.TryParse(Console.ReadLine(), out nbAttaque);
}

Console.WriteLine("\n\n--- Choix de la classe ---\n");
Console.WriteLine("1 - Guerrier");
Console.WriteLine("2 - Nain");
Console.WriteLine("3 - Elfe\n");

Console.Write("Choisissez la classe votre combattant : ");
existChoice = int.TryParse(Console.ReadLine(), out choice);
while (!(existChoice && choice>0 && choice<4))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\tErreur de saisis!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Choisissez la calsse votre combattant : ");
    existChoice = int.TryParse(Console.ReadLine(), out choice);
}
switch (choice)
{
    case 1:
        guerrier1 = new Guerrier(nom,pv,nbAttaque);
        break;
    case 2:
        guerrier1 = new Nain(nom, pv, nbAttaque);
        break;
    case 3:
        guerrier1 = new Elfe(nom, pv, nbAttaque);
        break;
    default:
        break;
}

Console.ReadKey();
Console.Clear();

Console.Write("Choisissez le nom de votre deuxième geurrier : ");
nom = Console.ReadLine();
while (!(nom?.Length > 0))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\tVotre nom ne peux pas être vide!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Choisissez le nom de votre duexième guerrier : ");
    nom = Console.ReadLine();
}

Console.Write($"Choisissez le nombre point de vie de {nom} : ");
existPv = int.TryParse(Console.ReadLine(), out pv);
while (!(existPv && nbTour > 0))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\tErreur de saisis!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Choisissez le nombre point de vie de {nom} : ");
    existPv = int.TryParse(Console.ReadLine(), out pv);
}

Console.Write($"Choisissez le nombre d'attaque par tour de {nom} : ");
existNbAttaque = int.TryParse(Console.ReadLine(), out nbAttaque);
while (!(existNbAttaque && nbTour > 0))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\tErreur de saisis!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Choisissez le nombre d'attaque par tour de {nom} : ");
    existNbAttaque = int.TryParse(Console.ReadLine(), out nbAttaque);
}

Console.WriteLine("\n\n--- Choix de la classe ---\n");
Console.WriteLine("1 - Guerrier");
Console.WriteLine("2 - Nain");
Console.WriteLine("3 - Elfe\n");

Console.Write("Choisissez la classe votre combattant : ");
existChoice = int.TryParse(Console.ReadLine(), out choice);
while (!(existChoice && choice > 0 && choice < 4))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\tErreur de saisis!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Choisissez la calsse votre combattant : ");
    existChoice = int.TryParse(Console.ReadLine(), out choice);
}
switch (choice)
{
    case 1:
        guerrier2 = new Guerrier(nom, pv, nbAttaque);
        break;
    case 2:
        guerrier2 = new Nain(nom, pv, nbAttaque);
        break;
    case 3:
        guerrier2 = new Elfe(nom, pv, nbAttaque);
        break;
    default:
        break;
}

do
{
    guerrier1.Pv;
    guerrier2;
} while (guerrier1.IsDeath() || guerrier2.IsDeath());