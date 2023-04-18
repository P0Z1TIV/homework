// Вывод третьего числа
Console.WriteLine("Введите число: ");
string Num = Console.ReadLine();
int num = Convert.ToInt32(Num);

if (num < 99)
    {
        Console.WriteLine("Третьего числа нет");
      
    }
else 
    {
       while (num > 999)
       {
          num = num / 10;
       }
       Console.WriteLine(num % 10);

    }  
