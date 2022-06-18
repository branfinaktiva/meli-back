namespace Domain.Services.Location;

public class LocationService : ILocationService
{
    public LocationService()
    {
    }

    public Position GetLocation(List<Satellite> satellites)
    {
        return new Position
        {
            X = 1,
            Y = 1
        };
    }
}

