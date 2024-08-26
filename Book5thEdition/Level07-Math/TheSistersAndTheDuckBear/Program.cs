/* En el siguiente programa se desarrolla el desafio de la 
 * pagina 56 del libro The C# Player's Guide*/
namespace TheSistersAndTheDuckBear
{
  public class Program
  {
    public static void Main (string []args)
    {
      Console.WriteLine("Ingresa el numero de huevos de chocolate recolectados ese dia");
      string inputUsuario = Console.ReadLine();
      int huevosDeChocolate = Convert.ToInt32(inputUsuario);
      // Reciben equitativamente el mismo numero de huevos
      double huevosHermanas = huevosDeChocolate / 4.0;
      Console.WriteLine("Las hermanas (4) deben recibir " + huevosHermanas + " en total");
      // El resto lo recibe la mascota
      int huevosOsoPato = huevosDeChocolate % 4;
      Console.WriteLine("Sobran " + huevosOsoPato + " para el osopato");
    }
  }
}


