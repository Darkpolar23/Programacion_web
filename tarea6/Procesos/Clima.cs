public record ClimaResponse
{
    public Main? Main { get; init; }
    public string? Name { get; init; }
}

public record Main
{
    public double Temp { get; init; }
    public double Feels_Like { get; init; }
    public int Humidity { get; init; }
}


