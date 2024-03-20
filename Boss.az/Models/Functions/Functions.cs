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

            ConsoleKeyInfo info = Console.ReadKey(true);
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
                    SecondMenu();
                }
                else if (select == 1)//about
                {
                    Console.Clear();
                    string about = @"
                                             About Us
    About the Project:

Boss.Az is an online platform designed for all participants of the labor market to benefit from precise and swift job or employee search. 
The project provides users with easy access to a wide range of job postings and CV databases.

The project started its activities in 2008 and is currently one of the leading online resources in Azerbaijan's labor market.

Boss.Az is not a recruitment company. 
The aim of the project is to create a direct and efficient communication opportunity between job seekers and potential employers.

    Placement of Listings:

Boss.Az allows users to post job vacancies and CVs on the website. 
Each user can post one job vacancy and one CV free of charge per month.

Contact Us:

We are committed to the development and improvement of the project, and we are ready to listen to your opinions and suggestions about it. 
You can contact us by writing to talibliibrahim@gmail.com or by calling the phone number (051) 595-97-57.";
                    foreach (var item in about)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(item);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.ReadLine();
                }
                else if(select == 2)//exit
                {
                    Console.WriteLine("See YOU");
                    Environment.Exit(0);
                }
            }
        } while (true);

    }
    public static void SecondMenu()
    {
        string bossaz =
            @"

            ██╗      █████╗  ██████╗ ██╗███╗  ██╗
            ██║     ██╔══██╗██╔════╝ ██║████╗ ██║
            ██║     ██║  ██║██║  ██╗ ██║██╔██╗██║
            ██║     ██║  ██║██║  ╚██╗██║██║╚████║
            ███████╗╚█████╔╝╚██████╔╝██║██║ ╚███║
            ╚══════╝ ╚════╝  ╚═════╝ ╚═╝╚═╝  ╚══╝
";
        string[] menu =
        {
            "\t\t\tSign in",
            "\t\t\tSign Up",
            "\t\t\tGo On As Guest"
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

            ConsoleKeyInfo info = Console.ReadKey(true);
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
            else if (info.Key == ConsoleKey.Escape)
                break;
            else if (info.Key == ConsoleKey.Enter)
            {
                if (select == 0) //start
                {

                }
                else if (select == 1)
                {

                }
                else if (select == 2)
                {

                }
            }
        } while (true);
    }
}
