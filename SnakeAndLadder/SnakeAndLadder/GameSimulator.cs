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
            int player1Position = 0, player2Position = 0, winningPosition = 100, noPlay = 0, snake = -1, ladder = 1, dieValueCheck, optionCheck, numOfTimesDiceRolled, playerTurn = 0, player1DiceRoll = 0, player2DiceRoll = 0;
            Random value = new Random();

            while (player1Position < winningPosition && player2Position < winningPosition)
            {

                optionCheck = value.Next(-1, 2);
                //Console.WriteLine("Player option is:" + optionCheck);
                dieValueCheck = value.Next(1, 7);
                //Console.WriteLine("Dice Rolled to:" + dieValueCheck);

                if (playerTurn == 0)
                {
                    playerTurn = playerTurn + 1;
                    player1DiceRoll++;
                    if (optionCheck == ladder)
                    {
                        playerTurn = playerTurn - 1;
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
                    Console.WriteLine("Player 1 position is:" + player1Position);
                    if (player1Position > 100)
                    {
                        player1Position = player1Position - dieValueCheck;
                    }
                }
                else
                {
                    playerTurn = playerTurn - 1;
                    player2DiceRoll++;
                    if (optionCheck == ladder)
                    {
                        playerTurn = playerTurn + 1;
                        player2Position = player2Position + dieValueCheck;
                    }
                    else if (optionCheck == snake)
                    {
                        player2Position = player2Position - dieValueCheck;
                        if (player2Position < 0)
                        {
                            player2Position = 0;
                        }
                    }
                    else
                    {
                        player2Position = player2Position + noPlay;
                    }
                    Console.WriteLine("Player 2 position is:" + player2Position);
                    if (player2Position > 100)
                    {
                        player2Position = player2Position - dieValueCheck;
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine("No of times Player 1 rolled the Dice:" + player1DiceRoll);
            Console.WriteLine("No of times Player 2 rolled the Dice:" + player2DiceRoll);
            numOfTimesDiceRolled = player1DiceRoll + player2DiceRoll;
            Console.WriteLine();
            Console.WriteLine("No of times Dice rolled by both Players:" + numOfTimesDiceRolled);
            Console.WriteLine();
            if (player1Position > player2Position)
            {
                Console.WriteLine("Player 1 Won the Game");
            }
            else
            {
                Console.WriteLine("Player 2 Won the Game");
            }
        }
    }
}
