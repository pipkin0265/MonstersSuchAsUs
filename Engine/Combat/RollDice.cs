using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class RollDice
    {
        private int _diceNum;
        private int _sizeDice;
        private int _diceEnd;
        Random random = new Random();

        public int DiceNum { get { return _diceNum; } set { _diceNum = value; } }
        public int DiceSize { get { return _sizeDice; } set { _sizeDice = value; } }
        public int DiceEnd { get { Roll(); return _diceEnd; } }

        public RollDice(string typeDice)
        {
            string[] dice = typeDice.Split('D');
            int num = Convert.ToInt32(dice[0]);
            int die = Convert.ToInt32(dice[1]);

            DiceNum = num;
            DiceSize = die;
        }

        public RollDice(int Num, int Size)
        {
            DiceNum = Num;
            DiceSize = Size;
        }

        public int Roll()
        {
            int sum = 0;

            for (int i = 0; i < _diceNum; i++)
            {
                sum += random.Next(_sizeDice + 1);
            }

            return sum;
        }
    }
}
