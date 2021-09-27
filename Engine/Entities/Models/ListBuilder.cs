using Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class ListBuilder
    {
        private static string[] ScanLine(StreamReader reader)
        {
            string[] line = reader.ReadLine().Split(' ');
            return line;
        }

        public static void BuildObjects()
        {
            // Build Monster
            using (StreamReader reader = File.OpenText(@"../../../Engine/TextDocs/MonstersList.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(ScanLine(reader)[1]);

                    string name = ScanLine(reader)[1];

                    int xp = int.Parse(ScanLine(reader)[1]);

                    int armor = int.Parse(ScanLine(reader)[1]);

                    int gold = int.Parse(ScanLine(reader)[1]);

                    string damage = ScanLine(reader)[1];

                    int baseAttack = int.Parse(ScanLine(reader)[1]);

                    int currentHitpoints = int.Parse(ScanLine(reader)[1]);

                    int maximumHitpoints = int.Parse(ScanLine(reader)[1]);

                    bool isDead = bool.Parse(ScanLine(reader)[1]);

                    bool canBeAttacked = bool.Parse(ScanLine(reader)[1]);

                    World.Monsters.Add(new Monster(id, name, xp, gold, armor, damage, baseAttack, currentHitpoints, maximumHitpoints, isDead, canBeAttacked));

                }
            }

            // Build Rooms
            using (StreamReader reader = File.OpenText(@"../../../Engine/TextDocs/Rooms.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());
                    string name = reader.ReadLine();
                    string descript = reader.ReadLine();
                    int exit1 = int.Parse(reader.ReadLine());
                    int exit2 = int.Parse(reader.ReadLine());
                    int exit3 = int.Parse(reader.ReadLine());
                    int exit4 = int.Parse(reader.ReadLine());
                    int idMonster = int.Parse(reader.ReadLine());
                 // room loot

                    World.Location.Add(new Room(id, name, descript, exit1, exit2, exit3, exit4, idMonster));
                    
                }
            }

            // Build Weapons
            using (StreamReader reader = File.OpenText(@"../../../Engine/TextDocs/Weapons.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());
                    string name = reader.ReadLine();
                    string pluralName = reader.ReadLine();
                    string descript = reader.ReadLine();
                    int cost = int.Parse(reader.ReadLine());
                    string damage = reader.ReadLine();
                    string type = reader.ReadLine();
                    bool equip = bool.Parse(reader.ReadLine());
                    int wearLocation = int.Parse(reader.ReadLine());

                    World.Weapons.Add(new Weapon(id, name, pluralName, descript, cost, damage, type, equip, wearLocation));
                }
            }
        }
    }
}
