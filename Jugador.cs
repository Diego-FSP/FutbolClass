namespace JugadoresClass;

public abstract class Jugador
{
    public double visionJuego;
    public double visionCompañeros;
    public double potencia;
    public double habilidadPases;

    public virtual double GetPrecision()
    {}

    public virtual double GetVisionGeneral()
    {}

    public virtual void AplicarEntrenamientoFisico()
    {}

    public virtual void AplicarEntrenamientoLirico()
    {}

    public virtual void AplicarEntrenamientoTactico()
    {}
}