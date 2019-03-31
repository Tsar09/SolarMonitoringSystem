
using System.Threading.Tasks;

namespace SolarMonitoringSystem.Services.Interfaces
{
    public interface IInverterGaugeService 
    {
        void ProcessBaseBatchData();

        void ProcessFirstBatchData();

        Task ProcessSecondBatchData();

        void ProcessThirdBatchData();

        void ProcessFourthBatchData();
    }
}
