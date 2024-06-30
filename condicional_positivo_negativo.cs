using System;
using System.ComponentModel.Design;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("Não negativo");
            }
            else if (numero > 0)
            {
                Console.WriteLine("Não negativo");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}