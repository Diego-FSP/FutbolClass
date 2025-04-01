using JugadoresClass;
using SecionesClass;
namespace EquipoClass;

public class Equipo
{
    public List<Jugador> Jugadores= [new Atacante(), new Defensor()];
    public List<Sesion> SecionesEntrenamiento= [new SesionFisica(), new SesionLirica(), new SesionTactica()];
    
    public void Entrenar()
    {
        foreach(Jugador j in Jugadores)
        foreach(Sesion e in SecionesEntrenamiento)
        e.AplicarA(j);
    }

    public double GetPotencia()
    {
        double[] potencias = { 0 , 0};
        foreach(Jugador j in Jugadores)
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
        foreach(Jugador j in Jugadores)
        precision+= 3 * j.GetPrecision() + j.habilidadPases;

        return precision;
    }

    public double GetVision()
    {
        double suma=0;
        foreach(Jugador j in Jugadores)
        suma+=j.GetVisionGeneral();
        return suma;
    }
}