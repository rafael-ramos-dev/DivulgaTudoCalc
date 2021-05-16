using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivulgaTudoCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int pessoas = 30;
            int pessoasVisualizam = 100;
            decimal valorInicial = 1;
            decimal valorFinal;

            int pessoasTransicao;

            int clicks = 12;
            int clicksFinal = 20;
            int views = 120;
            int viewsFinal;


            //regra de 3 para calcular valor total necessáro para as 100 pessoas
            //valorFinal = (valorInicial * pessoasVisualizam) / pessoas;

            


            //Console.WriteLine("São necessários " + valorFinal + " para que cem pessoas visualizem");
            //Console.WriteLine();

            //if (pessoasVisualizam == 100)
            //{
            //    clicks = 12;
            //    Console.WriteLine("O número de clicks é de: " + clicks);
            //}

            //Console.ReadKey();


            //regra de 3 para calcular a quantidade de pessoas necessárias para que sejam efetuados os 20 cliques
            //pessoas = pessoasVisualizam;

            //pessoasVisualizam = (pessoas * clicksFinal) / clicks ;


            //Console.WriteLine("O número de pessoas que visualizam para vinte cliques é de: " + pessoasVisualizam);
            //Console.ReadKey();


            // A cada 166 pessoas (pessoasVisualizam) eu tenho 3 compartilhamentos com 40 view em cada
            // somando o total de 120 visualizações

            //views = 120;


            // replicação para mais 3 pessoas (isso será refeito em um ciclo de 2 vezes)

            for (int teste = 0; teste < 4; teste++)
            {
                //regra de 3 para calcular valor total necessáro para as 100 pessoas
                valorFinal = (valorInicial * pessoasVisualizam) / pessoas;


                //regra de 3 para calcular a quantidade de pessoas necessárias para que sejam efetuados os 20 cliques
                pessoasTransicao = pessoasVisualizam;

                clicksFinal = (pessoasTransicao * clicksFinal) / clicks;

                Console.WriteLine("São necessários " + valorFinal + " para que cem pessoas visualizem");
                Console.WriteLine("O número de pessoas que visualizam para vinte cliques é de: " + clicksFinal);
                Console.WriteLine("Os Views são de: " + views);
                Console.WriteLine();
                Console.WriteLine();

                views += views;

                Console.WriteLine("Interação: " + teste);
                Console.ReadKey();
            }


        }
    }
}
