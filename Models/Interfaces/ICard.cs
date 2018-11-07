using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;

namespace Models.Interfaces
{
    public interface ICard
    {
        int Value { get; }

        Signs Sign { get; }

        CardType CardType { get; }
    }
}
