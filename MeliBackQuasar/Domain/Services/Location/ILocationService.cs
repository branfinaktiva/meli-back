namespace Domain.Services.Location;

public interface ILocationService
{
    PositionSatelliteResponse ReadMessage(SatelliteRequest satelliteRequest);
    Position GetLocation(List<Satellite> satellites);
    PositionSatelliteResponse GetLocation();
    bool CreateLocation(string name, Satellite satellite);
}

