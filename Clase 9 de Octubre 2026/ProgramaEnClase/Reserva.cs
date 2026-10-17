public class Reserva{
    public int IdReserva { get; private set; }
    public DateTime FechaInicio { get; private set; }
    public DateTime FechaFin { get; private set; }
    public DateTime FechaCreacion { get; private set; }
    public EstadoReserva Estado { get; private set; }
    public decimal PrecioEstimado { get; private set; }
    
    public Cliente Cliente { get; private set; }
    public Vehiculo Vehiculo { get; private set; }

    public Reserva(int idReserva, DateTime fechaInicio, DateTime fechaFin, DateTime fechaCreacion, EstadoReserva estado,
    Cliente cliente, Vehiculo vehiculo){
        IdReserva = idReserva;
        FechaInicio = fechaInicio;
        FechaFin = fechaFin;
        FechaCreacion = fechaCreacion;
        Estado = estado;
        Cliente = cliente;
        Vehiculo = vehiculo;
        PrecioEstimado = CalcularPrecioEstimado();
    }

    public int CalcularDuracion() => (FechaFin - FechaInicio).Days;

    public decimal CalcularPrecioEstimado() => Vehiculo.CalcularTarifa(CalcularDuracion());

    public bool Confirmar(List<Reserva> reservas){
        // Regla: La fecha de inicio debe ser anterior a la fecha de fin
        if (FechaInicio >= FechaFin)
            throw new ArgumentException("La fecha de inicio debe ser anterior a la fecha de fin.");

        // Regla: El cliente debe tener licencia vigente
        if (!Cliente.PuedeAlquilador())
            throw new InvalidOperationException("El cliente no cuenta con una licencia vigente o válida.");

        // Regla: Vehículo no puede estar alquilado, en mantenimiento o fuera de servicio
        if (!Vehiculo.EstaDisponible(FechaInicio, FechaFin, reservas))
            throw new InvalidOperationException("El vehículo no está disponible para el período solicitado.");

        Estado = EstadoReserva.Confirmada;
        return true;
    }

    public void Cancelar(){
        Estado = EstadoReserva.Cancelada;
        if (Vehiculo.Estado == EstadoVehiculo.Alquilado){
            Vehiculo.CambiarEstado(EstadoVehiculo.Disponible);
        }
    }

    public override string ToString(){
        return $"Reserva #{IdReserva} | Cliente: {Cliente.Nombre} | Vehículo ID: {Vehiculo.Id} | " +
            $"Del {FechaInicio.ToShortDateString()} al {FechaFin.ToShortDateString()} | " +
            $"Estado: {Estado} | Precio Estimado: ${PrecioEstimado}";
    }
}