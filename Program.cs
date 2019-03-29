using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mesSelecionado;
            int diaSelecionado;
            int anonumero;
            string anoEscrito;
            int chaveAno1;
            int chaveAno2;
            int resultadoChavesAno;
            int anoSelecionado;
            int diaSemana;
            int somaDasChaves;
            int primeiroResultado;

            Console.Write("Ola professor, tudo bom?\nDesculpa pela demora para entregar o programa\n\nEsperamos que de tudo certo\n!_!");
            Console.ReadKey();

            Console.Clear();
            Console.Write("Digite o dia desejado: ");
            diaSelecionado = int.Parse(Console.ReadLine());
            Console.Write("Digite o mes desejado: ");
            mesSelecionado = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano desejado (4 digitos EX: 0020): ");
            anoEscrito = Console.ReadLine();

            //------------------CHAVE-DO-ANO------------------//

            anonumero = int.Parse(anoEscrito.Substring(2, 2));

            chaveAno1 = anonumero / 4;
            chaveAno2 = anonumero % 7;
            resultadoChavesAno = chaveAno1 + chaveAno2;
            anoSelecionado = resultadoChavesAno % 7;

            Console.WriteLine(anoSelecionado);
            //------------------------------------------------------//

 
            //------------------CHAVE-Da-SEMANA------------------//
            somaDasChaves = diaSelecionado + mesSelecionado + anoSelecionado;
            primeiroResultado = somaDasChaves / 7;
            diaSemana = somaDasChaves - (7 * primeiroResultado);
            

            //------------------CHAVE-DAS-SEMANAS------------------//

            if (diaSemana == 0)
            {
                Console.Write("Sábado");
            }
            else if (diaSemana == 1)
            {
                Console.Write("Domingo");
            }
            else if (diaSemana == 2)
            {
                Console.Write("Segunda-Feira");
            }
            else if (diaSemana == 3)
            {
                Console.Write("Terça-Feira");
            }
            else if (diaSemana == 4)
            {
                Console.Write("Quarta-Feira");
            }
            else if (diaSemana == 5)
            {
                Console.Write("Quinta-Feira");
            }
            else if (diaSemana == 6)
            {
                Console.Write("Sexta-Feira");
            }


            Console.ReadKey();

            //------------------------------------------------------//

            //------------------CHAVE-DO-MES------------------//
            switch (mesSelecionado)
            {
                case 1:
                    mesSelecionado = 1;
                    break;

                case 2:
                    mesSelecionado = 4;
                    break;

                case 3:
                    mesSelecionado = 4;
                    break;

                case 4:
                    mesSelecionado = 0;
                    break;

                case 5:
                    mesSelecionado = 2;
                    break;

                case 6:
                    mesSelecionado = 5;
                    break;

                case 7:
                    mesSelecionado = 0;
                    break;

                case 8:
                    mesSelecionado = 3;
                    break;

                case 9:
                    mesSelecionado = 6;
                    break;

                case 10:
                    mesSelecionado = 1;
                    break;

                case 11:
                    mesSelecionado = 4;
                    break;

                case 12:
                    mesSelecionado = 6;
                    break;
            }
            //------------------------------------------------------//
           
        }
    }
}
