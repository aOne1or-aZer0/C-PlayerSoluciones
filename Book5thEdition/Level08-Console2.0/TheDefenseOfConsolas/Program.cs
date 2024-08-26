/*Objetivos: 
Preguntar al usuario por la fila y columna objetivo.
- Calcular las filas y columnas.
- Mostrar las instrucciones de despliegue en un color diferente.
- Cambiar el título de la ventana.
- Reproducir un sonido con Console.Beep() al final.
*/
namespace TheDefenseOfConsolas
{
  public class Program
  {
    public static void Main(string []args)
    {
      Console.Title = "The Defense Of Consolas";
      Console.WriteLine("CIUDAD CONSOLAS - SISTEMA DE DEFENSA MAGICA");
      Console.WriteLine("--------------------------------------------");
     // Entrada de datos
      Console.Write("Ingresa el numero de la fila objetivo (1-8): ");
      string inputFila = Console.ReadLine();
      int fila = Convert.ToInt32(inputFila);

      Console.Write("Ingresa el numero de la columna objetivo (1-8): ");
      string inputColumna = Console.ReadLine();
      int columna = Convert.ToInt32(inputColumna);
      // Cambia el color del texto de la consola
      Console.ForegroundColor = ConsoleColor.Green;
      // Imprime en pantalla las instrucciones
      Console.WriteLine("Presiona cualquier tecla para desplegar el escuadron...");
      Console.ReadKey(true);
      Console.WriteLine($"{fila}, {columna - 1}");
      Console.WriteLine($"{fila - 1}, {columna}");
      Console.WriteLine($"{fila}, {columna + 1}");
      Console.WriteLine($"{fila + 1}, {columna}");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Beep(900, 300);
    }
  }
}

