namespace GitHubActionsDotNet.Api.Models;
/// <summary>
/// Represents a weather forecast with date, temperature, and summary.
/// </summary>
public record WeatherForecast
{
    public DateOnly Date { get; init; }

    public int TemperatureC { get; init; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; init; }
}
