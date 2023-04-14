// Четное или нет
Console.WriteLine("Enter number: ");
string FirstNum = Console.ReadLine();
int Num = Convert.ToInt32(FirstNum);
if (Num % 2 == 0)
    {
        Console.WriteLine("Even");
    }
else
    {
        Console.WriteLine("Not even");
    }
