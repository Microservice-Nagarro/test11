using BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Models.Settings;
using BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Services;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;

namespace BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        HealthCheck
{
    public class ExampleServiceHealthCheck(IExampleService exampleService, ILogger<ExampleServiceHealthCheck> logger, IOptions<HealthCheckSettings> settings) : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            for (byte i = 0; i < settings.Value.AttemptsCount; i++)
            {
                var result = await exampleService.GetSomething();
                if (result.IsSuccessStatusCode)
                {
                    return HealthCheckResult.Healthy("Successfully connected to the service");
                }

                logger.LogWarning("Failure status code returned: {StatusCode}", (int)result.StatusCode);
            }

            return HealthCheckResult.Unhealthy("Could not connect to the service");
        }
    }
}

