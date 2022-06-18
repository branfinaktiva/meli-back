using Domain.Contracts;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeliBackQuasar.Controllers;

[ApiController]
[Route("[controller]")]
public class TopSecretController : ControllerBase
{

    [HttpPost]
    public PositionSatelliteResponse Post(SatelliteRequest satelliteRequest)
    {
        return new PositionSatelliteResponse
        {
            Message = "Esto es un mensaje",
            Position = new Position
            {
                X = 203,
                Y = 2
            }
        };
    }

    [HttpPost("topsecret_split/{name}")]
    public PositionSatelliteResponse TopSecretSplit(string name, Satellite satellite)
    {
        return new PositionSatelliteResponse
        {
            Message = "Esto es un mensaje",
            Position = new Position
            {
                X = 203,
                Y = 2
            }
        };
    }
}

