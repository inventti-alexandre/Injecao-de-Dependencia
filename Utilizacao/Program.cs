using InjecaoDependencia;
using System;
using Utilizacao.Models;

namespace Utilizacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste1 = DI.Instancia.Resolver<Teste1>();
            var teste2 = DI.Instancia.Resolver<Teste2>();

            teste1.Testar();
            teste2.Testar();

            Console.Write("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
