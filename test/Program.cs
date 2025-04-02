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
            Console.Clear();
            Console.WriteLine("Integrantes de la seleccion Argentina: "+Argentina.Jugadores.Count);
            Console.WriteLine("Potencia: "+Argentina.GetPotencia());
            Console.WriteLine("Precision: "+Argentina.GetPrecision());
            Console.WriteLine("1|Entrenar");
            Console.WriteLine("2|Salir");
            byte op= Byte.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    Argentina.Entrenar();
                break;
                case 2:
                    salir=true;
                break;
            }
        }
    }
}