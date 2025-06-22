static void Exercicio1()
{
    Console.WriteLine("Exercício 1: Crie um array de 10 posições e preencha-o com os números de 10 a 100, Use um for para exibir os valores deste vetor.");

    int[] numeros = new int[10];

    for (int i = 0; i < numeros.Length; i++)
        numeros[i] += i > 0 ? numeros[i - 1] + 10 : 10;

    for (int i = 0; i < numeros.Length; i++)
        Console.WriteLine($"Posição {i} = {numeros[i]}");
        
    Console.WriteLine();
}

static void Exercicio2()
{
    Console.WriteLine("Crie um array bidimensional de 16 posições e preencha-o com os números de 1 a 16, Use dois fors para exibir os valores deste vetor.");

    char[,] letras =
    {
        { 'a', 'b', 'c', 'd' },
        { 'e', 'f', 'g', 'h' },
        { 'i', 'j', 'k', 'l' },
        { 'm', 'n', 'o', 'p' }
    };

    int coluna;

    for (int linha = 0; linha < letras.GetLength(0); linha++)
    {
        for (coluna = 0; coluna < letras.GetLength(1); coluna++)
        {
            Console.WriteLine($"Posição [{linha}, {coluna}] = {letras[linha, coluna]}");
        }
    }
    
    Console.WriteLine();
}

static void Exercicio3()
{
    Console.WriteLine(
        """
        Faça um programa com um vetor com 10 elementos inteiros positivos (aleatórios e de sua escolha). 
        Permita que seja solicitado um determinado valor inteiro e positivo para ser procurado no vetor.
        Caso exista, o programa deve exibir o índice no qual o valor está posicionado. 
        Caso Contrário, o programa deve informar que o elemento não existe no vetor.
        """);

    int[] numeros = [1, 2, 3, 100, 5, 300, 7, 8, 9, 6000];

    Console.Write("Digite um número inteiro positivo para procurar no vetor: ");

    if (!int.TryParse(Console.ReadLine(), out int numeroProcurado) || numeroProcurado < 0)
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro positivo.");
        return;
    }

    bool encontrado = false;

    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] != numeroProcurado)
            continue;

        Console.WriteLine($"O número {numeroProcurado} foi encontrado na posição {i}.");
        encontrado = true;
        break;
    }

    if (!encontrado)
        Console.WriteLine($"O número {numeroProcurado} não existe no vetor.");

    Console.WriteLine();
}

static void Exercicio4()
{
    Console.WriteLine(
        """
        Exercício 5: Crie um array bidimensional de 9 posições e preencha com reais positivos (aleatórios e de sua escolha).
        Calcule e exiba a soma dos elementos de cada linha desta matriz.
        """);

    float[,] numeros =
    {
        { 1.5f, 2.5f, 3.5f },
        { 4.5f, 5.5f, 6.5f },
        { 7.5f, 8.5f, 9.5f }
    };

    float somaLinha = 0;

    for (int linha = 0; linha < numeros.GetLength(0); linha++)
    {
        for (int coluna = 0; coluna < numeros.GetLength(1); coluna++)
            somaLinha += numeros[linha, coluna];

        Console.WriteLine($"A soma dos elementos da linha {linha} é: {somaLinha}");
        somaLinha = 0;
    }
    
    Console.WriteLine();
}

static void Exercicio5()
{
    Console.WriteLine(
        """
        Exercício 5: Faça um programa com uma matriz de 25 posições de inteiros positivos ou negativos (aleatórios e de sua escolha).
        e encontre e exiba o maior elemento desta matriz.
        """);

    int[,] numeros =
    {
        { 1, -2, 3, 4, 5 },
        { -6, 7, 8, -9, 10 },
        { 11, -12, 13, 14, -15 },
        { 16, -17, 18, 19, -20 },
        { -21, 22, 23, -24, 25 }
    };

    int maior = 0;

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (numeros[i, j] <= maior)
                continue;

            maior = numeros[i, j];
        }
    }

    Console.WriteLine("O maior elemento da matriz é: " + maior);
    Console.WriteLine();
}

Exercicio1();
Exercicio2();
Exercicio3();
Exercicio4();
Exercicio5();