using System;
using System.Threading;
using System.Xml;
using SigmaCalculator2027;

namespace SigmaCalculatorMenu
{

    public static class Sigma_Menu
    {
        public static void SmRun()
        {
            Open();

            static void Open()
            {
                static void ProvideUI()
                {

                    Console.WriteLine();
                    Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow;
                    string logo = @"
     ,---.  ,--.                              ,-----.        ,--.              ,--.          ,--.                 
    '   .-' `--' ,---. ,--,--,--. ,--,--.    '  .--./ ,--,--.|  | ,---.,--.,--.|  | ,--,--.,-'  '-. ,---. ,--.--. 
    `.  `-. ,--.| .-. ||        |' ,-.  |    |  |    ' ,-.  ||  || .--'|  ||  ||  |' ,-.  |'-.  .-'| .-. ||  .--' 
    .-'    ||  |' '-' '|  |  |  |\ '-'  |    '  '--'\\ '-'  ||  |\ `--.'  ''  '|  |\ '-'  |  |  |  ' '-' '|  |    
    `-----' `--'.`-  / `--`--`--' `--`--'     `-----' `--`--'`--' `---' `----' `--' `--`--'  `--'   `---' `--'    
                `---'                                                                                              ";

                    Console.WriteLine(logo); Console.ResetColor();

                    string Compactlogo = @"
 ,---.   ,-----. ,---. ,-----.                                                                                
'   .-' '  .--./'.-.  \'--,  /                                                                                
`.  `-. |  |     .-' .' .'  /                                                                                 
.-'    |'  '--'\/   '-./   /                                                                                  
`-----'  `-----''-----'`--' ";

                    Console.WriteLine();
                    Console.Write("                                          ");
                    //Console.Write("                                      "); original distance
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Welcome to Sigma Calculator!"); Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("                                  --------------------------------------------"); //104+spaces
                    Console.WriteLine();
                }
                //what I want.. Calculator, Encryption, Lottery, zsoltarok, eddig csak ennyi, oh and logout

                Console.CursorVisible = false;
                bool Smenu = true;
                
                int SmenuSelect = 1;
                int blinkInt = 1;
                
                ConsoleKeyInfo Smainmenu;
                (int leftM, int topM) = Console.GetCursorPosition();

                if (Start.Session.IsAdmin)
                {
//admin
                    while (Smenu == true)
                    {

                        Console.SetCursorPosition(leftM, topM);
                        

                        if (SmenuSelect == 1)
                        {
                            while(blinkInt ==1)
                            {
                                Console.Clear();ProvideUI();
                                Console.WriteLine();
                                Console.Write("                                              "); //56
                                Console.WriteLine("->[ Calculator ]<-");
                                Console.WriteLine();
                                Console.Write("                                                   ");
                                Console.WriteLine("Lottery");
                                Thread.Sleep(400);
                                blinkInt = 2;
                            }
                            while(blinkInt != 1)
                            {
                                Console.Clear(); ProvideUI();
                                Console.WriteLine();
                                Console.Write("                                              "); //56
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("███"); Console.ResetColor(); Console.Write(" Calculator "); Console.ForegroundColor = ConsoleColor.Black;  Console.WriteLine("███"); Console.ResetColor();
                                Console.WriteLine();
                                Console.Write("                                                   ");
                                Console.WriteLine("Lottery");
                                Thread.Sleep(400);
                                blinkInt = 1;
                            }
                            



                        }
                        
                        if (SmenuSelect == 2)
                        {

                        }
                        if (SmenuSelect == 3)
                        {

                        }
                        if (SmenuSelect == 4)
                        {

                        }


                    }
                }
// non admin
                else
                {
                
                    while (Smenu == true)
                    {
                        Console.SetCursorPosition(leftM, topM);

                        if (SmenuSelect == 1)
                        {

                        }
                        if (SmenuSelect == 2)
                        {

                        }
                        if (SmenuSelect == 3)
                        {

                        }
                        if (SmenuSelect == 4)
                        {

                        }
                        // + extra menuk



                    }

                }



            }



        }
    }
}
/*
 * if (Session.IsAdmin)
{
    Console.WriteLine("Secret admin menu unlocked");
}
*/
