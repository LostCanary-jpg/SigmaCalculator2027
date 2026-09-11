using System.Threading;
using System;
using System.IO;


namespace SigmaCalculator2027
{

    public static class Start
    {
        public static void Menu()
        {
            Accounts.fileExist();
            Console.CursorVisible = false;
            string logo = @"
 ,---.  ,--.                              ,-----.        ,--.              ,--.          ,--.                 
'   .-' `--' ,---. ,--,--,--. ,--,--.    '  .--./ ,--,--.|  | ,---.,--.,--.|  | ,--,--.,-'  '-. ,---. ,--.--. 
`.  `-. ,--.| .-. ||        |' ,-.  |    |  |    ' ,-.  ||  || .--'|  ||  ||  |' ,-.  |'-.  .-'| .-. ||  .--' 
.-'    ||  |' '-' '|  |  |  |\ '-'  |    '  '--'\\ '-'  ||  |\ `--.'  ''  '|  |\ '-'  |  |  |  ' '-' '|  |    
`-----' `--'.`-  / `--`--`--' `--`--'     `-----' `--`--'`--' `---' `----' `--' `--`--'  `--'   `---' `--'    
            `---'                                                                                              ";

            string Compactlogo = @"
 ,---.   ,-----. ,---. ,-----.                                                                                
'   .-' '  .--./'.-.  \'--,  /                                                                                
`.  `-. |  |     .-' .' .'  /                                                                                 
.-'    |'  '--'\/   '-./   /                                                                                  
`-----'  `-----''-----'`--' ";

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(logo);
            Console.WriteLine();
            Console.Write("                                      ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to Sigma Calculator 2027!"); Console.ResetColor();
            Thread.Sleep(500);
            Console.Write("                               ");
            Console.WriteLine("Would you like to login or create a new user?");
            Console.WriteLine();
            Console.WriteLine();
            bool loginmenu = true;
            int menuselect = 1;
            ConsoleKeyInfo mainmenu;
            (int leftM, int topM) = Console.GetCursorPosition();
            
            while(loginmenu == true)
            {
                Console.SetCursorPosition(leftM, topM);

                if (menuselect == 1)
                {
                    Console.Write("                                                    "); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Login"); Console.ResetColor(); //52
                    Console.Write("                                                "); Console.WriteLine("Create a User");
                    Console.WriteLine();
                    Console.Write("                                                     "); Console.WriteLine("Exit");
                }
                if (menuselect == 2)
                {
                    Console.Write("                                                    "); Console.WriteLine("Login"); Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("                                                "); Console.WriteLine("Create a User"); Console.ResetColor(); //48
                    Console.WriteLine();
                    Console.Write("                                                     "); Console.WriteLine("Exit");
                }
                if (menuselect == 3)
                {
                    Console.Write("                                                    "); Console.WriteLine("Login");
                    Console.Write("                                                "); Console.WriteLine("Create a User");
                    Console.WriteLine(); Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("                                                     "); Console.WriteLine("Exit"); Console.ResetColor();
                    //environment.exit
                }

                mainmenu = Console.ReadKey(true);

                switch(mainmenu.Key)
                {
                    case ConsoleKey.DownArrow:
                        menuselect = menuselect == 3 ? 1 : menuselect + 1;
                        break;
                    case ConsoleKey.UpArrow:
                        menuselect = menuselect == 1 ? 3 : menuselect - 1;
                        break;
                    case ConsoleKey.Enter:
                        loginmenu = false;
                        break;

                }

            }

            switch (menuselect)
            {
                case 1:
                    Console.Clear();
                    //login
                    Console.CursorVisible = true;

                    Console.WriteLine();
                    Console.WriteLine(Compactlogo);
                    Console.WriteLine();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine();

                    string loginUser = "";
                    string loginPass = "";

                    
                        Console.WriteLine("    Username: "); 
                        Console.WriteLine("    Password: "); 

                    int baseLine = Console.CursorTop;
                    int usernameLine = baseLine - 2;
                    int passwordLine = baseLine - 1;
                    int inputOffset = 14;

                    Console.SetCursorPosition(0, usernameLine); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("    Username: "); Console.ResetColor();

                    Console.SetCursorPosition(inputOffset, usernameLine);
                    loginUser = Console.ReadLine();

                    Console.SetCursorPosition(0, usernameLine); Console.ForegroundColor = ConsoleColor.White; Console.Write("    Username: "); Console.ResetColor();

                    Console.SetCursorPosition(0, passwordLine); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("    Password: "); Console.ResetColor();

                    Console.SetCursorPosition(inputOffset, passwordLine);
                    loginPass = Console.ReadLine(); Console.WriteLine();

                    Console.SetCursorPosition(0, passwordLine); Console.ForegroundColor = ConsoleColor.White; Console.Write("    Password: "); Console.ResetColor();

                    Console.SetCursorPosition(0, baseLine + 1);

                    if (Accounts.TryLogin(loginUser, loginPass, out bool isAdmin))
                    {
                        Session.IsAdmin = isAdmin;
                        Session.CurrentUser = loginUser;
                        if (isAdmin)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("Welcome back, levedadmin."); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("     <Developer mode unlocked>"); Console.ResetColor();
                            Thread.Sleep(467); Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Press Enter to Continue."); Console.ResetColor();
                            ConsoleKeyInfo continueKey;
                            continueKey = Console.ReadKey(true);
                            switch(continueKey.Key)
                            {
                                case ConsoleKey.Enter:
                                    Console.Clear();
                                    SigmaMenu();
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine($"Welcome back, {loginUser}."); Console.ResetColor();
                            Thread.Sleep(467); Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Press Enter to Continue."); Console.ResetColor();
                            ConsoleKeyInfo continueKey;
                            continueKey = Console.ReadKey(true);
                            switch (continueKey.Key)
                            {
                                case ConsoleKey.Enter:
                                    Console.Clear(); Console.WriteLine("good boy"); Thread.Sleep(67); Console.Clear();
                                    SigmaMenu();
                                    break;
                            }
                        }
                        
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Login has failed."); //send back to main
                        Thread.Sleep(467); Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Press Enter to Continue."); Console.ResetColor();
                        ConsoleKeyInfo continueKey;
                        continueKey = Console.ReadKey(true);
                        switch (continueKey.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.Clear();
                                Start.Menu();
                                break;
                        }
                        
                    }
                   
                    break;

                case 2:
                    Console.Clear();
                    //create account
                    Console.CursorVisible = true;
                    Console.Write("choose a username: ");
                    string newUser = Console.ReadLine(); Console.WriteLine();
                    if(Accounts.UsernameExists(newUser))
                    {
                        Console.WriteLine("that username is taken"); //send back to redo creation
                        break;
                    }
                    Console.Write("choose passoword: ");
                    string newPass = Console.ReadLine(); Console.WriteLine();
                    Accounts.CreateUser(newUser, newPass);
                    Console.WriteLine("account created"); //after acc creation, go to login screen.

                    break;
                case 3:
                    Console.Clear(); Thread.Sleep(100);
                    Environment.Exit(0);
                    break;

            }

        }



        public static void SigmaMenu()
        {
            Console.WriteLine("this is the sigma calc");
            Console.ReadKey();
        }


        public static class Accounts //ennek a nagyreszet sajnos nem sajat magamtol csinaltam :(
        {
            private const string path = "users.txt";
            public static void fileExist()
            {
                if(!File.Exists(path))
                {
                    File.WriteAllLines(path, new string[] { "levedadmin,yo:gurt27" }); //secret secret shhhh
                }
            }

            public static void CreateUser(string username, string password)
            {
                File.AppendAllText(path, $"{username},{password}{Environment.NewLine}");
            }

            public static bool TryLogin(string username, string password, out bool isAdmin)
            {
                isAdmin = false;
                string[] lines = File.ReadAllLines(path);

                foreach(string line in lines)
                {
                    string[] parts = line.Split(',');
                    string savedUser = parts[0];
                    string savedPass = parts[1];

                    if (savedUser == username && savedPass == password)
                    {
                        isAdmin = savedUser == "levedadmin";
                        return true;
                    }
                }
                return false;

            }

            public static bool UsernameExists(string username)
            {
                if (!File.Exists(path)) return false;
                foreach (string line in File.ReadAllLines(path))
                {
                   if (line.Split(',')[0] == username) return true;

                }
                return false;
            }

        }


        public static class Session
        {
            public static bool IsAdmin = false;
            public static string CurrentUser = "";

        }



    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Start.Menu();
        }

    }

}

/*
 * if (Session.IsAdmin)
{
    Console.WriteLine("Secret admin menu unlocked");
}
*/