using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Command
    {
        public static void CommandGo(string input, Player player)
        {
            string[] commands = input.Split(null);
            string verb = commands[0].ToLower();
            string noun;
            if (commands.Length != 1)
            {
                noun = commands[1];
            }
            else
            {
                noun = "";
            }
            RegularCommands(verb, noun);

        }

        public static void RegularCommands(string verb, string noun)
        {
            switch (verb)
            {
                case "help":
                    Help.HelpTab();
                    break;
                case "north":
                        PlayerMovement.RelocateTo(verb);
                    break;
                case "east":
                    PlayerMovement.RelocateTo(verb);
                    break;
                case "south":
                    PlayerMovement.RelocateTo(verb);
                    break;
                case "west":
                    PlayerMovement.RelocateTo(verb);
                    break;
                case "attack":
                    Attack.MakeAttack(noun, Player.player);
                    break;
            }
        }
    }
}
