using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SolarMonitoringSystem.Services.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace SolarMonitoringSystem.Tasks
{
    public class GatherSolarDataService : IHostedService
    {
        private readonly ILogger _logger;
        private readonly IInverterGaugeService _inverterGaugeService;

        public GatherSolarDataService(
            ILogger<GatherSolarDataService> logger,
            IInverterGaugeService inverterGaugeService)
        {
            _inverterGaugeService = inverterGaugeService;
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("TIMED BACKGROUND SERVICE IS STARTING.");
            return GatherData();
        }

        private async Task GatherData()
        {
            _logger.LogInformation("SECOND INVERTER DATA FEATCHING IS STARTING.");
            _inverterGaugeService.ProcessSecondBatchData();
            await Task.Delay(20000);

            _logger.LogInformation("THIRD INVERTER DATA FEATCHING IS STARTING.");
            _inverterGaugeService.ProcessThirdBatchData();

            await Task.Delay(20000);
            _logger.LogInformation("FOURTH INVERTER DATA FEATCHING IS STARTING.");
            _inverterGaugeService.ProcessFourthBatchData();

            await Task.Delay(20000);
            await GatherData();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("TIMED BACKGROUND SERVICE IS STOPPING.");
            return Task.CompletedTask;
        }
    }
}
