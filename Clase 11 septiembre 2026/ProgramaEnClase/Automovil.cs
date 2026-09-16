public class Automovil : Vehiculo
{
    // Atributos de la clase
    private int cantidadPuertas;
    private string tipoCombustible;
    private double cilindrada;
    private double capacidadMaletero;

    // Constructor
    public Automovil(int idVehiculo, string marca, string modelo, int anio, double precio,
    int cantidadPuertas, string tipoCombustible, double cilindrada, double capacidadMaletero) : base(idVehiculo, marca, modelo, anio, precio)
    {
        this.cantidadPuertas = cantidadPuertas;
        this.tipoCombustible = tipoCombustible;
        this.cilindrada = cilindrada;
        this.capacidadMaletero = capacidadMaletero;
    }

    // Métodos de la case
    public void Encender()
    {
        Console.WriteLine("El auto se ha encendido.");
    }

    public void Apagar()
    {
        Console.WriteLine("El auto se ha apagado.");
    }
    
    public new double CalcularCostoSeguro(){
        return precio*0.3;
    }

    public new void RealizarMantenimiento(){
        Console.WriteLine("Se ha realizado el mantenimiento del automovil.");
    }
}