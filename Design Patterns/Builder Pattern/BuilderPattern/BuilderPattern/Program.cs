using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            // Need to use polymorphism to simply give the specification or blueprint for our robot.
            IRobotBuilder robot = new DroidBuilder();

            // Then we pass our specification or our blueprint to our director (Think of it as like an engineer who needs to know what you want).
            RobotDirector director = new RobotDirector(robot);

            // Tell the director/engineer to make the robot, using the specification we provided.
            director.MakeRobot();

            // Once we've made the robot, we can now get the robot from our engineer.
            Robot r2d2 = director.getRobot();

            Console.WriteLine("Robot has been built");


            // Print out some information about our robot; using new C# 6 feature (string interpolation).
            Console.WriteLine($"Robot head: { r2d2.GetRobotHead() } ");
            Console.WriteLine($"Robot arms: { r2d2.GetRobotArms() } ");
            Console.WriteLine($"Robot torso: { r2d2.GetRobotTorso() } ");
            Console.WriteLine($"Robot legs: { r2d2.GetRobotLegs() } ");

            // Pause terminal to see output.
            Console.ReadKey();
        }        
    }
}
