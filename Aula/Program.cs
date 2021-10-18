using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
             ContaCorrente conta = new ContaCorrente();

            conta.setTitular("Igor");
            conta.setSaldo(100.0);

            Console.WriteLine(conta.getTitular());

            conta.Sacar(10);

            Console.WriteLine(conta.getSaldo());

        }
    }
}
