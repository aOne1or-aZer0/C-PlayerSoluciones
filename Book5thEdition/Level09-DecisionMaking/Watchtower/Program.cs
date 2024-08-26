/*Objetivos:
- Pide al usuario un valor x y un valor y. Son las coordenadas del
enemigo respecto a la ubicación de la torre de vigilancia.
- Usando if statements y operadores relacionalse, mostrar un mensaje sobre la dirección en la que está. 
Por ejemplo, «¡El enemigo está al noroeste!» o «¡El enemigo está aquí!»
*/
using System;
namespace Watchtower
{
    public class Program
    {
        public static void Main(string[]args)
        {
            Console.Title = "Watchtower";
            Console.WriteLine("TORRE DE VIGILANCIA");
            Console.WriteLine("-------------------");
            // Datos de entrada
            Console.Write("Ingresa la coordenada 'x': " );
            string? inputCoordenadaX = Console.ReadLine();
            int coordenadaX = Convert.ToInt32(inputCoordenadaX);

            Console.Write("Ingresa la coordenada 'y': " );
            string? inputCoordenadaY = Console.ReadLine();
            int coordenadaY = Convert.ToInt32(inputCoordenadaY);
            // Condicionales. Posición del enemigo
            if (coordenadaX < 0 && coordenadaY > 0)
            {
                Console.WriteLine("¡El enemigo está al noroeste!");
            }
            else if (coordenadaX < 0 && coordenadaY == 0)
            {
                Console.WriteLine("¡El enemigo está al oeste!");
            }
            else if (coordenadaX < 0 && coordenadaY < 0)
            {
                Console.WriteLine("¡El enemigo está al suroeste!");
            }
              else if (coordenadaX == 0 && coordenadaY > 0)
            {
                Console.WriteLine("¡El enemigo está al norte!");
            }
            else if (coordenadaX == 0 && coordenadaY == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("EL ENEMIGO ESTA AQUI");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Beep(500, 1000);
            }
              else if (coordenadaX == 0 && coordenadaY < 0)
            {
                Console.WriteLine("¡El enemigo está al sur!");
            }
              else if (coordenadaX > 0 && coordenadaY > 0)
            {
                Console.WriteLine("¡El enemigo está al noreste!");
            }
             else if (coordenadaX > 0 && coordenadaY == 0)
            {
                Console.WriteLine("¡El enemigo está al este!");
            }
             else if (coordenadaX > 0 && coordenadaY < 0)
            {
                Console.WriteLine("¡El enemigo está al sureste!");
            }
        }
    } 
}