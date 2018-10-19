using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot
{
    public class RobotController
    {
        public IRobot Robot { get; set; }

        public RobotController(IRobot robot)
        {
            Robot = robot;
        }

        public String ExecuteCommand(String command)
        {
            throw new NotImplementedException();
        }
    }
}
