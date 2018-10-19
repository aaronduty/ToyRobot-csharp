using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ToyRobot
{
    public class RobotController
    {
        private IRobot robot;

        public RobotController(IRobot robot)
        {
            this.robot = robot;
        }

        public void Execute(String command)
        {
            var rx = new Regex(@"^(?<command>\w+)( (?<X>\d+),(?<Y>\d+),(?<F>\w+))?$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(command);
            GroupCollection groups = matches.Cast<Match>().First().Groups;
            String keyword = groups["command"].Value;
            int X = int.TryParse(groups["X"].Value, out X) ? X : 0;
            int Y = int.TryParse(groups["Y"].Value, out Y) ? Y : 0;
            Heading F = Enum.Parse<Heading>(groups["F"].Value);

            switch (keyword.ToLower())
            {
                case "place":
                    robot.Place(X, Y, F);
                    break;
                case "left":
                    robot.Left();
                    break;
                case "right":
                    robot.Right();
                    break;
                case "move":
                    robot.Move();
                    break;
                case "report":
                    Console.WriteLine(robot.Report());
                    break;
                default:
                    break;
            }
        }
    }
}
