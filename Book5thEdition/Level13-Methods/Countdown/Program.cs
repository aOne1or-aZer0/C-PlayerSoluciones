/*
Objetivos:
- Usar la recursión
- El código debe contar de 10 hasta 1
*/
namespace Countdown
{
    public class Program
    {
        public void MostrarBanner()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
                ____                            _            
               / __ \___  _______  ____________(_)____  ____ 
              / /_/ / _ \/ ___/ / / / ___/ ___/ // __ \/ __ \
             / _, _/  __/ /__/ /_/ / /  (__  ) // /_/ / / / /
            /_/ |_|\___/\___/\__,_/_/  /____/_/ \____/_/ /_/      
            ");
            Console.WriteLine("CUENTA REGRESIVA");
            Console.WriteLine("-----------------");
            Console.ForegroundColor = ConsoleColor.Gray; 
            Console.WriteLine();
        } 
        public int CuentaRegresiva(int numero = 10) 
        {
            if (numero <= 0) return 0;
            {
                Console.WriteLine(numero);
                return CuentaRegresiva(numero-1);
            }
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.MostrarBanner();
            program.CuentaRegresiva();  
        }
    }
}