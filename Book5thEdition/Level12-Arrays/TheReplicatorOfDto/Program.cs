/*
Objetivos:
• Make a program that creates an array of length 5.
• Ask the user for five numbers and put them in the array.
• Make a second array of length 5.
• Use a loop to copy the values out of the original array and into the new one.
• Display the contents of both arrays one at a time to illustrate that the Replicator of D’To works
again.
*/
using System;
namespace TheReplicatorOfDto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Replicator";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("EL REPLICADOR DE D'TO");
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.Gray;
        
            int[] inputArreglo = new int[5]; // Array de 5 elementos. NOTA: los indices empiezan en 0..
            int[] segundoArreglo = new int[5]; // Segundo Array

            Console.WriteLine("Entrada de datos (5 números enteros)");
            for (int contadorIngresoDeDatos = 0; contadorIngresoDeDatos < 5; contadorIngresoDeDatos++) // se itera 5 veces el mensaje para ingresar los números
            {
                Console.WriteLine("Ingresa el número para el indice " + contadorIngresoDeDatos);
                inputArreglo[contadorIngresoDeDatos] = Convert.ToInt32(Console.ReadLine());
            }

            // Copiar valores de inputArreglo a segundoArreglo
            for (int contadorCopiarValores = 0; contadorCopiarValores < 5; contadorCopiarValores++)
            {
                segundoArreglo[contadorCopiarValores] = inputArreglo[contadorCopiarValores];
            }

            // Imprimir los valores de los arrays
            Console.WriteLine("Valores del primer arreglo :");
            for (int i = 0; i < inputArreglo.Length; i++)
            {
                Console.WriteLine("Valor en el índice " + i + ": " + inputArreglo[i]);
            }
            Console.WriteLine(); // Un espacio de Línea
            Console.WriteLine("Valores de segundo arreglo:");
            for (int i = 0; i < segundoArreglo.Length; i++)
            {
                Console.WriteLine("Valor en el índice " + i + ": " + segundoArreglo[i]);
            }
    }   }
}