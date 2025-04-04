namespace JugadoresClass;

public abstract class Jugador
{
    public double visionJuego=0;
    public double visionCompañeros=0;
    public double potencia=0;
    public double habilidadPases=0;

    public virtual double GetPrecision()
    {
        return 0;
    }

    public virtual double GetVisionGeneral()
    {
        return 0;
    }

    public virtual void AplicarEntrenamientoFisico()
    {}

    public virtual void AplicarEntrenamientoLirico()
    {}

    public virtual void AplicarEntrenamientoTactico()
    {}
}