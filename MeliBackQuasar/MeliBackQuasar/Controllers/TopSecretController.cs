using Microsoft.AspNetCore.Mvc;

namespace MeliBackQuasar.Controllers;

[ApiController]
[Route("[controller]")]
public class TopSecretController : ControllerBase
{
    private readonly ILocationService locationService;

    public TopSecretController(ILocationService locationService)
    {
        this.locationService = locationService;
    }

    [HttpPost]
    public IActionResult Post(SatelliteRequest satelliteRequest)
    {
        try
        {
            var response = locationService.ReadMessage(satelliteRequest);
            return Ok(response);
        }
        catch (GeneralException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex);
        }
    }

    [HttpPost("/topsecret_split/{name}")]
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

