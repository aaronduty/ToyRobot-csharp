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
            MatchCollection matches = rx.Matches(command);
            GroupCollection groups = matches.Cast<Match>().First().Groups;
            String keyword = groups["command"].Value;
            int X = int.TryParse(groups["X"].Value, out X) ? X : 0;
            int Y = int.TryParse(groups["Y"].Value, out Y) ? Y : 0;
            String F = groups["F"].Value;

            String output = "";
            switch (keyword.ToLower())
            {
                case "place":
                    Robot.Place(X, Y, Enum.Parse<Heading>(F));
                    output = "Robot Placed";
                    break;
                case "left":
                    Robot.Left();
                    output = "Robot Turn Left";
                    break;
                case "right":
                    Robot.Right();
                    output = "Robot Turn Right";
                    break;
                case "move":
                    Robot.Move();
                    output = "Robot Move";
                    break;
                case "report":
                    output = Robot.Report();
                    break;
                default:
                    output = "Unrecognized Command";
                    break;
            }

            return output;
        }
    }
}
