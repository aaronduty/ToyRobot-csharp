namespace ToyRobot.Commands
{
    internal class RightRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        public RightRobotCommand(IRobot robot) : base(robot)
        {
        }

        public void execute()
        {
            robot.Right();
            outputWriter.WriteLine("Robot turned right.");
        }
    }
}