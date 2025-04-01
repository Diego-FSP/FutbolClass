namespace JugadoresClass;

public class Atacante: Jugador
{
    public double anotacion;
    
    public override double GetPrecision()
    {
        return anotacion;
    }

    public override double GetVisionGeneral()
    {
        double suma= base.visionJuego + base.habilidadPases;
        return suma;
    }

    public override void AplicarEntrenamientoFisico()
    {
        base.potencia++;
        base.habilidadPases+=0.5;
    }

    public override void AplicarEntrenamientoLirico()
    {
        base.habilidadPases++;
        anotacion+=0.5;
    }

    public override void AplicarEntrenamientoTactico()
    {
        base.habilidadPases+=0.5;
        base.visionJuego+=0.5;
        base.visionCompañeros+=0.5;
    }
}