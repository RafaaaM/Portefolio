using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Ex3
{
    internal class Empregado
    {
        private string nome; //Nome da pessoa
        private int idade; //Idade da pessoa

        public Empregado()
        { }


        //construtor
        public Empregado(string _nome, int _idade)
        {
            nome = _nome;
            idade = _idade;
        }

        public void MostraDados()
        {
            Console.WriteLine("Nome:"+nome+ "\nIdade:"+idade);
1
        }


    }
    
}
