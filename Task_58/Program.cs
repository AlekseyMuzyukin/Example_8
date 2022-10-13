Console.WriteLine("Введите количество строк первой матрицы ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы ");
int p = Convert.ToInt32(Console.ReadLine());
if (n != p)
{
    Console.WriteLine("Введена неправильная матрица");
}
else
{

    int[,] firstMartrix = new int[m, n];
    CreateArray(firstMartrix);
    Console.WriteLine("Первая матрица:");
    PrintArray(firstMartrix);

    int[,] secondMartrix = new int[n, p];
    CreateArray(secondMartrix);
    Console.WriteLine("Вторая матрица:");
    PrintArray(secondMartrix);

    int[,] resultMatrix = new int[m, p];

    MultipleMatrix(firstMartrix, secondMartrix, resultMatrix);
    Console.WriteLine("Произведение матриц:");
    PrintArray(resultMatrix);

    void MultipleMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < firstMartrix.GetLength(1); k++)
                {
                    sum += firstMartrix[i, k] * secomdMartrix[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
    }

    void CreateArray(int[,] array)
    {
        var rnd = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rnd.Next(0, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("|");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j],3} | ");
            }
            Console.WriteLine("");
        }
    }

}