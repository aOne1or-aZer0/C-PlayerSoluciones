/*
Objetivos:
- Usar el código proporcionado en el libro y refactorizarlos a ciclos 'foreach'
*/
using System;
namespace TheLawsofFreach
{
 public class Program
 {
    public static void Main(string[]args)
    {

        /* 
        int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

        int currentSmallest = int.MaxValue; // Start higher than anything in the array.
        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] < currentSmallest)
                currentSmallest = array[index];WW
        }

        Console.WriteLine(currentSmallest);
        */

        /*
        int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

        int total = 0;
        for (int index = 0; index < array.Length; index++)
            total += array[index];
        float average = (float)total / array.Length;
        Console.WriteLine(average);
        */
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("LAS LEYES DE FREACH");
        Console.WriteLine("-------------------");
        Console.ForegroundColor = ConsoleColor.Gray;

        int[] nuevoArreglo = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90}; 
        int datoMasGrande = int.MaxValue;
        int indice = 0; // Variable para los indices 0-9
     

        foreach (int dato in nuevoArreglo) 
        {
            Console.WriteLine("Indice " + indice + ": " + dato);
            if (dato < datoMasGrande) // La condición evalua cual es el valor más pequeño dentro del arreglo
            {
                datoMasGrande = dato;
            }
            indice ++; // Incrementa el indice en cada iteración del ciclo
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("El valor más pequeño dentro del array es : " + datoMasGrande);
        Console.ForegroundColor = ConsoleColor.Gray;

        int total = 0;
        foreach (int dato in nuevoArreglo)
        {
            total += dato; // Se acumula cada dato del array
        }
        double promedioValoresArray = (double) total / nuevoArreglo.Length;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("El promedio de valores dentro del array es: " + promedioValoresArray);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
 }   
}