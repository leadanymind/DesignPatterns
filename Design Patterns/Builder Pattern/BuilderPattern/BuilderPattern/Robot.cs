using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Robot : IRobotSchematics
    {
        // Simple yet verbose schema/object that encapsulates the essentials of a basic robot.
        // Meant to capture all the components of the object.

        private string robotHead;
        private string robotArms;
        private string robotTorso;
        private string robotLegs;

        public string GetRobotHead()
        {
            return robotHead;
        }

        public string GetRobotArms()
        {
            return robotArms;
        }

        public string GetRobotTorso()
        {
            return robotTorso;
        }

        public string GetRobotLegs()
        {
            return robotLegs;
        }

        public void SetRobotHead(string head)
        {
            this.robotHead = head;
        }        

        public void SetRobotTorso(string torso)
        {
            this.robotTorso = torso;
        }

        public void SetRobotArms(string arms)
        {
            this.robotArms = arms;
        }

        public void SetRobotLegs(string legs)
        {
            this.robotLegs = legs;
        }
    }
}
