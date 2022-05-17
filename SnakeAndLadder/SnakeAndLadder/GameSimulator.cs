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
            int playerPosition, winningPosition=100, noPlay=0, snake=-1, ladder=1, dieValueCheck, optionCheck, numOfTimesDiceRolled=1;
            Random value=new Random();
            
            for(playerPosition=0; playerPosition < winningPosition; numOfTimesDiceRolled++)
            {
                optionCheck = value.Next(-1, 2);
                Console.WriteLine("Player option is:" + optionCheck);
                dieValueCheck = value.Next(1, 7);
                Console.WriteLine("Dice Rolled to:" + dieValueCheck);

                if (optionCheck == ladder)
                {
                    playerPosition = playerPosition + dieValueCheck;
                }
                else if (optionCheck == snake)
                {
                    playerPosition = playerPosition - dieValueCheck;
                    if (playerPosition < 0)
                    {
                        playerPosition = 0;
                    }
                }
                else
                {
                    playerPosition = playerPosition + noPlay;
                }
                Console.WriteLine("Player position is:" + playerPosition);
                if (playerPosition > 100)
                {
                    playerPosition = playerPosition - dieValueCheck;
                }

            }
            Console.WriteLine();
            Console.WriteLine("No of times Dice rolled to win the game:" + numOfTimesDiceRolled);
            Console.WriteLine();
        }
    }
}
