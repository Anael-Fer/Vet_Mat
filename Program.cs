using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace atv14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //14) Faça um programa para corrigir as provas de múltipla escolha de uma turma. Cada prova tem 10 questões e cada
            //questão vale 10 pontos.O primeiro conjunto de dados a ser lido(teclado) é o gabarito da prova.Os outros dados são as
            //respostas dadas por cada um dos 30 alunos da turma.Armazene o gabarito em um vetor e armazene as respostas dos
            //alunos em uma matriz 30x10(30 linhas e 10 colunas).
            //Calcule e mostre:
            //• A porcentagem de aprovação da turma, considerando que a nota mínima para aprovação é de 60 pontos.
            //• Imprima a quantidade de alunos que obtiveram nota acima da média da turma.


            char[] gabarito = new char[10];
            char[,] respostas = new char[30, 10];
            int alunosAprovados = 0;
            int totalAlunos = 30;

            Console.WriteLine("Digite o gabarito da prova (10 questões):");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Questão {i + 1}: ");
                gabarito[i] = char.Parse(Console.ReadLine().ToUpper());
            }

            for (int i = 0; i < totalAlunos; i++)
            {
                Console.WriteLine($"\nDigite as respostas do aluno {i + 1}:");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"Resposta da questão {j + 1}: ");
                    respostas[i, j] = char.Parse(Console.ReadLine().ToUpper());
                }
            }

            for (int i = 0; i < totalAlunos; i++)
            {
                int nota = 0;

                for (int j = 0; j < 10; j++)
                {
                    if (respostas[i, j] == gabarito[j])
                        nota += 10;
                }

                if (nota >= 60)
                    alunosAprovados++;
            }

            double porcentagemAprovacao = alunosAprovados / totalAlunos * 100;
            Console.WriteLine($"Porcentagem de aprovação da turma: {porcentagemAprovacao}%");

            Console.ReadLine();

        }
    }
}
