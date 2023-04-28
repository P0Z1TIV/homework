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
int GetSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
int[] array = FillArray (10, 10, 20);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", GetSum(array)));
