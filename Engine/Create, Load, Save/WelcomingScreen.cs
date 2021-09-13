using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class WelcomingScreen
    {
        public void Welcome()
        {
            Console.WriteLine("##     ##  #######  ##    ##  ######  ######## ######## ########   ###### ");
            Console.WriteLine("###   ### ##     ## ###   ## ##    ##    ##    ##       ##     ## ##    ## ");
            Console.WriteLine("#### #### ##     ## ####  ## ##          ##    ##       ##     ## ## ");
            Console.WriteLine("## ### ## ##     ## ## ## ##  ######     ##    ######   ########   ######  ");
            Console.WriteLine("##     ## ##     ## ##  ####       ##    ##    ##       ##   ##         ## ");
            Console.WriteLine("##     ## ##     ## ##   ### ##    ##    ##    ##       ##    ##  ##    ## ");
            Console.WriteLine("##     ##  #######  ##    ##  ######     ##    ######## ##     ##  ###### \n");

            Console.WriteLine(" ######  ##     ##  ######  ##     ##       ###     ######     ##     ##  ######  ");
            Console.WriteLine("##    ## ##     ## ##    ## ##     ##      ## ##   ##    ##    ##     ## ##    ## ");
            Console.WriteLine("##       ##     ## ##       ##     ##     ##   ##  ##          ##     ## ##       ");
            Console.WriteLine(" ######  ##     ## ##       #########    ##     ##  ######     ##     ##  ######  ");
            Console.WriteLine("      ## ##     ## ##       ##     ##    #########       ##    ##     ##       ## ");
            Console.WriteLine("##    ## ##     ## ##    ## ##     ##    ##     ## ##    ##    ##     ## ##    ## ");
            Console.WriteLine(" ######   #######   ######  ##     ##    ##     ##  ######      #######   ######  \n\n");

            // Ask if player is new...
            NewPlayer.CreateNewPlayer();
        }
    }
}
