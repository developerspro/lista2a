using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora casio = new Calculadora();
            casio.media(casio.solicitarNota(), casio.solicitarNota(), casio.solicitarNota());
            casio.avaliar();
            Console.ReadKey();

        }
    }
}
