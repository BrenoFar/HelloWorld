using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Digite o primeiro valor");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            float n2 = float.Parse(Console.ReadLine());
            float result = n1 * n2;
            Console.WriteLine("Seu nome é " + name);
            Console.WriteLine("O valor da multiplicação é " + result );
            Console.ReadLine();



        }
    }
}
