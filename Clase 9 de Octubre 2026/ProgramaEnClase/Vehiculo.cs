public abstract class Vehiculo{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }
    public decimal PrecioDiario { get; set; }
    public EstadoVehiculo Estado { get; set; }

    // Tarifa polimórfica
    public abstract decimal CalcularTarifa(int dias);

    public bool EstaDisponible(DateTime inicio, DateTime fin){
        // Regla: No se puede confirmar si está alquilado, en mantenimiento o fuera de servicio
        return Estado == EstadoVehiculo.Disponible;
    }

    public void CambiarEstado(EstadoVehiculo nuevoEstado){
        Estado = nuevoEstado;
    }

    public string ObtenerDescripcion() => $"{Marca} {Modelo} ({Anio})";
}