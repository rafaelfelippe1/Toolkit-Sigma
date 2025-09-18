//Reconhecer pertencimento a L_par_a e a b*.

using System;
using System.Linq;

public class Programa5
{
    public void Executar()
    {
        Console.WriteLine("--- Programa 5: Reconhecedor de Linguagens ---");
        Console.WriteLine("Escolha a linguagem para o reconhecimento:");
        Console.WriteLine("1) L = { w ∈ {a,b}* | w tem um número par de 'a's } (L_par_a)");
        Console.WriteLine("2) L = { a b* } (um 'a' seguido de zero ou mais 'b's)");

        int escolha = 0;
        while (escolha != 1 && escolha != 2)
        {
            Console.Write("Opção: ");
            int.TryParse(Console.ReadLine(), out escolha);
            if (escolha != 1 && escolha != 2) Console.WriteLine("Opção inválida.");
        }

        Console.Write("\nDigite a cadeia a ser reconhecida: ");
        string? cadeia = Console.ReadLine() ?? string.Empty;

        foreach (char c in cadeia)
        {
            if (c != 'a' && c != 'b')
            {
                Console.WriteLine($"\nA cadeia '{cadeia}' contém símbolos inválidos. REJEITA");
                return;
            }
        }

        bool aceita = false;
        if (escolha == 1) // L_par_a
        {
            aceita = cadeia.Count(c => c == 'a') % 2 == 0;
        }
        else // L = a b*
        {
            if (!string.IsNullOrEmpty(cadeia) && cadeia[0] == 'a')
            {
                aceita = true;
                for (int i = 1; i < cadeia.Length; i++)
                {
                    if (cadeia[i] != 'b')
                    {
                        aceita = false;
                        break;
                    }
                }
            }
            // se for vazia, ou não começar com 'a', aceita continua false
        }

        Console.WriteLine(aceita ? "\nACEITA" : "\nREJEITA");
    }
}