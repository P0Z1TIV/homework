// Перемножение матриц
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    var rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
}
int[,] matrix1 = new int[4, 3];
int[,] matrix2 = new int[3, 4];
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[4, 4];
    for(int i = 0; i < matrix1.GetLength(0); i++ )
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for(int k = 0; k <= 2; k++)
            {
            matrix3[i, j] = matrix3[i, j] + (matrix1[i, k] * matrix2[k, j]);
           
            }
             Console.Write($"{matrix3[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix3;
}
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
MultiplicationMatrix(matrix1, matrix2);
