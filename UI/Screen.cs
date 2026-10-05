using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.UI
{
    public class Screen
    {
        public void ScreenMain()
        {
            Console.Clear();

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++ TIC TAC TOE GAME V.1 ++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            Console.WriteLine("1. Play");
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter your choice: ");
        }

        public void PlayerScreen()
        {
            Console.Clear();

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++ PLAYERS REGISTER ++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
        }

        public void TableDraw(List<char> gameTable)
        {
            Console.Clear();

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++ PLAY BOARD +++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            Console.WriteLine($"  {gameTable[0]}  |  {gameTable[1]}  |  {gameTable[2]}  ");
            Console.WriteLine("-----------------");
            Console.WriteLine($"  {gameTable[3]}  |  {gameTable[4]}  |  {gameTable[5]}  ");
            Console.WriteLine("-----------------");
            Console.WriteLine($"  {gameTable[6]}  |  {gameTable[7]}  |  {gameTable[8]}  ");

            Console.WriteLine();
        }

        public void MarkTable(int position, char mark)
        {
            // Implement the logic to mark the table based on the position and mark
        
        }
    }
}