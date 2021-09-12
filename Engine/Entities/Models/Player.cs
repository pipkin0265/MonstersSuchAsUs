using Engine.Items;
using Engine.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Entities.Models
{
    public class Player : LivingCreature
    {
        public static Player player;

        private string plname;
        private string plclass;
        private string plrace;
        private int xp;
        private int gold;
        private int level;
        private int currentHitPoints;
        private int maxHitPoints;
        private int armor;
        private static Room _currentLocation;
        private static Monster _currentMonster;
        private Weapon _equip;

        public Dictionary<string, IEquip> Equipped = new Dictionary<string, IEquip>();

        public string PlayerClass { get { return plclass; } set { plclass = value; } }
        public string PlayerName { get { return plname; } set { plname = value; } }
        public string PlayerRace { get { return plrace; } set { plrace = value; } }
        public int ExperiencePoints { get { return xp; } set { xp = value; } }
        public int Gold { get { return gold; } set { gold = value; } }
        public int Level { get { return ((ExperiencePoints / 100) + 1); } }
        public int Armor { get { return armor; } set { armor = value; } }
        public static Room CurrentLocation { get { return _currentLocation; } set { _currentLocation = value; } }
        public static Monster CurrentMonster { get { return _currentMonster; } set { _currentMonster = value; } }
        public Weapon Equip { get { return _equip;  } set { _equip = value; } }

        public Player(string name, string PC, string PR, int gold, int currentHitPoints, int maxHitPoints, Weapon equip, bool dead, bool canBeAttacked)
            :base(currentHitPoints, maxHitPoints, dead, canBeAttacked)
        {
            this.PlayerName = name;
            this.PlayerClass = PC;
            this.PlayerRace = PR;
            this.Gold = gold;
            this.ExperiencePoints = 0;
            this.Armor = 10;
            this.CurrentHitPoints = currentHitPoints;
            this.MaximumHitPoints = maxHitPoints;
            Equipped = new Dictionary<string, IEquip>()
            {
                {"Head",null },
                {"Body",null },
                {"Legs",null },
                {"Feet",null },
                {"Primary Hand",null },
                {"Off Hand",null }
            };
            CurrentLocation = World.Location[0];

        }
        

    }
}
