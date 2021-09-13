using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class CurrentLocationClass
    {
        public static void DisplayLocation()
        {
            Console.WriteLine("You are at: {0}", Player.CurrentLocation.RoomName);

            if (Player.CurrentLocation.RoomDescription != "")
            {
                Console.WriteLine(Player.CurrentLocation.RoomDescription);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            
            string exits = "\n|Exits: ";
            
            List<string> validExits = new List<string>();

            if (Player.CurrentLocation.LocationToNorth != -1)
                validExits.Add("north");
            if (Player.CurrentLocation.LocationToEast != -1)
                validExits.Add("east");
            if (Player.CurrentLocation.LocationToSouth != -1)
                validExits.Add("south");
            if (Player.CurrentLocation.LocationToWest != -1)
                validExits.Add("west");
            if (validExits.Count == 1)
                exits += validExits[0] + " ";
            else
            {
                for (int i = 0; i < validExits.Count; i++)
                {
                    exits += validExits[i];
                    if (i < validExits.Count - 1)
                        exits += ", ";
                }
            }

            Console.WriteLine(exits + "|");

            if (Player.CurrentLocation.Mob != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (Monster mob in Player.CurrentLocation.Mob)
                {
                    if (mob.ID != 5)
                    {
                        Player.CurrentMonster = mob;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A " + mob.Name + " is surveying the area in here.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Player.CurrentMonster = mob;
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A large " + mob.Name + "takes up the room with its huge body.");
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
