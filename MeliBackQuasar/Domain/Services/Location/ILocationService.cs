namespace Domain.Services.Location;

public interface ILocationService
{
    Position GetLocation(List<Satellite> satellites);
}

