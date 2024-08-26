/*
Objetivos:
-Toma un número como input/entrada desde la consola.
- Se muestra en pantala la palabra «Tick» si el número es par, «Tock» si el número es impar.
*/
using System;
namespace RepairingTheClockTower
{
    public class Program
    {
        public static void Main(string[]args)
        {
            // Entrada de datos
            Console.WriteLine("Reparando el reloj");
            Console.WriteLine("-------------------");
            Console.Write("Ingresa un número: ");
            string? inputDelUsuario = Console.ReadLine();
            int numeroIngresado = Convert.ToInt32(inputDelUsuario);
            // Condicional
            if (numeroIngresado % 2 == 0)
            {
                Console.WriteLine("El número es par"); // Todo número divisible entre 2 es par
                Console.WriteLine("Tick"); // Imprime en pantalla 'Tick" si el número es par
            }
            else
            {
                Console.WriteLine("El número es impar");
                Console.WriteLine("Tock"); 
            }    
        }
    }
}