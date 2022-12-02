/* 
    Auteur : Dilan Morais Pinheiro
    Date : 07.11.2022
    Description : 
*/

List<int> myList = new List<int>();
string stgArrow = "-->";
string Alien1 = "  ▀▄   ▄▀";
string Alien2 = " ▄█▀███▀█▄";
string Alien3 = "█▀███████▀█";
string Alien4 = "█ █▀▀▀▀▀█ █";
string Alien5 = "   ▀▀ ▀▀";

string Alien6 = "  ▀▄   ▄▀";
string Alien7 = " ▄█▀███▀█▄";
string Alien8 = "█▀███████▀█";
string Alien9 = "█ █▀▀▀▀▀█ █";
string Alien10 = "  ▀▀ ▀▀";

string Alien11 = "  ▀▄   ▄▀";
string Alien12 = " ▄█▀███▀█▄";
string Alien13 = "█▀███████▀█";
string Alien14 = "█ █▀▀▀▀▀█ █";
string Alien15 = "   ▀▀ ▀▀";

string Alien16 = "  ▀▄   ▄▀";
string Alien17 = " ▄█▀███▀█▄";
string Alien18 = "█▀███████▀█";
string Alien19 = "█ █▀▀▀▀▀█ █";
string Alien20 = "   ▀▀ ▀▀";

string Alien21 = "  ▀▄   ▄▀";
string Alien22 = " ▄█▀███▀█▄";
string Alien23 = "█▀███████▀█";
string Alien24 = "█ █▀▀▀▀▀█ █";
string Alien25 = "   ▀▀ ▀▀";

string Alien26 = "  ▀▄   ▄▀";
string Alien27 = " ▄█▀███▀█▄";
string Alien28 = "█▀███████▀█";
string Alien29 = "█ █▀▀▀▀▀█ █";
string Alien30 = "   ▀▀ ▀▀";

string Alien31 = "  ▀▄   ▄▀";
string Alien32 = " ▄█▀███▀█▄";
string Alien33 = "█▀███████▀█";
string Alien34 = "█ █▀▀▀▀▀█ █";
string Alien35 = "   ▀▀ ▀▀";

string Alien36 = "  ▀▄   ▄▀";
string Alien37 = " ▄█▀███▀█▄";
string Alien38 = "█▀███████▀█";
string Alien39 = "█ █▀▀▀▀▀█ █";
string Alien40 = "   ▀▀ ▀▀";
const string SpaceShip = "      ▄\n     ███\n▄███████████▄\n█████████████\n█████████████";
int screenWidth = 125;
int screenHeight = 40;
int bytX = 40;
int bytY = 10;
int ShipPosX = 65;
int ShipPosY = 52;
int AlienPosX = 40;
int AlienPosY = 30;
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
        //AlienConstruct();
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
        Console.SetCursorPosition(ShipPosX, ShipPosY + i);
        Console.WriteLine(model[i]);
    }

    AlienConstruct();

    /*string[] model1 = Alien.Split("\n");

        for (int i = 0; i < model1.Count(); i++)
        {
            Console.SetCursorPosition(AlienPosX, AlienPosY + i);
            Console.WriteLine(model1[i]);
        }*/

}
void SpaceShipKey()
{
    do
    {
        Console.Clear();
        Console.SetWindowSize(screenWidth + 10, screenHeight + 10);
        spaceShip();


        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.LeftArrow:

                ShipPosX = ShipPosX - 4;
                if(ShipPosX < 3)
                {
                    ShipPosX = 3;
                }
                break;

            case ConsoleKey.RightArrow:

                ShipPosX = ShipPosX + 4;
                if(ShipPosX > 120)
                {
                    ShipPosX = 120;
                }
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
void AlienConstruct(/*int AlienPosX, int AlienPosY*/)
{
    Console.SetCursorPosition(35, 14);
    Console.WriteLine(Alien1);
    Console.SetCursorPosition(35, 15);
    Console.WriteLine(Alien2);
    Console.SetCursorPosition(35, 16);
    Console.WriteLine(Alien3);
    Console.SetCursorPosition(35, 17);
    Console.WriteLine(Alien4);
    Console.SetCursorPosition(35, 18);
    Console.WriteLine(Alien5);

    Console.SetCursorPosition(50, 14);
    Console.WriteLine(Alien6);
    Console.SetCursorPosition(50, 15);
    Console.WriteLine(Alien7);
    Console.SetCursorPosition(50, 16);
    Console.WriteLine(Alien8);
    Console.SetCursorPosition(50, 17);
    Console.WriteLine(Alien9);
    Console.SetCursorPosition(50, 18);
    Console.WriteLine(Alien10);

    Console.SetCursorPosition(65, 14);
    Console.WriteLine(Alien11);
    Console.SetCursorPosition(65, 15);
    Console.WriteLine(Alien12);
    Console.SetCursorPosition(65, 16);
    Console.WriteLine(Alien13);
    Console.SetCursorPosition(65, 17);
    Console.WriteLine(Alien14);
    Console.SetCursorPosition(65, 18);
    Console.WriteLine(Alien15);

    Console.SetCursorPosition(80, 14);
    Console.WriteLine(Alien16);
    Console.SetCursorPosition(80, 15);
    Console.WriteLine(Alien17);
    Console.SetCursorPosition(80, 16);
    Console.WriteLine(Alien18);
    Console.SetCursorPosition(80, 17);
    Console.WriteLine(Alien19);
    Console.SetCursorPosition(80, 18);
    Console.WriteLine(Alien20);

    Console.SetCursorPosition(35, 24);
    Console.WriteLine(Alien21);
    Console.SetCursorPosition(35, 25);
    Console.WriteLine(Alien22);
    Console.SetCursorPosition(35, 26);
    Console.WriteLine(Alien23);
    Console.SetCursorPosition(35, 27);
    Console.WriteLine(Alien24);
    Console.SetCursorPosition(35, 28);
    Console.WriteLine(Alien25);

    Console.SetCursorPosition(50, 24);
    Console.WriteLine(Alien26);
    Console.SetCursorPosition(50, 25);
    Console.WriteLine(Alien27);
    Console.SetCursorPosition(50, 26);
    Console.WriteLine(Alien28);
    Console.SetCursorPosition(50, 27);
    Console.WriteLine(Alien29);
    Console.SetCursorPosition(50, 28);
    Console.WriteLine(Alien30);

    Console.SetCursorPosition(65, 24);
    Console.WriteLine(Alien31);
    Console.SetCursorPosition(65, 25);
    Console.WriteLine(Alien32);
    Console.SetCursorPosition(65, 26);
    Console.WriteLine(Alien33);
    Console.SetCursorPosition(65, 27);
    Console.WriteLine(Alien34);
    Console.SetCursorPosition(65, 28);
    Console.WriteLine(Alien35);

    Console.SetCursorPosition(80, 24);
    Console.WriteLine(Alien36);
    Console.SetCursorPosition(80, 25);
    Console.WriteLine(Alien37);
    Console.SetCursorPosition(80, 26);
    Console.WriteLine(Alien38);
    Console.SetCursorPosition(80, 27);
    Console.WriteLine(Alien39);
    Console.SetCursorPosition(80, 28);
    Console.WriteLine(Alien40);
}