/*Objetivos:
-Construir un programa que permita a un usuario, el piloto, introducir un número.
- Si el número es superior a 100 o inferior a 0, seguir preguntando.
- Borra la pantalla una vez que el programa haya recogido un buen número.
- Pide a un segundo usuario, el cazador, que adivine números.
- Indicar si el número ingresado es demasiado alto, demasiado bajo o acertó.
- El bucle sigue hasta que acierten y se termina el programa.
*/
using System;
namespace TheProtoType
{
    public class MyClass
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("EL PROTOTIPO");
            Console.WriteLine("--------------");
            // Declamos las varibles fuera del bucle while para que sean accesibles en todo el código
            int numeroPiloto;
            int numeroCazador;
          
            while (true)
            {
                  // While anidado que sigue preguntando por un número hasta que se ingrese uno válido
                while (true)
                {
                    Console.Write("Piloto, ingresa un número entre 0 y 100: ");
                    string? inputPiloto = Console.ReadLine();
                    numeroPiloto = Convert.ToInt32(inputPiloto);

                    if (numeroPiloto < 0 || numeroPiloto > 100)
                    {
                        continue;

                    }
                    else
                    {
                        break; // Si la entrada es válida se sale del bucle interno
                    }
                    
                }

                Console.Clear();
                Console.WriteLine("Cazador, adivina el número.");
                Console.Write("¿Cual es tu próximo pronóstico?: ");
                string? inputCazador = Console.ReadLine();
                numeroCazador = Convert.ToInt32(inputCazador);

                if (numeroCazador > numeroPiloto)
                {
                    Console.WriteLine($"{numeroCazador} es muy alto");
                }
                else if (numeroCazador < numeroPiloto) 
                {
                    Console.WriteLine($"{numeroCazador} es muy bajo");
                }
                else // Este bloque maneja el caso en el que se adivina correctamente el número
                {
                    Console.WriteLine("¿Adivinaste el número!");
                    break;
                }
            }
            
        }
    }
}