using System;
using Aula;


class ContaCorrente
{
    public Cliente titular;
    private int agencia;
    private int numero;
    private double saldo;

    public ContaCorrente()
    {

    }

    public ContaCorrente(Cliente titular, int agencia, int numero, double saldo)
    {
        this.titular = titular;
        this.agencia = agencia;
        this.numero = numero;
        this.saldo = saldo;

    }

    public override string ToString()
    {
        return "Titular: " + this.titular + " Agencia: " + this.agencia + " Numero: " + this.numero + " Saldo = " + this.saldo;
    }

    public void setTitular(Cliente titular)
    {
        this.titular = titular;
    }

    public string getTitular()
    {
        return this.titular.ToString();
    }

    public void setAgencia(int agencia)
    {
        this.agencia = agencia;
    }
    public int getAgencia()
    {
        return this.agencia;
    }
    
    public void setNumero(int numero)
    {
        this.numero = numero;
    }

    public int getNumero()
    {
        return this.numero;
    }

    public void setSaldo(double saldo)
    {
        this.saldo = saldo;
    }

    public double getSaldo()
    {
        return this.saldo;
    }
    public void Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            Console.WriteLine("Saldo menor do que o valor a ser sacado");
        }
        else
        {
            this.saldo -= valor;
        }
        
    }

    public void Depositar(double valor)
    {
        if(valor <= 0)
        {
            Console.WriteLine("Deposite um valor maior que 0");
        }
        else
        {
            this.saldo += valor;
        }
    }

    public void transferir(ContaCorrente contaDestino, double valor)
    {
        if (this.saldo >= valor)
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
        }
        else
        {
            Console.WriteLine("Valor maior do que o saldo em conta.");
        }
    }




}