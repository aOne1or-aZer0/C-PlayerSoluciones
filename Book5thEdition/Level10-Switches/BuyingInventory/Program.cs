/*Objetivos
- El programa debe mostrar un menú
- Pide al usuario que introduzca un número en el menú.
- Utilizando la información anterior, Se usa un switch para mostrar el costo del item.


*/
namespace BuyingInventory       
{
    public class Program
    {
        public static void Main(string[]args)
        {
        // Menú de items
            Console.WriteLine("TIENDA");
            Console.WriteLine("-------");
            Console.WriteLine("Los siguientes items estan disponibles");
            Console.WriteLine("1 - Cuerda");
            Console.WriteLine("2 - Antorchas");
            Console.WriteLine("3 - Equipo de escalada");
            Console.WriteLine("4 - Agua Limpia");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoa");
            Console.WriteLine("7 - Suministro de alimentos");
            // Entrada de datos
            Console.Write("¿De que número quieres ver el precio? ");
            string? respuesta = Console.ReadLine();
            int numeroEleccion = Convert.ToInt32(respuesta); // Conversion de tipo de dato
            // Se muestra el item según la entrada del usuario
            respuesta = numeroEleccion switch
            {
                1 => "10 de oro",
                2 => "15 de oro",
                3 => "25 de oro",
                4 => "1 de oro",
                5 => "20 de oro",
                6 => "200 de oro",
                7 => "1 de oro",
                _ => "Escoge un número de item disponible."
            };
            Console.WriteLine(respuesta);
        }
    }   
}