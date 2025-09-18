# Toolkit-Sigma
Trabalho de Computação Cientifica
Alunos:
Rafael Felippe 06004407
Hugo Verissímo 06004445
Feliix Lessa 06004530
Lucas Duarte 06004467

# Projeto Toolkit Sigma

<p align="center">
  <img src="https://img.shields.io/badge/Linguagem-C%23-blueviolet" alt="Linguagem C#">
  <img src="https://img.shields.io/badge/Plataforma-.NET-blue" alt="Plataforma .NET">
  <img src="https://img.shields.io/badge/status-conclu%C3%ADdo-brightgreen" alt="Status do Projeto">
</p>

## 📝 Sobre o Projeto

O **Toolkit Sigma** é uma aplicação de console desenvolvida em C# como um conjunto de ferramentas educacionais para explorar conceitos fundamentais da Teoria da Computação. O projeto apresenta, de forma interativa, tópicos como alfabetos, cadeias, classificação de problemas, lógica proposicional e reconhecimento de linguagens formais.

## ✨ Funcionalidades

O toolkit é composto por um menu principal que dá acesso às seguintes ferramentas:

1.  **Verificador de Alfabeto e Cadeia**
    * Verifica se um símbolo ou uma cadeia de caracteres pertence ao alfabeto pré-definido `Σ = {a, b}`.

2.  **Classificador de Problemas (T/I/N)**
    * Um mini-quiz onde o usuário deve classificar problemas clássicos da computação como **(T)ratável**, **(I)ntratável** ou **(N)ão Computável**. Os problemas e suas respostas são carregados de um JSON interno.

3.  **Decisor: "Termina com b?"**
    * Um programa simples que decide se uma dada cadeia sobre o alfabeto `Σ = {a, b}` pertence à linguagem de todas as cadeias que terminam com o símbolo 'b'.

4.  **Avaliador Proposicional**
    * Ferramenta para avaliar fórmulas da lógica proposicional com as variáveis `P`, `Q` e `R`.
    * Permite a avaliação com valores de verdade específicos (V/F) ou a geração da tabela-verdade completa para as fórmulas:
        * `(P ∧ Q) ∨ R`
        * `P → (¬Q)`

5.  **Reconhecedor de Linguagens**
    * Reconhece se uma cadeia pertence a uma de duas linguagens regulares:
        * `L = { w ∈ {a,b}* | w tem um número par de 'a's }`
        * `L = { a b* }` (um 'a' seguido por zero ou mais 'b's)

## 🚀 Tecnologias Utilizadas

* **[C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)**: Linguagem de programação principal.
* **[.NET](https://dotnet.microsoft.com/)**: Plataforma de desenvolvimento utilizada. O projeto foi configurado para o .NET 9.0.

## 🔧 Como Executar

Para executar este projeto, você precisará ter o [SDK do .NET](https://dotnet.microsoft.com/download) instalado em sua máquina.

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/rafaelfelippe1/Toolkit-Sigma.git](https://github.com/rafaelfelippe1/Toolkit-Sigma.git)
    ```

2.  **Navegue até o diretório do projeto:**
    ```bash
    cd Toolkit-Sigma
    ```

3.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```

4.  Após a execução, um menu interativo aparecerá no terminal. Basta digitar o número da opção desejada e pressionar Enter.

## 🏛️ Estrutura do Projeto

O projeto está organizado da seguinte forma:

* **`Program.cs`**: Ponto de entrada da aplicação. Responsável por exibir o menu principal e direcionar para a ferramenta escolhida.
* **`Programa1.cs` a `Programa5.cs`**: Cada arquivo implementa uma das funcionalidades descritas acima, mantendo o código modular e organizado.
* **`Projeto Toolkit Sigma.csproj`**: Arquivo de configuração do projeto .NET.
* **`Projeto Toolkit Sigma.sln`**: Arquivo de solução do Visual Studio.
