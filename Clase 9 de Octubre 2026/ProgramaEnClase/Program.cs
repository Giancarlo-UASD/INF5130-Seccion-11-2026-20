List<Reserva> reservas = new List<Reserva>();
List<Contrato> contratos = new List<Contrato>();

// Datos iniciales de prueba para empezar a operar rápido
List<Vehiculo> vehiculos = new List<Vehiculo>{
    // Automóviles (1 al 10)
    new Automovil(1, "Toyota", "Corolla", 2023, 45.0m, EstadoVehiculo.Disponible, 4, 5, "Gasolina", true, 400),
    new Automovil(2, "Honda", "Civic", 2022, 50.0m, EstadoVehiculo.Disponible, 4, 5, "Gasolina", false, 450),
    new Automovil(3, "Hyundai", "Elantra", 2024, 40.0m, EstadoVehiculo.Disponible, 4, 5, "Gasolina", true, 380),
    new Automovil(4, "Kia", "Rio", 2021, 35.0m, EstadoVehiculo.Disponible, 4, 5, "Gasolina", false, 320),
    new Automovil(5, "Nissan", "Sentra", 2023, 42.0m, EstadoVehiculo.Disponible, 4, 5, "Gasolina", true, 405),
    new Automovil(6, "Mazda", "3", 2022, 48.0m, EstadoVehiculo.Disponible, 4, 5, "Gasolina", true, 350),
    new Automovil(7, "Chevrolet", "Cruze", 2020, 38.0m, EstadoVehiculo.Disponible, 4, 5, "Gasolina", false, 390),
    new Automovil(8, "Ford", "Escape", 2023, 65.0m, EstadoVehiculo.Disponible, 5, 5, "Gasolina", true, 600),
    new Automovil(9, "Toyota", "RAV4", 2024, 75.0m, EstadoVehiculo.Disponible, 5, 5, "Híbrido", true, 580),
    new Automovil(10, "Honda", "CR-V", 2023, 70.0m, EstadoVehiculo.Disponible, 5, 5, "Gasolina", true, 560),

    // Motocicletas (11 al 20)
    new Motocicleta(11, "Yamaha", "MT-03", 2022, 30.0m, EstadoVehiculo.Disponible, 321, "Naked", 1, true, false),
    new Motocicleta(12, "Honda", "CB500F", 2023, 35.0m, EstadoVehiculo.Disponible, 471, "Naked", 1, false, false),
    new Motocicleta(13, "Kawasaki", "Ninja 400", 2023, 40.0m, EstadoVehiculo.Disponible, 399, "Deportiva", 1, false, true),
    new Motocicleta(14, "Suzuki", "V-Strom 650", 2022, 50.0m, EstadoVehiculo.Disponible, 645, "Trail", 2, true, true),
    new Motocicleta(15, "Yamaha", "YZF-R3", 2023, 38.0m, EstadoVehiculo.Disponible, 321, "Deportiva", 1, false, true),
    new Motocicleta(16, "Honda", "Navi", 2024, 20.0m, EstadoVehiculo.Disponible, 109, "Scooter", 1, true, false),
    new Motocicleta(17, "KTM", "Duke 200", 2023, 28.0m, EstadoVehiculo.Disponible, 199, "Naked", 1, false, false),
    new Motocicleta(18, "BMW", "G310R", 2022, 45.0m, EstadoVehiculo.Disponible, 313, "Naked", 1, false, false),
    new Motocicleta(19, "Ducati", "Monster", 2023, 80.0m, EstadoVehiculo.Disponible, 937, "Naked", 1, false, true),
    new Motocicleta(20, "Suzuki", "AX100", 2021, 18.0m, EstadoVehiculo.Disponible, 98, "Urbana", 1, false, false)
};

// --- LISTA DE 20 CLIENTES ---
List<Cliente> clientes = new List<Cliente>{
    new Cliente(101, "Carlos Pérez", "402-1122334-1", "LIC-9988", DateTime.Now.AddYears(2), "809-555-0199"),
    new Cliente(102, "María Gómez", "001-2233445-2", "LIC-1122", DateTime.Now.AddYears(1), "829-555-0288"),
    new Cliente(103, "Juan Rodríguez", "031-3344556-3", "LIC-3344", DateTime.Now.AddYears(3), "849-555-0377"),
    new Cliente(104, "Ana Martínez", "402-4455667-4", "LIC-5566", DateTime.Now.AddYears(2), "809-555-0466"),
    new Cliente(105, "Luis Fernández", "002-5566778-5", "LIC-7788", DateTime.Now.AddYears(1), "829-555-0555"),
    new Cliente(106, "Carmen Sánchez", "003-6677889-6", "LIC-9900", DateTime.Now.AddYears(4), "849-555-0644"),
    new Cliente(107, "Pedro Ramírez", "401-7788990-7", "LIC-2233", DateTime.Now.AddYears(2), "809-555-0733"),
    new Cliente(108, "Lucía Torres", "001-8899001-8", "LIC-4455", DateTime.Now.AddYears(3), "829-555-0822"),
    new Cliente(109, "Sofía Díaz", "037-9900112-9", "LIC-6677", DateTime.Now.AddYears(1), "849-555-0911"),
    new Cliente(110, "Mateo Vargas", "402-0011223-0", "LIC-8899", DateTime.Now.AddYears(2), "809-555-1000"),
    new Cliente(111, "Valentina Castro", "001-1122334-9", "LIC-1010", DateTime.Now.AddYears(3), "829-555-1111"),
    new Cliente(112, "Alejandro Morales", "002-2233445-8", "LIC-2020", DateTime.Now.AddYears(1), "849-555-1222"),
    new Cliente(113, "Camila Herrera", "402-3344556-7", "LIC-3030", DateTime.Now.AddYears(2), "809-555-1333"),
    new Cliente(114, "Gabriel Jiminián", "003-4455667-6", "LIC-4040", DateTime.Now.AddYears(4), "829-555-1444"),
    new Cliente(115, "Isabella Peña", "401-5566778-5", "LIC-5050", DateTime.Now.AddYears(1), "849-555-1555"),
    new Cliente(116, "Daniel Rivas", "001-6677889-4", "LIC-6060", DateTime.Now.AddYears(2), "809-555-1666"),
    new Cliente(117, "Valeria Medina", "031-7788990-3", "LIC-7070", DateTime.Now.AddYears(3), "829-555-1777"),
    new Cliente(118, "Diego Castillo", "402-8899001-2", "LIC-8080", DateTime.Now.AddYears(2), "849-555-1888"),
    new Cliente(119, "Martina Peguero", "002-9900112-1", "LIC-9090", DateTime.Now.AddYears(1), "809-555-1999"),
    new Cliente(120, "Lucas Almonte", "003-0011223-5", "LIC-9991", DateTime.Now.AddYears(3), "829-555-2000")
};

bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("==================================================");
    Console.WriteLine("       SISTEMA DE ALQUILER DE VEHÍCULOS           ");
    Console.WriteLine("==================================================");
    Console.WriteLine(" 1. Registrar nuevo Vehículo (Auto / Moto)");
    Console.WriteLine(" 2. Registrar nuevo Cliente");
    Console.WriteLine(" 3. Listar Vehículos y Clientes");
    Console.WriteLine(" 4. Crear Reserva");
    Console.WriteLine(" 5. Confirmar Reserva (Genera Cambio de Estado)");
    Console.WriteLine(" 6. Generar Contrato y Ver Detalles");
    Console.WriteLine(" 7. Registrar Devolución de Vehículo");
    Console.WriteLine(" 8. Salir");
    Console.WriteLine("==================================================");
    Console.Write("Seleccione una opción (1-8): ");

    string opcion = Console.ReadLine();
    Console.WriteLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("--- REGISTRAR VEHÍCULOS ---");
            Console.Write("¿Es Automóvil (1) o Motocicleta (2)?: ");
            string tipoV = Console.ReadLine();
            Console.Write("ID del vehículo: ");
            int idV = int.Parse(Console.ReadLine());
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Año: ");
            int anio = int.Parse(Console.ReadLine());
            Console.Write("Precio diario ($): ");
            decimal precio = decimal.Parse(Console.ReadLine());

            if (tipoV == "1")
            {
                Console.Write("Cantidad de puertas: ");
                int puertas = int.Parse(Console.ReadLine());
                Console.Write("Capacidad pasajeros: ");
                int pas = int.Parse(Console.ReadLine());
                Console.Write("Combustible: ");
                string comb = Console.ReadLine();
                Console.Write("¿Es transmisión automática? (s/n): ");
                bool aut = Console.ReadLine().ToLower() == "s";
                Console.Write("Capacidad maletero: ");
                decimal mal = decimal.Parse(Console.ReadLine());

                vehiculos.Add(new Automovil(idV, marca, modelo, anio, precio, EstadoVehiculo.Disponible, puertas, pas, comb, aut, mal));
                Console.WriteLine("\n¡Automóvil registrado con éxito!");
            }
            else
            {
                Console.Write("Cilindrada (cc): ");
                int cil = int.Parse(Console.ReadLine());
                Console.Write("Tipo de motocicleta: ");
                string tMoto = Console.ReadLine();
                Console.Write("Capacidad de cascos: ");
                int cascos = int.Parse(Console.ReadLine());
                Console.Write("¿Tiene maletero? (s/n): ");
                bool tieneMal = Console.ReadLine().ToLower() == "s";
                Console.Write("¿Requiere licencia especial? (s/n): ");
                bool licEsp = Console.ReadLine().ToLower() == "s";

                vehiculos.Add(new Motocicleta(idV, marca, modelo, anio, precio, EstadoVehiculo.Disponible, cil, tMoto, cascos, tieneMal, licEsp));
                Console.WriteLine("\n¡Motocicleta registrada con éxito!");
            }
            break;

        case "2":
            Console.WriteLine("--- REGISTRAR CLIENTE ---");
            Console.Write("ID del Cliente: ");
            int idC = int.Parse(Console.ReadLine());
            Console.Write("Nombre completo: ");
            string nom = Console.ReadLine();
            Console.Write("Documento de identidad: ");
            string doc = Console.ReadLine();
            Console.Write("Número de Licencia: ");
            string lic = Console.ReadLine();
            Console.Write("Teléfono: ");
            string tel = Console.ReadLine();

            clientes.Add(new Cliente(idC, nom, doc, lic, DateTime.Now.AddYears(1), tel));
            Console.WriteLine("\n¡Cliente registrado con éxito!");
            break;

        case "3":
            Console.WriteLine("--- LISTADO GENERAL ---");
            Console.WriteLine("\n[VEHÍCULOS]");
            foreach (var v in vehiculos) Console.WriteLine(v.ToString()+"\n");
                    
            Console.WriteLine("\n[CLIENTES]");
            foreach (var c in clientes) Console.WriteLine(c);
            break;

        case "4":
            Console.WriteLine("--- CREAR RESERVA ---");
    
            // 1. Primero preguntamos el rango de fechas o los días del alquiler
            Console.Write("Ingrese la fecha de inicio (formato AAAA-MM-DD) o presione Enter para hoy: ");
            string inputInicio = Console.ReadLine();
            DateTime inicio = string.IsNullOrWhiteSpace(inputInicio) ? DateTime.Now : DateTime.Parse(inputInicio);

            Console.Write("¿Cuántos días durará el alquiler?: ");
            int dias = int.Parse(Console.ReadLine());
            DateTime fin = inicio.AddDays(dias);

            // 2. Mostramos los vehículos disponibles filtrados por ese rango de fechas
            MostrarVehiculosDisponibles(vehiculos, inicio, fin, reservas);

            Console.Write("\nIngrese ID del Vehículo a reservar: ");
            int idVehRes = int.Parse(Console.ReadLine());
            Vehiculo vehEncontrado = vehiculos.Find(v => v.Id == idVehRes);

            MostrarClientes(clientes);
            Console.Write("Ingrese ID del Cliente: ");
            int idCliRes = int.Parse(Console.ReadLine());
            Cliente cliEncontrado = clientes.Find(c => c.IdCliente == idCliRes);

            if (vehEncontrado != null && cliEncontrado != null){
                if (vehEncontrado.EstaDisponible(inicio, fin, reservas)){
                    int idRes = reservas.Count + 1;
            
                    Reserva nuevaReserva = new Reserva(idRes, inicio, fin, DateTime.Now, EstadoReserva.Pendiente, cliEncontrado, vehEncontrado);
                    reservas.Add(nuevaReserva);
            
                    Console.WriteLine($"\n¡Reserva #{idRes} creada con estado PENDIENTE! Precio estimado: ${nuevaReserva.PrecioEstimado}");
                }
                else{
                    Console.WriteLine("\n[Error] El vehículo seleccionado ya no está disponible para esas fechas.");
                }
            }
            else{
                Console.WriteLine("\n[Error] Vehículo o Cliente no encontrados.");
            }
            break;

        case "5":
            Console.WriteLine("--- CONFIRMAR RESERVA ---");
            MostrarReservasPendientes(reservas);
            Console.Write("Ingrese ID de la Reserva a confirmar: ");
            Reserva resAConf = null;
            while (resAConf == null){
                Console.Write("Ingrese ID de la Reserva a confirmar: ");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int idResConf)){
                    resAConf = reservas.Find(r => r.IdReserva == idResConf && r.Estado == EstadoReserva.Pendiente);

                    if (resAConf == null){
                        Console.WriteLine("[Error] No se encontró ninguna reserva con ese ID. Intente nuevamente.\n");
                    }
                }
                else{
                    Console.WriteLine("[Error] Por favor, ingrese un número de ID válido.\n");
                }
            }
            bool confirmado = resAConf.Confirmar(reservas.Where(r => r != resAConf).ToList());
            if (confirmado)
                Console.WriteLine("\n¡Reserva confirmada exitosamente!");
            else
                Console.WriteLine("\n[Error] No se pudo confirmar (Verifique si el cliente puede alquilar o si el vehículo está disponible).");
            break;

        case "6":
            Console.WriteLine("--- GENERAR CONTRATO ---");
            MostrarReservasConfirmadas(reservas);
            Console.Write("Ingrese ID de la Reserva Confirmada: ");
            Reserva resParaContrato = null;
            while (resParaContrato == null){
                Console.Write("Ingrese ID de la Reserva a confirmar: ");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int idResConf)){
                    resParaContrato = reservas.Find(r => r.IdReserva == idResConf && r.Estado == EstadoReserva.Confirmada);

                    if (resParaContrato == null){
                        Console.WriteLine("[Error] No se encontró ninguna reserva con ese ID. Intente nuevamente.\n");
                    }
                }
                else{
                    Console.WriteLine("[Error] Por favor, ingrese un número de ID válido.\n");
                }
            }
            Console.Write("Ingrese kilometraje inicial del vehículo: ");
            int kmIni = int.Parse(Console.ReadLine());

            int idCon = contratos.Count + 1;
            DateTime fechaFirma = DateTime.Now;
            DateTime fechaDevPrevista = resParaContrato.FechaFin; 
            DateTime? fechaDevReal = null; 
            decimal montoTotal = resParaContrato.PrecioEstimado; 

            Contrato nuevoContrato = new Contrato(idCon, fechaFirma, fechaDevPrevista, fechaDevReal, 
            montoTotal, kmIni, resParaContrato);
            contratos.Add(nuevoContrato);
            break;

        case "7":
            Console.WriteLine("--- REGISTRAR DEVOLUCIÓN ---");
            MostrarContratosActivos(contratos);
            Console.Write("Ingrese ID del Contrato activo: ");
            Contrato contratoDev = null;
            while (contratoDev == null){
                Console.Write("Ingrese ID del Contrato: ");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out idCon)){
                    contratoDev = contratos.Find(r => r.IdContrato == idCon && r.EsActivo);

                    if (contratoDev == null){
                        Console.WriteLine("[Error] No se encontró ningún contrato con ese ID. Intente nuevamente.\n");
                    }
                }
                else{
                    Console.WriteLine("[Error] Por favor, ingrese un número de ID válido.\n");
                }
            }
            Console.Write("Ingrese kilometraje final al devolver: ");
            int kmFin = int.Parse(Console.ReadLine());

            contratoDev.RegistrarDevolucion(kmFin);
            Console.WriteLine($"\n¡Devolución registrada con éxito! Monto final cobrado (incluyendo cargos/retrasos): ${contratoDev.MontoTotal}");
            break;

        case "8":
            salir = true;
            Console.WriteLine("Saliendo del sistema. ¡Gracias por usar la aplicación!");
            break;

        default:
            Console.WriteLine("[Error] Opción no válida.");
            break;
    }

    if (!salir)
    {
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}

static void MostrarVehiculosDisponibles(List<Vehiculo> vehiculos, DateTime inicio, DateTime fin, List<Reserva> reservas){
    Console.WriteLine($"\n--- Vehículos Disponibles del {inicio.ToShortDateString()} al {fin.ToShortDateString()} ---");
    bool hayDisponibles = false;
    foreach (var v in vehiculos){
        // Comprueba si está libre tanto en estado general como en el rango de fechas y reservas
        if (v.EstaDisponible(inicio, fin, reservas)){
            Console.WriteLine(v.ToString()+"\n");
            hayDisponibles = true;
        }
    }

    if (!hayDisponibles){
        Console.WriteLine("No hay vehículos disponibles para las fechas seleccionadas.");
    }
}

static void MostrarClientes(List<Cliente> clientes){
    Console.WriteLine("\n--- Lista de Clientes ---");
    foreach (var c in clientes){
        Console.WriteLine(c.ToString());
    }
}

static void MostrarReservasPendientes(List<Reserva> reservas){
    Console.WriteLine("\n--- Reservas Pendientes ---");
    foreach (var r in reservas){
        if (r.Estado == EstadoReserva.Pendiente){
            Console.WriteLine(r.ToString());
        }
    }
}
static void MostrarReservasConfirmadas(List<Reserva> reservas){
    Console.WriteLine("\n--- Reservas Pendientes ---");
    foreach (var r in reservas){
        if (r.Estado == EstadoReserva.Confirmada){
            Console.WriteLine(r.ToString());
        }
    }
}
static void MostrarContratosActivos(List<Contrato> contratos){
    Console.WriteLine("\n--- Contratos Activos ---");
    foreach (var c in contratos){
        if (c.EsActivo){
            Console.WriteLine(c.ToString());
        }
    }
}