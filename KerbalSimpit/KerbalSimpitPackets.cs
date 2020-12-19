namespace KerbalSimpit
{
    public static class CommonPackets
    {
        public static byte Synchronisation = 0;
        public static byte EchoRequest = 1;
        public static byte EchoResponse = 2;
    }

    public static class OutboundPackets
    {
        // Propulsion Resources
        public static byte LiquidFuel = 1;
        public static byte LiquidFuelStage = 2;
        public static byte Oxidizer = 3;
        public static byte OxidizerStage = 4;
        public static byte SolidFuel = 5;
        public static byte SolidFuelStage = 6;
        public static byte XenonGas = 7;
        public static byte XenonGasStage = 8;
        public static byte MonoPropellant = 9;
        public static byte EvaPropellant = 10;

        // Vessel Resources
        public static byte ElectricCharge = 20;
        public static byte Ore = 21;
        public static byte Ablator = 22;
        public static byte AblatorStage = 23;

        // Vessel Movement/Postion
        public static byte Altitude = 30;
        public static byte Velocities = 31;
        public static byte Airspeed = 32;
        public static byte Apsides = 33;
        public static byte ApsidesTime = 34;
        public static byte ManeuverData = 35;

        // Vessel Details
        public static byte ActionGroups = 40;
        public static byte DeltaV = 41;
        public static byte DeltaVEnv = 42;
        public static byte BurnTime = 43;
        public static byte CustomActionGroups = 44;

        // External Environment
        public static byte TargetInfo = 50;
        public static byte SoIName = 51;
        public static byte SceneChange = 52;   
    }

    public static class InboundPackets
    {
        public static byte RegisterHandler = 8;
        public static byte DeregisterHandler = 9;
        public static byte CAGEnable = 10;
        public static byte CAGDisable = 11;
        public static byte CAGToggle = 12;
        public static byte ActionGroupActivate = 13;
        public static byte ActionGroupDeactivate = 14;
        public static byte ActionGroupToggle = 15;
        public static byte VesselRotation = 16;
        public static byte VesselTranslation = 17;
        public static byte WheelControl = 18;
        public static byte VesselThrottle = 19;
        public static byte AutopilotMode = 20;
        public static byte WarpChange = 24;
    }

    public static class ActionGroupBits
    {
        // This is the same order given in
        // https://kerbalspaceprogram.com/api/_base_action_8cs.html
        public static byte StageBit = 1;
        public static byte GearBit = 2;
        public static byte LightBit = 4;
        public static byte RCSBit = 8;
        public static byte SASBit = 16;
        public static byte BrakesBit = 32;
        public static byte AbortBit = 64;
    }

    public static class WarpContolEnum
    {
        public const byte timewarp1 = 0;
        public const byte timewarp5 = 1;
        public const byte timewarp10 = 2;
        public const byte timewarp50 = 3;
        public const byte timewarp100 = 4;
        public const byte timewarp1000 = 5;
        public const byte timewarp10000 = 6;
        public const byte timewarp100000 = 7;
        public const byte timewarpPhysical2 = 8;
        public const byte timewarpPhysical3 = 9;
        public const byte timewarpPhysical4 = 10;
        public const byte timewarpUp = 11;
        public const byte timewarpDown = 12;
        public const byte timewarpNextManeuver = 13;
        public const byte timewarpSOIChange = 14;
        public const byte timewarpApoapsis = 15;
        public const byte timewarpPeriapsis = 16;
        public const byte timewarpCancelAutoWarp = 17;
    }
}
