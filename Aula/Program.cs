using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente("igor", 112, 123, 200);
            ContaCorrente contaDois = new ContaCorrente("Joao",11100, 22200,0);

            conta.transferir(contaDois, 100);

            ContaCorrente[] cc = { conta, contaDois};

            foreach(ContaCorrente contas in cc)
            {
                Console.WriteLine(contas.ToString());
            }


        }
    }
}
