namespace ToyRobot.Commands
{
    internal class MoveRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        public MoveRobotCommand(IRobot robot) : base(robot)
        {
        }

        public void Execute()
        {
            robot.Move();
            outputWriter.WriteLine("Robot moved.");
        }
    }
}