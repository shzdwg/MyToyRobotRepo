using System;
using System.IO;

namespace ToyRobotApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            if (args.Length > 0 && File.Exists(args[0]))
            {
                // Process commands from a file
                var lines = File.ReadAllLines(args[0]);
                ProcessCommands(robot, lines);
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
            else
            {
                // Process commands from standard input
                Console.WriteLine("Enter commands (type 'END' to finish):");
                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    ProcessCommand(robot, command);
                }
            }
        }

        private static void ProcessCommands(Robot robot, string[] commands)
        {
            foreach (var command in commands)
            {
                ProcessCommand(robot, command);
            }
        }

        private static void ProcessCommand(Robot robot, string command)
        {
            if (command.StartsWith("PLACE"))
            {
                var parts = command.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 4 && int.TryParse(parts[1], out int x) && int.TryParse(parts[2], out int y))
                {
                    try
                    {
                        robot.Place(x, y, parts[3]);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else if (robot.IsPlaced)
            {
                switch (command)
                {
                    case "MOVE":
                        robot.Move();
                        break;
                    case "LEFT":
                        robot.Left();
                        break;
                    case "RIGHT":
                        robot.Right();
                        break;
                    case "REPORT":
                        var (x, y, f) = robot.Report();
                        Console.WriteLine($"{x},{y},{f}");
                        break;
                }
            }
        }
    }
}
