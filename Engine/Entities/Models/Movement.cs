using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Movement
    {
        public static bool canMove = true;

        // Takes new location and moves it to the player's current location
        public static void ChangeLoc(Room location)
        {
            Player.CurrentLocation = location;
        }

        // Moves player to any location
        public static void RelocateTo(Room location)
        {
            ChangeLoc(location);
        }

        // If player dies they will respawn in base
        public static void MoveToBase()
        {
            RelocateTo(World.Location[0]);
        }

        // Moves player to the next room
        public static void MoveToRoom(string input)
        {
            int ele = World.Location.IndexOf(Player.CurrentLocation);
            switch (input)
            {
                case "north":
                    if(Player.CurrentLocation.LocationToNorth != -1)
                    {
                        RelocateTo(World.Location[Player.CurrentLocation.LocationToNorth]);
                    }
                    else
                    {
                        canMove = false;
                    }
                    break;
                case "east":
                    if (Player.CurrentLocation.LocationToEast != -1)
                    {
                        RelocateTo(World.Location[Player.CurrentLocation.LocationToEast]);
                    }
                    else
                    {
                        canMove = false;
                    }
                    break;
                case "south":
                    if (Player.CurrentLocation.LocationToSouth != -1)
                    {
                        RelocateTo(World.Location[Player.CurrentLocation.LocationToSouth]);
                    }
                    else
                    {
                        canMove = false;
                    }
                    break;
                case "west":
                    if (Player.CurrentLocation.LocationToWest != -1)
                    {
                        RelocateTo(World.Location[Player.CurrentLocation.LocationToWest]);
                    }
                    else
                    {
                        canMove = false;
                    }
                    break;
            }

        }
    }
}
