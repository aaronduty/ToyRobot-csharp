using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ToyRobot.Commands
{
    class RobotCommandFactory
    {
        protected Regex rx = new Regex(
            @"^(?<command>\w+)( (?<X>\d+),(?<Y>\d+),(?<F>\w+))?$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);
        protected IRobot robot;

        public RobotCommandFactory(IRobot robot)
        {
            this.robot = robot;
        }
        
        public IRobotCommand GetCommand(String command)
        {
            MatchCollection matches = rx.Matches(command);
            GroupCollection groups = matches.Cast<Match>().First().Groups;
            String keyword = groups["command"].Value;
            int X = int.TryParse(groups["X"].Value, out X) ? X : 0;
            int Y = int.TryParse(groups["Y"].Value, out Y) ? Y : 0;
            bool validHeading = Enum.TryParse(groups["F"].Value, out Heading F);

            switch (keyword.ToLower())
            {
                case "place" when validHeading:
                    return new PlaceRobotCommand(robot, X, Y, F);
                case "left":
                    return new LeftRobotCommand();
                case "right":
                    return new RightRobotCommand();
                case "move":
                    return new MoveRobotCommand();
                case "report":
                    return new ReportRobotCommand();
                default:
                    return new UnknownRobotCommand();
            }
        }
    }
}
