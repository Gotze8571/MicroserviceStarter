using static SampleService.Services.ApiClient;

namespace SampleService.Services
{
    public interface IApiClient
    {
        CoinsInfo ConnectToApi(string currency);
    }
}