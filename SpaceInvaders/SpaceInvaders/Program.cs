List<int> myList = new List<int>();
string stgArrow = " -->";
int bytX = 40;
int bytY = 11;
ConsoleKey Key;

do
{

    Console.Clear();

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

    Console.SetCursorPosition(3, 3);
    bytY += myList.Count;
    Console.SetCursorPosition(bytX, (myList.Count + bytY));
    Console.Write(stgArrow);


    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.UpArrow:

            bytY = bytY - 5;
            break;

        case ConsoleKey.DownArrow:

            bytY = bytY + 6;
            if (bytY == 17)
            {
                bytY = bytY + 7;
            }
            break;

        case ConsoleKey.Enter:
            Console.SetCursorPosition(0, myList.Count + 8);
            Console.Write("nouvelle course : ");
            Console.SetCursorPosition(0, myList.Count + 10);
            Console.Write("niveau d'importance : ");

            break;

    }
} while (true);



