using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Adventures.Models;
using Engine.Entities.Models;

namespace MonstersSuchAsUs
{
    public class Program
    {
        static void Main(string[] args)
        {
            MakeTitle();
            Adventure newAdventure = new Adventure();
            Console.ReadKey();
                        
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

        public partial class Adventure
        {
            private Player _player;

            public Adventure()
            {
                                
                _player = new Player();

                _player.CurrentHitPoints = 10;
                _player.MaximumHitPoints = 10;
                _player.Gold = 20;
                _player.ExperiencePoints = 0;
                _player.Level = 1;

                Console.WriteLine("Hit Points: " + _player.CurrentHitPoints);
                Console.WriteLine("Gold: " + _player.Gold);
                Console.WriteLine("Experience: " + _player.ExperiencePoints);
                Console.WriteLine("Level: " + _player.Level);
            }
        }
    }
}
