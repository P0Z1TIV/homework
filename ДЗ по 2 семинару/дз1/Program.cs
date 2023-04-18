// Вывод второго числа
Console.WriteLine("Введите число: ");
string Num = Console.ReadLine();
int num = Convert.ToInt32(Num);

if (num > 99 && num < 1000)
    {
        int secondNumber = (num / 10) % 10;
        Console.WriteLine(secondNumber);
    }
else 
    {
        Console.WriteLine("Число не соответствует заданному параметру");
    }    
