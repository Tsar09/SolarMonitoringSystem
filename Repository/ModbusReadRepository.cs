using Microsoft.Extensions.Options;
using NModbus;
using SolarMonitoringSystem.Infrastructure;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SolarMonitoringSystem.Repository
{
    public class ModbusReadRepository
    {
        private ModbusSlaveConfiguration _modbusSlaveConfiguration { get; set; }

        public ModbusReadRepository(IOptions<ModbusSlaveConfiguration> modbusSlaveConfiguration)
        {
            _modbusSlaveConfiguration = modbusSlaveConfiguration.Value;
        }

        public async Task<ushort[]> ReadHoldingRegisters(byte slaveAddress, ushort startAddress, ushort registersCount)
        {
            //using (TcpClient client = new TcpClient(_modbusSlaveConfiguration.IpAddress, _modbusSlaveConfiguration.Port))
            //{
                TcpClient client = new TcpClient();
                await client.ConnectAsync(_modbusSlaveConfiguration.IpAddress, _modbusSlaveConfiguration.Port);
                IModbusMaster modbus = new ModbusFactory().CreateMaster(client);
                var t = await modbus.ReadHoldingRegistersAsync(slaveAddress, startAddress, registersCount);
                client.Close();
                return t;
          //  }

        }
    }
}
