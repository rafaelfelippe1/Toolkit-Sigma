
public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("  Projeto Toolkit - Avaliação AV1");
            Console.WriteLine("========================================");
            Console.WriteLine("1) Verificador de alfabeto e cadeia (Σ={a,b})");
            Console.WriteLine("2) Classificador T/I/N por JSON");
            Console.WriteLine("3) Decisor: termina com 'b'?");
            Console.WriteLine("4) Avaliador proposicional (P,Q,R)");
            Console.WriteLine("5) Reconhecedor: L_par_a e a b*");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("0) Sair");
            Console.WriteLine("========================================");

            int opcaoEscolhida = LerOpcaoDoMenu(0, 5);
            Console.WriteLine();

            if (opcaoEscolhida == 0) return;

            // instacia para chamar as classes.
            if (opcaoEscolhida == 1) new Programa1().Executar();
            if (opcaoEscolhida == 2) new Programa2().Executar();
            if (opcaoEscolhida == 3) new Programa3().Executar();
            if (opcaoEscolhida == 4) new Programa4().Executar();
            if (opcaoEscolhida == 5) new Programa5().Executar();

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }

    private static int LerOpcaoDoMenu(int valorMinimo, int valorMaximo)
    {
        while (true)
        {
            Console.Write("Escolha uma opção: ");
            string? textoDigitado = Console.ReadLine();
            if (int.TryParse(textoDigitado, out int valorLido))
            {
                if (valorLido >= valorMinimo && valorLido <= valorMaximo)
                {
                    return valorLido;
                }
            }
            Console.WriteLine("Opção inválida. Tente novamente.");
        }
    }
}