using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversor conversor = new Conversor();
            conversor.solicitarDolar();
            conversor.solicitarReal();
            conversor.converter();
            conversor.mostrar();
            }
    }
}
