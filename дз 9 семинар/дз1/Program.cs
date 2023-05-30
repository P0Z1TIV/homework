//задйте значение N, напишите программу, 
//которая вывдете все натуральные числа в промежутке от 1 до N
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumber(N);
void PrintNumber(int Number)
{
    if(Number < 1){
        return;
    }
    Console.Write(Number + " "); 
    PrintNumber(Number - 1); 
      
}