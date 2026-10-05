using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Logic
{
    public class Player
    {
        public string? Name { get; set; }
        public int? Victories { get; set; } = 0;
        public int? Defeats { get; set; } = 0;
        public char? Symbol { get; set; }
        public bool Shift { get; set; }

        public Player()
        {
            
        }


        public void Register(string name, char symbol)
        {                       
            Name = name;
            Symbol = symbol;
        }
    }
}