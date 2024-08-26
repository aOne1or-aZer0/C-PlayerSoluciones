/*Este programa usa los 14 tipos de variables descritos*/
namespace TheVariableShop
{
  public class Program
  {
   public static void Main(string[]args)
   {
    // Les asigne el valor maximo que pueden tener las variables de tipo entero.
    int intMaximoValor = 2_147_483_647;
    short shortMaximoValor = 32_767;
    long longMaximoValor = 9_223_372_036_854_775_807;
    byte byteMaximoValor = 255;
    sbyte sbyteMaximoValor = 127;
    uint uintMaximoValor = 4_294_967_295;
    ushort ushortMaximoValor = 65_535;
    ulong ulongMaximoValor = 18_446_744_073_709_551_615;
    // Los caracteres usan comillas simples y las cadenas comillas dobles.
    char valorCaracterDeTexto = 'b';
    string valorCadenaDeTexto = "Variable... ";
    // Para los punto flotante asigne igualmente el valor maximmo para su tipo.
    float valorFloat = 3.1415168f;
    double valorDouble = 5.1234567890123456;
    decimal valorDecimal = 94.12345678901234567890123456789m;
    //Los valores booleanos se sobreentienden
    bool valorBooleanoTrue = true;
    bool valorBooleanoFalse = false;
    //Por ultimo se imprimen en pantalla los valores asignados
    Console.WriteLine("Bienvenido a la tienda de Variables ¿Que deseas comprar?");
    Console.WriteLine("1.int: " + intMaximoValor);
    Console.WriteLine("2.short: " + shortMaximoValor);
    Console.WriteLine("3.long: " + longMaximoValor);
    Console.WriteLine("4.byte: " + byteMaximoValor);
    Console.WriteLine("5.sbyte: " + sbyteMaximoValor);
    Console.WriteLine("6.uint: " + uintMaximoValor);
    Console.WriteLine("7.ushort: " + ushortMaximoValor);
    Console.WriteLine("8.ulong: " + ulongMaximoValor);

    Console.WriteLine("9.char: " + valorCaracterDeTexto);
    Console.WriteLine("10.string: " + valorCadenaDeTexto);

    Console.WriteLine("11.float: " + valorFloat);
    Console.WriteLine("12.double: " + valorDouble);
    Console.WriteLine("13.decimal: " + valorDecimal);

    Console.WriteLine("14.bool1: " + valorBooleanoTrue);
    Console.WriteLine("15.bool2: " + valorBooleanoFalse);

   }
  }
}
