using System;
using System.Runtime.Serialization;

namespace Cawifre.BRhapsody
{
    public interface ILife { }

    public sealed class RealLife : ILife { }

    public sealed class FantasyLife : ILife { }

    public sealed class MissingLifeException : Exception
    {
        public MissingLifeException() { }

        public MissingLifeException(string message) : base(message) { }

        public MissingLifeException(string message, Exception innerException) : base(message, innerException) { }

        protected MissingLifeException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
