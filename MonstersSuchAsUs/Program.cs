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
        }
    }
}
