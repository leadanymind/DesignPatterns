namespace BuilderPattern
{
    interface IRobotSchematics
    {
        // This interface defines the schema/interface required to complete a robot
        void SetRobotHead(string head);
        void SetRobotTorso(string torso);
        void SetRobotArms(string arms);
        void SetRobotLegs(string legs);
    }
}