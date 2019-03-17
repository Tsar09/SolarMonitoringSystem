namespace SolarMonitoringSystem.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Ep2000Model
    {
        //public static readonly Dictionary<int, string[]> BatteryLowVoltageDic;
        //public static readonly Dictionary<int, string[]> BulkChargeCurrentDic;
        //public static readonly Dictionary<int, string[]> ConstantChargeVoltageDic;
        //public static readonly Dictionary<int, string[]> FloatChargeVoltageDic;

        static Ep2000Model()
        {
            //BatteryLowVoltageDic = new Dictionary<int, string[]>();
            //ConstantChargeVoltageDic = new Dictionary<int, string[]>();
            //FloatChargeVoltageDic = new Dictionary<int, string[]>();
            //BulkChargeCurrentDic = new Dictionary<int, string[]>();
            //string[] textArray1 = new string[] { "11V", "10.9V", "10.8V", "10.7V", "10.6V", "10.5V" };
            //BatteryLowVoltageDic.Add(0, textArray1);
            //string[] textArray2 = new string[] { "22V", "21.8V", "21.6V", "21.4V", "21.2V", "21V" };
            //BatteryLowVoltageDic.Add(1, textArray2);
            //string[] textArray3 = new string[] { "14V", "14.2V", "14.4V" };
            //ConstantChargeVoltageDic.Add(0, textArray3);
            //string[] textArray4 = new string[] { "28V", "28.4V", "28.8V" };
            //ConstantChargeVoltageDic.Add(1, textArray4);
            //string[] textArray5 = new string[] { "13.5V", "13.6V", "13.7V" };
            //FloatChargeVoltageDic.Add(0, textArray5);
            //string[] textArray6 = new string[] { "27V", "27.2V", "27.4V" };
            //FloatChargeVoltageDic.Add(1, textArray6);
            //string[] textArray7 = new string[] { "10A", "20A", "30A" };
            //BulkChargeCurrentDic.Add(0, textArray7);
            //string[] textArray8 = new string[] { "5A", "10A", "15A" };
            //BulkChargeCurrentDic.Add(1, textArray8);
        }

        public string Alarm { get; set; }

        public string AVRState { get; set; }

        public string BatClass { get; set; }

        public string BatteryCurrent { get; set; }

        public string BatteryLowVoltage { get; set; }

        public string BatterySOC { get; set; }

        public string BatteryVoltage { get; set; }

        public string BulkChargeCurrent { get; set; }

        public string BuzzerSilence { get; set; }

        public string BuzzerState { get; set; }

        public string ChargeFlag { get; set; }

        public string ChargeState { get; set; }

        public string ConstantChargeVoltage { get; set; }

        public string Fault { get; set; }

        public string FloatChargeVoltage { get; set; }

        public string GridFrequency { get; set; }

        public string GridFrequencyType { get; set; }

        public string GridVoltage { get; set; }

        public string GridVoltageType { get; set; }

        [Key]
        public long Id { get; set; }

        public string LoadCurrent { get; set; }

        public string LoadPercent { get; set; }

        public string LoadPower { get; set; }

        public string LoadState { get; set; }

        public string MachineType { get; set; }

        public string MainSW { get; set; }

        public string OutputFrequency { get; set; }

        public string OutputVoltage { get; set; }

        public string RatedPower { get; set; }

        public DateTime RecordTime { get; set; }

        public string SoftwareVersion { get; set; }

        public string TransformerTemp { get; set; }

        public string WorkState { get; set; }
    }
}

