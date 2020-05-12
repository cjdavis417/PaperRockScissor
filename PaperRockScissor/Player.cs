using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace PaperRockScissor
{
    class Player
    {
        private string Name { get; set; }
        private int Win { get; set; }
        private int Lose { get; set; }
        private int Tie { get; set; }

        public Player(string name, int win, int lose, int tie)
        {
            this.Name = name;
            this.Win = win;
            this.Lose = lose;
            this.Tie = tie;
        }

        public string PlayerName() { return Name; }
        public int PlayerWins() { return Win; }


        public void Winner() { Win++; }
        public void Looser() { Lose++; }
        //public void Tied() { Tie++; }
        
        // static method. Static methods can be called without being tied to an object
        public static void PlayerDate()
        {
            Console.WriteLine("Today is {0}", DateTime.Now);
        }

    }
}
