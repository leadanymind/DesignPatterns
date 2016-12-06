namespace BuilderPattern
{
    interface IRobotSchematics
    {
        void SetRobotHead(string head);
        void SetRobotTorso(string torso);
        void SetRobotArms(string arms);
        void SetRobotLegs(string legs);
    }
}