using System;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (hora >= 18 && hora < 24)
            {
                Console.WriteLine("Boa noite!");
            }
            else
            {
                Console.WriteLine("Hora inválida!");
            }
        }
    }
}

/* No novo código, removemos as verificações (hora >= 12) e (hora >= 18) dos blocos else if, 
pois estas verificações são desnecessárias. Se hora não é menor que 12, automaticamente 
é maior ou igual a 12, e se não é menor que 18, automaticamente é maior ou igual a 18.
Portanto, o comportamento do programa permanece o mesmo e a leitura do código fica mais limpa.

Resumindo, ambos os códigos funcionam da mesma maneira e apresentam os mesmos resultados para as mesmas entradas.*/



/*

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (hora < 24)
            {
                Console.WriteLine("Boa noite!");
            }
            else
            {
                Console.WriteLine("Hora inválida!");
            }

*/
