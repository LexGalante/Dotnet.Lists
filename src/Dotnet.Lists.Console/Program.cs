using System;
using System.Collections.Generic;

namespace Dotnet.Lists.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleArray();
            ExampleSortedList();
            ExampleQueue();
            ExampleLinkedList();
        }

        /// <summary>
        /// Classe base de todas as matrizes em .net
        /// </summary>
        private static void ExampleArray()
        {
            System.Console.WriteLine($"------------------------------------------------{Environment.NewLine}");
            System.Console.WriteLine("Exemplo de lista do tipo Array");

            var pessoas = new Pessoa[]
            {
                new Pessoa() { Nome = "Fulano", Idade = 12 },
                new Pessoa() { Nome = "Ciclano", Idade = 24 },
                new Pessoa() { Nome = "Pafuncio", Idade = 36 }
            };

            System.Console.WriteLine("Iterando por uma Array");
            foreach (var pessoa in pessoas)
                System.Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade}");

            System.Console.WriteLine($"Tamanho do array: {pessoas.Length}");

            System.Console.WriteLine($"------------------------------------------------{Environment.NewLine}");
        }

        /// <summary>
        /// Lista com vinculo atraves de nós 
        /// </summary>
        private static void ExampleLinkedList()
        {
            System.Console.WriteLine($"------------------------------------------------{Environment.NewLine}");
            System.Console.WriteLine("Exemplo de lista do tipo LinkedList");

            var fulano = new Pessoa() { Nome = "Fulano", Idade = 12 };
            var pessoas = new LinkedList<Pessoa>(new Pessoa[]
            {
                fulano,
                new Pessoa() { Nome = "Ciclano", Idade = 24 },
                new Pessoa() { Nome = "Pafuncio", Idade = 36 }
            });

            System.Console.WriteLine("Iterando por uma LinkedList");
            foreach (var pessoa in pessoas)
                System.Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade}");

            System.Console.WriteLine("Operações com LinkedList");
            System.Console.WriteLine("Adição no inicio");
            pessoas.AddFirst(new Pessoa() { Nome = "Adicao", Idade = 36 });
            pessoas.AddLast(new Pessoa() { Nome = "Adicao Antes", Idade = 36 });

            System.Console.WriteLine($"------------------------------------------------{Environment.NewLine}");
        }

        /// <summary>
        /// Lista de valores que indexa pela chave do item
        /// </summary>
        private static void ExampleSortedList()
        {
            System.Console.WriteLine($"------------------------------------------------{Environment.NewLine}");
            System.Console.WriteLine("Exemplo de lista do tipo SortedList");

            var pessoas = new SortedList<string, Pessoa>
            {
                { "fulano", new Pessoa() { Nome = "Fulano", Idade = 12 } },
                { "ciclano", new Pessoa() { Nome = "Ciclano", Idade = 24 } },
                { "pafuncio", new Pessoa() { Nome = "Pafuncio", Idade = 36 } }
            };

            System.Console.WriteLine("Iterando por uma SortedList");
            foreach (var pessoa in pessoas)
                System.Console.WriteLine($"{pessoa.Key} - {pessoa.Value.Nome} - {pessoa.Value.Idade}");

            System.Console.WriteLine("Acessoando SortedList por uma chave");
            var x = pessoas["pafuncio"].Nome;
            System.Console.WriteLine(x);

            System.Console.WriteLine($"------------------------------------------------{Environment.NewLine}");
        }

        /// <summary>
        /// https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.queue-1?view=netframework-4.8
        /// Exemplo de lista do tipo fila
        /// Primeiro que entra e o primeiro que sai
        /// </summary>
        private static void ExampleQueue()
        {
            System.Console.WriteLine($"------------------------------------------------{Environment.NewLine}");
            System.Console.WriteLine("Exemplo de lista do tipo QUEUE");

            Queue<Pessoa> pessoas = new Queue<Pessoa>();
            pessoas.Enqueue(new Pessoa() { Nome = "Fulano", Idade = 12 });
            pessoas.Enqueue(new Pessoa() { Nome = "Ciclano", Idade = 24 });
            pessoas.Enqueue(new Pessoa() { Nome = "Pafuncio", Idade = 36 });

            System.Console.WriteLine("Iterando por uma QUEUE");
            foreach (var pessoa in pessoas)
                System.Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade}");

            var pessoaPeek = pessoas.Peek();
            System.Console.WriteLine("PEEK - Metodo para analisar apenas o proximo item da QUEUE");
            System.Console.WriteLine($"{pessoaPeek.Nome} - {pessoaPeek.Idade} - {pessoas.Count}");
            var pessoaDequeue = pessoas.Dequeue();
            System.Console.WriteLine("DEQUEUE - Metodo que remove o primeiro item da QUEUE");
            System.Console.WriteLine($"{pessoaDequeue.Nome} - {pessoaDequeue.Idade} - {pessoas.Count}");

            System.Console.WriteLine($"------------------------------------------------{Environment.NewLine}");
        }
    }
}
