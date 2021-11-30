using MaPiReservation.Data;
using MaPiReservation.Data.Entities;

public class ClienteApi : IApi
{
    private readonly ILogger<ClienteApi> _logger;

    public ClienteApi(ILogger<ClienteApi> logger)
    {
        _logger = logger;
    }

    public void Register(WebApplication app)
    {
       app.MapGet("/api/Reservation/{id}", GetReservation);
       app.MapPost("/api/Reservation", GetAllRerservations);
    }

    public async Task<IResult> GetAllRerservations( IReserva repository)
    {
        var result = await repository.GetReservasAsync();
        if(result is null) return Results.NotFound();
        return Results.Ok(result);
    }

    public async Task<IResult> GetReservation(int id, IReserva repository)
    {
        var result = await repository.GetReservaAsync(id);
        if(result is null) return Results.NotFound();
        return Results.Ok(result);
    }
}