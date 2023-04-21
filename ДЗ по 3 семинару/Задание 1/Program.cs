// Палиндром
Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
if (number < 10000 || number > 99999)
{
   Console.WriteLine("Не пятизначное число"); 
}
else if (number / 10000 == number % 10 && (number / 1000) % 10 == (number % 100) / 10)
{
    Console.WriteLine("Палиндром"); 
}
else { Console.WriteLine("Не палиндром"); }