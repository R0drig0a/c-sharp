using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComBancoDeDados
{
    internal class Sistema
    {
        public void Executar()
        {
            int menu;
            do
            {
                Console.WriteLine("""
                    1 -  Séries
                    2 - Times
                    3 - Sair
                    """);
                Console.WriteLine("Digite o que precisa do menu: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case 1: new ExercicioSeries().Executar(); break;
                    case 2: new ExercicioTimes().Executar(); break;
                }
            } while (menu != 3);
        }

    }
}
