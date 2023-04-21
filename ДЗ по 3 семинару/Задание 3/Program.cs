// Вывод кубов от 1 до N.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i} ");
}
