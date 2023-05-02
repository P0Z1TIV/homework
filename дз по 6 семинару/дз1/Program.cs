// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] FillArray (int length)
{
    int[] result = new int[length];
    Console.WriteLine("Введите число элементов массива ");
    length = int.Parse(Console.ReadLine());
    for(int i = 0; i < length; i++)
        {
        Console.WriteLine($"Введите {i+1} число массива ");
        result[i] = int.Parse(Console.ReadLine());
        }
    return result;
}
int GetCount (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}
int[] array = FillArray (10);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", GetCount(array)));
