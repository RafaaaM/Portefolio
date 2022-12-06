using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Ex2
{
    internal class Pessoa
    {
        //atributos
        public string nome;

        public double altura;

        string data_nasc;

        //construtores

        public Pessoa()
        {
            nome = "";
            altura = 0;
            data_nasc = "";
           
        }
        public Pessoa(string nome, double altura, string data_nasc)
        {
            this.nome = nome;
            this.altura = altura;
            this.data_nasc = data_nasc;
        }
    }
}
