public class Motocicleta : Vehiculo{
    public int Cilindrada { get; private set; }
    public string TipoMotocicleta { get; private set; }
    public int CapacidadCasco { get; private set; }
    public bool TieneMaletero { get; private set; }
    public bool RequiereLicenciaEspecial { get; private set; }

    public Motocicleta(int id, string marca, string modelo, int anio, decimal precioDiario, EstadoVehiculo estado, 
    int cilindrada, string tipoMotocicleta, int capacidadCasco, bool tieneMaletero, bool requiereLicenciaEspecial) 
    : base(id, marca, modelo, anio, precioDiario, estado){
        Cilindrada = cilindrada;
        TipoMotocicleta = tipoMotocicleta;
        CapacidadCasco = capacidadCasco;
        TieneMaletero = tieneMaletero;
        RequiereLicenciaEspecial = requiereLicenciaEspecial;
    }

    public override decimal CalcularTarifa(int dias){
        return PrecioDiario * dias * 0.9m; // Descuento base para motos
    }

    public bool ValidarLicencia(string tipoLicencia){
        if (RequiereLicenciaEspecial)
            return tipoLicencia == "MotoBasic" || tipoLicencia == "MotoPro";
        return true;
    }

    public decimal CalcularCargoProteccion(){
        return 6.0m;
    }

    public override string ToString(){
        string maletero = TieneMaletero ? "Sí" : "No";
        string licenciaEspecial = RequiereLicenciaEspecial ? "Sí" : "No";
    
        return base.ToString() + $" | Cilindrada: {Cilindrada}cc | Tipo: {TipoMotocicleta} | " +
            $"\nCascos: {CapacidadCasco} | Maletero: {maletero} | Licencia Especial: {licenciaEspecial}";
    }
}