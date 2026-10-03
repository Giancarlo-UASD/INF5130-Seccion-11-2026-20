Console.WriteLine("========================================");
Console.WriteLine("     CONFIGURACIÓN INICIAL DE JUGADORES ");
Console.WriteLine("========================================");

Jugador[] jugadores = new Jugador[2];      

// Registro de Jugador 1
Console.Write("Ingrese el nombre del Jugador 1: ");
string nombreJ1 = Console.ReadLine();
Console.Write("Ingrese el Nivel de Entrenador para el Jugador 1: ");
int? nivelJ1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese las Medallas para el Jugador 1: ");
int? medallasJ1 = int.Parse(Console.ReadLine());
jugadores[0] = new Jugador("J01", string.IsNullOrEmpty(nombreJ1) ? "Jugador1" : nombreJ1, 
nivelJ1.GetValueOrDefault(0), medallasJ1.GetValueOrDefault(0));

// Registro de Jugador 2
Console.Write("Ingrese el nombre del Jugador 2: ");
string nombreJ2 = Console.ReadLine();
Console.Write("Ingrese el Nivel de Entrenador para el Jugador 2: ");
int? nivelJ2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese las Medallas para el Jugador 2: ");
int? medallasJ2 = int.Parse(Console.ReadLine());
        
jugadores[1] = new Jugador("J02", string.IsNullOrEmpty(nombreJ2) ? "Jugador2" : nombreJ2, 
nivelJ2.GetValueOrDefault(0), medallasJ2.GetValueOrDefault(0));


// Asignar las 6 Pokémon fijas al Jugador 1
jugadores[0].ListaPokemons = new List<Pokemon>()
{
    new Pokemon(1, "Pikachu", 5, 100),
    new Pokemon(2, "Charmander", 5, 100),
    new Pokemon(3, "Bulbasaur", 5, 95),
    new Pokemon(4, "Squirtle", 5, 105),
    new Pokemon(5, "Jigglypuff", 4, 120),
    new Pokemon(6, "Snorlax", 8, 200)
};

// Asignar las otras 6 Pokémon fijas al Jugador 2
jugadores[1].ListaPokemons = new List<Pokemon>()
{
    new Pokemon(7, "Mewtwo", 10, 180),
    new Pokemon(8, "Gengar", 6, 110),
    new Pokemon(9, "Dragonite", 7, 150),
    new Pokemon(10, "Lucario", 6, 130),
    new Pokemon(11, "Eevee", 3, 90),
    new Pokemon(12, "Scyther", 6, 120)
};

jugadores[0].ElegirPokemon(0);
jugadores[1].ElegirPokemon(0);

jugadores[0].ListaObjetos = new List<Objeto>()
{
    new Objeto(101, "Elixir de la Vida", "Cura", 50, 1),
    new Objeto(102, "La vida sigue", "Anti Parálisis", 30, 1),
    new Objeto(103, "Bendición del Phoenix", "Revive", 100, 1),
};
jugadores[1].ListaObjetos = new List<Objeto>()
{
    new Objeto(101, "Elixir de la Vida", "Cura", 50, 1),
    new Objeto(102, "La vida sigue", "Anti Parálisis", 30, 1),
    new Objeto(103, "Bendición del Phoenix", "Revive", 100, 1),
};


int opcion = 0;
int turno = 0;
do{
    if(jugadores[turno].SigueVivo()){
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.WriteLine("========================================");
        Console.WriteLine("           MENÚ PRINCIPAL POKÉMON        ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Jugador {turno + 1}: {jugadores[turno].Nombre}" + 
        $" (Nivel: {jugadores[turno].NivelEntrenador}) (Medallas: {jugadores[turno].Medallas})");
        Console.WriteLine($"Pokemon Elegido: {jugadores[turno].PokemonElegido.Nombre}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("1. Elegir Pokemon.");
        Console.WriteLine("2. Usar Objeto.");
        Console.WriteLine("3. Ver Estado.");
        Console.WriteLine("4. Atacar.");
        Console.WriteLine("5. Ataque Especial.");
        Console.WriteLine("6. Salir");
        Console.Write("Seleccione una opción: ");
        if(jugadores[turno].PokemonElegido.Estado == EstadoPokemon.DERROTADO)
            opcion = 1;
        else{
            while(!int.TryParse(Console.ReadLine(), out opcion)){
                Console.WriteLine("Ingrese un número válido.");
                Console.Write("Seleccone una opción: ");
            }
        }
    }else{
        Console.WriteLine($"El jugador {jugadores[turno].Nombre} ya no puede continuar...");
        Console.WriteLine($"El ganador es {jugadores[1-turno].Nombre}, Felicidades :)");
        opcion = 6;
    }
    switch (opcion){
        case 1:
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.WriteLine("\n--- LISTA DE POKÉMON DE " + jugadores[turno].Nombre.ToUpper() + " ---");
            for (int i = 0; i < jugadores[turno].ListaPokemons.Count; i++){
                Console.WriteLine($"{i + 1}. {jugadores[turno].ListaPokemons[i].Nombre}" +
                $" (HP: {jugadores[turno].ListaPokemons[i].Salud})");
            }
            Console.Write("Seleccione el índice de su Pokémon para pelear: ");
            if (int.TryParse(Console.ReadLine(), out int seleccion)){
                jugadores[turno].ElegirPokemon(seleccion-1);
            }else
                jugadores[turno].ElegirPokemon(-1);
            break;

        case 2:
            Pokemon p;
            Objeto o;
            for (int i = 0; i < jugadores[turno].ListaObjetos.Count; i++){
                Console.WriteLine($"{i + 1}. {jugadores[turno].ListaObjetos[i].Nombre}" +
                $" (Cantidad: {jugadores[turno].ListaObjetos[i].Cantidad})");
            }
            Console.Write("Seleccione el índice del objeto a Utilizar: ");
            if (int.TryParse(Console.ReadLine(), out seleccion)){
                seleccion--;
                if(seleccion >= 0 && seleccion < jugadores[turno].ListaObjetos.Count)
                    o = jugadores[turno].ListaObjetos[seleccion];
                else{
                    Console.WriteLine("[Error] Seleccionó incorrectamente...");
                    break;
                }
            }else{
                Console.WriteLine("[Error] Seleccionó incorrectamente...");
                break;
            }
            for (int i = 0; i < jugadores[turno].ListaPokemons.Count; i++){
                Console.WriteLine($"{i + 1}. {jugadores[turno].ListaPokemons[i].Nombre}" +
                $" (HP: {jugadores[turno].ListaPokemons[i].Salud})");
            }
            Console.Write("Seleccione el índice de su Pokémon para usar el objeto: ");
            if (int.TryParse(Console.ReadLine(), out int seleccion2)){
                seleccion2--;
                if(seleccion2 >= 0 && seleccion2 < jugadores[turno].ListaPokemons.Count){
                    p = jugadores[turno].ListaPokemons[seleccion2];
                    jugadores[turno].UsarObjeto(o, p);
                }else{
                    Console.WriteLine("[Error] Seleccionó incorrectamente...");
                    break;
                }
            }else{
                Console.WriteLine("[Error] Seleccionó incorrectamente...");
                break;
            }
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.WriteLine("\n--- Estado de los Pokemon de " + jugadores[turno].Nombre.ToUpper() + " ---");
            for (int i = 0; i < jugadores[turno].ListaPokemons.Count; i++){
                if(jugadores[turno].ListaPokemons[i] == jugadores[turno].PokemonElegido)
                    Console.Write("(Elegido)");
                Console.WriteLine($"{i + 1}. {jugadores[turno].ListaPokemons[i].Nombre}" +
                $" (HP: {jugadores[turno].ListaPokemons[i].Salud})" + 
                $" (Estado: {jugadores[turno].ListaPokemons[i].Estado})");
            }
            break;

        case 4:
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.WriteLine("\n--- ATACAR ---");
            jugadores[turno].IniciarCombate(jugadores[1-turno].PokemonElegido, 1);
            break;

        case 5:
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.WriteLine("\n--- ATACAR ---");
            jugadores[turno].IniciarCombate(jugadores[1-turno].PokemonElegido, 2);
            break;
        case 6:
            Console.WriteLine("Saliendo del juego...");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    turno = 1 - turno;

    if (opcion != 6){
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

}while (opcion != 6);