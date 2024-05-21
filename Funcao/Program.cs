using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            area(); 

            Console.ReadKey();
        }

            static void area()
        {

            Console.WriteLine("Escolha uma forma geométrica de acordo com os números: 1(Quadrado), 2(Retângulo), 3(Trapézio), 4(Losango): ");
            int forma = int.Parse(Console.ReadLine());

            switch (forma)
            {
                case 1:
                    Console.WriteLine("Digite a medida dos lados do quadrado: ");
                    int lado = int.Parse(Console.ReadLine());

                    int resultado = lado * lado;

                    Console.WriteLine("O resultado da área do quadrado é de " + resultado);
                    break;

                case 2:
                    Console.WriteLine("Digite a medida da base do retângulo: ");
                    int bas = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a medida da altura do retângulo: ");
                    int altura = int.Parse(Console.ReadLine());

                    int resultado2 = bas * altura;

                    Console.WriteLine("O resultado da área do retângulo é de " + resultado2);
                    break;

                case 3:
                    Console.WriteLine("Digite a medida da base maior do trapézio: ");
                    int basma = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a medida da base menor do trapézio: ");
                    int basme = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a medida da altura do trapézio: ");
                    int altura2 = int.Parse(Console.ReadLine());

                    int resultado3 = (basma + basme) * altura2 / 2;

                    Console.WriteLine("O resultado da área do trapézio é de " + resultado3);
                    break;

                case 4:
                    Console.WriteLine("Digite a medida da diagonal maior do trapézio: ");
                    int diagma = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a medida da diagonal menor do trapézio: ");
                    int diagme = int.Parse(Console.ReadLine());

                    int resultado4 = (diagma + diagme) / 2;

                    Console.WriteLine("O resultado da área do trapézio é de " + resultado4);
                    break;
            }
        }
    }
}