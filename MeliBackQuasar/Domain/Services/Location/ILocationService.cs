namespace Domain.Services.Location;

public interface ILocationService
{
    PositionSatelliteResponse ReadMessage(SatelliteRequest satelliteRequest);
    Position GetLocation(List<Satellite> satellites);
}

