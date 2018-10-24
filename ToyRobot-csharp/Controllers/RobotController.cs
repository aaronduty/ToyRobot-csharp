using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ToyRobot
{
    public class RobotController
    {
        public IRobot Robot { get; set; }

        private Regex rx = new Regex(@"^(?<command>\w+)( (?<X>\d+),(?<Y>\d+),(?<F>\w+))?$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public RobotController(IRobot robot)
        {
            Robot = robot;
        }

        public String ExecuteCommand(String command)
        {
            
        }
    }
}
