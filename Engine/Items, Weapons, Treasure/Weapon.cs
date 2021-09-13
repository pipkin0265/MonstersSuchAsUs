using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : IItem, IEquip, IWeapon
    {
        private int _id;
        private string _name;
        private string _damage;
        private string _damagetype;

        public int ID { get; set; }
        public string Name { get; set; }
        public string PluralName { get; set; }
        public string Damage { get; set; }
        public string DamageType { get; set; }
        public int WearLocation { get; set; }
        public string Description { get; set; }
        public bool Equip { get; set; }

        public Weapon(int id, string name, string pluralName, string desc, string damage, string damageType, bool equip, int wearLocation)
        {
            this.ID = id;
            this.Name = name;
            this.PluralName = pluralName;
            this.Description = desc;
            this.Damage = damage;
            this.DamageType = damageType;
            this.Equip = equip;
            this.WearLocation = wearLocation;
        }
    }
}
