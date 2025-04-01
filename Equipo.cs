using JugadoresClass;
using SecionesClass;
namespace EquipoClass;

public class Equipo
{
    public List<Jugador> Jugadores;
    public List<Sesion> SecionesEntrenamiento;
    
    public void Entrenar()
    {}

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
    {}

    public double GetVision()
    {}
}