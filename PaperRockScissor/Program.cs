using System;
using System.Collections.Generic;

namespace PaperRockScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> choices = new List<string>() { "Paper", "Rock", "Scissor" };
            bool playgame = true;
            string gameOption = "y";
            Player Player1 = new Player();
            Player Player2 = new Player();
            bool validNumberOfPlayers;

            Console.WriteLine("Welcome to - Paper Rock Scissor -");

            NewGame();

            void NewGame()
            {
                do
                {

                    GatherPlayerInfo();

                    // start game
                    Console.Write("Choose: Paper, Rock, or Scissor: ");
                    string usrchoice;
                    string compchoice;


                    // user chooses
                    usrchoice = Console.ReadLine();

                    // computer chooses
                    compchoice = ComputerChoice();

                    // Verify Users' input
                    bool verifiedusr = verifyUsrChoice(usrchoice);

                    // output game status
                    if (verifiedusr)
                    {
                        Console.WriteLine("Your choice is: " + usrchoice);
                        Console.WriteLine("The computer chose: " + compchoice);

                        // compares user and computer to determine winner.
                        Console.WriteLine("You " + ComparePicks(usrchoice, compchoice) + "!");
                        Console.WriteLine("Play again.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Your selection is invalid.  Please try again.");
                        Console.WriteLine();
                    }

                    // Play again?
                    ContinueGame();
                   
                } while (playgame);
                
            }

            void GatherPlayerInfo()
            {
                do
                {
                    // gather player information
                    Console.Write("1 or 2 players?: ");
                    int numberOfPlayers = int.Parse(Console.ReadLine());
                    Console.WriteLine(numberOfPlayers);

                    if (numberOfPlayers == 2)
                    {
                        validNumberOfPlayers = true;
                        Console.WriteLine("Name of player 1: ");
                        Player1.Name = Console.ReadLine();

                        Console.WriteLine("Name of player 2: ");
                        Player2.Name = Console.ReadLine();
                    }
                    else if (numberOfPlayers == 1)
                    {
                        validNumberOfPlayers = true;
                        Console.WriteLine("Name of player: ");
                        Player1.Name = Console.ReadLine();
                    }
                    else
                    {
                        validNumberOfPlayers = false;
                        Console.WriteLine("Invalid Entry");
                    }
                } while (!validNumberOfPlayers);
            }

            // verifies the players' input
            bool verifyUsrChoice(string usr)
            {
                if (usr == choices[0] || usr == choices[1] || usr == choices[2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }

            // Generates computers choice
            string ComputerChoice()
            {
                string choice;
                Random random = new Random(DateTime.Now.Millisecond);

                // selects the List item
                choice = choices[random.Next(0, 2)];
                return choice;
            }

            // determines the winner
            string ComparePicks(string usr, string comp)
            {
                string WinLose = "null";
                
                if (usr == comp)
                {
                    WinLose = "tie";
                }
                else if (usr == "Paper" && comp == "Rock")
                {
                    WinLose = "win";
                }
                else if (usr == "Rock" && comp == "Scissor")
                {
                WinLose = "win";
                }
                else if (usr == "Scissor" && comp == "Paper")
                {
                    WinLose = "win";
                }
                else
                {
                    WinLose = "lose";
                }
                 
                return WinLose;
            }

            // checks with user if game is to continue
            void ContinueGame()
            {
                Console.Write("Play new game? ('y' or 'n'): ");
                gameOption = Console.ReadLine();

                if (gameOption.ToString() == "n")
                {
                    playgame = false;
                    Console.WriteLine("Good bye!");
                }
            }

        }

        
    }
}
