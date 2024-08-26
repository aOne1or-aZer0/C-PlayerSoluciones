namespace TheDominionOfKings
{
  public class Program
  {
    public static void Main(string []args)
    {
      Console.WriteLine("¡El Dominio de Los Reyes!");
      Console.WriteLine("Cada estado vale 1 punto, cada ducado 3 puntos, y cada provincia 6 puntos");
      // Datos de entrada
      Console.WriteLine("INFORMACION DE LOS TERRITORIOS");
      Console.WriteLine("------------------------------");
      Console.WriteLine("Ingresa el numero de estados: ");
      string inputNumeroEstados = Console.ReadLine();
      int numeroEstados = Convert.ToInt32(inputNumeroEstados);

      Console.WriteLine("Ingresa el numero de ducados: ");
      string inputNumeroDucados = Console.ReadLine();
      int numeroDucados = Convert.ToInt32(inputNumeroDucados); 

      Console.WriteLine("Ingresa el numero de provincias: ");
      string inputNumeroProvincias = Console.ReadLine();
      int numeroProvincias = Convert.ToInt32(inputNumeroProvincias);
      // Operaciones
      int puntosEstados = numeroEstados * 1;
      int puntosDucados = numeroDucados * 3;
      int puntosProvincias = numeroProvincias * 6;
      int puntosEnTotal = puntosEstados + puntosDucados + puntosProvincias;
      Console.WriteLine("Ha obtenido un total de: " + puntosEnTotal + " puntos, ¡Felicidades su majestad!");
    }
  } 
}
