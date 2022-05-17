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
            int player1Position, winningPosition=100, noPlay=0, snake=-1, ladder=1, dieValueCheck, optionCheck;
            Random value=new Random();
            
            for(player1Position=0; player1Position <= winningPosition;)
            {
                optionCheck = value.Next(-1, 2);
                Console.WriteLine("Player option is:" + optionCheck);
                dieValueCheck = value.Next(1, 7);
                Console.WriteLine("Dice Rolled to:" + dieValueCheck);

                if (optionCheck == ladder)
                {
                    player1Position = player1Position + dieValueCheck;
                }
                else if (optionCheck == snake)
                {
                    player1Position = player1Position - dieValueCheck;
                    if (player1Position < 0)
                    {
                        player1Position = 0;
                    }
                }
                else
                {
                    player1Position = player1Position + noPlay;
                }
                Console.WriteLine("Player position is:" + player1Position);
            }
           
            
        }
    }
}
