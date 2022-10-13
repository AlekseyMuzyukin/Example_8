int[] sum1 = new int[4];
int[] res = new int[4];
int min = 0;
int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
SummIndex(array2D);
Console.WriteLine("_______________________________");
MinSummIndex(sum1, ref min);


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} | ");

        }
        Console.WriteLine("");
    }
}

void SummIndex(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum1[i] += matrix[i, j];
            res[i] = sum1[i];
        }
    }
}

void MinSummIndex(int[] res, ref int min)
{
    int tempmin = res[0];
    for (int i = 0; i < res.Length; i++)
    {
        if (tempmin > res[i])
        {
            tempmin = res[i];
            min = i;
        }
    }

}

Console.WriteLine($"Строка с наименьшей суммой => {min}");
