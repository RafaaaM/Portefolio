using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criar objeto do tipo caixa

            Caixa c1 = new Caixa();
            double resultado = c1.volume(12);
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
