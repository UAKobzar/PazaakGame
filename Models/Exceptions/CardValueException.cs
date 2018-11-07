using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Exceptions
{

    [Serializable]
    public class CardValueException : Exception
    {
        public CardValueException() { }
        public CardValueException(string message, int value) : base(message) { Value = value; }
        public CardValueException(string message, Exception inner) : base(message, inner) { }
        protected CardValueException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        public int Value { get; private set; }
    }
}
