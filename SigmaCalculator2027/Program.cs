using System.Threading;

namespace SigmaCalculator2027
{

    public static class Start
    {
        public static void Menu()
        {
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
            Thread.Sleep(1000);
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