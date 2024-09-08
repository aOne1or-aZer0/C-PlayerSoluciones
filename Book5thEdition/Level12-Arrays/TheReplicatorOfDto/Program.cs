/*
Objetivos:
- El programa crea un array de longitud 5
- Pide al usuario cinco números y los pone en el array
- Se crea un segundo array de longitud 5
- Un bucle  copia los valores del array original en el nuevo.
- Muestra el contenido de ambos arrays de uno en uni para mostrar que si funciona el código
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