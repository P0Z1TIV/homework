int[] FillArray (int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rand = new Random();
    for(int i = 0; i < length; i++)
    {
        result[i] = rand.Next(minValue, maxValue);
    }
    return result;
}
int GetCount (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] array = FillArray (10, 100, 999);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", GetCount(array)));
