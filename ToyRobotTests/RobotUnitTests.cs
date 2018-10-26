using System;
using System.Text.RegularExpressions;
using ToyRobot;
using Xunit;
using System.Linq;

namespace ToyRobotTests
{
    public class RobotUnitTests
    {
        ITable table = new Table(5, 5);
        Regex reportPattern = new Regex(@"^(?<X>\d+),(?<Y>\d+),(?<F>NORTH|SOUTH|EAST|WEST)$");

        [Theory]
        [InlineData(0, 0, Heading.NORTH)]
        [InlineData(3, 4, Heading.SOUTH)]
        public void Place(int x, int y, Heading f)
        {
            //prep
            var robot = new Robot(table, 0, 0, Heading.NORTH);

            //test
            robot.Place(table, x, y, f);

            //check
            Assert.Matches(reportPattern, robot.Report());
        }

        [Theory]
        [InlineData(3, Heading.EAST)]
        [InlineData(1, Heading.WEST)]
        public void MoveEastOrWest(int expectedX, Heading f)
        {
            //prep
            var robot = new Robot(table, 2, 0, f);

            //test
            robot.Move();

            //check
            var matchGroups = reportPattern.Matches(robot.Report()).Cast<Match>().First().Groups;
            Assert.Equal(expectedX.ToString(), matchGroups["X"].Value);
        }

        [Theory]
        [InlineData(3, Heading.NORTH)]
        [InlineData(1, Heading.SOUTH)]
        public void MoveNorthOrSouth(int expectedY, Heading f)
        {
            //prep
            var robot = new Robot(table, 0, 2, f);

            //test
            robot.Move();

            //check
            var matchGroups = reportPattern.Matches(robot.Report()).Cast<Match>().First().Groups;
            Assert.Equal(expectedY.ToString(), matchGroups["Y"].Value);
        }

        [Theory]
        [InlineData(Heading.NORTH, Heading.WEST)]
        [InlineData(Heading.WEST, Heading.SOUTH)]
        [InlineData(Heading.SOUTH, Heading.EAST)]
        [InlineData(Heading.EAST, Heading.NORTH)]
        public void TurnLeft(Heading startF, Heading expectedF)
        {
            //prep
            var robot = new Robot(table, 0, 0, startF);

            //test
            robot.Left();

            //check
            var matchGroups = reportPattern.Matches(robot.Report()).Cast<Match>().First().Groups;
            Assert.Equal(expectedF.ToString(), matchGroups["F"].Value);
        }

        [Theory]
        [InlineData(Heading.NORTH, Heading.EAST)]
        [InlineData(Heading.WEST, Heading.NORTH)]
        [InlineData(Heading.SOUTH, Heading.WEST)]
        [InlineData(Heading.EAST, Heading.SOUTH)]
        public void TurnRight(Heading startF, Heading expectedF)
        {
            //prep
            var robot = new Robot(table, 0, 0, startF);

            //test
            robot.Right();

            //check
            var matchGroups = reportPattern.Matches(robot.Report()).Cast<Match>().First().Groups;
            Assert.Equal(expectedF.ToString(), matchGroups["F"].Value);
        }

        [Fact]
        public void Report()
        {
            //prep
            var robot = new Robot(table, 0, 0, Heading.NORTH);

            //check
            Assert.Matches(reportPattern, robot.Report());
        }

        [Theory]
        [InlineData(Heading.NORTH)]
        [InlineData(Heading.SOUTH)]
        [InlineData(Heading.EAST)]
        [InlineData(Heading.WEST)]
        public void CannotGoOffSurface(Heading f)
        {
            //prep
            var robot = new Robot(new Table(1, 1), 0, 0, f);
            var expectedReport = robot.Report();

            //test
            robot.Move();

            //check
            Assert.Equal(expectedReport, robot.Report());
        }

        [Fact]
        public void CannotBePlacedOffSurface()
        {
            //prep
            var robot = new Robot(table, 0, 0, Heading.EAST);

            //test and check
            Assert.Throws<RobotPlacementException>(() => robot.Place(6, 6, Heading.NORTH));
        }
    }
}
