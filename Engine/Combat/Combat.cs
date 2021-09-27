using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine
{
    internal class Combat
    {
        private int _fight;
        private int _attackEnd;
        private int _damageEnd;

        public int Fight { get { return _fight; } set { _fight = value; } }
        public int AttackEnd { get { return _attackEnd; } }
        public int DamageEnd { get { return _damageEnd; } }

        public Combat()
        {
            _fight = 1;
        }

        public void Duel(Monster enemy, Player player)
        {
            RollDice attack = new RollDice(1, 20);
            RollDice _playerDamage = new RollDice(player.Equip.Damage);
            RollDice monsterDamage = new RollDice(enemy.Damage);
            if (enemy.CanBeAttacked == false)
            {
                Console.WriteLine("Immune! You didn't even leave a scratch.");
                return;
            }

            while (enemy.Dead != true && player.Dead != true)
            {
                _attackEnd = attack.Roll();

                Console.WriteLine("You attacked with your " + player.Equip.Name.ToString() + ": " + AttackEnd);

                if (AttackEnd >= enemy.Armor)
                {
                    Console.WriteLine("You hit the " + enemy.Name);

                    _damageEnd = _playerDamage.Roll();
                    Console.WriteLine("You dealt " + DamageEnd + " points of damage to the " + enemy.Name);

                    enemy.CurrentHitPoints -= DamageEnd;
                    Console.WriteLine(enemy.Name + " has " + enemy.CurrentHitPoints + " health left!");

                    if (enemy.CurrentHitPoints <= 0)
                    {
                        Console.WriteLine("The " + enemy.Name + " is dead!");
                        enemy.Dead = true;
                        Console.WriteLine("The fight took " + Fight + " rounds to finsih.");
                        Player.CurrentLocation.Mob.Remove(enemy);
                        player.ExperiencePoints += enemy.Experience;
                        player.Gold += enemy.Gold;

                    }
                    else
                    {
                        Console.WriteLine("Your attack missed!");
                    }

                    _attackEnd = attack.Roll();
                    Console.WriteLine(enemy.Name + " attacks you: " + AttackEnd);

                    if (AttackEnd > player.Armor)
                    {
                        Console.WriteLine("The " + enemy.Name + " attacks you: " + AttackEnd);

                        if (AttackEnd > player.Armor)
                        {
                            Console.WriteLine("The " + enemy.Name + " lands an attack on you!");

                            _damageEnd = monsterDamage.Roll();
                            Console.WriteLine("The " + enemy.Name + " did " + DamageEnd + " damage to yout health.");

                            player.CurrentHitPoints -= DamageEnd;

                            if (player.CurrentHitPoints <= 0)
                            {
                                Console.WriteLine("You have died!");
                                player.Dead = true;
                                Console.WriteLine("The fight took " + Fight + " rounds to finish.\n");
                                // Load game
                                // CurrentLocationClass.DisplayLocation();
                                
                            }
                            else
                            {
                                Console.WriteLine("The " + enemy.Name + " missed their attack!");
                            }

                            Fight++;
                        }
                        
                        if (player.Dead == true)
                        {
                            player.PlayerName += "/Dead";
                        }

                    }
                }
            }
        }
    }
}
