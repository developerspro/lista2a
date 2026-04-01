using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * 
5. Conversor de Temperatura (Celsius para Fahrenheit)
Descrição: Solicite uma temperatura em Celsius e converta para Fahrenheit.
Fórmula: F = C * 9/5 + 32
 * 
 * 
 */
namespace CA0104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Termometro term = new Termometro();
            term.solicitarTempCelsius();
            term.converter();
            term.exibirConversao();
        }
    }
}
