using System;
using System.Collections.Generic;
using System.Text;

namespace PaperRockScissor
{
    class Round
    {
        private List<string> _selections { get; set; }

        public Round()
        {
            _selections = new List<string>();
        }

        public Round(string player1, string player2)
            : this() // this calls the constructor above first
        {
            _selections.Add(player1);
            _selections.Add(player2);
        }

        public string getSelections(int i)
        {
            return _selections[i];
        }

    }
}
