using Infraestructure.Models;

namespace Infraestructure.Repositories;

public interface ILocationRepository
{
    bool Create(LocationModel city);
    List<LocationModel> GetLocation();
    bool CreateOrUpdate(LocationModel location);
}

