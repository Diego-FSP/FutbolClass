using JugadoresClass;
namespace SecionesClass;

public class SesionTactica:Sesion
{
    public override void AplicarA(Jugador j)
    {
        j.AplicarEntrenamientoTactico();
    }
}