namespace ToyRobot.Commands
{
    internal class ReportRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        public ReportRobotCommand(IRobot robot) : base(robot)
        {
        }

        public void execute()
        {
            outputWriter.WriteLine("Robot at " + robot.Report());
        }
    }
}