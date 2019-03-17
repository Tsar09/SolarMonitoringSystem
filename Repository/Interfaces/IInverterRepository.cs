using SolarMonitoringSystem.Data;

namespace SolarMonitoringSystem.Repository.Interfaces
{
    public interface IInverterRepository
    {
        BaseInverterData ReadBaseBatchData();

        FirstBatchInverterData ReadFirstBatchData();

        SecondBatchInverterData ReadSecondBatchData();

        ThirdBatchInverterData ReadThirdBatchData();

        FourthBatchInverterData ReadFourthBatchData();
    }
}
