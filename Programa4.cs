// Avaliar fórmulas proposicionais sobre P, Q, R.

using System;

public class Programa4
{
    public void Executar()
    {
        Console.WriteLine("--- Programa 4: Avaliador Proposicional Básico ---");

        Console.WriteLine("Escolha a fórmula para avaliar:");
        Console.WriteLine("1) Conjunção e Disjunção: (P ∧ Q) ∨ R");
        Console.WriteLine("2) Implicação e Negação: P → (¬Q)");
        int formulaEscolhida = LerOpcaoDoMenu(1, 2);

        Console.WriteLine("\nO que você deseja fazer?");
        Console.WriteLine("1) Avaliar com valores específicos");
        Console.WriteLine("2) Gerar a Tabela-Verdade completa");
        int acaoEscolhida = LerOpcaoDoMenu(1, 2);

        if (acaoEscolhida == 1) AvaliarFormula(formulaEscolhida);
        else GerarTabelaVerdade(formulaEscolhida);
    }

    private void AvaliarFormula(int formula)
    {
        Console.WriteLine("\nDigite os valores para as proposições (V para verdadeiro, F para falso).");
        bool p = LerValorProposicional("P");
        bool q = LerValorProposicional("Q");
        bool r = LerValorProposicional("R");

        bool resultado;
        if (formula == 1)
        {
            resultado = (p && q) || r;
            Console.WriteLine($"\nResultado de ({V(p)} ∧ {V(q)}) ∨ {V(r)} é: {V(resultado)}");
        }
        else
        {
            resultado = !p || !q;
            Console.WriteLine($"\nResultado de {V(p)} → (¬{V(q)}) é: {V(resultado)}");
        }
    }

    private void GerarTabelaVerdade(int formula)
    {
        Console.WriteLine("\n--- Tabela-Verdade ---");
        if (formula == 1) Console.WriteLine("| P | Q | R | (P ∧ Q) ∨ R |");
        else Console.WriteLine("| P | Q | R | P → (¬Q) |");
        Console.WriteLine("|---|---|---|-------------|");

        bool[] valores = { true, false };
        foreach (bool p in valores)
            foreach (bool q in valores)
                foreach (bool r in valores)
                {
                    bool resultado;
                    if (formula == 1)
                    {
                        resultado = (p && q) || r;
                        Console.WriteLine($"| {V(p)} | {V(q)} | {V(r)} |      {V(resultado)}      |");
                    }
                    else
                    {
                        resultado = !p || !q;
                        Console.WriteLine($"| {V(p)} | {V(q)} | {V(r)} |      {V(resultado)}      |");
                    }
                }
    }

    private bool LerValorProposicional(string nome)
    {
        while (true)
        {
            Console.Write($"Valor de {nome} (V/F): ");
            string? entrada = Console.ReadLine()?.ToUpper();
            if (entrada == "V") return true;
            if (entrada == "F") return false;
            Console.WriteLine("Entrada inválida. Use 'V' ou 'F'.");
        }
    }

    private string V(bool valor) => valor ? "V" : "F";

    private int LerOpcaoDoMenu(int min, int max)
    {
        while (true)
        {
            Console.Write("Opção: ");
            if (int.TryParse(Console.ReadLine(), out int valor) && valor >= min && valor <= max) return valor;
            Console.WriteLine("Opção inválida. Tente novamente.");
        }
    }
}