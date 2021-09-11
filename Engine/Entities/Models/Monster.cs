using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Entities.Models
{
    public class Monster : LivingCreature
    {
        private int _id;
        private string _name;
        private int _experience;
        private int gold;
        private int _armor;
        private string _damage;
        private int _baseAttack;
        private bool _isDead;

        public int ID { get { return _id; } set { _id = value;  } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Experience { get { return _experience; } set { _experience = value; } }
        public int Gold { get { return gold; } set { gold = value; } }
        public int Armor { get { return _armor; } set { _armor = value; } }
        public string Damage { get { return _damage; } set { _damage = value; } }
        public int BaseAttack { get { return _baseAttack; } set { _baseAttack = value; } }

        public Monster(int id, string name, int xp, int gold, int armor, string damage, int baseAttack, int mobHitpoints, int mobMaxHitpoints, bool mobIsDead, bool canBeAttacked):
            base(mobHitpoints, mobMaxHitpoints, mobIsDead, canBeAttacked)
        {
            this.ID = id;
            this.Name = name;
            this.Experience = xp;
            this.Gold = gold;
            this.Armor = armor;
            this.Damage = damage;
            this.BaseAttack = baseAttack;
            this.CurrentHitPoints = mobHitpoints;
            this.MaximumHitPoints = mobMaxHitpoints;
            this._isDead = mobIsDead;
        }

        public Monster(Monster m) : base(m.CurrentHitPoints, m.MaximumHitPoints, m._isDead, m.CanBeAttacked)
        {
            this.ID = m.ID;
            this.Name = m.Name;
            this.Experience = m.Experience;
            this.Gold = m.Gold;
            this.Armor = m.Armor;
            this.Damage = m.Damage;
            this.BaseAttack = m.BaseAttack;
            this.CurrentHitPoints = m.CurrentHitPoints;
            this.MaximumHitPoints = m.MaximumHitPoints;
            this._isDead = m._isDead;
        }
    }
}
