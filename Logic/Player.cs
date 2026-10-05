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

        public char? Mark { get; set; }

        public Player()
        {
            
        }


        public void Register(string name, char mark)
        {                       
            Name = name;
            Mark = mark;
        }

    }
}