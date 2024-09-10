/*
Objetivos:
- Crear 2 métodos para usarlos en los programas de consola previos para mejorarlos
*/
namespace TakingaNumber
{
    public class Program
    {
        public static void MostrarMensaje()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "Metodos";
            Console.WriteLine("METODOS");
            Console.WriteLine("--------");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        
        public static void Main(string[] args)
        {
            MostrarMensaje();
        }
    }

   

}