using System;
using System.Collections.Generic;
using System.Text;

namespace PaperRockScissor
{
    class Player
    {
        private string Name;
        private int Win;
        private int Lose;
        private int Tie;

        public Player(string name, int win, int lose, int tie)
        {
            Name = name;
            Win = win;
            Lose = lose;
            Tie = tie;
        }

        public string PlayerName() { return Name; }
        public int PlayerWins() { return Win; }


        public void Winner() { Win++; }
        public void Looser() { Lose++; }
        public void Tied() { Tie++; }
      


    }
}
