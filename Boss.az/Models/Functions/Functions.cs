namespace Boss.az.Models.Functions;

public static class Functions
{
    public static void FirstMenu()
    {
        string bossaz =
            @"


          ██████╗░░█████╗░░██████╗░██████╗  ░█████╗░███████╗
          ██╔══██╗██╔══██╗██╔════╝██╔════╝  ██╔══██╗╚════██║
          ██████╦╝██║░░██║╚█████╗░╚█████╗░  ███████║░░███╔═╝
          ██╔══██╗██║░░██║░╚═══██╗░╚═══██╗  ██╔══██║██╔══╝░░
          ██████╦╝╚█████╔╝██████╔╝██████╔╝  ██║░░██║███████╗
          ╚═════╝░░╚════╝░╚═════╝░╚═════╝░  ╚═╝░░╚═╝╚══════╝
";
        string[] menu =
        {
            "\t\t\t\tStart",
            "\t\t\t\tAbout",
            "\t\t\t\tExit"
        };

        int select = 0;
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(bossaz);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < menu.Length; i++)
            {
                bool isCheck = false;
                if (i == select)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(menu[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    isCheck = true;
                }
                if (!isCheck)
                    Console.WriteLine(menu[i]);
            }

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.UpArrow)
            {
                if (select == 0)
                    select = menu.Length - 1;
                else select--;
            }
            else if (info.Key == ConsoleKey.DownArrow)
            {
                if (select == menu.Length - 1) select = 0;
                else select++;
            }
            else if (info.Key == ConsoleKey.Enter)
            {
                if (select == 0) //start
                {

                }
                else if (select == 1)//about
                {
                   
                }
                else if(select == 2)//exit
                {
                    Console.WriteLine("See YOU");
                    Environment.Exit(0);
                }
            }
        } while (true);

    }
}
