using System;

namespace Conditional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese limite de velocidad: ");
            var limiteVelocidad =int.Parse(Console.ReadLine());
            Console.Write("Ingrese velocidad del automovil: ");
            var velocidadAuto = int.Parse(Console.ReadLine());

            if (velocidadAuto<limiteVelocidad)
            {
                Console.WriteLine("OK");
            }
            else
            {
                const int kmPorPuntos = 5;
                var puntos = (velocidadAuto - limiteVelocidad) / kmPorPuntos;
                if (puntos>12)
                {
                    Console.WriteLine("Licencia suspendida");
                }
                else
                {
                    Console.WriteLine("Puntos en la licencia: {0}",puntos);
                }
            }

        }
    }
}
