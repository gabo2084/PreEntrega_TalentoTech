using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Logic
{
    public class GamePlay
    {
        
        public GamePlay()
        {
            
        }


        public void PlayerRegister(string name1, char mark1, string name2)
        {
            Player player1 = new();
            Player player2 = new();

            player1.Register(name1, mark1);
            player2.Name = name2;
            player2.Mark = player1.Mark == 'X' ? 'O' : 'X';

            Console.WriteLine($"Player 1: {player1.Name} | Mark: {player1.Mark}");
            Console.WriteLine($"Player 2: {player2.Name} | Mark: {player2.Mark}");
            
        }

        

    }
        
}