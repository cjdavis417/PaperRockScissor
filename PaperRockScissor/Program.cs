using System;
using System.Collections.Generic;

namespace PaperRockScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> choices = new List<string>() { "Paper", "Rock", "Scissor" };

            Console.WriteLine("Welcome to - Paper Rock Scissor -");

            NewGame();

            void NewGame()
            {
                do
                {
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

                   
                } while (true);
                
            }

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

        }

        
    }
}
