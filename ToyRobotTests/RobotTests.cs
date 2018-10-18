using System;
using Xunit;

namespace ToyRobotTests
{
    public class RobotTests
    {
        [Fact]
        public void Test1()
        {
            new ToyRobot.Robot(new ToyRobot.Table(5, 5), 0, 0, ToyRobot.Heading.North);
        }
    }
}
