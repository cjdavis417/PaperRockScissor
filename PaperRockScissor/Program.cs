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
                    Console.WriteLine("Choose: Paper, Rock, or Scissor: ");
                    string usrchoice;
                    string compchoice;
                    usrchoice = Console.ReadLine();
                    compchoice = ComputerChoice();
                    verifyUsrChoice();

                    // Verify Users' input
                    //bool verify = verifyUsrChoice();

                    
                        Console.WriteLine("Your choice is: " + usrchoice);
                        Console.WriteLine("The computer chose: " + compchoice);

                        Console.WriteLine("You " + ComparePicks(usrchoice, compchoice) + "!");
                        Console.WriteLine("Play again.");
                        Console.WriteLine();
                    

                   
                } while (true);
                
            }

            bool verifyUsrChoice()
            {

                return true;
            }

            // Generates computers choice
            string ComputerChoice()
            {
                string choice;
                Random random = new Random(DateTime.Now.Millisecond);
                choice = choices[random.Next(0, 2)];
                return choice;
            }

            string ComparePicks(string usr, string comp)
            {
                string WinLose = "null";
                //string lowerusr = usr.ToLower();
                //string lowercomp = comp.ToLower();
                // test user's input
                
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
