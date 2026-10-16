public class Automovil : Vehiculo{
    public int CantidadPuertas { get; set; }
    public int CapacidadPasajeros { get; set; }
    public string TipoCombustible { get; set; }
    public bool TransmisionAutomatica { get; set; }
    public decimal CapacidadMaletero { get; set; }

    public override decimal CalcularTarifa(int dias){
        // Regla: Tarifa polimórfica según reglas del automóvil
        return PrecioDiario * dias * (TransmisionAutomatica ? 1.15m : 1.0m);
    }
}