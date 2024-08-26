/*El siguiente programa calcula el area de un triangulo teniendo en cuenta
la formula Area = Base x Altura/2 */
namespace TheTriangleFarmer
{
  public class Program
  {
    public static void Main(string[]args)
    {
      Console.WriteLine("Calculadora de Area del Triangulo");
      Console.WriteLine("Ingresa la base del tringulo");
      string inputBase = Console.ReadLine();
      double baseTriangulo = Convert.ToDouble(inputBase);

      Console.WriteLine("Ingresa la altura del triangulo");
      string inputAltura = Console.ReadLine();
      double alturaTriangulo = Convert.ToDouble(inputAltura);

      double totalAreaTriangulo = (baseTriangulo*alturaTriangulo)/2;
      Console.WriteLine("El resultado es: " + totalAreaTriangulo);
    }
  }
}
