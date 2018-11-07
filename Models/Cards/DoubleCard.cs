using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Cards
{
    class DoubleCard : BasicCard
    {
        public DoubleCard() : base(0, Enums.Signs.Plus, Enums.CardType.DoubleCard)
        {

        }

        public void SetAndDoubleValue(int value)
        {
            Value = value * 2;
        }
    }
}
