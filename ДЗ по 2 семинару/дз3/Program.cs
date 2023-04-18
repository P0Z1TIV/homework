// Вывод дня нелели
Console.WriteLine("Номер дня недели: ");
string Num = Console.ReadLine();
int num = Convert.ToInt32(Num);
if (num > 7 || num < 1)
    {
        Console.WriteLine("Не день недели");
    }
else if (num == 6 || num == 7)
    {
        Console.WriteLine("Выходной");
    }
else if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5)

    {
        Console.WriteLine("Рабочий день");
    }
