/* La importancia de comentar bien tu codigo.
La mecanica es facil el desafio es hacer que estos sean utiles*/
namespace GoodComments
{
  public class Program
  {
    public static void Main(string[]args)
    {
      // Es buena practica declarar las variables dentro del bloque o metodo donde se usan
      string DescripcionObjeto3 = "De La Muerte";
      string DescripcionObjeto4 = "3000";

      Console.WriteLine("¿De que tipo de 'cosa' estamos hablando?");
      string DescripcionObjeto1 = Console.ReadLine();
      Console.WriteLine("¿Como lo describirias? ¿Grande? ¿Andrajoso? ¿Azul?");
      string DescripcionObjeto2 = Console.ReadLine();
      Console.WriteLine(DescripcionObjeto1 + " " + DescripcionObjeto2 + " " + DescripcionObjeto3 + " " + DescripcionObjeto4 + "!");
    }
  }
}


