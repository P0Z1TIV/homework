// Сумма цифр в числе

int SumNumber () 
{
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int x = 0;
for (int i = 0; number > 0; number = number / 10) 
{
   i = i + number % 10;
   
    x = i;
}
return x;
}

Console.WriteLine(SumNumber());
