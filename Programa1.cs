public class Programa1
{
    private readonly char[] alfabeto = ['a', 'b'];

    public void Executar()
    {

        Console.WriteLine("--- Programa 1: Verificador de Alfabeto e Cadeia ---");

        Console.Write("Digite um símbolo para verificar: ");
        string? entradaSimbolo = Console.ReadLine();
        if (!string.IsNullOrEmpty(entradaSimbolo) && entradaSimbolo.Length == 1)
        {
            char simbolo = entradaSimbolo[0];
            if (alfabeto.Contains(simbolo))
            {
                Console.WriteLine($"-> O símbolo '{simbolo}' é VÁLIDO (pertence a Σ).");
            }
            else
            {
                Console.WriteLine($"-> O símbolo '{simbolo}' é INVÁLIDO (não pertence a Σ).");
            }
        }
        else
        {
            Console.WriteLine("-> Entrada inválida. Por favor, digite um único símbolo.");
        }

        Console.WriteLine();

        Console.Write("Digite uma cadeia para verificar: ");
        string? cadeia = Console.ReadLine() ?? string.Empty;
        bool cadeiaValida = cadeia.All(c => alfabeto.Contains(c));

        if (cadeiaValida)
        {
            Console.WriteLine($"-> A cadeia '{cadeia}' é VÁLIDA (pertence a Σ*).");
        }
        else
        {
            Console.WriteLine($"-> A cadeia '{cadeia}' é INVÁLIDA (não pertence a Σ*).");
        }
    }
}