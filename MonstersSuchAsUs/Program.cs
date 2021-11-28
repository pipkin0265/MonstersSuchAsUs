using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace MonstersSuchAsUs
{
    public class Program
    {

        private static void Main(string[] args)
        {
            #region Start
            Console.ForegroundColor = ConsoleColor.Magenta;         // Makes text color purple

            ListBuilder.BuildObjects();                             // Calling ListBuilder on load to build all our list
               
            WelcomingScreen welcoming = new WelcomingScreen();      // Welcoming screen

            welcoming.Welcome();

            Console.WriteLine("Need help? Type 'Help' to see commands");
            Console.WriteLine("");

            CurrentLocationClass.DisplayLocation();
            Console.WriteLine("");
            #endregion

            #region Loop
            // Infinite loop
            while (true)
            {
                Console.Write(Player.player.CurrentHitPoints + "/" + Player.player.MaximumHitPoints + " Hp" + " >");
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    continue;
                }

                string exitInput = userInput.ToLower();

                if (exitInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Saving your character, will close when finish. Please wait...");
                    // Save
                    break;
                }

                // Parse
                Parse(exitInput);
            }
            #endregion
        }

        private static void PlayerChangedProp(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "CurrentLocation")
            {
                CurrentLocationClass.DisplayLocation();
            }
        }

        private static void Parse(string input)
        {
            Command.CommandGo(input, Player.player);

            Console.WriteLine("");
        }

    }
}
