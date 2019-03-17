namespace SolarMonitoringSystem.Infrastructure
{
    public class ModbusSlaveConfiguration
    {
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public byte ChargerSlaveId { get; set; }
        public byte InvertorSlaveId { get; set; }
    }
}
