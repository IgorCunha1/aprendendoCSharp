using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente igor = new Cliente();
            igor.setNome("Igor");
            igor.setCpf("076.252.694-77");
            igor.setProfissao("DEV");
            ContaCorrente conta = new ContaCorrente(igor, 111,222,100.00);

            Console.WriteLine(conta.getTitular());

        }
    }
}
