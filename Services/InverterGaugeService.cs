using Prometheus;
using SolarMonitoringSystem.Repository.Interfaces;
using SolarMonitoringSystem.Services.Interfaces;

namespace SolarMonitoringSystem.Services
{
    internal class InverterGaugeService : IInverterGaugeService
    {
        private readonly IInverterRepository _inverterRepository;

        public InverterGaugeService(IInverterRepository inverterRepository)
        {
            _inverterRepository = inverterRepository;
        }

        public void ProcessData()
        { 
        }

        public void ProcessBaseBatchData()
        {
        }

        public void ProcessFirstBatchData()
        {
        }

        public void ProcessSecondBatchData()
        {
            var data = _inverterRepository.ReadSecondBatchData();
            SetGauge(nameof(data.AbsorbChargerCurrentSet), data.AbsorbChargerCurrentSet);
            SetGauge(nameof(data.BatteryAH), data.BatteryAH);
            SetGauge(nameof(data.BatteryHighVoltage), data.BatteryHighVoltage);
            SetGauge(nameof(data.BatteryLowReturnVoltage), data.BatteryLowReturnVoltage);
            SetGauge(nameof(data.BatteryLowVoltage), data.BatteryLowVoltage);
            SetGauge(nameof(data.BatteryType), data.BatteryType);
            SetGauge(nameof(data.EnergyUseMode), data.EnergyUseMode);
            SetGauge(nameof(data.GridMaxInputCurrent), data.GridMaxInputCurrent);
            SetGauge(nameof(data.GridMaxOutputCurrent), data.GridMaxOutputCurrent);
            SetGauge(nameof(data.GridProtectStandard), data.GridProtectStandard);
            SetGauge(nameof(data.InverterChargerFromGridEnable), data.InverterChargerFromGridEnable);
            SetGauge(nameof(data.InverterDischargerEnable), data.InverterDischargerEnable);
            SetGauge(nameof(data.InverterDischargerToGridEnable), data.InverterDischargerToGridEnable);
            SetGauge(nameof(data.InverterMaxChargerCurrent), data.InverterMaxChargerCurrent);
            SetGauge(nameof(data.InverterMaxDischargerCurrent), data.InverterMaxDischargerCurrent);
            SetGauge(nameof(data.InverterOffgridWorkEnable), data.InverterOffgridWorkEnable);
            SetGauge(nameof(data.InverterOngridWorkEnable), data.InverterOngridWorkEnable);
            SetGauge(nameof(data.InverterOutputFrequencySet), data.InverterOutputFrequencySet);
            SetGauge(nameof(data.InverterOutputVoltageSet), data.InverterOutputVoltageSet);
            SetGauge(nameof(data.InverterSearchModeEnable), data.InverterSearchModeEnable);
            SetGauge(nameof(data.MaxChargerCurrentSet), data.MaxChargerCurrentSet);
            SetGauge(nameof(data.MaxCombineChargerCurrent), data.MaxCombineChargerCurrent);
            SetGauge(nameof(data.NormalVoltagePoint), data.NormalVoltagePoint);
            SetGauge(nameof(data.StartChargerVoltagePoint), data.StartChargerVoltagePoint);
            SetGauge(nameof(data.StartSellVoltagePoint), data.StartSellVoltagePoint);
            SetGauge(nameof(data.SystemSetting), data.SystemSetting);
            SetGauge(nameof(data.TimeModeUseEnable), data.TimeModeUseEnable);
        }

        public void ProcessThirdBatchData()
        {
            var data = _inverterRepository.ReadThirdBatchData();
            SetGauge(nameof(data.ACRadiatorTemperature), data.ACRadiatorTemperature);
            SetGauge(nameof(data.ACVoltageGrade), data.ACVoltageGrade);
            SetGauge(nameof(data.BatteryVoltage), data.BatteryVoltage);
            SetGauge(nameof(data.BUSVoltage), data.BUSVoltage);
            SetGauge(nameof(data.CombineType), data.CombineType);
            SetGauge(nameof(data.ControlCurrent), data.ControlCurrent);
            SetGauge(nameof(data.DCRadiatorTemperature), data.DCRadiatorTemperature);
            SetGauge(nameof(data.GridCurrent), data.GridCurrent);
            SetGauge(nameof(data.GridFrequency), data.GridFrequency);
            SetGauge(nameof(data.GridRelayState), data.GridRelayState);
            SetGauge(nameof(data.GridVoltage), data.GridVoltage);
            SetGauge(nameof(data.InverterCurrent), data.InverterCurrent);
            SetGauge(nameof(data.InverterFrequency), data.InverterFrequency);
            SetGauge(nameof(data.InverterMaxNumber), data.InverterMaxNumber);
            SetGauge(nameof(data.InverterNumber), data.InverterNumber);
            SetGauge(nameof(data.InverterRelayState), data.InverterRelayState);
            SetGauge(nameof(data.InverterVoltage), data.InverterVoltage);
            SetGauge(nameof(data.LoadCurrent), data.LoadCurrent);
            SetGauge(nameof(data.LoadPercent), data.LoadPercent);
            SetGauge(nameof(data.LoadRelayState), data.LoadRelayState);
            SetGauge(nameof(data.N_LineRelayState), data.N_LineRelayState);
            SetGauge(nameof(data.Pgrid), data.Pgrid);
            SetGauge(nameof(data.PInverter), data.PInverter);
            SetGauge(nameof(data.Pload), data.ACRadiatorTemperature);
            SetGauge(nameof(data.Qgrid), data.ACRadiatorTemperature);
            SetGauge(nameof(data.Qinverter), data.Qinverter);
            SetGauge(nameof(data.Qload), data.Qload);
            SetGauge(nameof(data.RatedPower), data.RatedPower);
            SetGauge(nameof(data.SGrid), data.SGrid);
            SetGauge(nameof(data.SInverter), data.SInverter);
            SetGauge(nameof(data.Sload), data.Sload);
            SetGauge(nameof(data.WorkState), data.WorkState);
        }

        public void ProcessFourthBatchData()
        {
            var data = _inverterRepository.ReadFourthBatchData();
            SetGauge(nameof(data.AccumulatedBuyPower), data.AccumulatedBuyPower);
            SetGauge(nameof(data.AccumulatedChargerPower), data.AccumulatedChargerPower);
            SetGauge(nameof(data.AccumulatedDischargerPower), data.AccumulatedDischargerPower);
            SetGauge(nameof(data.AccumulatedGrid_chargerPower), data.AccumulatedGrid_chargerPower);
            SetGauge(nameof(data.AccumulatedLoadPower), data.AccumulatedLoadPower);
            SetGauge(nameof(data.AccumulatedPV_sellPower), data.AccumulatedPV_sellPower);
            SetGauge(nameof(data.AccumulatedSelf_usePower), data.AccumulatedSelf_usePower);
            SetGauge(nameof(data.AccumulatedSellPower), data.AccumulatedSellPower);
            SetGauge(nameof(data.BattCurrent), data.BattCurrent);
            SetGauge(nameof(data.DCRelayState), data.DCRelayState);
            SetGauge(nameof(data.EarthRelayState), data.EarthRelayState);
            SetGauge(nameof(data.ErrorMessage1), data.ErrorMessage1);
            SetGauge(nameof(data.ErrorMessage2), data.ErrorMessage2);
            SetGauge(nameof(data.ErrorMessage3), data.ErrorMessage3);
            SetGauge(nameof(data.WarningMessage1), data.WarningMessage1);
            SetGauge(nameof(data.WarningMessage2), data.WarningMessage2);
        }

        private void SetGauge(string metricName, double metricValue)
        {
            //Metrics.CreateGauge(metricName, "", new GaugeConfiguration
            //{
            //    SuppressInitialValue = true             
            //}).Set(metricValue);
        }

    }
}
