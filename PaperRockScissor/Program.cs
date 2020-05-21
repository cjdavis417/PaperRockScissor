using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace PaperRockScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<Player> GameStatus = new List<Player>();
            int turnCounter = 0;
            

                do 
                {
                    Console.WriteLine("Welcome to - Paper Rock Scissor -");
                    Console.WriteLine();
                    Player.PlayerDate(); // calls static method
                    Console.WriteLine("Best out of 10.  It's you versus the computer.");
                    Console.WriteLine();
                    Console.Write("What is your name? ");
                    Player player1 = new Player(Console.ReadLine(), 0, 0, 0);
                    Player player2 = new Player("Computer", 0, 0, 0);

                    // initialize game object
                    var NewGame = new Game(DateTime.Now, player1, player2, false);
                    
                    while (turnCounter < 10)
                    {

                        NewGame.Player1Turn();

                        turnCounter++;

                    }

                    // final score stuff
                    NewGame.GameEnd = DateTime.Now;
                    Console.WriteLine("***** Final Score *****");
                    Console.WriteLine(NewGame.ReadScore());
                    Console.WriteLine("Game started: {0}, Game Ended: {1}", NewGame.GameStart, NewGame.GameEnd);
                    Console.WriteLine("************************");
                    break;

                } while (true);

                
            }


        }

        
    
}
