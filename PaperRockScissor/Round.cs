using System;
using System.Collections.Generic;
using System.Text;

namespace PaperRockScissor
{
    class Round
    {
        List<string> Selections;

        public Round()
        {
            Selections = new List<string>();
        }

        public Round(string player1, string player2)
            : this()
        {
            Selections.Add(player1);
            Selections.Add(player2);
        }

    }
}
