using Microsoft.Extensions.Options;
using SolarMonitoringSystem.Infrastructure;
using SolarMonitoringSystem.Repository.Interfaces;

namespace SolarMonitoringSystem.Repository
{
    public class ChargerRepository : ModbusReadRepository, IChargerRepository
    {
        private readonly ModbusSlaveConfiguration _modbusSlaveConfiguration;

        public ChargerRepository(IOptions<ModbusSlaveConfiguration> modbusSlaveConfiguration)
            : base(modbusSlaveConfiguration)
        {
            _modbusSlaveConfiguration = modbusSlaveConfiguration.Value;
        }

        public ushort[] Read()
        {
            // ENUM each value is index in enum
            return ReadHoldingRegisters(_modbusSlaveConfiguration.ChargerSlaveId, 1, 2);
        }
    }
}
