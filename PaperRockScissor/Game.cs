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
        int numberOfTurns;
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
            Console.WriteLine("hi");

            // Game intro
            _gameIntro();
        }

        private void _gameIntro()
        {
            // intro stuff eventually
        }

        public bool Player1Turn()
        {
            Console.Write("{0}, choose: Paper, Rock, or Scissor: ", this.Players[0].PlayerName());

            // user chooses
            player1Choice = Console.ReadLine();

            // Verify Users' input
            if (this.verifyUsrChoice(player1Choice))
            {
                // adds the validated choice to the round
                round = new Round(player1Choice, this.ComputerChoice());
                
                Console.WriteLine("Your choice is: {0}", round.getSelections(0));
                Console.WriteLine("The computer chose: {0}", round.getSelections(1));

                // compares inputs
                Console.WriteLine("You " + ComparePicks(round) + "!");
                Console.WriteLine("Play again.");
                Console.WriteLine();

                Console.WriteLine("Here's how you're doing: ");
                Console.WriteLine(ReadScore());
                Console.WriteLine();
                

                return true;
            }
            else
            {
                Console.WriteLine("Your selection is invalid.  Please try again.");
                Console.WriteLine();
                return false;
            }
        }

        public string ReadScore()
        {
            string score = this.Players[0].PlayerName() + ": " + this.Players[0].PlayerWins() + ", " + this.Players[1].PlayerName() + ": " + this.Players[1].PlayerWins();
            return score;
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

        string ComparePicks(Round choices)
        {
            string WinLose = "null";
            string usr = choices.getSelections(0);
            string comp = choices.getSelections(1);

            if (usr == comp)
            {
                WinLose = "tie";
            }
            else if (usr == "Paper" && comp == "Rock")
            {
                WinLose = "win";
                Players[0].Winner();
                Players[1].Looser();
            }
            else if (usr == "Rock" && comp == "Scissor")
            {
                WinLose = "win";
                Players[0].Winner();
                Players[1].Looser();
            }
            else if (usr == "Scissor" && comp == "Paper")
            {
                WinLose = "win";
                Players[0].Winner();
                Players[1].Looser();
            }
            else
            {
                WinLose = "lose";
                Players[0].Looser();
                Players[1].Winner();
            }

            return WinLose;
        }

    }
}
