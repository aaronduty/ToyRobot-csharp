using System;

namespace ToyRobot.Commands
{
    internal class RightRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        public RightRobotCommand(IRobot robot) : base(robot)
        {
        }

        public String Execute()
        {
            robot.Right();
            return "Robot turned right.";
        }
    }
}