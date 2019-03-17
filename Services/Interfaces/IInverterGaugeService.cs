
namespace SolarMonitoringSystem.Services.Interfaces
{
    public interface IInverterGaugeService 
    {
        void ProcessBaseBatchData();

        void ProcessFirstBatchData();

        void ProcessSecondBatchData();

        void ProcessThirdBatchData();

        void ProcessFourthBatchData();
    }
}
