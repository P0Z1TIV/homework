// Найти строку с наименьшей суммой элементов.
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
int firstStroka = 0;
int secondStroka = 0;
int thirdStroka = 0;

int[,] matrix = new int[3, 4];
void GetStroka(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if(i == 0) 
            {
            firstStroka = firstStroka + matrix[i, j];
            }
            else if (i == 1)
            {
                secondStroka = secondStroka + matrix[i, j]; 
            }
            else if (i == 2)
            {
                thirdStroka = thirdStroka + matrix[i, j];  
            }
           
        }
    }
    if (firstStroka <= secondStroka && firstStroka <= thirdStroka)
    {
        Console.WriteLine($"Первая строка имеет наименьшую сумму элементов, а именно: {firstStroka}");
    }
    else if (secondStroka <= firstStroka && secondStroka <= thirdStroka)
    {
        Console.WriteLine($"Вторая строка имеет наименьшую сумму элементов, а именно: {secondStroka}");
    }
    else if (thirdStroka <= firstStroka && thirdStroka <= secondStroka)
    {
        Console.WriteLine($"Третья строка имеет наименьшую сумму элементов, а именно: {thirdStroka}");
    }
}
FillArray(matrix);
PrintArray(matrix);
GetStroka(matrix);
