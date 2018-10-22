using System;

namespace ToyRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            var robotController = new RobotController(new Robot(new Table(5, 5), 0, 0, Heading.NORTH));
            String command = null;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Welcome to the Toy Robot Simulator.");
            Console.WriteLine("A robot has been provided on a 5x5 table.");
            Console.WriteLine("Available commands are:");
            Console.WriteLine("PLACE X,Y,(NORTH|SOUTH|EAST|WEST)");
            Console.WriteLine("MOVE");
            Console.WriteLine("LEFT");
            Console.WriteLine("RIGHT");
            Console.WriteLine("REPORT");
            Console.WriteLine("END");
            Console.WriteLine("--------------------------------------------------");

            Console.Write("\r\n>");
            do
            {
                command = Console.ReadLine().ToUpper();
                Console.WriteLine(robotController.ExecuteCommand(command));
                Console.Write(">");
            } while (command != "END");
        }
    }
}
