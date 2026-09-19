public class Motocicleta : Vehiculo
{
    // Atributos de la clase
    private int cilindrada;
    private string tipo;
    private string color;
    private bool tieneMaletero;

    // Constructor
    public Motocicleta(int idVehiculo, string marca, string modelo, int anio, double precio, int kilometraje,
    int cilindrada, string tipo, string color, bool tieneMaletero) : base(idVehiculo, marca, modelo, anio, precio, kilometraje)
    {
        this.cilindrada = cilindrada;
        this.tipo = tipo;
        this.color = color;
        this.tieneMaletero = tieneMaletero;
    }

    // Métodos de la case
    public void Acelerar()
    {
        Console.WriteLine();
        Console.WriteLine("La motocicleta ha acelerado.");
        Console.WriteLine();
    }

    public void Frenar()
    {
        Console.WriteLine();
        Console.WriteLine("La motocicleta ha frenado.");
        Console.WriteLine();
    }
    
    public new double CalcularCostoSeguro(){
        return precio*0.1;
    }

    public new void RealizarMantenimiento(){
        Console.WriteLine();
        Console.WriteLine("Se ha realizado el mantenimiento de la motocicleta.");
        Console.WriteLine();
    }

    public new void MostrarDetalles()
    {
        Console.WriteLine();
        Console.WriteLine("Los detalles de la motocicleta son:");
        Console.WriteLine("ID de la motocicleta: " + idVehiculo);
        Console.WriteLine("Marca de la motocicleta: " + marca);
        Console.WriteLine("Modelo de la motocicleta: " + modelo);
        Console.WriteLine("Año de la motocicleta: " + anio);
        Console.WriteLine("Precio de la motocicleta: " + precio);
        Console.WriteLine("Kilometraje de la motocicleta: " + kilometraje);
        Console.WriteLine("Cilindrada de la motocicleta: " + cilindrada);
        Console.WriteLine("Tipo de la motocicleta: " + tipo);
        Console.WriteLine("Color de la motocicleta: " + color);
        Console.WriteLine("Capacidad de Mateletero de la motocicleta: " + tieneMaletero);
        Console.WriteLine(); 
    }
}