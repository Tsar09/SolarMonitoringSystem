namespace SolarMonitoringSystem.Data
{
    public class FirstBatchInverterData
    {
        public ushort WorkState { get; set; }
        public ushort MachineType { get; set; }
        public ushort SerialNumber { get; set; }
        public ushort Hardware { get; set; }
        public ushort Software { get; set; }
        public ushort BatteryVoltageCalibrationCoefficient { get; set; }
        public ushort BusVoltageCalibrationCoefficient { get; set; }
        public ushort InverterVoltageCalibrationCoefficient { get; set; }
        public ushort GridVoltageCalibrationCoefficient { get; set; }
        public ushort ControlCurrentCalibrationCoefficient { get; set; }
        public ushort InverterCurrentCalibrationCoefficient { get; set; }
        public ushort GridCurrentCalibrationCoefficient { get; set; }
        public ushort LoadCurrentCalibrationCoefficient { get; set; }
    }
}

