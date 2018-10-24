using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToyRobot.Commands
{
    public abstract class AbstractRobotCommand
    {
        protected readonly IRobot robot;
        protected TextWriter outputWriter = Console.Out;

        public AbstractRobotCommand(IRobot robot)
        {
            this.robot = robot;
        }
    }
}
