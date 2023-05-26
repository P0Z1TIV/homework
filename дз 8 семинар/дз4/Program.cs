﻿// Создание 3D массива
int[,,] array3D = new int[2, 2, 2];
void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}
void FillArray(int[,,] array3D)
{
    var rand = new Random();
    for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                        {
                            array3D[i, j, k] = rand.Next(0, 10);    
                        }
                }
        }
}
FillArray(array3D);
PrintArray(array3D);
Console.WriteLine();

