using Microsoft.EntityFrameworkCore;
using MaPiReservation.Data.Entities;

namespace MaPiReservation.Data;

public class ReservaRepository : IReserva
{
    private readonly AppDbContext _context;

    public ReservaRepository(AppDbContext context)
    {
        _context = context;
    }

    public int add<T>(T entity) where T : class 
    {
        _context.Add(entity);
        return _context.SaveChanges();
    }

    public void delete<T>(T entity) where T : class
    {
        throw new NotImplementedException();
    }

    public async Task<Reserva?> GetReservaAsync(int id)
    {
        var result = await _context.Reserva.Where(r => r.Id == id).FirstOrDefaultAsync();
        return result;
    }

    public async Task<IEnumerable<Reserva>> GetReservasAsync(int pageIndex = 1, int pageSize = 25)
    {
        return await _context.Reserva.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
    }

    public async Task<bool> saveChangesAsync() => await _context.SaveChangesAsync() > 0;

    public bool update(Reserva existingReservation)
    {
        throw new NotImplementedException();
    }
}