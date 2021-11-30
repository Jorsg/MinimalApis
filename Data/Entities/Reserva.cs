namespace MaPiReservation.Data.Entities;

    public class Reserva
    {
        public int Id { get; set; } = 0;
        public int IdHotel { get; set; } = 0;
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public int CantidadPersonas { get; set; } = 0;
        public string? Ciudad { get; set; }
        public int IdPasajero { get; set; } = 0;
    }