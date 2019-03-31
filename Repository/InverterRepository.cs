using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SolarMonitoringSystem.Data;
using SolarMonitoringSystem.Infrastructure;
using SolarMonitoringSystem.Repository.Interfaces;
using System.Threading.Tasks;

namespace SolarMonitoringSystem.Repository
{
    public class InverterRepository : ModbusReadRepository, IInverterRepository
    {
        private const int BaseDataStartRegisterAddress = 30001;
        private const int BaseDataRegistersCountToRead = 26; //TODO: check -3

        private const int FirstBatchStartRegisterAddress = 20002;
        private const int FirstBatchRegistersCountToRead = 16;

        private const int SecondBatchStartRegisterAddress = 20102;
        private const int SecondBatchRegistersCountToRead = 1; // 42;

        private const int ThirdBatchStartRegisterAddress = 25202;
        private const int ThirdBatchRegistersCountToRead = 40;

        private const int FourthBatchStartRegisterAddress = 25242;
        private const int FourthBatchRegistersCountToRead = 34; //TODO: check -7

        private readonly ILogger _logger;
        private readonly ModbusSlaveConfiguration _modbusSlaveConfiguration;

        public InverterRepository(
            IOptions<ModbusSlaveConfiguration> modbusSlaveConfiguration,
            ILogger<InverterRepository> logger)
            : base(modbusSlaveConfiguration)
        {
            _modbusSlaveConfiguration = modbusSlaveConfiguration.Value;
            _logger = logger;
        }

        public BaseInverterData ReadBaseBatchData()
        {
            var data = ReadHoldingRegisters(_modbusSlaveConfiguration.InvertorSlaveId, BaseDataStartRegisterAddress, BaseDataRegistersCountToRead);
            _logger.LogInformation($"Read BASE batch inverter batch: { string.Join(", ", data) }");
            return new BaseInverterData
            {
                
            };
        }

        public FirstBatchInverterData ReadFirstBatchData()
        {
            var data = ReadHoldingRegisters(_modbusSlaveConfiguration.InvertorSlaveId, FirstBatchStartRegisterAddress, FirstBatchRegistersCountToRead);
            _logger.LogInformation($"Read FIRST batch inverter batch: { string.Join(", ", data) }");
            return new FirstBatchInverterData
            {

            };
        }

        public async Task<SecondBatchInverterData> ReadSecondBatchData()
        {
            var data = await ReadHoldingRegisters(_modbusSlaveConfiguration.InvertorSlaveId, SecondBatchStartRegisterAddress, SecondBatchRegistersCountToRead);
            //var data = new ushort[100];
            _logger.LogInformation($"Read SECOND batch inverter batch: { string.Join(", ", data) }");
            return new SecondBatchInverterData
            {
                InverterOffgridWorkEnable = data[0],

                InverterOutputVoltageSet = data[2] / 10, //TODO: check start
                InverterOutputFrequencySet = data[3] / 100,
                InverterSearchModeEnable = data[4],
                InverterOngridWorkEnable = data[5],
                InverterChargerFromGridEnable = data[6],
                InverterDischargerEnable = data[7],
                InverterDischargerToGridEnable = data[8],
                EnergyUseMode = data[9],
                TimeModeUseEnable = data[10],
                GridProtectStandard = data[11],

                InverterMaxDischargerCurrent = data[13] * 0.1,
                InverterMaxChargerCurrent = data[14] * 0.1,
                GridMaxOutputCurrent = data[15] * 0.1,
                GridMaxInputCurrent = data[16] * 0.1,
                StartChargerVoltagePoint = data[17] * 0.1,
                NormalVoltagePoint = data[18] * 0.1,
                StartSellVoltagePoint = data[19] * 0.1,



                MaxChargerCurrentSet = data[23] * 0.1,
                AbsorbChargerCurrentSet = data[24] * 0.1,
                BatteryLowVoltage = data[25] * 0.1,
                BatteryHighVoltage = data[26] * 0.1,
                BatteryType = data[27],
                BatteryAH = data[28],
                BatteryLowReturnVoltage = data[29] * 0.1,
                MaxCombineChargerCurrent = data[30] * 0.1,

                SystemSetting = data[40] * 0.1,
            };
        }

        public ThirdBatchInverterData ReadThirdBatchData()
        {
            //var data = ReadHoldingRegisters(_modbusSlaveConfiguration.InvertorSlaveId, ThirdBatchStartRegisterAddress, ThirdBatchRegistersCountToRead);
            var data = new ushort[100];
            _logger.LogInformation($"Read THIRD batch inverter batch: { string.Join(", ", data) }");

            return new ThirdBatchInverterData
            {
                WorkState = data[0],
                ACVoltageGrade = data[1],
                RatedPower = data[2],
                BatteryVoltage = data[3],
                InverterVoltage = data[4],
                GridVoltage = data[5],
                BUSVoltage = data[6],
                ControlCurrent = data[7],
                InverterCurrent = data[8],
                GridCurrent = data[9],
                LoadCurrent = data[10],
                PInverter = data[11],
                Pgrid = data[12],
                Pload = data[14],
                LoadPercent = data[15],
                SInverter = data[16],
                SGrid = data[17],
                Sload = data[18],

                Qinverter = data[20],

                Qgrid = data[22],
                Qload = data[23],

                InverterFrequency = data[25],
                GridFrequency = data[26],

                InverterMaxNumber = data[29],
                CombineType = data[30],
                InverterNumber = data[31],

                ACRadiatorTemperature = data[33],
                TransformerTemperature = data[34],
                DCRadiatorTemperature = data[35],

                InverterRelayState = data[36],
                GridRelayState = data[36],
                LoadRelayState = data[37],
                N_LineRelayState = data[38]
            };
        }


        public FourthBatchInverterData ReadFourthBatchData()
        {
            //var data = ReadHoldingRegisters(_modbusSlaveConfiguration.InvertorSlaveId, FourthBatchStartRegisterAddress, FourthBatchRegistersCountToRead);
            var data = new ushort[100];
            _logger.LogInformation($"Read FOURTH batch inverter batch: { string.Join(", ", data) }");

            return new FourthBatchInverterData
            {
                DCRelayState = data[0],
                EarthRelayState = data[1],

                AccumulatedChargerPower = data[4] * 1000,

                AccumulatedDischargerPower = data[6] * 1000,

                AccumulatedBuyPower = data[8] * 1000,

                AccumulatedSellPower = data[10] * 1000,

                AccumulatedLoadPower = data[12] * 1000,

                AccumulatedSelf_usePower = data[14] * 1000,

                AccumulatedPV_sellPower = data[16] * 1000,

                AccumulatedGrid_chargerPower = data[18] * 1000,

                ErrorMessage1 = data[20],
                ErrorMessage2 = data[21],
                ErrorMessage3 = data[22],

                WarningMessage1 = data[24],
                WarningMessage2 = data[25],

                BattCurrent = data[27]
            };
        }

    }
}
