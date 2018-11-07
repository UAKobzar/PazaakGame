using Models.Enums;
using Models.Exceptions;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Cards
{
    public class BasicCard : ICard
    {
        public int Value { get; protected set; }

        public Signs Sign { get; protected set; }

        public CardType CardType { get; protected set; }

        public BasicCard(int value, Signs sign, CardType cardType)
        {
            Value = value;
            CardType = cardType;
            Value = value;
        }
    }
}
