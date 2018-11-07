using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Board
    {
        private ICard[] _cards;

        public Board()
        {
            _cards = new ICard[9];
        }

        public ICard this[int i] { get => _cards[i]; }

        public void AddToBoard(ICard card)
        {
            for (int i = 0; i < 9; i++)
            {
                if (_cards[i] == null)
                {
                    _cards[i] = card;
                    break;
                }
            }
        }

        public int GetValue()
        {
            var result = 0;
            for (int i = 0; i < 9 || _cards[i] != null; i++)
            {
                result += _cards[i].Sign == Enums.Signs.Plus ? _cards[i].Value : -1 * _cards[i].Value;
            }

            return result;
        }

        public void Reset()
        {
            _cards = new ICard[9];
        }
    }
}
