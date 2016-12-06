namespace BuilderPattern
{
    public interface IRobotBuilder
    {
        // Definition of builder, and what needs to be called in order to build the robot
        void BuildRobotHead();
        void BuildRobotTorso();
        void BuildRobotArms();
        void BuildRobotLegs();
        Robot GetRobot();
    }
}