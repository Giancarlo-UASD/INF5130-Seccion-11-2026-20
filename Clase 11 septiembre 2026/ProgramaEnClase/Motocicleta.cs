public class Motocicleta : Vehiculo
{
    // Atributos de la clase
    private int cilindrada;
    private string tipo;
    private string color;
    private bool tieneMaletero;

    // Constructor
    public Motocicleta(int idVehiculo, string marca, string modelo, int anio, double precio,
    int cilindrada, string tipo, string color, bool tieneMaletero) : base(idVehiculo, marca, modelo, anio, precio)
    {
        this.cilindrada = cilindrada;
        this.tipo = tipo;
        this.color = color;
        this.tieneMaletero = tieneMaletero;
    }

    // Métodos de la case
    public void Acelerar()
    {
        Console.WriteLine("La motocicleta ha acelerado.");
    }

    public void Frenar()
    {
        Console.WriteLine("La motocicleta ha frenado.");
    }
    
    public new double CalcularCostoSeguro(){
        return precio*0.1;
    }

    public new void RealizarMantenimiento(){
        Console.WriteLine("Se ha realizado el mantenimiento de la motocicleta.");
    }
}