using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class GameSimulator
    {
        public void DieRoller()
        {
            int player1Position = 0, dieValueCheck;
            Random value=new Random();
            dieValueCheck = value.Next(1, 7);
            Console.WriteLine("Dice Rolled to:" + dieValueCheck);

        }
    }
}
