using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class RobotDirector
    {

        private IRobotBuilder robotBuilder;

        public RobotDirector(IRobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }

        public Robot getRobot()
        {
            return this.robotBuilder.GetRobot();
        }

        public void MakeRobot()
        {
            this.robotBuilder.BuildRobotHead();
            this.robotBuilder.BuildRobotTorso();
            this.robotBuilder.BuildRobotLegs();
            this.robotBuilder.BuildRobotArms();
        }

    }
}
