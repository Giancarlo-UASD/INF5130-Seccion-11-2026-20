public class Cliente{
    public int IdCliente { get; private set; }
    public string Nombre { get; private set; }
    public string Documento { get; private set; }
    public string NumeroLicencia { get; private set; }
    public DateTime FechaVencimientoLicencia { get; private set; }
    public string Telefono { get; private set; }


    public Cliente(int idCliente, string nombre, string documento, string numeroLicencia,
    DateTime fechaVencimientoLicencia, string telefono){
        IdCliente = idCliente;
        Nombre = nombre;
        Documento = documento;
        NumeroLicencia = numeroLicencia;
        FechaVencimientoLicencia = fechaVencimientoLicencia;
        Telefono = telefono;
    }


    public bool ValidarLicencia(){
        return FechaVencimientoLicencia > DateTime.Now;
    }

    public bool CumpleEdadMinima(){
        return true;
    } 

    public void ActualizarDatos(){
        return;
    }

    public bool PuedeAlquilador(){
        return ValidarLicencia() && CumpleEdadMinima();
    }

    public override string ToString(){
        return $"[ID: {IdCliente}] {Nombre} | Doc: {Documento} | Licencia: {NumeroLicencia} (Vence: {FechaVencimientoLicencia.ToShortDateString()}) | Tel: {Telefono}";
    }
}