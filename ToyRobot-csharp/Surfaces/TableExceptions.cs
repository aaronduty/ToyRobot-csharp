using System;

namespace ToyRobot
{
    public class NegativeOrZeroDimensionException : Exception
    {
        public NegativeOrZeroDimensionException()
        {
        }

        public NegativeOrZeroDimensionException(string message) : base(message)
        {
        }

        public NegativeOrZeroDimensionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
