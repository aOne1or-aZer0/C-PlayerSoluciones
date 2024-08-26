/* */
namespace TheDefenseOfConsolas
{
  public class Program
  {
    public static void Main(string []args)
    {
      Console.Title = "The Defense Of Consolas";
      Console.WriteLine("CIUDAD CONSOLAS - SISTEMA DE DEFENSA MAGICA");
      Console.WriteLine("--------------------------------------------");
     
      Console.Write("Ingresa el numero de la fila objetivo (1-8): ");
      string inputNumeroFila = Console.ReadLine();
      byte numeroFila = Convert.ToByte(inputNumeroFila);

      Console.Write("Ingresa el numero de la columna objetivo (1-8): ");
      string inputNumeroColumna = Console.ReadLine();
      byte numeroColumna = Convert.ToByte(inputNumeroColumna);

      Console.WriteLine("Presiona cualquier tecla para desplegar el escuadron");
      Console.ReadKey(true);
      Console.Beep(440, 1000);
    }
  }
    
}

