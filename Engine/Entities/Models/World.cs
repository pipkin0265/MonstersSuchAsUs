using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine
{
    public static class World
    {
        // Holds the objects of mobs
        public static readonly List<Monster> Monsters = new List<Monster>();

        // Holds the objects of rooms
        public static readonly List<Room> Location = new List<Room>();

        //  Holds the objects of weapons
        public static readonly List<IWeapon> Weapons = new List<IWeapon>();

        // Search code for mobs
        public static Monster MonsterID(int id)
        {
            return Monsters.SingleOrDefault(x => x.ID == id);
        }
        public static Monster MonsterName(string name)
        {
            return Monsters.SingleOrDefault(x => x.Name == name);
        }

        // Search code for rooms
        public static Room LocationID(int id)
        {
            return Location.SingleOrDefault(x => x.ID == id);
        }

        // Search code for weapons
        public static IWeapon WeaponID(int id)
        {
            return Weapons.SingleOrDefault(x => x.ID == id);
        }
        public static IWeapon WeaponName(string name)
        {
            return Weapons.SingleOrDefault(x => x.Name == name);
        }
    }
}
