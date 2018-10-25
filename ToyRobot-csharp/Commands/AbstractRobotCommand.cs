namespace ToyRobot.Commands
{
    public abstract class AbstractRobotCommand
    {
        protected readonly IRobot robot;

        public AbstractRobotCommand(IRobot robot)
        {
            this.robot = robot;
        }
    }
}
