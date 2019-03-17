namespace SolarMonitoringSystem.Data
{
    public class FourthBatchInverterData
    {
        public ushort DCRelayState { get; set; }
        public ushort EarthRelayState { get; set; }

        public int AccumulatedChargerPower { get; set; }
        public int AccumulatedDischargerPower { get; set; }
        public int AccumulatedBuyPower { get; set; }
        public int AccumulatedSellPower { get; set; }
        public int AccumulatedLoadPower { get; set; }
        public int AccumulatedSelf_usePower { get; set; }
        public int AccumulatedPV_sellPower { get; set; }
        public int AccumulatedGrid_chargerPower { get; set; }

        public ushort ErrorMessage1 { get; set; }
        public ushort ErrorMessage2 { get; set; }
        public ushort ErrorMessage3 { get; set; }

        public ushort WarningMessage1 { get; set; }
        public ushort WarningMessage2 { get; set; }

        public ushort BattCurrent { get; set; }
    }
}

