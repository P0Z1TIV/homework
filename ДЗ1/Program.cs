// Сравнение двух чисел
Console.WriteLine("Enter first number: ");
string FirstNum = Console.ReadLine();
int fNum = Convert.ToInt32(FirstNum);
Console.WriteLine("Enter second number: ");
string SecondNum = Console.ReadLine();
int sNum = Convert.ToInt32(SecondNum);
if (fNum > sNum)
    {
        Console.WriteLine("First number bigger second number");
    } 
else if (fNum < sNum) 
    {
        Console.WriteLine("Second number bigger first number");
    } 
else 
    {
        Console.WriteLine("Both numbers are equal");
    }
