/*
Objetivos:
- Crear 2 métodos para usarlos en los programas de consola previos para mejorarlos
*/
namespace TakingaNumber
{
    public class Program
    {
        public void MostrarMensaje()
        {
            Console.Title = "Metodos";
            Console.WriteLine("METODOS");
            Console.WriteLine("--------");
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.MostrarMensaje();
        }
    }

   

}