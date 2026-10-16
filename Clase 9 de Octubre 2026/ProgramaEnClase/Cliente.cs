public class Cliente{
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Documento { get; set; }
    public string NumeroLicencia { get; set; }
    public DateTime FechaVencimientoLicencia { get; set; }
    public string Telefono { get; set; }

    public bool ValidarLicencia(){
        // Regla: Licencia vigente[cite: 1]
        return FechaVencimientoLicencia > DateTime.Now;
    }

    public bool CumpleEdadMinima() => true; // Lógica de edad

    public bool PuedeAlquilador(){
        return ValidarLicencia() && CumpleEdadMinima();
    }
}