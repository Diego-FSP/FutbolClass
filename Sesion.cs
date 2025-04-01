using JugadoresClass;
namespace SecionesClass;

public abstract class Sesion
{
    public string nombre;

    public virtual void AplicarA(Jugador j);
}