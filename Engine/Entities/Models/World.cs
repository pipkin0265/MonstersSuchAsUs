using Engine.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine.Entities.Models
{
    public static class World
    {
        // Holds the objects of mobs
        public static readonly List<Monster> Monsters = new List<Monster>();

        // Holds the objects of rooms
        public static readonly List<Room> Location = new List<Room>();

        // Search for mobs
        public static Monster MonsterID(int id)
        {
            return Monsters.SingleOrDefault(x => x.ID == id);
        }
        public static Monster MonsterName(string name)
        {
            return Monsters.SingleOrDefault(x => x.Name == name);
        }

        // Search code for Rooms
        public static Room LocationID(int id)
        {
            return Location.SingleOrDefault(x => x.ID == id);
        }
    }
}
