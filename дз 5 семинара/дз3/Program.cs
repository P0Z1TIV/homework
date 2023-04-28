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
    int min = array[0];
    int max = array[0];
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    sum = min + max;
    return sum;
}
int[] array = FillArray (10, 1, 100);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", GetSum(array)));
