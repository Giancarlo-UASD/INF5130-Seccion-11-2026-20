public interface IAtaque{
    void EjecutarAtaque(Pokemon enemigo);
}

public class Pokemon : IAtaque{
    public int IdPokemon {get; private set;}
    public string Nombre {get; private set;}
    public int Nivel {get; private set;}
    public int Salud {get; private set;}
    public EstadoPokemon Estado {get; private set;}

    public Pokemon(int id, string nombre, int nivel, int salud){
        IdPokemon = id;
        Nombre = nombre;
        Nivel = nivel;
        Salud = salud;
        Estado = EstadoPokemon.SALUDABLE;
    }

    public void Atacar(Pokemon enemigo){
        if(Estado != EstadoPokemon.SALUDABLE){
            Console.WriteLine("No puede atacar en este estado...");
            return;
        }
        Console.WriteLine($"{Nombre} realiza un ataque básico.");
        Random rand = new Random();
        int dañoBase = Nivel * 10;
        int probabilidadCritico = rand.Next(1, 10);

        if (probabilidadCritico > 4){ // Ataque crítico o especial
            Console.WriteLine($"¡Golpe Crítico/Especial de {Nombre}!");
            enemigo.RecibirDaño(dañoBase * 2);

            if (enemigo.Salud > 0){
                enemigo.CambiarEstado(EstadoPokemon.PARALIZADO); 
            }
        }
        else{
            Console.WriteLine($"{Nombre} ejecuta su ataque.");
            enemigo.RecibirDaño(dañoBase);
        }
    }

    public void RecibirDaño(int cantidad){
        Salud -= cantidad;
        if (Salud < 0) Salud = 0;
        Console.WriteLine($"{Nombre} recibe {cantidad} de daño. Salud restante: {Salud}");

        // Si la salud llega a 0, se cambia el estado a DERROTADO[cite: 2]
        if (Salud == 0){
            CambiarEstado(EstadoPokemon.DERROTADO);
        }
    }

    public void Curar(int puntos){
        Salud += puntos;
        Console.WriteLine($"{Nombre} se ha curado {puntos} puntos. Salud actual: {Salud}");
        if (Estado == EstadoPokemon.DERROTADO && Salud > 0){
            CambiarEstado(EstadoPokemon.SALUDABLE);
        } 
    }

    public void CambiarEstado(EstadoPokemon nuevoEstado){
        Estado = nuevoEstado;
        Console.WriteLine($"-> El estado de {Nombre} ha cambiado a: {Estado}");
    }

    //Este es el ataque especial
    public void EjecutarAtaque(Pokemon enemigo){
        if(Estado != EstadoPokemon.SALUDABLE){
            Console.WriteLine("No puede atacar en este estado...");
            return;
        }
        Console.WriteLine($"{Nombre} realiza un ataque Especial.");
        Random rand = new Random();
        int dañoBase = Nivel * 20;
        int probabilidadCritico = rand.Next(1, 10);

        if (probabilidadCritico > 2){ // Ataque crítico o especial
            Console.WriteLine($"¡Golpe Crítico/Especial de {Nombre}!");
            enemigo.RecibirDaño(dañoBase * 2);

            if (enemigo.Salud > 0){
                enemigo.CambiarEstado(EstadoPokemon.PARALIZADO); 
            }
        }
        else{
            Console.WriteLine($"{Nombre} ejecuta su ataque.");
            enemigo.RecibirDaño(dañoBase);
        }
    }
}