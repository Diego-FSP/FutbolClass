using System;
using JugadoresClass;
using SecionesClass;
using EquipoClass;

public class Program
{
    public static void Main(string[] arg)
    {
        Equipo Argentina= new Equipo();
        bool salir=false;
        while(salir==false)
        {
            Console.WriteLine("Integrantes de la seleccion Argentina: "+Argentina.Jugadores.Count);
            Console.WriteLine("Potencia: "+Argentina.GetPotencia());
            Console.WriteLine("Precision: "+Argentina.GetPrecision());
            Console.WriteLine("1|Entrenar");
            Console.ReadLine();
        }
    }
}