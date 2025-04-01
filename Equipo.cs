using JugadoresClass;
using SecionesClass;
namespace EquipoClass;

public class Equipo
{
    public List<Jugador> Jugadores= {new Atacante(), new Defensor()};
    public List<Sesion> SecionesEntrenamiento= {new SesionFisica(), new SesionLirica(), new SesionTactica()};
    
    public void Entrenar()
    {
        foreach(Jugadores j)
        foreach(SecionesEntrenamiento e)
        e.AplicarA(j.this);
    }

    public double GetPotencia()
    {
        double potencias[2] = { 0 , 0}:
        foreach(Jugadores j)
        if(j.potencia>potencias[0])
        {
            potencias[1]=potencias[0];
            potencias[0]=j.potencia;
        }
        return potencias[0]+potencias[1];
    }

    public double GetPrecision()
    {
        double precision=0;
        foreach(Jugadores j)
        precision+= 3 * j.GetPrecision() + j.habilidadPases;
    }

    public double GetVision()
    {
        double suma=0;
        foreach(Jugadores j)
        suma+=j.GetVisionGeneral();
        return suma;
    }
}