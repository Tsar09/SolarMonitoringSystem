using SolarMonitoringSystem.Data;
using System.Threading.Tasks;

namespace SolarMonitoringSystem.Repository.Interfaces
{
    public interface IInverterRepository
    {
        BaseInverterData ReadBaseBatchData();

        FirstBatchInverterData ReadFirstBatchData();

        Task<SecondBatchInverterData> ReadSecondBatchData();

        ThirdBatchInverterData ReadThirdBatchData();

        FourthBatchInverterData ReadFourthBatchData();
    }
}
