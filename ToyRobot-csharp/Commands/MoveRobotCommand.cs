namespace ToyRobot.Commands
{
    internal class MoveRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        public MoveRobotCommand(IRobot robot) : base(robot)
        {
        }

        public void execute()
        {
            robot.Move();
            outputWriter.WriteLine("Robot moved.");
        }
    }
}