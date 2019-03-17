namespace SolarMonitoringSystem.Data
{
    public class ThirdBatchInverterData
    {
        public ushort WorkState { get; set; }
        public ushort ACVoltageGrade { get; set; }
        public ushort RatedPower { get; set; }
        public ushort BatteryVoltage { get; set; }
        public ushort InverterVoltage { get; set; }
        public ushort GridVoltage { get; set; }
        public ushort BUSVoltage { get; set; }
        public ushort ControlCurrent { get; set; }
        public ushort InverterCurrent { get; set; }
        public ushort GridCurrent { get; set; }
        public ushort LoadCurrent { get; set; }
        public ushort PInverter { get; set; }
        public ushort Pgrid { get; set; }
        public ushort Pload { get; set; }
        public ushort LoadPercent { get; set; }
        public ushort SInverter { get; set; }
        public ushort SGrid { get; set; }
        public ushort Sload { get; set; }

        public ushort Qinverter { get; set; }
        public ushort Qgrid { get; set; }
        public ushort Qload { get; set; }

        public ushort InverterFrequency { get; set; }
        public ushort GridFrequency { get; set; }

        public ushort InverterMaxNumber { get; set; }
        public ushort CombineType { get; set; }
        public ushort InverterNumber { get; set; }

        public ushort ACRadiatorTemperature { get; set; }
        public ushort TransformerTemperature { get; set; }
        public ushort DCRadiatorTemperature { get; set; }

        public ushort InverterRelayState { get; set; }
        public ushort GridRelayState { get; set; }
        public ushort LoadRelayState { get; set; }
        public ushort N_LineRelayState { get; set; }
    }
}

