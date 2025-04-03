using JugadoresClass;
namespace SecionesClass;

public class SesionFisica:Sesion
{
    public override void AplicarA(Jugador j)
    {
        j.AplicarEntrenamientoFisico();
    }
}