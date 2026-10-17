public class Contrato{
    public int IdContrato { get; private set; }
    public DateTime FechaFirma { get; private set; }
    public DateTime FechaDevolucionPrevista { get; private set; }
    public DateTime? FechaDevolucionReal { get; private set; }
    public decimal MontoTotal { get; private set; }
    public int KilometrajeInicial { get; private set; }
    public int KilometrajeFinal { get; private set; }
    public bool EsActivo { get; private set; }
    
    public Reserva Reserva { get; private set; }
    private readonly HashSet<string> pagosRegistrados = new HashSet<string>();

    public Contrato(int idContrato, DateTime fechaFirma, DateTime fechaDevolucionPrevista, DateTime? fechaDevolucionReal,
    decimal montoTotal, int kilometrajeInicial, Reserva reserva){
        IdContrato = idContrato;
        FechaFirma = fechaFirma;
        FechaDevolucionPrevista = fechaDevolucionPrevista;
        FechaDevolucionReal = fechaDevolucionReal;
        MontoTotal = montoTotal;
        KilometrajeInicial = kilometrajeInicial;
        Reserva = reserva;
        EsActivo = true;
        KilometrajeFinal = -1;
    }

    public decimal CalcularCargoPorRetraso(){
        if (FechaDevolucionPrevista < (DateTime)FechaDevolucionReal){
            return Reserva.Vehiculo.CalcularTarifa(((DateTime)FechaDevolucionReal - FechaDevolucionPrevista).Days); 
        }
        return 0;
    }

    public void CalcularMontoFinal(){
        MontoTotal = Reserva.Vehiculo.CalcularTarifa(Reserva.CalcularDuracion()) + CalcularCargoPorRetraso();
    }

    public void RegistrarPago(string idTransaccionUnica, decimal monto){
        if (monto <= 0)
            throw new ArgumentException("El monto del pago debe ser positivo.");

        if (pagosRegistrados.Contains(idTransaccionUnica))
            throw new InvalidOperationException("Este pago ya ha sido registrado anteriormente en el sistema.");

        pagosRegistrados.Add(idTransaccionUnica);
    }

    public void RegistrarDevolucion(int kilometrajeFinal){
        // Regla: El kilometraje final no puede ser inferior al inicial
        if (kilometrajeFinal < KilometrajeInicial)
            throw new ArgumentException("El kilometraje final no puede ser inferior al kilometraje inicial.");

        FechaDevolucionReal = DateTime.Now;
        CalcularMontoFinal();
        EsActivo = false;
        KilometrajeFinal = kilometrajeFinal;
    }

    public override string ToString(){
        string devRealStr = EsActivo ?  "Pendiente" : FechaDevolucionReal.Value.ToShortDateString();

        return $"Contrato #{IdContrato} | Reserva #{Reserva.IdReserva} | " +
            $"Cliente: {Reserva.Cliente.Nombre} | Vehículo: {Reserva.Vehiculo.Marca} {Reserva.Vehiculo.Modelo} | " +
            $"Firma: {FechaFirma.ToShortDateString()} | Dev. Prevista: {FechaDevolucionPrevista.ToShortDateString()} | " +
            $"Dev. Real: {devRealStr} | Km Inicial: {KilometrajeInicial} km | Monto: ${MontoTotal}";
    }
}