// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void PrintArray(double[,] matr)
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
void FillArray(double[,] matr)
{
    var rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = Math.Round(rand.Next() + rand.NextDouble(), 2);
                }
        }           
}
double[,] matrix = new double[3, 4];
FillArray(matrix);
PrintArray(matrix);
