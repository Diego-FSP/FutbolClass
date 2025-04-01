using JugadoresClass;
namespace SecionesClass;

public class SesionLirica:Sesion
{
    public override void AplicarA(Jugador j)
    {
        j.AplicarEntrenamientoLirico();
    }
}