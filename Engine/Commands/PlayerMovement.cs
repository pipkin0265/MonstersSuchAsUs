using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class PlayerMovement
    {
        public static void RelocateTo(string verb)
        {
            Movement.MoveToRoom(verb);
            CurrentLocationClass.DisplayLocation();
            if (Movement.canMove == false)
            {
                Console.WriteLine("You can not go that way! " + verb);
            }
        }
    }
}
