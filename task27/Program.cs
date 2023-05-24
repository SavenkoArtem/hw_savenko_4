int Promt(string msg)
{    
    Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());    
    return num;
}


int SumDigitNumber(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    
    return sum;
}


try
{
int num = Promt("Enter a number:");
Console.WriteLine($"Result = {SumDigitNumber(num)}");
}
catch
{
    Console.WriteLine("You need enter a natural number!");
}