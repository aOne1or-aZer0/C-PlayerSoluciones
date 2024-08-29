namespace DiscountedInventory
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
            Console.WriteLine("7 - Suministro de Alimentos");
            // Entrada de datos
            Console.Write("¿De que número quieres ver el precio? ");
            int numeroArticulo = Convert.ToInt32(Console.ReadLine()); // Conversion de tipo de dato

            string? articulo = numeroArticulo switch
                {
                    1 => "Cuerda",
                    2 => "Antorchas",
                    3 => "Equipo de escalada",
                    4 => "Agua Limpia",
                    5 => "Machete",
                    6 => "Canoa",
                    7 => "Suministro de Alimentos",
                    _ => "Escoge un número de item disponible"
                };
            double precio = articulo switch
            {  
                   "Cuerda" => 10,
                   "Antorchas" => 15,
                   "Equipo de escalada" => 25,
                   "Agua Limpia" => 1,
                   "Machete" => 20,
                   "Canoa" => 200,
                   "Suministro de Alimentos" => 1

            };
            Console.Write("¿Cual es tu nombre?: ");
            string? nombreUsuario = Console.ReadLine();
            if (nombreUsuario == "JV")
            {
                precio = precio /2;
            }
            Console.WriteLine("Hola JV, tienes 50% de descuento en los artículos de la tienda");
            Console.WriteLine($"{articulo} cuesta {precio} de oro ");
        }
    }
}