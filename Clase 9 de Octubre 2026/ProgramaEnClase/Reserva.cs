public class Reserva{
    public int IdReserva { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public DateTime FechaCreacion { get; set; }
    public EstadoReserva Estado { get; set; }
    public decimal PrecioEstimado { get; set; }
    
    public Cliente Cliente { get; set; }
    public Vehiculo Vehiculo { get; set; }

    public int CalcularDuracion() => (FechaFin - FechaInicio).Days;

    public bool Confirmar(){
        // Regla: La fecha de inicio debe ser anterior a la fecha de fin[cite: 1]
        if (FechaInicio >= FechaFin)
            throw new ArgumentException("La fecha de inicio debe ser anterior a la fecha de fin.");

        // Regla: El cliente debe tener licencia vigente[cite: 1]
        if (!Cliente.PuedeAlquilador())
            throw new InvalidOperationException("El cliente no cuenta con una licencia vigente o válida.");

        // Regla: Vehículo no puede estar alquilado, en mantenimiento o fuera de servicio[cite: 1]
        if (!Vehiculo.EstaDisponible(FechaInicio, FechaFin))
            throw new InvalidOperationException("El vehículo no está disponible para el período solicitado.");

        Estado = EstadoReserva.Confirmada;
        Vehiculo.CambiarEstado(EstadoVehiculo.Alquilado);
        return true;
    }

    public void Cancelar(){
        Estado = EstadoReserva.Cancelada;
        if (Vehiculo.Estado == EstadoVehiculo.Alquilado){
            Vehiculo.CambiarEstado(EstadoVehiculo.Disponible);
        }
    }
}