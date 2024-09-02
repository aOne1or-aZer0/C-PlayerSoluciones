/*Objetivos:


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
            for (int contador = 1; contador <= 100; contador++)
            {
                if (contador % 3 == 0 && contador % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{contador}: Fuego y Electrico");
                }
                else if (contador % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{contador}: Amarillo");
                }
                 else if (contador % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{contador}: Fuego");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{contador}: Normal");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }     
    }   
}