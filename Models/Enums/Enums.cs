using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Enums
{
    public enum Signs
    {
        Minus,
        Plus
    }

    public enum CardType
    {
        Basic,
        Positive,
        Negative,
        PositiveNegative,
        FlipCard,
        DoubleCard,
        Tiebreaker
    }

    public enum Turn
    {
        End,
        Stand,
        SideCard
    }

    public enum GameResult
    {
        Running,
        Player1Win,
        Player2Win,
        Tie
    }
}
