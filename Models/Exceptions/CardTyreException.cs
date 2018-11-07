using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Exceptions
{

    [Serializable]
    public class CardTyreException : Exception
    {
        public CardTyreException() { }
        public CardTyreException(string message, CardType cardType) : base(message) { CardType = cardType; }
        public CardTyreException(string message, Exception inner) : base(message, inner) { }
        protected CardTyreException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        public CardType CardType { get; private set; }
    }
}
