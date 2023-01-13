/* 
    Auteur : Dilan Morais Pinheiro
    Date : 05.01.2023
    Description : Jeu Space Invaders
*/
using System.Timers;
using Class;
using System.Threading;
using System.Text;

Console.OutputEncoding = Encoding.Unicode; // Permet d'ajouter certain carachtère
List<Missile> missiles = new List<Missile>(); // Liste de missile
List<int> myList = new List<int>();
string stgArrow = "-->";
const string Alien1 = "  ▀▄   ▄▀\n ▄█▀███▀█▄\n█▀███████▀█\n█ █▀▀▀▀▀█ █\n   ▀▀ ▀▀"; // Design de l'alien
const string SpaceShip = "      ▄\n     ███\n▄███████████▄\n█████████████\n█████████████"; // Design du vaisseau
int screenWidth = 125; // Taille de l'écran
int screenHeight = 40; // Taille de l'écran
int bytX = 40;
int bytY = 10;
int ShipPosX = 65; // Position X du vaisseau
int ShipPosY = 52; // Position Y du vaisseau
int AlienPosX = 40; // Position X de l'alien
int AlienPosY = 14; // Position Y de l'alien

int[] yFireMoving = new int[3]; // Position Y du missile
int[] xFireMoving = new int[3]; // Position X du missile
bool isFireExist = false;
int xFirePos = 0;
int yFirePos = 0;

int[] xAlienPos = new int[8];
int[] yAlienPos = new int[8];
byte Enter;

do
{
    do
    {
        // Clear la console
        Console.Clear();
        Console.CursorVisible = false;

        // Affiche le menu
        Console.SetWindowSize(screenWidth, screenHeight);
        Console.WriteLine("\t ███████ ██████   █████   ██████ ███████     ██ ███    ██ ██    ██  █████  ██████  ███████ ██████  ███████ ");
        Console.WriteLine("\t ██      ██   ██ ██   ██ ██      ██          ██ ████   ██ ██    ██ ██   ██ ██   ██ ██      ██   ██ ██      ");
        Console.WriteLine("\t ███████ ██████  ███████ ██      █████       ██ ██ ██  ██ ██    ██ ███████ ██   ██ █████   ██████  ███████ ");
        Console.WriteLine("\t      ██ ██      ██   ██ ██      ██          ██ ██  ██ ██  ██  ██  ██   ██ ██   ██ ██      ██   ██      ██ ");
        Console.WriteLine("\t ███████ ██      ██   ██  ██████ ███████     ██ ██   ████   ████   ██   ██ ██████  ███████ ██   ██ ███████ ");
        Console.WriteLine("\n\n");

        Console.WriteLine("\t\t\t\t\t\t" + @"  ____  _             ");
        Console.WriteLine("\t\t\t\t\t\t" + @" |  _ \| | __ _ _   _ ");
        Console.WriteLine("\t\t\t\t\t\t" + @" | |_) | |/ _` | | | |");
        Console.WriteLine("\t\t\t\t\t\t" + @" |  __/| | (_| | |_| |");
        Console.WriteLine("\t\t\t\t\t\t" + @" |_|   |_|\__,_|\__, |");
        Console.WriteLine("\t\t\t\t\t\t" + @"                |___/");

        Console.WriteLine("\t\t\t\t\t\t" + @"  ____       _   _   _                 ");
        Console.WriteLine("\t\t\t\t\t\t" + @" / ___|  ___| |_| |_(_)_ __   __ _ ___ ");
        Console.WriteLine("\t\t\t\t\t\t" + @" \___ \ / _ \ __| __| | '_ \ / _` / __|");
        Console.WriteLine("\t\t\t\t\t\t" + @"  ___) |  __/ |_| |_| | | | | (_| \__ \");
        Console.WriteLine("\t\t\t\t\t\t" + @" |____/ \___|\__|\__|_|_| |_|\__, |___/");
        Console.WriteLine("\t\t\t\t\t\t" + @"                             |___/     ");

        Console.WriteLine("\t\t\t\t\t\t" + @"  _   _ _       _                                 ");
        Console.WriteLine("\t\t\t\t\t\t" + @" | | | (_) __ _| |__  ___  ___ ___  _ __ ___  ___ ");
        Console.WriteLine("\t\t\t\t\t\t" + @" | |_| | |/ _` | '_ \/ __|/ __/ _ \| '__/ _ \/ __|");
        Console.WriteLine("\t\t\t\t\t\t" + @" |  _  | | (_| | | | \__ \ (_| (_) | | |  __/\__ \");
        Console.WriteLine("\t\t\t\t\t\t" + @" |_| |_|_|\__, |_| |_|___/\___\___/|_|  \___||___/");
        Console.WriteLine("\t\t\t\t\t\t" + @"          |___/                                   ");

        Console.WriteLine("\t\t\t\t\t\t" + @"     _    _                 _   ");
        Console.WriteLine("\t\t\t\t\t\t" + @"    / \  | |__   ___  _   _| |_ ");
        Console.WriteLine("\t\t\t\t\t\t" + @"   / _ \ | '_ \ / _ \| | | | __|");
        Console.WriteLine("\t\t\t\t\t\t" + @"  / ___ \| |_) | (_) | |_| | |_ ");
        Console.WriteLine("\t\t\t\t\t\t" + @" /_/   \_\_.__/ \___/ \__,_|\__|");

        Console.WriteLine("\t\t\t\t\t\t" + @"  _____      _ _   ");
        Console.WriteLine("\t\t\t\t\t\t" + @" | ____|_  _(_) |_ ");
        Console.WriteLine("\t\t\t\t\t\t" + @" |  _| \ \/ / | __|");
        Console.WriteLine("\t\t\t\t\t\t" + @" | |___ >  <| | |_ ");
        Console.WriteLine("\t\t\t\t\t\t" + @" |_____/_/\_\_|\__|");

        Console.SetCursorPosition(bytX, (myList.Count + bytY));
        Console.Write(stgArrow);

        Enter = 0;

        // Switch qui permet de naviguer dans le menu
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.UpArrow:

                bytY = bytY - 6;
                if (bytY == 29)
                {
                    bytY = bytY + 1;
                }
                if (bytY < 10)
                {
                    bytY = 10;
                }
                break;

            case ConsoleKey.DownArrow:

                bytY = bytY + 6;
                if (bytY == 29)
                {
                    bytY = bytY - 1;
                }
                if (bytY > 34)
                {
                    bytY = 34;
                }
                break;

            case ConsoleKey.Enter:

                Enter = 1;
                break;
        }
    } while (Enter != 1);
    Console.Clear();

    // Selon la position du curseur cela va afficher une nouvelle fenêtre
    if (bytY == 10)
    {
        SpaceShipKey();
    }
    if (bytY == 16)
    {
        Settings();
    }
    if (bytY == 28)
    {
        About();
    }
    if (bytY == 34)
    {
        Environment.Exit(0);
    }
} while (true);


void spaceShip()
{
    // Met le vaisseau dans un tableau pour l'afficher correctement 
    string[] model = SpaceShip.Split("\n");

    for (int i = 0; i < model.Count(); i++)
    {
        Console.SetCursorPosition(ShipPosX, ShipPosY + i);
        Console.WriteLine(model[i]);
    }
    AlienConstruct();
}

void HignScore()
{
    Console.WriteLine("Score");
    Console.WriteLine("Dimitrie : 3000");
    Console.WriteLine("Alex345 : 500");
    Console.WriteLine("Fritosse2000 : 1000");
    Console.WriteLine("FunyBary : 5000");
    Console.WriteLine("Zboona : 300");
    Console.WriteLine("YO4N1ST : 100");
}


/// <summary>
/// Méthode pour les mouvements du vaisseau
/// </summary>
void SpaceShipKey()
{

    do
    {
        // redimensionne la fenêtre de jeu
        Console.SetWindowSize(screenWidth + 10, screenHeight + 10);
        spaceShip();
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey();

            }
            // Switch qui permet de déplacer le vaisseau de gauche à droite et de tirer un missile 
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:

                    int oldShipXL = ShipPosX;
                    ShipPosX = ShipPosX - 4;
                    if (ShipPosX > 3)
                    {
                        // Copie une zone source spécifiée du tampon d'écran vers une zone de destination spécifiée 
                        Console.MoveBufferArea(oldShipXL, ShipPosY, 13, 5, ShipPosX, ShipPosY);
                    }
                    else
                    {
                        ShipPosX = 3;
                        Console.MoveBufferArea(oldShipXL, ShipPosY, 13, 5, ShipPosX, ShipPosY);
                    }
                    break;

                case ConsoleKey.RightArrow:
                    int oldShipX = ShipPosX;
                    ShipPosX = ShipPosX + 4;
                    if (ShipPosX! < 120)
                    {
                        Console.MoveBufferArea(oldShipX, ShipPosY, 13, 5, ShipPosX, ShipPosY);
                    }
                    else
                    {
                        ShipPosX = 120;
                        Console.MoveBufferArea(oldShipX, ShipPosY, 13, 5, ShipPosX, ShipPosY);
                    }
                    break;

                case ConsoleKey.Spacebar:
                    // Déplace le missile dans un tableau
                    if (isFireExist == false)
                    {
                        xFireMoving[0] = ShipPosX + 6;
                        yFireMoving[0] = ShipPosY - 1;
                        isFireExist = true;
                        ShootShip(xFireMoving[0], yFireMoving[0]);
                    }
                    break;

                case ConsoleKey.Escape:

                    Enter = 2;
                    break;

            }
        }
        Thread.Sleep(16);



        if (yFireMoving[0] != 11 && isFireExist)
        {
            // Met le missile dans un tableau
            yFirePos = yFireMoving[0];
            xFirePos = xFireMoving[0];

            yFireMoving[1] = yFireMoving[0] - 1;
            yFireMoving[0] = yFireMoving[1];

            xFireMoving[1] = xFireMoving[0];
            xFireMoving[0] = xFireMoving[1];

            // Fait disparaitre le missile quand il touche le font de l'écran
            Console.SetCursorPosition(xFirePos, yFirePos);
            Console.WriteLine(" ");

            ShootShip(xFireMoving[0], yFireMoving[0]);
        }



        // Efface un alien quand le missile le touche 
        if (yFireMoving[0] == 14)
        {
            int delX = xFireMoving[0];
            int delY = yFireMoving[0];
            isFireExist = false;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(delX, delY++);
                Console.WriteLine("           ");

            }
        }
    } while (Enter != 2);
}

/// <summary>
/// Méthode pour afficher les settings
/// </summary>
void Settings()
{
    int bytSettingsX = 40;
    int bytSettingsY = 11;
    do
    {

        Console.Clear();
        Console.WriteLine("\t\t\t\t\t\t" + @"  ____       _   _   _                 ");
        Console.WriteLine("\t\t\t\t\t\t" + @" / ___|  ___| |_| |_(_)_ __   __ _ ___ ");
        Console.WriteLine("\t\t\t\t\t\t" + @" \___ \ / _ \ __| __| | '_ \ / _` / __|");
        Console.WriteLine("\t\t\t\t\t\t" + @"  ___) |  __/ |_| |_| | | | | (_| \__ \");
        Console.WriteLine("\t\t\t\t\t\t" + @" |____/ \___|\__|\__|_|_| |_|\__, |___/");
        Console.WriteLine("\t\t\t\t\t\t" + @"                             |___/     ");
        Console.WriteLine("\n\n");


        Console.WriteLine("\t\t\t\t\t\t" + "  ____                        _ " + " " + " " + @"   ___  _   _ " + "    /" + @"___  _____ _____ ");
        Console.WriteLine("\t\t\t\t\t\t" + " / ___|  ___  _   _ _ __   __| |" + " " + " " + @"  / _ \| \ | |" + "   /" + @"/ _ \|  ___|  ___|");
        Console.WriteLine("\t\t\t\t\t\t" + @" \___ \ / _ \| | | | '_ \ / _` |" + " " + " " + @" | | | |  \| |" + "  /" + @"| | | | |_  | |_   ");
        Console.WriteLine("\t\t\t\t\t\t" + "  ___) | (_) | |_| | | | | (_| |" + " " + " " + @" | |_| | |\  |" + " /" + @" | |_| |  _| |  _|  ");
        Console.WriteLine("\t\t\t\t\t\t" + @" |____/ \___/ \__,_|_| |_|\__,_|" + " " + " " + @"  \___/|_| \_|" + "/" + @"   \___/|_|   |_|    ");

        Console.WriteLine("\t\t\t\t\t\t" + " ____  _  __  __ _            _ _         ");
        Console.WriteLine("\t\t\t\t\t\t" + @"|  _ \(_)/ _|/ _(_) ___ _   _| | |_ _   _ ");
        Console.WriteLine("\t\t\t\t\t\t" + @"| | | | | |_| |_| |/ __| | | | | __| | | |");
        Console.WriteLine("\t\t\t\t\t\t" + "| |_| | |  _|  _| | (__| |_| | | |_| |_| |");
        Console.WriteLine("\t\t\t\t\t\t" + @"|____/|_|_| |_| |_|\___|\__,_|_|\__|\__, |");
        Console.WriteLine("\t\t\t\t\t\t" + @"                                    |___/ ");

        Console.WriteLine("\t\t\t\t\t\t" + @" _____                ");
        Console.WriteLine("\t\t\t\t\t\t" + @"| ____|__ _ ___ _   _ ");
        Console.WriteLine("\t\t\t\t\t\t" + @"|  _| / _` / __| | | |");
        Console.WriteLine("\t\t\t\t\t\t" + @"| |__| (_| \__ \ |_| |");
        Console.WriteLine("\t\t\t\t\t\t" + @"|_____\__,_|___/\__, |");
        Console.WriteLine("\t\t\t\t\t\t" + @"                |___/");

        Console.WriteLine("\t\t\t\t\t\t" + @" _   _               _ ");
        Console.WriteLine("\t\t\t\t\t\t" + @"| | | | __ _ _ __ __| |");
        Console.WriteLine("\t\t\t\t\t\t" + @"| |_| |/ _` | '__/ _` |");
        Console.WriteLine("\t\t\t\t\t\t" + @"|  _  | (_| | | | (_| |");
        Console.WriteLine("\t\t\t\t\t\t" + @"|_| |_|\__,_|_|  \__,_|");

        Console.SetCursorPosition(bytSettingsX, (myList.Count + bytSettingsY));
        Console.Write(stgArrow);

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.UpArrow:
                bytSettingsY = bytSettingsY - 5;

                if (bytSettingsY < 11)
                {
                    bytSettingsY = 11;
                }
                break;

            case ConsoleKey.DownArrow:

                bytSettingsY = bytSettingsY + 5;
                if (bytSettingsY > 16)
                {
                    bytSettingsY = 16;
                }
                break;
            case ConsoleKey.Enter:

                if (bytSettingsY == 16)
                {
                    bytSettingsY = 17;
                    if (bytSettingsY == 17)
                    {
                        bytSettingsY = bytSettingsY + 6;
                    }
                }
                break;
            case ConsoleKey.Escape:
                Enter = 2;
                break;
        }

    } while (Enter != 2);

}
/// <summary>
/// Méthode pour afficher la page about
/// </summary>
void About()
{
    do
    {
        Console.Clear();
        Console.WriteLine("\t\t\t\t\t\t" + @"     _    _                 _   ");
        Console.WriteLine("\t\t\t\t\t\t" + @"    / \  | |__   ___  _   _| |_ ");
        Console.WriteLine("\t\t\t\t\t\t" + @"   / _ \ | '_ \ / _ \| | | | __|");
        Console.WriteLine("\t\t\t\t\t\t" + @"  / ___ \| |_) | (_) | |_| | |_ ");
        Console.WriteLine("\t\t\t\t\t\t" + @" /_/   \_\_.__/ \___/ \__,_|\__|");
        Console.WriteLine("\n\n");

        Console.WriteLine("Création d'un programme dans le carde d'un projet");
        Console.WriteLine("Le but du projet est de prgrammer un jeu intituler SpaceInvaders dans le but est d'éliminer les aliens adverse avant qu'ils ne vous envahisse");

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.Escape:
                Enter = 2;
                break;
        }


    } while (Enter != 2);
}
/// <summary>
/// Méthode pour afficher les aliens
/// </summary>
void AlienConstruct()
{
    // Met les caractère de l'alien dans un tableau pour l'afficher correctement 
    for (int k = 0; k < 2; k++)
    {
        for (int j = 0; j < 4; j++)
        {
            string[] model = Alien1.Split("\n");

            for (int i = 0; i < model.Count(); i++)
            {
                Console.SetCursorPosition(AlienPosX, AlienPosY + i);
                Console.WriteLine(model[i]);
                xAlienPos[i] = AlienPosX;
                yAlienPos[i] = AlienPosY;
            }
            AlienPosX += 15;
        }
        AlienPosX = 40;
        AlienPosY = 19;
    }
}
/// <summary>
/// Méthode pour le missile
/// </summary>
static void ShootShip(int x, int y)
{
    // Afficher le missile selon les cordooné x et y 
    Console.SetCursorPosition(x, y);
    Console.WriteLine("╿");
}