// Вывод максимального из трёх
Console.WriteLine("Enter first number: ");
string FirstNum = Console.ReadLine();
int fNum = Convert.ToInt32(FirstNum);
Console.WriteLine("Enter second number: ");
string SecondNum = Console.ReadLine();
int sNum = Convert.ToInt32(SecondNum);
Console.WriteLine("Enter third number: ");
string ThirdNum = Console.ReadLine();
int tNum = Convert.ToInt32(ThirdNum);
if (fNum >= sNum && fNum >= tNum)
    {
        Console.WriteLine(fNum);
    } 
else if (sNum >= fNum && sNum > tNum) 
    {
        Console.WriteLine(sNum);
    } 
else if (tNum >= fNum && tNum >= sNum)
    {
        Console.WriteLine(tNum);
    }
