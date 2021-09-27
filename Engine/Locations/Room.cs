using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        private int _id;
        private string roomName;
        private string roomDescript;
        private Monster _monsters;
        private int _locationNorth;
        private int _locationEast;
        private int _locationSouth;
        private int _locationWest;


        public int ID { get { return _id; } set { _id = value; } }
        public string RoomName { get { return roomName; } set { roomName = value; } }
        public string RoomDescription { get { return roomDescript; } set { roomDescript = value; } }
        public Monster RoomMonsters { get { return _monsters; } set { _monsters = value; } }
        public int LocationToNorth { get { return _locationNorth; } set { _locationNorth = value; } }
        public int LocationToEast { get { return _locationEast; } set { _locationEast = value; } }
        public int LocationToSouth { get { return _locationSouth;  } set { _locationSouth = value; } }
        public int LocationToWest { get { return _locationWest; } set { _locationWest = value; } }
        public List<Monster> Mob = new List<Monster>();


        public Room(int id, String name, String descript, int exit1, int exit2, int exit3, int exit4, int monsterID)
        {
            this.ID = id;
            this.RoomName = name;
            this.roomDescript = descript;
            this.LocationToNorth = exit1;
            this.LocationToEast = exit2;
            this.LocationToSouth = exit3;
            this.LocationToWest = exit4;

            // Adds Monsters
            if (monsterID != 15) // 15 = Jasmine / The Mother
            {
                if (monsterID > -1)
                {
                    Random rand = new Random();

                    int catchMob = RandomNumberGen.RandomNumber(0, 14); // index
                    this.RoomMonsters = new Monster(World.Monsters[catchMob]);
                    this.Mob.Add(RoomMonsters);
                }
            }
            else
            {
                this.Mob.Add(World.MonsterID(monsterID));
            }
        }
    }
}
