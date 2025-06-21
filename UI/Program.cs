using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opciones para Construir Casa de Ladrillos:\n");
            bool pintarRequerido = false;
            bool construirSegundoPisoRequerido = true;
            bool construirSotanoRequerido = true;

            Console.WriteLine($"-> Pintar: {(pintarRequerido ? "Sí" : "No")}");
            Console.WriteLine($"-> 2do Piso: {(construirSegundoPisoRequerido ? "Sí" : "No")}");
            Console.WriteLine($"-> Sótano: {(construirSotanoRequerido ? "Sí" : "No")}\n");

            Casa casaLadrillo = new CasaLadrillo(pintarRequerido, construirSegundoPisoRequerido, construirSotanoRequerido);
            casaLadrillo.ConstruirCasa();

            ///

            Console.WriteLine("Opciones para Construir Casa de Madera:\n");
            bool pintarRequerido2 = true;
            bool construirSegundoPisoRequerido2 = true;
            bool construirSotanoRequerido2 = true;

            Console.WriteLine($"-> Pintar: {(pintarRequerido2 ? "Sí" : "No")}");
            Console.WriteLine($"-> 2do Piso: {(construirSegundoPisoRequerido2 ? "Sí" : "No")}");
            Console.WriteLine($"-> Sótano: {(construirSotanoRequerido2 ? "Sí" : "No")}\n");

            Casa casaMadera = new CasaMadera(pintarRequerido2, construirSegundoPisoRequerido2, construirSotanoRequerido2);
            casaMadera.ConstruirCasa();



            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
