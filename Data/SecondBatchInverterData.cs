namespace SolarMonitoringSystem.Data
{
    public class SecondBatchInverterData
    {
        public ushort InverterOffgridWorkEnable { get; set; }

        public int InverterOutputVoltageSet { get; set; }
        public int InverterOutputFrequencySet { get; set; }
        public ushort InverterSearchModeEnable { get; set; }
        public ushort InverterOngridWorkEnable { get; set; }
        public ushort InverterChargerFromGridEnable { get; set; }
        public ushort InverterDischargerEnable { get; set; }
        public ushort InverterDischargerToGridEnable { get; set; }
        public ushort EnergyUseMode { get; set; }
        public ushort TimeModeUseEnable { get; set; }
        public ushort GridProtectStandard { get; set; }

        public double InverterMaxDischargerCurrent { get; set; }
        public double InverterMaxChargerCurrent { get; set; }
        public double GridMaxOutputCurrent { get; set; }
        public double GridMaxInputCurrent { get; set; }
        public double StartChargerVoltagePoint { get; set; }
        public double NormalVoltagePoint { get; set; }
        public double StartSellVoltagePoint { get; set; }
        
        public double MaxChargerCurrentSet { get; set; }
        public double AbsorbChargerCurrentSet { get; set; }
        public double BatteryLowVoltage { get; set; }
        public double BatteryHighVoltage { get; set; }
        public ushort BatteryType { get; set; }
        public ushort BatteryAH { get; set; }
        public double BatteryLowReturnVoltage { get; set; }
        public double MaxCombineChargerCurrent { get; set; }

        public double SystemSetting { get; set; }
    }
}

