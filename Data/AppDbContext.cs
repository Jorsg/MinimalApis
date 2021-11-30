using Microsoft.EntityFrameworkCore;
using MaPiReservation.Data.Entities;

namespace MaPiReservation.Data;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public AppDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Reserva> Reserva => Set<Reserva>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ConnetionSQL"));
    }
}