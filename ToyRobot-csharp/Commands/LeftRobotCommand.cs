namespace ToyRobot.Commands
{
    internal class LeftRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        public LeftRobotCommand(IRobot robot) : base(robot)
        {
        }

        public void Execute()
        {
            robot.Left();
            outputWriter.WriteLine("Robot turned left.");
        }
    }
}