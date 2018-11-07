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
    class PositiveNegativeCard : BasicCard
    {
        public PositiveNegativeCard(int value) : base (value, Signs.Plus, CardType.PositiveNegative)
        {

        }

        public void SwapSign()
        {
            Sign = 1 - Sign;
        }
    }
}
