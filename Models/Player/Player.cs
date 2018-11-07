using Models.Decks;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Player
{
    public class Player
    {
        public Board _board;
        public SideDeck _sideDeck;

        private bool _stand = false;

        public void Reset()
        {
            _board.Reset();
            _stand = false;
        }

        public void Stand()
        {
            _stand = true;
        }
    }
}
