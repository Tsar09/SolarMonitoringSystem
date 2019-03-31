using Microsoft.Extensions.Options;
using NModbus;
using SolarMonitoringSystem.Infrastructure;
using System;
using System.Net;
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
            //TcpClient client = new TcpClient();
            //client.Connect(_modbusSlaveConfiguration.IpAddress, _modbusSlaveConfiguration.Port);
            //IModbusMaster modbus = new ModbusFactory().CreateMaster(client);
            //var t = modbus.ReadHoldingRegisters(slaveAddress, startAddress, registersCount);
            //client.Close();
            //return t;
            //  }
            using (TcpClient client = new TcpClient())
            {
                client.ReceiveTimeout = 60000;
                client.SendTimeout = 60000;
                client.NoDelay = false;

                await client.ConnectAsync(_modbusSlaveConfiguration.IpAddress, 502);

                var modbus = new ModbusFactory().CreateMaster(client);
                return await modbus.ReadHoldingRegistersAsync(slaveAddress, startAddress, registersCount);
            }

        }
    }
}
