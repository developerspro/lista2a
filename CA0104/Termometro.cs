using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0104
{
     class Termometro
    {
        public double celsius;
        public double fahrenheit;

        public void solicitarTempCelsius()
        {
            Console.WriteLine("Digite a temperatura em Celsius");
            celsius = double.Parse(Console.ReadLine());
        }

        public void converter()
        {
            //Fórmula: F = C * 9/5 + 32
            fahrenheit = celsius * 9/5 + 32;
        }

        public void exibirConversao()
        {
            Console.WriteLine("Celsius:{0} em Fahrenheit:{1}",celsius,fahrenheit);
        }

    }
}
