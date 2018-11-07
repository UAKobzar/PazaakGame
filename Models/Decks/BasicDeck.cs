using Models.Cards;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Decks
{
    public class BasicDeck
    {
        private Queue<ICard> _deck;

        public BasicDeck()
        {
            Shuffle();
        }

        public ICard GetNextCard()
        {
            return _deck.Dequeue();
        }

        private void Shuffle()
        {
            _deck = new Queue<ICard>();
            List<ICard> cards = new List<ICard>();

            for (int i = 1; i <= 10; i++)
            {
                cards.Add(new BasicCard(i, Enums.Signs.Plus, Enums.CardType.Basic));
                cards.Add(new BasicCard(i, Enums.Signs.Plus, Enums.CardType.Basic));
            }

            Random rnd = new Random();

            var cardIndex = 0;

            do
            {
                cardIndex = rnd.Next(0, cards.Count - 1);
                _deck.Enqueue(cards[cardIndex]);
                cards.RemoveAt(cardIndex);
            } while (cards.Count > 0);
        }
    }
}
