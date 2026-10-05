using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.UI;

namespace TicTacToe.Logic
{
    public class GamePlay
    {
        
        Player player1 = new();
        Player player2 = new();

        List<char> gameTable = new() {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
        Screen screen = new();
        bool exitGame = false;
        bool winner = false;
        bool validateSymbol = false;
        
        
        public void PlayerRegister()
        {
            Console.Write($"\nEnter the name of player 1: ");
            string? name1 = Console.ReadLine();
            char symbol1 = ' ';

            while (!validateSymbol)
            {
                Console.Write($"\nEnter the symbol for player 1: ");
                symbol1 = Console.ReadKey().KeyChar;
                symbol1 = char.ToUpper(symbol1);

                if (symbol1 == 'X' || symbol1 == 'O')
                {
                    validateSymbol = true;
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid symbol. Please choose 'X' or 'O'.");
                }                
            }

            Console.Write($"\n\nEnter the name of player 2: ");
            string? name2 = Console.ReadLine();
            player1.Register(name1!, symbol1);
            player2.Name = name2;
            player2.Symbol = player1.Symbol == 'X' ? 'O' : 'X';
        }

        public void PlayerInfo(Player player1, Player player2)
        {            
            Console.WriteLine($"\nPlayer 1: {player1.Name} | Symbol: {player1.Symbol}");
            Console.WriteLine($"Player 2: {player2.Name} | Symbol: {player2.Symbol}");
        }

        public void StartGame()
        {
            // Implement the game logic here
            exitGame = false;
            
            while (exitGame == false)
            {
                
                screen.ScreenMain();

                int? choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        // Start the game

                        screen.PlayerScreen();
                        PlayerRegister();

                        screen.TableDraw(gameTable);
                        PlayerInfo(player1, player2);

                        LotteryShift();

                        for (int i = 0; i < gameTable.Count(); i++)
                        {
                            if (player1.Shift == true)
                            {
                                Console.Write($"\n{player1.Name} ({player1.Symbol}), choose a position (1-9): ");
                                int position = int.Parse(Console.ReadLine()!);
                                markTable(position, player1.Symbol);
                                player1.Shift = false;
                                player2.Shift = true;
                                CheckWinner();
                                if (winner == true)
                                {
                                    Console.WriteLine("\nPress any key to return to the main menu...");
                                    Console.ReadKey();
                                    ResetGame();
                                    break;
                                }
                            }
                            else if (player2.Shift == true)
                            {
                                Console.Write($"\n{player2.Name} ({player2.Symbol}), choose a position (1-9): ");
                                int position = int.Parse(Console.ReadLine()!);
                                markTable(position, player2.Symbol);
                                player1.Shift = true;
                                player2.Shift = false;
                                CheckWinner();
                                if (winner == true)
                                {
                                    Console.WriteLine("\nPress any key to return to the main menu...");
                                    Console.ReadKey();
                                    ResetGame();
                                    break;
                                }
                            }
                        }

                        break;
                    case 0:
                        exitGame = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        
        public void markTable(int position, char? symbol)
        {
            if (position < 1 || position > 9)
            {
                Console.WriteLine("Position must be between 1 and 9.");
            }
            else if (gameTable[position - 1] == 'X' || gameTable[position - 1] == 'O')
            {
                Console.WriteLine("Position already marked. Please choose another position.");
            }
            else
            {
                gameTable[position - 1] = symbol!.Value;
                screen.TableDraw(gameTable);
            }
        }

        public void LotteryShift()
        {
            Random random = new Random();
            int shift = random.Next(1, 3);

            if (shift == 1)
            {
                player1.Shift = true;
                player2.Shift = false;
                Console.WriteLine($"\n{player1.Name} goes first!");
            }
            else
            {
                player1.Shift = false;
                player2.Shift = true;
                Console.WriteLine($"\n{player2.Name} goes first!");
            }
        }

        public void ResetGame()
        {
            winner = false;
            validateSymbol = false;
            gameTable = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            player1.Shift = false;
            player2.Shift = false;
        }

        public void CheckWinner()
        {
            // Implement the logic to check for a winner
            if (gameTable[0] == gameTable[1] && gameTable[1] == gameTable[2])
            {
                // Player wins
                if (gameTable[0] == player1.Symbol)
                {
                    Console.WriteLine($"\n{player1.Name} wins!");
                }
                else if (gameTable[0] == player2.Symbol)
                {
                    Console.WriteLine($"\n{player2.Name} wins!");
                }
                
                winner = true;
            }
            else if (gameTable[3] == gameTable[4] && gameTable[4] == gameTable[5])
            {
                // Player wins
                if (gameTable[3] == player1.Symbol)
                {
                    Console.WriteLine($"\n{player1.Name} wins!");
                }
                else if (gameTable[3] == player2.Symbol)
                {
                    Console.WriteLine($"\n{player2.Name} wins!");
                }
                
                winner = true;
            }
            else if (gameTable[6] == gameTable[7] && gameTable[7] == gameTable[8])
            {
                // Player wins
                if (gameTable[6] == player1.Symbol)
                {
                    Console.WriteLine($"\n{player1.Name} wins!");
                }
                else if (gameTable[6] == player2.Symbol)
                {
                    Console.WriteLine($"\n{player2.Name} wins!");
                }
                
                winner = true;
            }
            else if (gameTable[0] == gameTable[3] && gameTable[3] == gameTable[6])
            {
                // Player wins
                if (gameTable[0] == player1.Symbol)
                {
                    Console.WriteLine($"\n{player1.Name} wins!");
                }
                else if (gameTable[0] == player2.Symbol)
                {
                    Console.WriteLine($"\n{player2.Name} wins!");
                }
                
                winner = true;
            }
            else if (gameTable[1] == gameTable[4] && gameTable[4] == gameTable[7])
            {
                // Player wins
                if (gameTable[1] == player1.Symbol)
                {
                    Console.WriteLine($"\n{player1.Name} wins!");
                }
                else if (gameTable[1] == player2.Symbol)
                {
                    Console.WriteLine($"\n{player2.Name} wins!");
                }
                
                winner = true;
            }
            else if (gameTable[2] == gameTable[5] && gameTable[5] == gameTable[8])
            {
                // Player wins
                if (gameTable[2] == player1.Symbol)
                {
                    Console.WriteLine($"\n{player1.Name} wins!");
                }
                else if (gameTable[2] == player2.Symbol)
                {
                    Console.WriteLine($"\n{player2.Name} wins!");
                }
                
                winner = true;
            }
            else if (gameTable[0] == gameTable[4] && gameTable[4] == gameTable[8])
            {
                // Player wins
                if (gameTable[0] == player1.Symbol)
                {
                    Console.WriteLine($"\n{player1.Name} wins!");
                }
                else if (gameTable[0] == player2.Symbol)
                {
                    Console.WriteLine($"\n{player2.Name} wins!");
                }
                
                winner = true;
            }
            else if (gameTable[2] == gameTable[4] && gameTable[4] == gameTable[6])
            {
                // Player wins
                if (gameTable[2] == player1.Symbol)
                {
                    Console.WriteLine($"\n{player1.Name} wins!");
                }
                else if (gameTable[2] == player2.Symbol)
                {
                    Console.WriteLine($"\n{player2.Name} wins!");
                }

                winner = true;
            }
        }

    }
        
}