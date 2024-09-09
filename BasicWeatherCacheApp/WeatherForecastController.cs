using System.Net.Http.Headers;
using StackExchange.Redis;

namespace BasicWeatherCacheApp;

public class WeatherForecastController
{
    private readonly HttpClient _client;
    private readonly IDatabase _redis;

    public WeatherForecastController(HttpClient client, IConnectionMultiplexer muxer)
    {
        _client = client;
        _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("weatherCachingApp","1.0") );
        _redis = muxer.GetDatabase();
    }
}