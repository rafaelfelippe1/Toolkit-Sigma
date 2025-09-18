//Ler problemas de um JSON e classificar como T/I/N.

using System;
using System.Collections.Generic;
using System.Text.Json;

public record Problema(string Nome, string ClassificacaoCorreta);

public class Programa2
{
    public void Executar()
    {
        Console.WriteLine("--- Programa 2: Classificador T/I/N ---");

        string jsonProblemas = """
        [
            { "Nome": "Ordenação de um vetor (Mergesort)", "ClassificacaoCorreta": "T" },
            { "Nome": "Problema do Caixeiro Viajante (solução ótima)", "ClassificacaoCorreta": "I" },
            { "Nome": "Problema da Parada (Halting Problem)", "ClassificacaoCorreta": "N" },
            { "Nome": "Encontrar o caminho mais curto em um grafo (Dijkstra)", "ClassificacaoCorreta": "T" }
        ]
        """;

        var listaDeProblemas = JsonSerializer.Deserialize<List<Problema>>(jsonProblemas);

        if (listaDeProblemas == null || listaDeProblemas.Count == 0)
        {
            Console.WriteLine("Não foi possível carregar os problemas.");
            return;
        }

        int acertos = 0;
        int erros = 0;

        Console.WriteLine("Classifique os problemas como (T)ratável, (I)ntratável ou (N)ão Computável:");

        foreach (var problema in listaDeProblemas)
        {
            string resposta = "";
            while (resposta != "T" && resposta != "I" && resposta != "N")
            {
                Console.Write($"\nProblema: {problema.Nome}\nSua classificação (T/I/N): ");
                resposta = Console.ReadLine()?.ToUpper() ?? "";
                if (resposta != "T" && resposta != "I" && resposta != "N")
                {
                    Console.WriteLine("Resposta inválida. Use apenas T, I ou N.");
                }
            }

            if (resposta == problema.ClassificacaoCorreta)
            {
                Console.WriteLine("-> Correto!");
                acertos++;
            }
            else
            {
                Console.WriteLine($"-> Errado! A classificação correta é: {problema.ClassificacaoCorreta}");
                erros++;
            }
        }

        Console.WriteLine("\n--- Resumo Final ---");
        Console.WriteLine($"Total de Acertos: {acertos}");
        Console.WriteLine($"Total de Erros: {erros}");
    }
}