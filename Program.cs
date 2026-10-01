<<<<<<< HEAD
﻿
=======
﻿
using TicTacToe.Logic;

Console.Write($"\nIngresa el nombre del jugador 1: ");
string? name1 = Console.ReadLine();

Console.Write($"\nIngresa la marca del jugador 1: ");
char mark1 = Console.ReadKey().KeyChar;

Console.Write($"\n\nIngresa el nombre del jugador 2: ");
string? name2 = Console.ReadLine();

Console.WriteLine();

GamePlay Game = new ();
Game.PlayerRegister(name1, mark1, name2);

>>>>>>> Logic
