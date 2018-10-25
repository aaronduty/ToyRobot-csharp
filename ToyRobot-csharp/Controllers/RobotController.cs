using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using ToyRobot.Commands;

namespace ToyRobot
{
    public class RobotController
    {
        public IRobot Robot { get; set; }

        private Regex rx = new Regex(@"^(?<command>\w+)( (?<X>\d+),(?<Y>\d+),(?<F>\w+))?$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private RobotCommandFactory commandFactory;

        public RobotController(IRobot robot)
        {
            Robot = robot;
            commandFactory = new RobotCommandFactory(robot);
        }

        public String ExecuteCommand(String command)
        {
            IRobotCommand robotCommand = commandFactory.GetCommand(command);
            return robotCommand.Execute();
        }
    }
}
