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

        public string PlayerClass { get { return plclass; } set { plclass = value; } }
        public string PlayerName { get { return plname; } set { plname = value; } }
        public string PlayerRace { get { return plrace; } set { plrace = value; } }
        public int ExperiencePoints { get { return xp; } set { xp = value; } }
        public int Gold { get { return gold; } set { gold = value; } }
        public int Level { get { return ((ExperiencePoints / 100) + 1); } }
        public int Armor { get { return armor; } set { armor = value; } }

        public Player(string name, string PC, string PR, int gold, int currentHitPoints, int maxHitPoints, bool dead, bool canBeAttacked)
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

        }
        

    }
}
