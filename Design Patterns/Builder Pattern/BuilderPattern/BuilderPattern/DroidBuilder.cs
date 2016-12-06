using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class DroidBuilder : IRobotBuilder
    {
        // This class is meant to be a template for a specific type of robot. In this case, this is a droid builder.
        // There are many different types of robots that have their own specifications for each method.

        private Robot robot;

        public DroidBuilder()
        {
            this.robot = new Robot();
        }

        public void BuildRobotArms()
        {
            robot.SetRobotArms("No arms are set, just connectors to wheels");
        }

        public void BuildRobotHead()
        {
            robot.SetRobotHead("Robot head is round, white and has a camera");
        }

        public void BuildRobotLegs()
        {
            robot.SetRobotLegs("Robot legs are simply wheels.");
        }

        public void BuildRobotTorso()
        {
            robot.SetRobotTorso("Robot torso is a round cylinder shape made of steel");
        }

        public Robot GetRobot()
        {
            return this.robot;
        }
    }
}
