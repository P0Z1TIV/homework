//вывести значения от M до N 
//используя рекрсию
int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
int ReadInt(string text){
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int PrintNumber(int M, int N)
{
    if (M == N)
    {
        return M;
    }
        return M + PrintNumber(M + 1, N);
    
}

System.Console.WriteLine(PrintNumber(M,N));
