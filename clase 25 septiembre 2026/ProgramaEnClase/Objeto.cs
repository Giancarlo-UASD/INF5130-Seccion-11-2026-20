public interface IObjetoUsable{
    void Usar(Pokemon p);
}

public class Objeto : IObjetoUsable{
    public int IdObjeto {get; private set;}
    public string Nombre {get; private set;}
    public string Tipo {get; private set;}
    public int ValorEfecto {get; private set;}
    public int Cantidad {get; private set;}

    public Objeto(int id, string nombre, string tipo, int valorEfecto, int cantidad){
        IdObjeto = id;
        Nombre = nombre;
        Tipo = tipo;
        ValorEfecto = valorEfecto;
        Cantidad = cantidad;
    }

    public void AplicarEfecto(Pokemon p){
        Console.WriteLine("Se ha aplicado el efecto...");
    }

    public void Usar(Pokemon p){
        if(Cantidad <= 0){
            Console.WriteLine("No tiene suficientes objetos para realizar esta acción...")
        }
        AplicarEfecto(p);
        if(Tipo == "Cura"){
            p.Curar(ValorEfecto);
        }
        else if(Tipo == "Anti Parálisis"){
            if(p.Estado == EstadoPokemon.PARALIZADO){
                p.CambiarEstado(EstadoPokemon.SALUDABLE);
                p.Curar(ValorEfecto);
            }
        }else if(Tipo == "Revive"){
            if(p.Estado == EstadoPokemon.DERROTADO){
                p.CambiarEstado(EstadoPokemon.SALUDABLE);
                p.Curar(ValorEfecto);
            }
        }
    }

    public void Consumir(){
        if (Cantidad > 0){
            Cantidad--;
            Console.WriteLine($"[Inventario] Quedan {Cantidad} unidades del objeto {Nombre}.");
        }
    }
}