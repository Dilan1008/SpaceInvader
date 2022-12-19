using System.Timers;
using Class;
using System.Threading;
using System.Text;

/* 
    Auteur : Dilan Morais Pinheiro
    Date : 07.11.2022
    Description : 
*/
Console.OutputEncoding = Encoding.Unicode;
List<Missile> missiles = new List<Missile>();
List<int> myList = new List<int>();
string stgArrow = "-->";
const string Alien1 = "  ▀▄   ▄▀\n ▄█▀███▀█▄\n█▀███████▀█\n█ █▀▀▀▀▀█ █\n   ▀▀ ▀▀";
//string Alien2 = "  ▀▄   ▄▀";
//string Alien3 = " ▄█▀███▀█▄";
//string Alien4 = "█▀███████▀█";
//string Alien5 = "█ █▀▀▀▀▀█ █";
//string Alien5 = "   ▀▀ ▀▀";

const string SpaceShip = "      ▄\n     ███\n▄███████████▄\n█████████████\n█████████████";
int screenWidth = 125;
int screenHeight = 40;
int bytX = 40;
int bytY = 10;
int ShipPosX = 65;
int ShipPosY = 52;
int AlienPosX = 40;
int AlienPosY = 14;
/*int AlienPosX2 = 30;
int AlienPosX3 = 30;
int AlienPosX4 = 30;
int AlienPosX5 = 30;*/
int ShootPosY = 50;
int ShootEspacePosY = 50;

int[] yFireMoving = new int[3];
int[] xFireMoving = new int[3];
bool isFireExist = false;
int xFirePos = 0;
int yFirePos = 0;

int[] xAlienPos = new int[8];
int[] yAlienPos = new int[8];

/*int[] xFirstLineEnemy = new int[6];
xFirstLineEnemy[0] = 60; xFirstLineEnemy[1] = 66; xFirstLineEnemy[2] = 72;
xFirstLineEnemy[3] = 78; 

int[] yFirstLineEnemy = new int[7];
yFirstLineEnemy[0] = 19; yFirstLineEnemy[1] = 19; yFirstLineEnemy[2] = 19;
yFirstLineEnemy[3] = 19; 

int[] xSecondLineEnemy = new int[6];
xSecondLineEnemy[0] = 60; xSecondLineEnemy[1] = 66; xSecondLineEnemy[2] = 72;
xSecondLineEnemy[3] = 78; 

int[] ySecondLineEnemy = new int[7];
ySecondLineEnemy[0] = 18; ySecondLineEnemy[1] = 18; ySecondLineEnemy[2] = 18;
ySecondLineEnemy[3] = 18;

int counterForHands = 0;

bool[] destroyEnemy = new bool[6];
destroyEnemy[0] = false; destroyEnemy[1] = false; destroyEnemy[2] = false;
destroyEnemy[3] = false; destroyEnemy[4] = false; destroyEnemy[5] = false;
int[] falseEnemy = new int[6];

bool[] destroyEnemyOfSecond = new bool[6];
destroyEnemyOfSecond[0] = false; destroyEnemyOfSecond[1] = false; destroyEnemyOfSecond[2] = false;
destroyEnemyOfSecond[3] = false; destroyEnemyOfSecond[4] = false; destroyEnemyOfSecond[5] = false;*/


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
    string[] model = SpaceShip.Split("\n");

    for (int i = 0; i < model.Count(); i++)
    {
        Console.SetCursorPosition(ShipPosX, ShipPosY + i);
        Console.WriteLine(model[i]);
    }
    AlienConstruct();
    //drawAlineFirstLine(ref xFirstLineEnemy, ref yFirstLineEnemy, ref counterForHands, ref destroyEnemy);
}
void SpaceShipKey()
{

    do
    {

        Console.SetWindowSize(screenWidth + 10, screenHeight + 10);
        //Console.SetCursorPosition(65, 52);
        //Console.WriteLine("--------------------------------------------------");
        spaceShip();
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey();

            }
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:

                    int oldShipXL = ShipPosX;
                    ShipPosX = ShipPosX - 4;
                    if (ShipPosX > 3)
                    {
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
            yFirePos = yFireMoving[0];
            xFirePos = xFireMoving[0];

            yFireMoving[1] = yFireMoving[0] - 1;
            yFireMoving[0] = yFireMoving[1];

            xFireMoving[1] = xFireMoving[0];
            xFireMoving[0] = xFireMoving[1];

            Console.SetCursorPosition(xFirePos, yFirePos);
            Console.WriteLine(" ");

            ShootShip(xFireMoving[0], yFireMoving[0]);
        }

        if (yFireMoving[0] == 11)
        {
            isFireExist = false;

            Console.SetCursorPosition(xFireMoving[0], yFireMoving[0]);
            Console.WriteLine(" ");
        }

        if (yFireMoving[0] == 11)
        {
            int delX = 40;
            int delY = 14;
            isFireExist = false;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(delX, delY++);
                Console.WriteLine("           ");
                
            }
        }

        foreach (int xAlien in xAlienPos)
        {
            
        }

        /*for (int i = 0; i < xFirstLineEnemy.Length; i++)
        {
            if (destroyEnemy[i] != true)
            {
                if (xFirstLineEnemy[i] <= xFireMoving[0] && xFireMoving[0] <= xFirstLineEnemy[i] + 4 && yFirstLineEnemy[i] == yFireMoving[0])
                {
                    Console.SetCursorPosition(xFirstLineEnemy[i], yFirstLineEnemy[i]);
                    Console.Write("     ");

                    destroyEnemy[i] = true;

                    yFireMoving[0] = 16;
                    break;
                }
            }
        }

        //check if the enemy line and the player are in the same coordinates
        if (ShipPosY == yFirstLineEnemy[0])
        {
            // this place is death animation
            Thread.Sleep(200);
            break;
        }*/

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
            case ConsoleKey.Escape:
                Enter = 2;
                break;
        }


    } while (Enter != 2);
}
void AlienConstruct(/*int AlienPosX, int AlienPosY*/)
{
    /*AlienPosX = 40;
    AlienPosY = 14; 
    /*AlienPosX2 = 30;
    AlienPosX3 = 30;
    AlienPosX4 = 30;
    AlienPosX5 = 30;*/

    for(int k = 0; k < 2; k++)
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
            /*Console.SetCursorPosition(AlienPosX1 += 15, 14);
            Console.WriteLine(Alien1);
            Console.SetCursorPosition(AlienPosX2 += 15, 15);
            Console.WriteLine(Alien2);
            Console.SetCursorPosition(AlienPosX3 += 15, 16);
            Console.WriteLine(Alien3);
            Console.SetCursorPosition(AlienPosX4 += 15, 17);
            Console.WriteLine(Alien4);
            Console.SetCursorPosition(AlienPosX5 += 15, 18);
            Console.WriteLine(Alien5);*/

        }
        AlienPosX = 40;
        AlienPosY = 19;

        /*if (AlienPosX + AlienPosY == yFirePos)
        {
            Console.SetCursorPosition(AlienPosX, AlienPosY);
            Console.WriteLine("     ");
            Console.SetCursorPosition(AlienPosX, AlienPosY);
            Console.WriteLine("     ");
            Console.SetCursorPosition(AlienPosX, AlienPosY);
            Console.WriteLine("     ");
            Console.SetCursorPosition(AlienPosX, AlienPosY);
            Console.WriteLine("     ");
        }*/
    }



    /*AlienPosX1 = 30;
    AlienPosX2 = 30;
    AlienPosX3 = 30;
    AlienPosX4 = 30;
    AlienPosX5 = 30;

    for (int i = 0; i < 4; i++)
    {
        Console.SetCursorPosition(AlienPosX1 += 15, 24);
        Console.WriteLine(Alien1);
        Console.SetCursorPosition(AlienPosX2 += 15, 25);
        Console.WriteLine(Alien2);
        Console.SetCursorPosition(AlienPosX3 += 15, 26);
        Console.WriteLine(Alien3);
        Console.SetCursorPosition(AlienPosX4 += 15, 27);
        Console.WriteLine(Alien4);
        Console.SetCursorPosition(AlienPosX5 += 15, 28);
        Console.WriteLine(Alien5);
    }*/

}
void drawAlineFirstLine(ref int[] xFirstLineEnemy, ref int[] yFirstLineEnemy, ref int counter, ref bool[] destroyEnemy)
{
    string delAlien = "     ";
    counter++;

    if(counter % 2 != 0)
    {
        for (int i = 0; i < xFirstLineEnemy.Length; i++)
        {
            Console.SetCursorPosition(xFirstLineEnemy[i], yFirstLineEnemy[i]);

            if (destroyEnemy[i])
            {
                Console.Write("    ");
            }
            else
            {
                for (int k = 0; k < 2; k++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        string[] model = Alien1.Split("\n");

                        for (int f = 0; f < model.Count(); f++)
                        {
                            Console.SetCursorPosition(AlienPosX, AlienPosY + f);
                            Console.WriteLine(model[f]);
                        }
                        AlienPosX += 15;
                    }
                    AlienPosX = 40;
                    AlienPosY = 19;
                }
            }
        }
    }

    }
static void ShootShip(int x, int y)
{
    /* System.Timers.Timer aTimer = new System.Timers.Timer(100);
     aTimer.Elapsed += OnTimedEvent;
     aTimer.Start();


     void OnTimedEvent(Object source, ElapsedEventArgs e)
     {
         Console.SetCursorPosition(ShipPosX + 6, ShootPosY);
         Console.WriteLine(" ");
         Console.SetCursorPosition(ShipPosX + 6, ShootPosY -= 2);
         Console.Write(bullet);

        if(ShootPosY == 20)
        {
            aTimer.Stop();
            Console.SetCursorPosition(ShipPosX + 6, ShootPosY);
            Console.WriteLine(" ");
            ShootPosY = 50;
        }
     }*/

    Console.SetCursorPosition(x, y);
    Console.WriteLine("╿");
}