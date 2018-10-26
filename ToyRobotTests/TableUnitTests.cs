using System;
using ToyRobot;
using Xunit;

namespace ToyRobotTests
{
    public class TableUnitTests
    {
        [Fact]
        public void ThrowsOnNegativeDimensions()
        {
            Assert.Throws<NegativeOrZeroDimensionException>(() => new Table(-2, -3));
        }

        [Fact]
        public void ThrowsOnZeroLengthDimension()
        {
            Assert.Throws<NegativeOrZeroDimensionException>(() => new Table(0, 0));
        }
    }
}
