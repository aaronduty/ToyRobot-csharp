using System;

namespace ToyRobot.Commands
{
    internal class ReportRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        public ReportRobotCommand(IRobot robot) : base(robot)
        {
        }

        public String Execute()
        {
            return "Robot placed: " + robot.Report();
        }
    }
}