namespace ToyRobot.Commands
{
    internal class RightRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        public RightRobotCommand(IRobot robot) : base(robot)
        {
        }

        public void execute()
        {
            robot.Left();
            outputWriter.WriteLine("Robot turned right.");
        }
    }
}