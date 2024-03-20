namespace Boss.az.Models.Functions;

using Boss.az.Models.Humans;
using Boss.az.Models.Other_Models;
using System.Net;
using System.Net.Mail;

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
                if (select == 0) //Sign in
                {
                    Console.Clear();
                }
                else if (select == 1) //Sign up
                {
                    Console.Clear();
                    SignUp();
                }
                else if (select == 2) //go on as Guest
                {
                    try
                    {
                    Console.Clear();
                    Database.ReadVacanciesFromJson();
                    Database.ShowVacancies();
                    ConsoleKeyInfo i = Console.ReadKey(true);
                        if (i.Key == ConsoleKey.Escape)
                            break;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    
                }
            }
        } while (true);
    }

    public static void SignUp()
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
            "\t\t\t\tAs Employer",
            "\t\t\t\tAs Worker",
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
                if (select == 0) //As Employer
                {
                    string name, surname, sheher, phone,email;
                    int age;
                    Console.Write("Enter your Name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter your Surname: ");
                    surname = Console.ReadLine();
                    Console.Write("Enter your City: ");
                    sheher = Console.ReadLine();
                    Console.Write("Enter your Phone (+994): ");
                    phone = Console.ReadLine();
                    Console.Write("Enter your Age: ");
                    age = int.Parse(Console.ReadLine());
                    Console.Write("Enter your email: ");
                    email = Console.ReadLine();
                    Console.Write("How many vacancies do you have: ");
                    int count = int.Parse(Console.ReadLine());
                    List<Vacancie> vacancies = new();
                    for (int i = 0; i < count; i++)
                    {
                        string namev, information, requirement;
                        int salary, WorkingTime;
                        Console.Write($"Enter {i+1}. Vacancie Name: ");
                        namev = Console.ReadLine();
                        Console.Write($"Enter {i + 1}. Vacancie Information: ");
                        information = Console.ReadLine();
                        Console.Write($"Enter {i + 1}. Vacancie Requirement: ");
                        requirement = Console.ReadLine();
                        Console.Write($"Enter {i + 1}. Vacancie Salary: ");
                        salary = int.Parse(Console.ReadLine());
                        Console.Write($"Enter {i + 1}. Vacancie WorkingTime: ");
                        WorkingTime = int.Parse(Console.ReadLine());

                        Vacancie v = new(namev,information,requirement,salary,WorkingTime);
                        vacancies.Add(v);
                    }
                    SendEmail(email);
                    try
                    {
                        Employer e = new(name, surname, sheher, phone, age, email, vacancies);
                        Database.employers.Add(e);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    };

                }
                else if(select == 1)
                {

                }
                else if (select == 2)
                {
                    break;
                }
            }
        } while (true);

    }
    public static void SendEmail(string to)
    {
        while (true)
        {
            Console.Clear();
            var client = new SmtpClient("smtp.gmail.com", 587);

            client.EnableSsl = true;

            client.Credentials = new NetworkCredential(
                "talibliibrahim28@gmail.com", "sjtsmwsehqcgbqfx");
            Random rand = new Random();
            int a = rand.Next(1000, 9999);
            var message = new MailMessage()
            {
                Subject = "OTP CODE",
                Body = a.ToString()
            };

            message.From = new MailAddress("talibliibrahim28@gmail.com", "Boss.az");
            message.To.Add(new MailAddress(to));

            client.Send(message);

            Console.Clear();
            Console.WriteLine("We Sent You an OTP CODE");
            Console.WriteLine("Please write this code to here: ");
            int code = int.Parse(Console.ReadLine());

            if (code == a)
            {
                Console.Clear();
                Console.WriteLine("You succesfully register");
                Thread.Sleep(1000);
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("WRONGGGG!!!");
                Console.WriteLine("We sent again");

            }
        }
    }
}
