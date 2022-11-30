/* 
    Auteur : Dilan Morais Pinheiro
    Date : 07.11.2022
    Description : 
*/

List<int> myList = new List<int>();
string stgArrow = "-->";
/*string Spaceship1 = " " + " " + " " + " " + " " + " " + "▄";
string Spaceship2 = " " + " " + " " + " " + " " + "███";
string Spaceship3 = "▄███████████▄";
string Spaceship4 = "█████████████";
string Spaceship5 = "█████████████";*/
const string SpaceShip = "       ▄\n     ███\n▄███████████▄\n█████████████\n█████████████";
int screenWidth = 125;
int screenHeight = 40;
int bytX = 40;
int bytY = 10;
int alienPosX = 65;
int alienPosY = 52;
byte Enter;

do
{
    do
    {
        // Clear la console
        Console.Clear();

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
    if(bytY == 10)
    {
        SpaceShipKey();
    }
    if(bytY == 16)
    {
        Settings();
    }
    if(bytY == 28)
    {
        About();
    }
    if(bytY == 34)
    {
        Environment.Exit(0);
    }



}while (true);

void spaceShip()
{
    string[] model = SpaceShip.Split("\n");
    
    for( int i = 0; i < model.Count(); i++)
    {
        Console.SetCursorPosition(alienPosX, alienPosY + i);
        Console.WriteLine(model[i]);
    }
}
void SpaceShipKey()
{
    do
    {
        Console.Clear();
        Console.SetWindowSize(screenWidth + 20, screenHeight + 20);
        spaceShip();


        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.LeftArrow:

                alienPosX = alienPosX - 4;
                break;

            case ConsoleKey.RightArrow:

                alienPosX = alienPosX + 4;
                break;

            case ConsoleKey.Enter:

                Enter = 2;
                break;

            case ConsoleKey.Spacebar:
                break;
        }

    } while (Enter != 2);
}
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
        Console.WriteLine("\t\t\t\t\t\t" + " / ___|  ___  _   _ _ __   __| |" + " " + " " + @"  / _ \| \ | |" + "   /" +  @"/ _ \|  ___|  ___|");
        Console.WriteLine("\t\t\t\t\t\t" + @" \___ \ / _ \| | | | '_ \ / _` |" + " " + " " + @" | | | |  \| |" + "  /" +  @"| | | | |_  | |_   ");
        Console.WriteLine("\t\t\t\t\t\t" + "  ___) | (_) | |_| | | | | (_| |" + " " + " " + @" | |_| | |\  |" + " /" +    @" | |_| |  _| |  _|  ");
        Console.WriteLine("\t\t\t\t\t\t" + @" |____/ \___/ \__,_|_| |_|\__,_|" + " " + " " + @"  \___/|_| \_|" + "/" +    @"   \___/|_|   |_|    ");

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

                if(bytSettingsY == 16)
                {
                    bytSettingsY = 17;
                    if(bytSettingsY == 17)
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
        Console.WriteLine("Le but du projet est de prgrammer un jeux intituler SpaceInvaders dans le but est d'éliminer les aliens adverse avant qu'ils ne vous envahisse");

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.Escape :
                Enter = 2;
                break;
        }


    } while (Enter != 2);
}
void Alien()
{

}