/*Objetivos:

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
            int numeroPiloto;
            int numeroCazador;
            while (true)
            {
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
                        break;
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
                else
                {
                    Console.WriteLine("¿Adivinaste el número!");
                    break;
                }
            }
            
        }
    }
}