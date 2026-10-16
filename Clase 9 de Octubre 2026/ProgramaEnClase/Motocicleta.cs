public class Motocicleta : Vehiculo{
    public int Cilindrada { get; set; }
    public string TipoMotocicleta { get; set; }
    public int CapacidadCasco { get; set; }
    public bool TieneMaletero { get; set; }
    public bool RequiereLicenciaEspecial { get; set; }

    public override decimal CalcularTarifa(int dias){
        // Regla: Tarifa polimórfica según reglas de la motocicleta
        return PrecioDiario * dias * 0.9m; // Descuento base para motos
    }

    public bool ValidarLicencia(string tipoLicencia){
        if (RequiereLicenciaEspecial)
            return tipoLicencia == "A2" || tipoLicencia == "MotoPro";
        return true;
    }
}