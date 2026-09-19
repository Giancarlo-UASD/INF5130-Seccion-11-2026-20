interface IMantenible{
	void RealizarMantenimiento();
}

public class Vehiculo: IMantenible{
    // Atributos de la clase
    protected int idVehiculo;
    protected string marca;
    protected string modelo;
    protected int anio;
    protected double precio;
    protected int kilometraje;

    // Constructor
    public Vehiculo(int idVehiculo, string marca, string modelo, int anio, double precio, int kilometraje)
    {
        this.idVehiculo = idVehiculo;
        this.marca = marca;
        this.modelo = modelo;
        this.anio = anio;
        this.precio = precio;
        this.kilometraje = kilometraje;
    }

    // Métodos de la case
    public void MostrarDetalles()
    {
        Console.WriteLine();
        Console.WriteLine("Los detalles del vehículo son:");
        Console.WriteLine("ID del vehículo: " + idVehiculo);
        Console.WriteLine("Marca del vehículo: " + marca);
        Console.WriteLine("Modelo del vehículo: " + modelo);
        Console.WriteLine("Año del vehículo: " + anio);
        Console.WriteLine("Precio del vehículo: " + precio);
        Console.WriteLine("Kilometraje del vehículo: " + kilometraje);
        Console.WriteLine(); 
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