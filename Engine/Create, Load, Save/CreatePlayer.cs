using Engine.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Create__Load__Save
{
    public static class CreatePlayer
    {
        public static void CreatePlayerMenu()
        {
            string name;
            string className = "";
            string raceName = "";
            int gold = 0;
            int hp = 0;
            bool validRace = false;
            bool validClass = false;

            Console.WriteLine("What is your name? ");
            Console.Write("> ");
            name = Console.ReadLine();

            Console.Write("Your name is..." + name);

            while (validClass == false)
            {
                Console.WriteLine("What class would you like to be" + name + "?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Solider, Rogue, Scientist, Raider > ");
                className = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.White;

                if (className == "solider")
                {
                    gold = 100;
                    validClass = true;
                }
                else if (className == "rogue")
                {
                    gold = 200;
                    validClass = true;
                }
                else if (className == "scientist")
                {
                    gold = 150;
                    validClass = true;
                }
                else if (className == "raider")
                {
                    gold = 50;
                    validClass = true;
                }
                else
                {
                    Console.WriteLine("Not a valid class! Please choose from the following...");
                }
            }

            while (validRace == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What race would you like to be?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Human, > ");
                raceName = Console.ReadLine().ToLower();

                if (raceName == "human")
                {
                    validRace = true;
                    hp = 100;
                }
                else if (raceName == "")
                {
                    validRace = true;
                    hp = 80;
                }
                else if (raceName == "")
                {
                    validRace = true;
                    hp = 120;
                }
                else
                {
                    Console.WriteLine("Not A VALID entry. Please choose again.");
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Player.player = new Player(name, className, raceName, gold, hp, hp, false, true);
            Console.WriteLine("Creating character data, please wait...");
            
        }
    }
}
