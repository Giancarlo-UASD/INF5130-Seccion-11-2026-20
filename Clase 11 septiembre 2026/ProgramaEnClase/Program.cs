using System;

Console.WriteLine("¿Qué tipo de Objeto desea crear?");
Console.WriteLine("1. Vehículo");
Console.WriteLine("2. Automovil");
Console.WriteLine("3. Motocicleta");
int opcion = int.Parse(Console.ReadLine());

Console.Write("Introduzca el id del Vehículo: ");
int idVehiculo = int.Parse(Console.ReadLine());

Console.Write("Introduzca la marca del Vehículo: ");
string marca = Console.ReadLine();

Console.Write("Introduzca el modelo del Vehículo: ");
string modelo = Console.ReadLine();

Console.Write("Introduzca el año del Vehículo: ");
int anio = int.Parse(Console.ReadLine());

Console.Write("Introduzca el precio del Vehículo: ");
double precio = double.Parse(Console.ReadLine());

Console.Write("Introduzca el kilometraje del Vehículo: ");
int kilometraje = int.Parse(Console.ReadLine());

if(opcion == 1){
    Vehiculo miVehiculo = new Vehiculo(idVehiculo, marca, modelo, anio, precio, kilometraje);
    Console.WriteLine("El costo del seguro es: " + miVehiculo.CalcularCostoSeguro());
    Console.WriteLine("Introduzca un nuevo kilometraje: "); 
    kilometraje = int.Parse(Console.ReadLine());
    miVehiculo.ActualizarKilometraje(kilometraje);
    miVehiculo.RealizarMantenimiento();
    miVehiculo.MostrarDetalles();
}else if(opcion == 2){
    Console.Write("Ingrese la cantidad de puertas: ");
    int cantidadPuertas = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el tipo de combustible: ");
    string tipoCombustible = Console.ReadLine();

    Console.Write("Ingrese la cilindrada: ");
    double cilindrada = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la capacidad del maletero: ");
    double capacidadMaletero = double.Parse(Console.ReadLine());

    Automovil miAutomovil = new Automovil(idVehiculo, marca, modelo, anio, precio, kilometraje,
    cantidadPuertas, tipoCombustible, cilindrada, capacidadMaletero);
    Console.WriteLine("El costo del seguro es: " + miAutomovil.CalcularCostoSeguro());
    Console.WriteLine("Introduzca un nuevo kilometraje: "); 
    kilometraje = int.Parse(Console.ReadLine());
    miAutomovil.ActualizarKilometraje(kilometraje);
    miAutomovil.RealizarMantenimiento();
    miAutomovil.Encender();
    miAutomovil.Apagar();
    miAutomovil.MostrarDetalles();
}else if(opcion == 3){
    Console.Write("Ingrese la cilindrada: ");
    int cilindrada = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el tipo: ");
    string tipo = Console.ReadLine();

    Console.Write("Ingrese el color: ");
    string color = Console.ReadLine();

    Console.Write("¿Tiene maletero? (true/false): ");
    bool tieneMaletero = bool.Parse(Console.ReadLine());

    Motocicleta miMotocicleta = new Motocicleta(idVehiculo, marca, modelo, anio, precio, kilometraje,
    cilindrada, tipo, color, tieneMaletero);
    Console.WriteLine();
    Console.WriteLine("El costo del seguro es: " + miMotocicleta.CalcularCostoSeguro());
    Console.WriteLine();
    Console.WriteLine("Introduzca un nuevo kilometraje: "); 
    kilometraje = int.Parse(Console.ReadLine());
    miMotocicleta.ActualizarKilometraje(kilometraje);
    miMotocicleta.RealizarMantenimiento();
    miMotocicleta.Acelerar();
    miMotocicleta.Frenar();
    miMotocicleta.MostrarDetalles();
}else{
    Console.WriteLine("Entrada Incorrecta....");
    System.Environment.Exit(1);
}
