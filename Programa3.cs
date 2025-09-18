// Decidir se uma cadeia sobre Σ={a,b} termina com 'b'.

using System;

public class Programa3
{
    public void Executar()
    {
        Console.WriteLine("--- Programa 5: Decisor 'Termina com b?' ---");
        Console.Write("Digite uma cadeia sobre o alfabeto {a,b}: ");
        string? cadeia = Console.ReadLine() ?? string.Empty;

        foreach (char c in cadeia)
        {
            if (c != 'a' && c != 'b')
            {
                Console.WriteLine("A cadeia informada contém símbolos que não pertencem a Σ={a,b}.");
                return;
            }
        }

        if (cadeia.EndsWith('b'))
        {
            Console.WriteLine("SIM");
        }
        else
        {
            Console.WriteLine("NAO");
        }
    }
}