using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Ex2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //criar objeto do tipo pessoa
            Pessoa p1 = new Pessoa();

            Console.WriteLine(p1.altura);

            Pessoa p2 = new Pessoa("Jõao",1.85,"07-10-2005");

            Console.WriteLine("P2 " +p2.nome);
            Console.WriteLine("P1 " +p1.nome);
        }
    }
}
