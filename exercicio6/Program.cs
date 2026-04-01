using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dobro db = new Dobro();
            db.solicitarNumero();
            db.calcularDobro();
            db.mostrarResultado();
        }
    }
}
