namespace ToyRobot.Commands
{
    internal class LeftRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        public LeftRobotCommand(IRobot robot) : base(robot)
        {
        }

        public void execute()
        {
            robot.Left();
            outputWriter.WriteLine("Robot turned left.");
        }
    }
}