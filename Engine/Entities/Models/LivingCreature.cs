using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Entities.Models
{
    public class LivingCreature
    {
        private static int currentHitPoints;
        private bool dead;
        private bool canBeAttacked;
        private static int maxHitPoints;

        public int CurrentHitPoints { get { return currentHitPoints; } set { currentHitPoints = value; } }
        public bool Dead { get { return dead; } set { dead = value; } }
        public bool CanBeAttacked { get { return canBeAttacked; } set { canBeAttacked = value; } }
        public int MaximumHitPoints { get { return maxHitPoints} set { maxHitPoints = value; } }

        public LivingCreature(int currentHitPoints, int maxHitPoints, bool dead, bool canBeAttacked)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maxHitPoints;
            Dead = dead;
            CanBeAttacked = canBeAttacked;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
