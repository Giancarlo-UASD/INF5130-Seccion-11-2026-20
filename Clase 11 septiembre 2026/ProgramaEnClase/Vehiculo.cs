interface IMantenible{
	void RealizarMantenimiento();
}

public class Vehiculo: IMantenible{
    // Atributos de la clase
    private int idVehiculo;
    private string marca;
    private string modelo;
    private int anio;
    protected double precio;
    private int kilometraje;

    // Constructor
    public Vehiculo(int idVehiculo, string marca, string modelo, int anio, double precio)
    {
        this.idVehiculo = idVehiculo;
        this.marca = marca;
        this.modelo = modelo;
        this.anio = anio;
        this.precio = precio;
    }

    // Métodos de la case
    public void MostrarDetalles()
    {
        Console.WriteLine($"Los detalles del vehículo son: {idVehiculo} {marca} {modelo}");
        Console.WriteLine($"Además {anio} {precio} {kilometraje}");
    }

    public double CalcularCostoSeguro(){
        return precio*0.2;
    }

    public void ActualizarKilometraje(int km){
        this.kilometraje = km;
    }

    public void RealizarMantenimiento(){
        Console.WriteLine("Se ha realizado el mantenimiento del vehículo.");
    }
}