using JugadoresClass;
namespace SecionesClass;

public class SesionFisica
{
    public override void AplicarA(Jugador j)
    {
        j.AplicarEntrenamientoFisico();
    }
}