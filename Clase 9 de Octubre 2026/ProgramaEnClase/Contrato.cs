public class Contrato{
    public int IdContrato { get; set; }
    public DateTime FechaFirma { get; set; }
    public DateTime FechaDevolucionPrevista { get; set; }
    public DateTime? FechaDevolucionReal { get; set; }
    public decimal MontoTotal { get; set; }
    public int KilometrajeInicial { get; set; }
    
    public Reserva Reserva { get; set; }
    private readonly HashSet<string> pagosRegistrados = new HashSet<string>();

    public void GenerarContrato(){
        // Regla: Solo se puede generar a partir de una reserva confirmada[cite: 1]
        if (Reserva == null || Reserva.Estado != EstadoReserva.Confirmada){
            throw new InvalidOperationException("El contrato solo se puede generar a partir de una reserva confirmada.");
        }

        FechaFirma = DateTime.Now;
        FechaDevolucionPrevista = Reserva.FechaFin;
        MontoTotal = Reserva.Vehiculo.CalcularTarifa(Reserva.CalcularDuracion());
    }

    public void RegistrarPago(string idTransaccionUnica, decimal monto){
        // Regla: El monto debe ser positivo[cite: 1]
        if (monto <= 0)
            throw new ArgumentException("El monto del pago debe ser positivo.");

        // Regla: Evitar registrar dos veces el mismo pago confirmado[cite: 1]
        if (pagosRegistrados.Contains(idTransaccionUnica))
            throw new InvalidOperationException("Este pago ya ha sido registrado anteriormente en el sistema.");

        pagosRegistrados.Add(idTransaccionUnica);
    }

    public void RegistrarDevolucion(int kilometrajeFinal, int kilometrajeInicial){
        // Regla: El kilometraje final no puede ser inferior al inicial[cite: 1]
        if (kilometrajeFinal < kilometrajeInicial)
            throw new ArgumentException("El kilometraje final no puede ser inferior al kilometraje inicial.");

        FechaDevolucionReal = DateTime.Now;
        Reserva.Vehiculo.CambiarEstado(EstadoVehiculo.Disponible);
    }
}