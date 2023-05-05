/* Напишите программу, которая на вход принимает элемент в двумерном массиве, 
и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.*/
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
                    matr[i, j] = rand.Next(0, 100);
                }
        }           
}
int[,] matrix = new int[3, 4];
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
void GetFirstIndex(int[,] matr)
{
int searchNumber = matrix[0, 0];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    if (number == matrix[i, j])
        {
            Console.WriteLine($"Индекс первого найденого числа: {i}, {j}");
            searchNumber = matrix[i, j];
            break;
        }
    
    
    }

}
if (number != searchNumber)
   { 
        Console.WriteLine("Такого числа нет");
   }
}
FillArray(matrix);
PrintArray(matrix);
GetFirstIndex(matrix);


