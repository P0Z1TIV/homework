// Возведение в степень
int Vozvedenie ()
{
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень ");
int stepen = int.Parse(Console.ReadLine());

int result = 1;
for (int i = 1; i <= stepen; i++)
    {
        result = result * number;
    }
return result;
}  
Console.WriteLine(Vozvedenie());
