//Leer Texto
namespace ReadingText
{
  public class Program
  {
    public static void Main(string[]args)
    {
      string nombre;
      Console.WriteLine("El pan esta listo.");
      Console.WriteLine("¿Para quien es la orden?.");
      nombre = Console.ReadLine();
      Console.WriteLine("Nota: " + nombre + " tiene pan");
    }
  }
}

