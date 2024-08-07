using System;


namespace ToyRobotApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.Place(0, 0, "NORTH");
            Console.WriteLine($"Initial Position: {robot.Report()}");

            robot.Move();
            Console.WriteLine($"After Move: {robot.Report()}");

            robot.Left();
            Console.WriteLine($"After Left Turn: {robot.Report()}");

            robot.Move();
            Console.WriteLine($"After Move: {robot.Report()}");

            robot.Right();
            Console.WriteLine($"After Right Turn: {robot.Report()}");

            robot.Move();
            Console.WriteLine($"After Move: {robot.Report()}");

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
