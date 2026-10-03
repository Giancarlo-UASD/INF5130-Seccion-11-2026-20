public class Jugador{
    public string IdJugador {get; private set;}
    public string Nombre {get; private set;}
    public int NivelEntrenador {get; private set;}
    public int Medallas {get; private set;}
    public List<Pokemon> ListaPokemons {get; set;}
    public Pokemon PokemonElegido {get; set;}
    public List<Objeto> ListaObjetos {get; set;}

    public Jugador(string id, string nombre, int nivel, int medallas){
        IdJugador = id;
        Nombre = nombre;
        NivelEntrenador = nivel;
        Medallas = medallas;
        ListaPokemons = new List<Pokemon>();
        ListaObjetos = new List<Objeto>();
    }

    public void ElegirPokemon(int index){
        if(index >= 0 && index < ListaPokemons.Count)
            if(ListaPokemons[index].Estado == EstadoPokemon.DERROTADO){
                Console.WriteLine("[Advertencia] Este Pokemon ha sido derrotado y no puede elegirlo.");
                PokemonElegido = ListaPokemons.FirstOrDefault(p => p.Estado != EstadoPokemon.DERROTADO);
            }
            else
                PokemonElegido = ListaPokemons[index];
        else{
            Console.WriteLine("[Error] No seleccionó correctamente...");
            PokemonElegido = ListaPokemons.FirstOrDefault(p => p.Estado != EstadoPokemon.DERROTADO);
        }
        return;
    }

    public void UsarObjeto(Objeto o, Pokemon p){
        Console.WriteLine($"\n[Entrenador {Nombre}] usa el objeto '{o.Nombre}' en {p.Nombre}.");
        o.Usar(p); // Llama a usar() de IObjetoUsable
        o.Consumir(); // Actualiza la cantidad del objeto
    }

    public void IniciarCombate(Pokemon enemigo, int modo){
        if(modo == 1)
            PokemonElegido.Atacar(enemigo);
        else
            PokemonElegido.EjecutarAtaque(enemigo);
    }

    public bool SigueVivo(){
        Pokemon p = ListaPokemons.FirstOrDefault(p => p.Estado != EstadoPokemon.DERROTADO);
        return (p != null);
    }
}