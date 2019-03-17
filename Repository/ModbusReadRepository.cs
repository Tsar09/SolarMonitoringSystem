using Microsoft.Extensions.Options;
using NModbus;
using SolarMonitoringSystem.Infrastructure;
using System.Net.Sockets;

namespace SolarMonitoringSystem.Repository
{
    public class ModbusReadRepository
    {
        private ModbusSlaveConfiguration _modbusSlaveConfiguration { get; set; }

        public ModbusReadRepository(IOptions<ModbusSlaveConfiguration> modbusSlaveConfiguration)
        {
            _modbusSlaveConfiguration = modbusSlaveConfiguration.Value;
        }

        public ushort[] ReadHoldingRegisters(byte slaveAddress, ushort startAddress, ushort registersCount)
        {
            using (TcpClient client = new TcpClient(_modbusSlaveConfiguration.IpAddress, _modbusSlaveConfiguration.Port))
            {
                IModbusMaster modbus = new ModbusFactory().CreateMaster(client);
                return modbus.ReadHoldingRegisters(slaveAddress, startAddress, registersCount);
            }
        }
    }
}
