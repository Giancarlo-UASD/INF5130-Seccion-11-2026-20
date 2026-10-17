public abstract class Vehiculo{
    public int Id { get; private set; }
    public string Marca { get; private set; }
    public string Modelo { get; private set; }
    public int Anio { get; private set; }
    public decimal PrecioDiario { get; private set; }
    public EstadoVehiculo Estado { get; private set; }

    public Vehiculo(int id, string marca, string modelo, int anio, decimal precioDiario, EstadoVehiculo estado){
        Id = id;
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
        PrecioDiario = precioDiario;
        Estado = estado;
    }

    public abstract decimal CalcularTarifa(int dias);

    public bool EstaDisponible(DateTime inicio, DateTime fin, List<Reserva> listaReservas){
        if (Estado != EstadoVehiculo.Disponible){
            return false;
        }
        foreach (var reserva in listaReservas){
            if (reserva.Vehiculo.Id == this.Id && 
                (reserva.Estado == EstadoReserva.Pendiente || reserva.Estado == EstadoReserva.Confirmada)){
                bool haySolapamiento = (inicio <= reserva.FechaFin) && (fin >= reserva.FechaInicio);
                if (haySolapamiento){
                    return false; 
                }
            }
        }
        return true; 
    }

    public void CambiarEstado(EstadoVehiculo nuevoEstado){
        Estado = nuevoEstado;
    }

    public override string ToString(){
        return $"ID: {Id} | {Marca} {Modelo} ({Anio}) | Precio Diario: ${PrecioDiario} | Estado: {Estado}";
    }
}