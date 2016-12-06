namespace BuilderPattern
{
    public interface IRobotBuilder
    {
        void BuildRobotHead();
        void BuildRobotTorso();
        void BuildRobotArms();
        void BuildRobotLegs();
        Robot GetRobot();
    }
}