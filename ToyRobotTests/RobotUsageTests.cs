using System;
using ToyRobot;
using Xunit;

/*
 * In my opinion I've already spent too long on this, so we're going to limit our tests to those in the problem.
 * I don't really care that I'm not using strict TDD for this. It's a coding puzzle, meant to be done quickly.
 * The philosophy of TDD cultists is something I'll expound upon in the future. Let's just say I don't
 * completely agree with it.
 * 
 * For the record, I recognize that these are integration tests.
 */

namespace ToyRobotTests
{
    public class RobotUsageTests
    {
        RobotController robotController = new RobotController(new Robot(new Table(5, 5), 0, 0, Heading.NORTH));

        [Fact]
        public void PuzzleTest1()
        {
            var commands = new String[] { "PLACE 0,0,NORTH", "MOVE", "REPORT" };
            var expectedOutput = "Robot placed: 0,1,NORTH";
            String output = null;

            foreach (var command in commands)
            {
                output = robotController.ExecuteCommand(command);
            }

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void PuzzleTest2()
        {
            var commands = new String[] { "PLACE 0,0,NORTH", "LEFT", "REPORT" };
            var expectedOutput = "Robot placed: 0,0,WEST";
            String output = null;

            foreach (var command in commands)
            {
                output = robotController.ExecuteCommand(command);
            }

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void PuzzleTest3()
        {
            var commands = new String[] { "PLACE 1,2,EAST", "MOVE", "MOVE", "LEFT", "MOVE", "REPORT" };
            var expectedOutput = "Robot placed: 3,3,NORTH";
            String output = null;

            foreach (var command in commands)
            {
                output = robotController.ExecuteCommand(command);
            }

            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void PlacementTest1()
        {
            String expectedOutput = "Placement failed. X or Y are out of bounds for the supplied surface.";
            String output = robotController.ExecuteCommand("PLACE 6,7,WEST");
            Assert.Equal(expectedOutput, output);
        }
    }
}
