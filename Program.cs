using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados de seu triângulo retângulo (todos precisam estar na mesma unidade de medida).");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Base:"); 
            Console.ForegroundColor = ConsoleColor.Red;
            string basey = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Altura:");
            Console.ForegroundColor = ConsoleColor.Red;
            string altura = Console.ReadLine();

            double base2 = Convert.ToDouble(basey);
            double altura2 = Convert.ToDouble(altura);
            double result = base2 * altura2;
            double resultado = result / 2;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("A área do seu triângulo retângulo é " + resultado);
            Console.ForegroundColor = ConsoleColor.Gray;
            

        }
    }
}
