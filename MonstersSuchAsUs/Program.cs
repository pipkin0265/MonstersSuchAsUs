using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonstersSuchAsUs
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeTitle();

            MakeMainMenu();
        }

        public static void MakeTitle()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("##     ##  #######  ##    ##  ######  ######## ######## ########   ######      ######  ##     ##  ######  ##     ##       ###     ######     ##     ##  ######  ");
            Console.WriteLine("###   ### ##     ## ###   ## ##    ##    ##    ##       ##     ## ##    ##    ##    ## ##     ## ##    ## ##     ##      ## ##   ##    ##    ##     ## ##    ## ");
            Console.WriteLine("#### #### ##     ## ####  ## ##          ##    ##       ##     ## ##          ##       ##     ## ##       ##     ##     ##   ##  ##          ##     ## ##       ");
            Console.WriteLine("## ### ## ##     ## ## ## ##  ######     ##    ######   ########   ######      ######  ##     ## ##       #########    ##     ##  ######     ##     ##  ######  ");
            Console.WriteLine("##     ## ##     ## ##  ####       ##    ##    ##       ##   ##         ##          ## ##     ## ##       ##     ##    #########       ##    ##     ##       ## ");
            Console.WriteLine("##     ## ##     ## ##   ### ##    ##    ##    ##       ##    ##  ##    ##    ##    ## ##     ## ##    ## ##     ##    ##     ## ##    ##    ##     ## ##    ## ");
            Console.WriteLine("##     ##  #######  ##    ##  ######     ##    ######## ##     ##  ######      ######   #######   ######  ##     ##    ##     ##  ######      #######   ######  \n\n");

            Console.WriteLine("                                                                     Press Start To Enter                                                                                      ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void MakeMainMenu()
        {
            MakeMenuOptions();
            var validInput = false;

            try
            {
                while (!validInput)
                {
                    switch (Console.ReadLine().ToUpper())
                    {
                        case "S":
                            // StartGame();
                            validInput = true;
                            break;
                        case "C":
                            // CreateCharacter();
                            validInput = true;
                            break;
                        case "L":
                            // Load Game();
                            validInput = true;
                            break;
                        default:
                            Console.WriteLine("\nYou did not select the following options, please try again!");
                            MakeMenuOptions();
                            validInput = false;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write($"KaBoom! The monsters destoryed your brain and all of humanity is lost! Something went wrong! {ex.Message}");
            }
        }

        private static void LoadGame()
        {
            Console.WriteLine("Load a game, great job!");
            Console.WriteLine("Still in early stages... please create a player!");
        }

        private static void MakeMenuOptions()
        {
            Console.WriteLine("(S)tart a new game");
            Console.WriteLine("(L)oad a game");
            Console.WriteLine("(C)reate a new character");
        }
    }
}
