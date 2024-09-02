/*Objetivos:
- El programa debe recorrer los valores entre 1 y 100 y mostrar el tipo 
- Cambia el color de la salida en función del tipo. (Por ejemplo, rojo para Fuego, amarillo para
Eléctrico, y azul para Eléctrico y Fuego)
*/
using System;
namespace TheMagicCannon
{
    public class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("EL CAÑON MÁGICO");
            Console.WriteLine("----------------");
            // Bucle
            for (int contador = 1; contador <= 100; contador++)
            {
                // Se declaran los condicionales de la más especifica a la más general
                if (contador % 3 == 0 && contador % 5 == 0) // Multiplos de 3 y 15
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{contador}: Fuego y Electrico");
                }
                else if (contador % 5 == 0) // Multiplos de 5
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{contador}: Amarillo");
                }
                 else if (contador % 3 == 0) // Multiplos de 3
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{contador}: Fuego");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{contador}: Normal"); // 
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }     
    }   
}