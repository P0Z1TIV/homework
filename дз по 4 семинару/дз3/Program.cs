// Создание массива с 8 элементами.
void MethodArray(int[] array)
{
    int lenght = array.Length;
    Random rand = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = rand.Next(1, 9);
        Console.Write(array[i] + " ");
    }
}
int[] array = new int[8];
MethodArray(array);
