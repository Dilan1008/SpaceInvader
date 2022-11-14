/* 
    Auteur : Dilan Morais Pinheiro
    Date : 07.11.2022
    Description : 
*/

List<int> myList = new List<int>();
string stgArrow = "-->";
string Spaceship1 = " " + " " + " " + " " + " " + " " + "▄";
string Spaceship2 = " " + " " + " " + " " + " " + "███";
string Spaceship3 = "▄███████████▄";
string Spaceship4 = "█████████████";
string Spaceship5 = "█████████████";
int screenWidth = 125;
int screenHeight = 40;
int bytX = 40;
int bytY = 10;
int alienPosX = 65;
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
    if(bytY == 10)
    {
        SpaceShipMove();
    }
    if(bytY == 16)
    {
        Settings();
    }


}while (true);

void SpaceShipMove()
{
    do
    {
            Console.SetWindowSize(screenWidth + 20, screenHeight + 20);
            Console.Clear();
            Console.SetCursorPosition(alienPosX, 52);
            Console.WriteLine(Spaceship1);
            Console.SetCursorPosition(alienPosX, 53);
            Console.WriteLine(Spaceship2);
            Console.SetCursorPosition(alienPosX, 54);
            Console.WriteLine(Spaceship3);
            Console.SetCursorPosition(alienPosX, 55);
            Console.WriteLine(Spaceship4);
            Console.SetCursorPosition(alienPosX, 56);
            Console.WriteLine(Spaceship5);


        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.LeftArrow:

                alienPosX = alienPosX - 4;
                if (alienPosX < 2)
                {
                    alienPosX = 2;
                }
                break;

            case ConsoleKey.RightArrow:

                alienPosX = alienPosX + 4;
                if (alienPosX > 130)
                {
                    alienPosX = 130;
                }
                break;

            case ConsoleKey.Enter:

                Enter = 2;
                break;
        }

    } while (Enter != 2);
}
void Settings()
{
    do
    {
        Console.Clear();
        Console.WriteLine("  ____             ");
        Console.WriteLine("  / ___|  ___  _ __  ");
        Console.WriteLine(@" \___ \ / _ \| '_ \ ");
        Console.WriteLine("   ___) | (_) | | | |");
        Console.WriteLine(@" |____/ \___/|_| |_|");

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.Enter:

                Enter = 2;
                break;
        }

    } while (Enter != 2);

}