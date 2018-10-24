using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.Commands
{
    class PlaceRobotCommand : AbstractRobotCommand, IRobotCommand
    {
        private readonly int x;
        private readonly int y;
        private readonly Heading f;

        public PlaceRobotCommand(IRobot robot, int x, int y, Heading f) : base(robot)
        {
            this.x = x;
            this.y = y;
            this.f = f;
        }

        public void execute()
        {
            robot.Place(x, y, f);
        }
    }
}
