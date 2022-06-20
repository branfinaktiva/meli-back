using Domain.Helpers;

namespace Domain.Services.Location;

public class LocationService : ILocationService
{
    public Position Kenobi = new()
    {
        X = -500,
        Y = -200
    };

    public Position Skywalker = new()
    {
        X = 100,
        Y = -100
    };

    public Position Sato = new()
    {
        X = 500,
        Y = 100
    };


    public LocationService()
    {
    }

    public Position GetLocation(List<Satellite> satellites)
    {
        Kenobi.R = satellites.First(p => p.Name.ToLower() == nameof(Kenobi).ToLower()).Distance;
        Skywalker.R = satellites.First(p => p.Name.ToLower() == nameof(Skywalker).ToLower()).Distance;
        Sato.R = satellites.First(p => p.Name.ToLower() == nameof(Sato).ToLower()).Distance;

        var a = Math.Pow(Kenobi.X, 2) + Math.Pow(Kenobi.Y, 2) - Math.Pow(Kenobi.R, 2);
        var b = Math.Pow(Skywalker.X, 2) + Math.Pow(Skywalker.Y, 2) - Math.Pow(Skywalker.R, 2);
        var c = Math.Pow(Sato.X, 2) + Math.Pow(Sato.Y, 2) - Math.Pow(Sato.R, 2);

        var x32 = Sato.X - Skywalker.X;
        var x13 = Kenobi.X - Sato.X;
        var x21 = Skywalker.X - Kenobi.X;

        var y32 = Sato.Y - Skywalker.Y;
        var y13 = Kenobi.Y - Sato.Y;
        var y21 = Skywalker.Y - Kenobi.Y;

        var x = (a * y32 + b * y13 + c * y21) / (2 * (Kenobi.X * y32 + Skywalker.X * y13 + Sato.X * y21));
        var y = (a * x32 + b * x13 + c * x21) / (2 * (Kenobi.Y * x32 + Skywalker.Y * x13 + Sato.Y * x21));

        var position = new Position
        {
            X = x,
            Y = y
        };

        return position;
    }
}

