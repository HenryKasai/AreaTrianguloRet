using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados em metros de seu triângulo retângulo.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Base:"); 
            Console.ForegroundColor = ConsoleColor.Red;
            string basey = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Altura:");
            Console.ForegroundColor = ConsoleColor.Red;
            string altura = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            decimal base2 = Convert.ToDecimal(basey);
            decimal altura2 = Convert.ToDecimal(altura);
            decimal result = base2 * altura2;
            decimal resultado = result / 2;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("A área do seu triângulo retângulo é " + resultado + " metros.");
            Console.ForegroundColor = ConsoleColor.Gray;
            

        }
    }
}
