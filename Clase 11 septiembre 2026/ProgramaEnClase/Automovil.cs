public class Automovil : Vehiculo
{
    // Atributos de la clase
    private int cantidadPuertas;
    private string tipoCombustible;
    private double cilindrada;
    private double capacidadMaletero;

    // Constructor
    public Automovil(int idVehiculo, string marca, string modelo, int anio, double precio, int kilometraje,
    int cantidadPuertas, string tipoCombustible, double cilindrada, double capacidadMaletero) : base(idVehiculo, marca, modelo, anio, precio, kilometraje)
    {
        this.cantidadPuertas = cantidadPuertas;
        this.tipoCombustible = tipoCombustible;
        this.cilindrada = cilindrada;
        this.capacidadMaletero = capacidadMaletero;
    }

    // Métodos de la case
    public void Encender()
    {
        Console.WriteLine();
        Console.WriteLine("El auto se ha encendido.");
        Console.WriteLine();
    }

    public void Apagar()
    {
        Console.WriteLine();
        Console.WriteLine("El auto se ha apagado.");
        Console.WriteLine();
    }
    
    public new double CalcularCostoSeguro(){
        return precio*0.3;
    }

    public new void RealizarMantenimiento(){
        Console.WriteLine();
        Console.WriteLine("Se ha realizado el mantenimiento del automovil.");
        Console.WriteLine();
    }

    public new void MostrarDetalles()
    {
        Console.WriteLine();
        Console.WriteLine("Los detalles del automóvil son:");
        Console.WriteLine("ID del automóvil: " + idVehiculo);
        Console.WriteLine("Marca del automóvil: " + marca);
        Console.WriteLine("Modelo del automóvil: " + modelo);
        Console.WriteLine("Año del automóvil: " + anio);
        Console.WriteLine("Precio del automóvil: " + precio);
        Console.WriteLine("Kilometraje del automóvil: " + kilometraje);
        Console.WriteLine("Cantidad de Puertas del automóvil: " + cantidadPuertas);
        Console.WriteLine("Tipo de Combustible del automóvil: " + tipoCombustible);
        Console.WriteLine("Cilindrada del automóvil: " + cilindrada);
        Console.WriteLine("Capacidad de Mateletero del automóvil: " + capacidadMaletero);
        Console.WriteLine(); 
    }
}