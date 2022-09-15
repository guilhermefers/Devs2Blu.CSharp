using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão.Aulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exc04();
        }


        static void Exc04()
        {
            int alunos, media;
            int soma = 0;
            int contador = 1;
            Random rd = new Random();

            Console.WriteLine("Informe a Quantidade de Alunos: ");
            Int32.TryParse(Console.ReadLine(), out alunos);

            while (alunos <= 0)
            {
                Console.WriteLine("Não Há Alunos, Informe a Quantidade Novamente");
                Int32.TryParse(Console.ReadLine(), out alunos);
            }
            while (contador <= alunos)
            {
                int nota =  rd.Next(5, 10); // CTRL RR = Rename de Variáveis ou F2 (Ele disse kkkk)
                Console.WriteLine($"Nota {contador}: {nota}");
                // Int32.TryParse(Console.ReadLine(), out notas);
                soma += nota;
                contador++;
            }
            media = soma / alunos;
            Console.WriteLine($"A Media da Turma é {media}");
        }

        static void Exe01()
        {
            int contador = 1;

            while (contador <= 100)
            {
                if (contador % 2 != 0) // !(numero - numero/2*2 == 0)) // % Resto da Divisão
                {
                    Console.WriteLine($"{contador}, ");
                }
                contador++;
            }
        }

    }
}
