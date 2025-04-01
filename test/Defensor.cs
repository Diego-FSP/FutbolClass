namespace JugadoresClass;

public class Defensor: Jugador
{
    public double quite=0;

    public override double GetPrecision()
    {
        return quite;
    }

    public override double GetVisionGeneral()
    {
        double suma= base.visionCompañeros + base.visionJuego;
        return suma;
    }

    public override void AplicarEntrenamientoFisico()
    {
        base.potencia++;
        base.habilidadPases+=0.5;
        quite+=0.5;
    }

    public override void AplicarEntrenamientoLirico()
    {
        base.habilidadPases++;
        base.visionJuego+=0.5;
    }

    public override void AplicarEntrenamientoTactico()
    {
        base.visionJuego+=0.5;
        base.visionCompañeros++;
    }
}