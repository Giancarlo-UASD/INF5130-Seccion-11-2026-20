public class Automovil : Vehiculo{
    public int CantidadPuertas { get; private set; }
    public int CapacidadPasajeros { get; private set; }
    public string TipoCombustible { get; private set; }
    public bool TransmisionAutomatica { get; private set; }
    public decimal CapacidadMaletero { get; private set; }

    public Automovil(int id, string marca, string modelo, int anio, decimal precioDiario, EstadoVehiculo estado, 
    int cantidadPuertas, int capacidadPasajeros, string tipoCombustible, bool transmisionAutomatica, 
    decimal capacidadMaletero) : base(id, marca, modelo, anio, precioDiario, estado){
        CantidadPuertas = cantidadPuertas;
        CapacidadPasajeros = capacidadPasajeros;
        TipoCombustible = tipoCombustible;
        TransmisionAutomatica = transmisionAutomatica;
        CapacidadMaletero = capacidadMaletero;
    }

    public override decimal CalcularTarifa(int dias){
        return PrecioDiario * dias * (TransmisionAutomatica ? 1.15m : 1.0m);
    }
    public decimal CalcularCargoAdicional(){
        return 5.0m;
    }
    public bool ValidarCapacidad(int pasajeros){
        return (pasajeros <= CapacidadPasajeros);
    }
    public override string ToString(){
        string transmision = TransmisionAutomatica ? "Automática" : "Manual";
        return base.ToString() + $" | Puertas: {CantidadPuertas} | Pasajeros: {CapacidadPasajeros} | " +
            $"\nCombustible: {TipoCombustible} | Transmisión: {transmision} | Maletero: {CapacidadMaletero}L";
    }
}