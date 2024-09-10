/*
Objetivos:
- Crear 2 métodos para usarlos en uno de los programas de consola previos para mejorarlo.
*/
namespace TakingaNumber
{
    public class Program 
    {
        public void MostrarMensaje()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "Metodos";
            Console.WriteLine("METODOS");
            Console.WriteLine("--------");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public int PedirUnNumero(string texto)
        {
            Console.Write(texto);
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero; 
        }

        public int EvaluarRangoDelNumero(string texto, int min, int max) // Metodo para evaluar el rango de los números 
        {
            while (true)
            {
                int numero = PedirUnNumero(texto);
                if (numero >= min && numero <= max)
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Número fuera de rango."); // En el caso de que el numero ingresado sea menor a 0 o mayor a 100, muestra el mensaje 
                }

            }
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.MostrarMensaje();
            int numeroPiloto = program.EvaluarRangoDelNumero("Piloto, ingresa un número entre 0 y 100: ", 0, 100 ); // Se llama al metodo y se pasan los parametros 0 y 100
            while(true)
            {
                int numeroCazador = program.PedirUnNumero("Cazador, adivina el número... ");
                if (numeroCazador < numeroPiloto) // Condicionales. 
                {
                    Console.WriteLine($"{numeroCazador} es muy bajo");
                }
                else if (numeroCazador > numeroPiloto) 
                {
                    Console.WriteLine($"{numeroCazador} es muy alto");
                }
                else 
                {
                    Console.WriteLine("¿Adivinaste el número!"); // Sale del programa al cumplirse la condición
                    break;
                }
            }   
        }
    }
}