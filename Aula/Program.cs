using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente("igor", 112, 123, 123.0);
            ContaCorrente contaDois = new ContaCorrente("Joao", 112, 123, 123.99);
            ContaCorrente contaTres = new ContaCorrente("Maria", 112, 123, 123.99);
            ContaCorrente contaQuatro = new ContaCorrente("Jose", 112, 123, 123.99);
            ContaCorrente contaCinco = new ContaCorrente("Igor", 112, 123, 123.99);

            ContaCorrente[] cc = { conta, contaDois, contaTres, contaQuatro, contaCinco };

            foreach(ContaCorrente contas in cc)
            {
                System.Console.Write(contas.ToString());
            }


        }
    }
}
