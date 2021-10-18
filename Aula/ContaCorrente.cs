using System;
class ContaCorrente
{

    private string titular;
    private int agencia;
    private int numero;
    private double saldo;
    
    
    public void setTitular(string titular)
    {
        this.titular = titular;
    }

    public string getTitular()
    {
        return this.titular;
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


}