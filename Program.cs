
using System.Linq;
using System.Collections.Generic;
using System;

namespace dotnetcore
{
    public class Pessoa{
        public Pessoa(string pNome, int pIdade)
        {
            Nome = pNome;
            Idade = pIdade;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    class Program
    {

        // Exercício 2:
        // - Fazer um programa que cadastre pessoas, contendo nome e idade;
        // - Imprimir a media de idade das pessoas
        // - Imprimir o nome e idade da pessoa mais velha
        // - Imprimir o nome e idade da pessoa mais nova
        // - Imprimir a quantidade de pessoas com maioridade
        // Requisítos:
        // - Utilizar List (Avg, Max, Min, Where)
        // - Utilizar Classe Pessoa
        static void Main(string[] args)
        {
            var xPessoas = new List<Pessoa>() {
                new Pessoa("Violet Evergarden", 15),
                new Pessoa("Aelin Galathynius", 19),
                new Pessoa("John Marston", 40),
                new Pessoa("Hunter", 20),
                };
            
            var xMedia = xPessoas.Average(p => p.Idade);
            Console.WriteLine("A média das idades é: " + xMedia);

            var xMaisNovo = xPessoas.OrderBy(p => p.Idade).First();
            Console.WriteLine("A pessoa mais nova é: " + xMaisNovo.Nome + " Com: " + xMaisNovo.Idade + " anos");

            var xMaisVelho = xPessoas.OrderByDescending(p => p.Idade).First();
            Console.WriteLine("A pessoa mais velha é: " + xMaisVelho.Nome + " Com: " + xMaisVelho.Idade + " anos");

            var xNumeroDeMaioresDeIdade = xPessoas.Where(p => p.Idade >= 18);
            Console.WriteLine("O número de maiores de idade é: " + xNumeroDeMaioresDeIdade.Count());
        }

    }
}
