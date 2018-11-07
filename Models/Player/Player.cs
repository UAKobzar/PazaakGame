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
        public Board Board { get; private set; }
        public SideDeck SideDeck { get; private set; }
        public int Wins { get; set; }

        public void Reset()
        {
            Board.Reset();
            _stand = false;
        }

        private bool _stand = false;
        public bool Stand { get; private set; }

        public void StandMove()
        {
            _stand = true;
        }

        public void PlaySideCard(int index)
        {
            Board.AddToBoard(SideDeck.PickCard(index));
        }
    }
}
