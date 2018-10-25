using System;

namespace ToyRobot.Commands
{
    internal class UnknownRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        private String message = "Command not understood. No action taken.";

        public UnknownRobotCommand() : base(null)
        {
        }

        public UnknownRobotCommand(String message) : base(null)
        {
            this.message = message;
        }

        public String Execute()
        {
            return message;
        }
    }
}