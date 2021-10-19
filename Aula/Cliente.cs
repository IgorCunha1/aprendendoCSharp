using System;
using System.Collections.Generic;
using System.Text;

namespace Aula
{
    public class Cliente
    {
        private string nome;
        private string cpf;
        private string profissao;
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public void setProfissao(string profissao)
        {
            this.profissao = profissao;
        }

        public string getProfissao()
        {
            return this.profissao;
        }

        public override string ToString()
        {
            return "Nome: " + this.nome + " CPF: " + this.cpf + " Profissao: " + this.profissao;
        }

    }

    
}
