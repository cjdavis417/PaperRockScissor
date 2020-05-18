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
            

            NewGame();

            void NewGame()
            {
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
                        Console.Write("{0}, choose: Paper, Rock, or Scissor: ", NewGame.Players[0].PlayerName());
                        string usrchoice;
                        string compchoice;

                        // user chooses
                        usrchoice = Console.ReadLine();

                        // computer chooses
                        compchoice = NewGame.ComputerChoice();

                        // Verify Users' input
                        bool verifiedusr = NewGame.verifyUsrChoice(usrchoice);

                        // output game status
                        //if (verifiedusr)
                        //{
                        //    Console.WriteLine("Your choice is: " + usrchoice);
                        //    Console.WriteLine("The computer chose: " + compchoice);

                        //   // compares user and computer to determine winner.
                        //    Console.WriteLine("You " + ComparePicks(usrchoice, compchoice, player1, player2) + "!");
                        //    Console.WriteLine("Play again.");
                        //    Console.WriteLine();
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Your selection is invalid.  Please try again.");
                        //    Console.WriteLine();
                        //}
                        NewGame.Player1Turn();

                        turnCounter++;
       
                        Console.WriteLine("Here's how you're doing: ");
                        Console.WriteLine(ReadScore(player1, player2));
                        Console.WriteLine();
                        

                    }

                    // final score stuff
                    NewGame.GameEnd = DateTime.Now;
                    Console.WriteLine("***** Final Score *****");
                    Console.WriteLine(ReadScore(player1, player2));
                    Console.WriteLine("Game started: {0}, Game Ended: {1}", NewGame.GameStart, NewGame.GameEnd);
                    Console.WriteLine("************************");
                    break;

                } while (true);

                
            }

          

            string ComparePicks(string usr, string comp, Player player1, Player player2)
            {
                string WinLose = "null";
                
                if (usr == comp)
                {
                    WinLose = "tie";
                }
                else if (usr == "Paper" && comp == "Rock")
                {
                    WinLose = "win";
                    player1.Winner();
                }
                else if (usr == "Rock" && comp == "Scissor")
                {
                    WinLose = "win";
                    player1.Winner();
                }
                else if (usr == "Scissor" && comp == "Paper")
                {
                    WinLose = "win";
                    player1.Winner();
                }
                else
                {
                    WinLose = "lose";
                    player2.Winner();
                }
                 
                return WinLose;
            }

            string ReadScore(Player player1, Player player2)
            {
                string score = player1.PlayerName() + ": " + player1.PlayerWins() + ", " + player2.PlayerName() + ": " + player2.PlayerWins();
                return score;
            }

        }

        
    }
}
