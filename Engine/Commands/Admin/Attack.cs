using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Attack
    {
        public static void MakeAttack(string noun, Player player)
        {
            if (Player.CurrentLocation.Mob == null)
            {
                Console.WriteLine("Don't think anything is here to attack!");
            }
            else
            {
                Combat attack = new Combat();
                Monster namedMonster;

                if (MonsterChecker(noun, out namedMonster))
                {
                    attack.Duel(namedMonster, player);
                }
            }
        }

        private static bool MonsterChecker(string monsterName, out Monster namedMonster)
        {
            foreach (Monster mob in Player.CurrentLocation.Mob)
            {
                if (mob.Name.Equals(monsterName))
                {
                    namedMonster = mob;
                    return true;
                }
            }
            namedMonster = null;
            return false;
        }
    }
}
