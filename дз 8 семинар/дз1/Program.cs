// Упорядочить по убыванию элементы каждой строки двумерного массива.
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
int[,] matrix = new int[5, 6];
int[,] Decrease (int[,] matrix) 
{
    for (int k = 0; k <= matrix.GetLength(0); k++) 
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 1; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] > matrix[i, j - 1])
                                {
                                    int tmp = 0;
                                    tmp = matrix[i, j];  
                                    matrix[i, j] = matrix[i, j - 1];
                                    matrix[i, j - 1] = tmp;
                                }
                        
                        }
                }
            
        }
    return matrix;
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Decrease (matrix);
PrintArray(matrix);
