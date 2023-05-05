// Среднее арифметическое элементов в каждом столбце массива.
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
double firstStolbec = 0;
double secondStolbec = 0;
double thirdStolbec = 0;
double forthStolbec = 0;
int[,] matrix = new int[3, 4];
void GetFirstIndex(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if(j == 0) {
            firstStolbec = firstStolbec + matrix[i, j];
            
            }
            else if (j == 1)
            {
                secondStolbec = secondStolbec + matrix[i, j];
            }
            else if (j == 2)
            {
                thirdStolbec = thirdStolbec + matrix[i, j];
            }
            else if (j == 3)
            {
                forthStolbec = forthStolbec + matrix[i, j];
            }
        }
    }
    Console.WriteLine($"Среднее арифметическое первого столбца {firstStolbec / 3}");
    Console.WriteLine($"Среднее арифметическое второго столбца {secondStolbec / 3}");
    Console.WriteLine($"Среднее арифметическое третьего столбца {thirdStolbec / 3}");
    Console.WriteLine($"Среднее арифметическое четвертого столбца {forthStolbec / 3}");
}
FillArray(matrix);
PrintArray(matrix);
GetFirstIndex(matrix);
