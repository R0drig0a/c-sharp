using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoClasses
{
    class ExecutorRetangulo
    {
        public void Executar()
        {
            CalcularArea();
            CalcularPerimetro();
        }

        private void CalcularArea()
        {
            Console.WriteLine("Digte a altura do retangulo: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digte a largura do retangulo: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            double area = comprimento * largura;

            Console.WriteLine("A area do retangulo é: " + area);
        }

        private void CalcularPerimetro()
        {

        }
    }
}
