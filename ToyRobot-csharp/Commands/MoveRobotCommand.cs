using System;

namespace ToyRobot.Commands
{
    internal class MoveRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        public MoveRobotCommand(IRobot robot) : base(robot)
        {
        }

        public String Execute()
        {
            robot.Move();
            return "Robot moved.";
        }
    }
}