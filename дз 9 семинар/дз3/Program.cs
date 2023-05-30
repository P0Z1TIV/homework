int result = Ackermann(3, 4);
Console.WriteLine(result);

int ReadInt(string text){
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}
