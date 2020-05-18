using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PaperRockScissor
{
    class Game
    {
        public List<Player> Players;
        public DateTime GameStart;
        public DateTime GameEnd;
        public bool Multiplayer; // player vs computer = false; player vs player = true
        List<string> Choices = new List<string>() { "Paper", "Rock", "Scissor" };
        string player1Choice;
        string player2Choice;
        string computerChoice;
        Round round;

        public Game()
        {
            Players = new List<Player>();
        }

        public Game(DateTime gameStart, Player player1, Player player2, bool multiplayer)
            : this()    // using ': this()' calls the constructor above before using this one,
                        // that way 'Players' is initialized.
        {
            this.GameStart = gameStart;
            this.Players.Add(player1);
            this.Players.Add(player2);
            this.Multiplayer = multiplayer;
        }

        public bool Player1Turn()
        {
            Console.Write("{0}, choose: Paper, Rock, or Scissor: ", this.Players[0].PlayerName());

            // user chooses
            player1Choice = Console.ReadLine();

            // Verify Users' input
            if (this.verifyUsrChoice(player1Choice))
            {
                round = new Round(player1Choice, this.ComputerChoice());

                if (ComparePicks() == "win")
                {

                }

                return true;
            }
            else
            {
                Console.WriteLine("Your selection is invalid.  Please try again.");
                Console.WriteLine();
                return false;
            }
        }

        // Validates user's choice
        public bool verifyUsrChoice(string usr)
        {
            if (usr == this.Choices[0] || usr == this.Choices[1] || usr == this.Choices[2])
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Generates computers choice
        public string ComputerChoice()
        {
            string choice;
            Random random = new Random(DateTime.Now.Millisecond);

            // selects the List item from the random number
            choice = this.Choices[random.Next(0, 2)];
            return choice;
        }

        string ComparePicks( string usr, string comp, Player player1, Player player2)
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

    }
}
