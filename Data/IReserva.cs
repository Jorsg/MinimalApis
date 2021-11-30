using MaPiReservation.Data.Entities;

namespace MaPiReservation.Data;

public interface IReserva
{
    Task<Reserva?> GetReservaAsync(int id);
    Task<IEnumerable<Reserva>> GetReservasAsync(int pageIndex = 1, int pageSize = 25);

    int add<T>(T entity) where T : class;
    void delete<T>(T entity) where T : class;
    Task<bool> saveChangesAsync();
    bool update(Reserva existingReservation);
}