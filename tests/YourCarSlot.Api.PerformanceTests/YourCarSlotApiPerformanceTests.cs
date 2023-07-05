using NBomber.Contracts;
using NBomber.CSharp;
using NBomber.Plugins.Http.CSharp;
using Shouldly;
using Xunit.Abstractions;

namespace YourCarSlot.Api.PerformanceTests
{
    public class YourCarSlotApiPerformanceTests
    {
        private ITestOutputHelper _outputHelper;

        public YourCarSlotApiPerformanceTests(ITestOutputHelper outputHelper)
        {
            this._outputHelper = outputHelper;
        }

        [Fact]
        public void GetReservationRequestShouldHandleAtLeast2000RequestsPerSecond()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            const string url = "http://localhost:5204/api/ReservationRequest/34a130d2-502f-4cf1-a376-63edeb092137";

            const int durationSeconds = 5;
            const int numberOfRequest = 100;

            var getReservationRequestStep = Step.Create("Get all reservation requests", clientFactory: HttpClientFactory.Create(httpClient:client), execute: async context =>
            {
                    var request = Http.CreateRequest("GET", url);
                    var response = await Http.Send(request, context);
                    return response;

            });

            var scenario = ScenarioBuilder.CreateScenario("Reservation Request API fetch", getReservationRequestStep)
                .WithWarmUpDuration(TimeSpan.FromSeconds(durationSeconds))
                .WithLoadSimulations(Simulation.KeepConstant(numberOfRequest, TimeSpan.FromSeconds(durationSeconds)));

            var stats = NBomberRunner
                .RegisterScenarios(scenario)
                .Run();

            _outputHelper.WriteLine($"OK: {stats.OkCount}, FAILED: {stats.FailCount}");
            
            stats.OkCount.ShouldBeGreaterThanOrEqualTo(durationSeconds * numberOfRequest);
        }

        [Fact]
        public void GetParkingSlotShouldHandleAtLeast2000RequestsPerSecond()
        {
            const int durationSeconds = 5;
            const int numberOfRequest = 100;
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            const string url = "https://localhost:7276/api/ParkingSlot";

            var getReservationRequestStep = Step.Create("Get all parking slots", clientFactory: HttpClientFactory.Create(httpClient:client), execute: async context =>
            {
                    var request = Http.CreateRequest("GET", url);
                    var response = await Http.Send(request, context);
                    return response;

            });

            var scenario = ScenarioBuilder.CreateScenario("All Parking slot API fetch", getReservationRequestStep)
                .WithWarmUpDuration(TimeSpan.FromSeconds(durationSeconds))
                .WithLoadSimulations(Simulation.KeepConstant(numberOfRequest, TimeSpan.FromSeconds(durationSeconds)));

            var stats = NBomberRunner
                .RegisterScenarios(scenario)
                .Run();

            _outputHelper.WriteLine($"OK: {stats.OkCount}, FAILED: {stats.FailCount}");

            stats.OkCount.ShouldBeGreaterThanOrEqualTo(durationSeconds * numberOfRequest);
        }
    }
}