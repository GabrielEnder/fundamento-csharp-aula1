
using System.Linq;
using System.Collections.Generic;
using System;

namespace dotnetcore
{
    class Program
    {
        // Exercício 1:
        // - Fazer a média de notas dos dois alunos (Zuqui, Bronza) e imprimir no Console.WriteLine();
        // - Imprimir no console para cada aluno
        //      - Nome do aluno
        //      - Caso média maior ou igual 7:
        //          - Passou no ano letivo
        //          - Não passou no ano letivo
        // Requisítos:
        // - Criar um método "CalcularMedia", onde a entrada de parâmetros seja as notas e o retorno seja a média em float
        // - Utilizar For ou Foreach


        // Exercício 2:
        // - Fazer um programa que cadastre pessoas, contendo nome e idade;
        // - Imprimir a media de idade das pessoas
        // - Imprimir o nome e idade da pessoa mais velha
        // - Imprimir o nome e idade da pessoa mais nova
        // - Imprimir a quantidade de pessoas com maior idade
        // Requisítos:
        // - Utilizar List (Avg, Max, Min, Where)
        // - Utilizar Classe Pessoa
        static void Main(string[] args)
        {
            var xNomeAlunoA = "Jonas";
            var xNomeAlunoB = "Sueli";

            var xNotasAlunoA = new List<float>() {8, 6, 10, 7};
            var xNotasAlunoB = new List<float>() {4, 6, 6, 9};

            var xMediaAlunoA = CalcularMedia(xNotasAlunoA);
            Console.WriteLine("Com a Media: " + xMediaAlunoA);
            PassouOuReprovou(xMediaAlunoA, xNomeAlunoA);

            var xMediaAlunoB = CalcularMedia(xNotasAlunoB);
            Console.WriteLine("Com a Media: " + xMediaAlunoB);
            PassouOuReprovou(xMediaAlunoB, xNomeAlunoB);
        }

        

        private static float CalcularMedia(List<float> Notas)
        {
            return Notas.Average();
        }
        private static void PassouOuReprovou(float Media, string NomeAluno)
        {
            if (Media >= 7)
            {
                Console.WriteLine(NomeAluno + " Passou de ano");
            }else{
                Console.WriteLine(NomeAluno + " Reprovou de ano");
            }
        }
    }
}
