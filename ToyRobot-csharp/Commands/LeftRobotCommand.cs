using System;

namespace ToyRobot.Commands
{
    internal class LeftRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        public LeftRobotCommand(IRobot robot) : base(robot)
        {
        }

        public String Execute()
        {
            robot.Left();
            return "Robot turned left.";
        }
    }
}