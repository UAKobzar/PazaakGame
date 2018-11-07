using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Decks
{
    public class SideDeck
    {
        private ICard[] _cards;

        public SideDeck()
        {
            _cards = new ICard[10];
        }

        public void AddCard(ICard card)
        {
            for (int i = 0; i < 10; i++)
            {
                if(_cards[i] == null)
                {
                    _cards[i] = card;
                    break;
                }
            }
        }

        public void AddRange(ICard[] cards)
        {
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                if (_cards[i] == null)
                {
                    _cards[i] = cards[j];
                    j++;
                }
            }
        }

        private void Shuffle()
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                var index = rnd.Next(0, 10);
                var tmp = _cards[i];
                _cards[i] = _cards[index];
                _cards[index] = tmp;
            }
        }

        private bool isShuffled = false;

        public ICard this[int i]
        {
            get
            {
                if (i > 4)
                    throw new IndexOutOfRangeException();
                if (!isShuffled)
                    Shuffle();
                return _cards[i];
            }
        }

        public ICard PickCard(int index)
        {
            if (index > 4)
                throw new IndexOutOfRangeException();
            var result = _cards[index];
            _cards[index] = null;
            return result;
        }
    }
}
