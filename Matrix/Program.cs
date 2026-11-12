
using System.Security.Cryptography;

void ImprimirCrescenteEDescresente(int[,] matrix)
{
    int linha = matrix.GetLength(0);
    int coluna = matrix.GetLength(1);

    string crescente = "";
    string decrescente = "";

    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            crescente =  $" {crescente} [{matrix[i, j]}] - ";
            decrescente = $" {decrescente} [{matrix[i, j]}] - ";
        }
        crescente = $" {crescente} \n";
    }

    for (int i = linha - 1; i >= 0; i--)
    {
        for (int j = coluna - 1; j >= 0; j--)
        {
            decrescente = $" {decrescente} [{matrix[i, j]}] - ";
        }
        decrescente = $" {decrescente} \n";
    }

    Console.WriteLine(crescente);
    Console.WriteLine();
    Console.WriteLine(decrescente);

}
void CriarMatrixComUsuario()
{

    Console.WriteLine("\n Exercicio 1 \n\n");

    Console.WriteLine("Digite o número de linhas: ");
    int linhas = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o número de colunas: ");
    int colunas = int.Parse(Console.ReadLine());
    int[,] matrix = new int[linhas, colunas];

    for(int x = 0; x < linhas; x++){
        for(int y = 0; y < colunas; y++){
            matrix[x, y] = RandomNumberGenerator.GetInt32(10, 50);
        }
    }

    ImprimirCrescenteEDescresente(matrix);
    Console.WriteLine();
}

void InverterMatrix(int linhas, int colunas)
{

    Console.WriteLine("\n Exercicio 2\n");

    int[,] original = new int[linhas, colunas];
    int[,] invertida = new int[colunas, linhas];

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            original[i, j] = RandomNumberGenerator.GetInt32(10, 50);
            invertida[j, i] = original[i, j];
            Console.Write($"[{original[i, j]}] - ");
        }
        Console.WriteLine();
    }

    for(int k = colunas - 1; k >= 0; k--)
    {
        for (int l = linhas - 1; l >= 0; l--)
        {
            Console.Write($"[{invertida[k, l]}] - ");
        }
        Console.WriteLine();
    }
}

//CriarMatrixComUsuario();
InverterMatrix(5,3);
